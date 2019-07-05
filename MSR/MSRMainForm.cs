﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSR
{
    public partial class MSRMainForm : Form
    {
        //Binding Source Initialization
        BindingSource createTabDGV_source { get; set; }
        
        public MSRMainForm()
        {
            InitializeComponent();
            InitalizeStartingFields();
            RefreshDataGridView();
        }

        private void InitalizeStartingFields()
        {
            //Full Date from server
            //MessageBox.Show(DatabaseAPI.DBAccessSingleton.Instance.GetDateTime().ToString());

            //Initialize Budget Year ComboBox
            int currentYear = DatabaseAPI.DBAccessSingleton.Instance.GetDateTime().Year;

            budgetYear_createTab_comboBox.Items.Add((currentYear - 1).ToString());
            budgetYear_createTab_comboBox.Items.Add((currentYear).ToString());
            budgetYear_createTab_comboBox.Items.Add((currentYear + 1).ToString());

            //Initialize BP ComboBox
            foreach (String item in BusinessAPI.BusinessSingleton.Instance.GetUniqueBP_List())
            {
                budgetPool_createTab_comboBox.Items.Add(item);
            }

            //Initialize Originator Combobox Selected Item
            originator_createTab_comboBox.Enabled = true;
            originator_createTab_comboBox.Items.Add(BusinessAPI.BusinessSingleton.Instance.userInfo.FullName);
            originator_createTab_comboBox.SelectedItem = BusinessAPI.BusinessSingleton.Instance.userInfo.FullName;

            //Initialize DateTime Picker
            changeDate_createTab_dateTimePicker.Value = DatabaseAPI.DBAccessSingleton.Instance.GetDateTime();

        }

        private void RefreshDataGridView()
        {
            //DGV clear
            createTab_dataGridView.DataSource = null;
            createTab_dataGridView.Rows.Clear();
            createTab_dataGridView.Refresh();

            createTab_dataGridView.ClearSelection();

            //Populate from Singleton List
            foreach (Domain.FormItems item in BusinessAPI.BusinessSingleton.Instance.formItemList)
            {
                createTab_dataGridView.Rows.Add(item.BudgetPool, item.ItemCode, item.ItemDesc, "1", item.Unit, "", "", item.AC_No);
            }
        }

        private void AddStock_createTab_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Save state of DGV
            UserInterfaceAPI.UserInterfaceSIngleton.Instance.UpdateBusinessSingletonFormItemList(createTab_dataGridView);

            AddStockItemForm fAddStockItem = new AddStockItemForm(budgetPool_createTab_comboBox.Text);
            fAddStockItem.ShowDialog();

            //Update state of DGV
            RefreshDataGridView();

            this.Show();
        }

        private void AddNonStock_createTab_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Save state of DGV
            UserInterfaceAPI.UserInterfaceSIngleton.Instance.UpdateBusinessSingletonFormItemList(createTab_dataGridView);

            AddNonStockItemForm fAddNonStockItem = new AddNonStockItemForm(budgetPool_createTab_comboBox.Text);
            fAddNonStockItem.ShowDialog();

            //Update state of DGV
            RefreshDataGridView();

            this.Show();
        }

        private void Test_ShowMSR_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowMSR fshowMSR = new ShowMSR();
            fshowMSR.ShowDialog();
            this.Show();
        }

        private void BudgetPool_createTab_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if reseting
            if(budgetPool_createTab_comboBox.SelectedIndex == -1)
            {
                return;
            }

            //Clear then Populate Approval Combobox
            //approval_createTab_comboBox.Items.Clear();
            approval_createTab_comboBox.DataSource = null;
            approval_createTab_comboBox.Enabled = true;
            //foreach (Domain.ApproverInfo item in DatabaseAPI.DBAccessSingleton.Instance.BudgetInfoAPI.GetBudgetHolder_List(budgetPool_createTab_comboBox.Text))
            //{
            //    approval_createTab_comboBox.Items.Add(item.FullName);
            //}

            approval_createTab_comboBox.DataSource = DatabaseAPI.DBAccessSingleton.Instance.BudgetInfoAPI.GetBudgetHolder_List(budgetPool_createTab_comboBox.Text);
            approval_createTab_comboBox.DisplayMember = "FullName";

            approval_createTab_comboBox.SelectedIndex = -1;

            addStock_createTab_button.Enabled = true;
            addNonStock_createTab_button.Enabled = true;
        }

        private void ChangeDate_createTab_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(changeDate_createTab_checkBox.Checked)
            {
                changeDate_createTab_dateTimePicker.Enabled = true;
            }
            else
            {
                changeDate_createTab_dateTimePicker.Enabled = false;
                changeDate_createTab_dateTimePicker.Value = DatabaseAPI.DBAccessSingleton.Instance.GetDateTime();
            }
            
        }

        private void Save_createTab_button_Click(object sender, EventArgs e)
        {
            //Unselect DataGridView
            createTab_dataGridView.ClearSelection();

            //Checking all required fields
            if (budgetYear_createTab_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a budget year.");
                return;
            }

            if (budgetPool_createTab_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a budget pool.");
                return;
            }

            if (originator_createTab_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an originator.");
                return;
            }

            if (createTab_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add an item.");
                return;
            }

            if (approval_createTab_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an approver.");
                return;
            }

            Boolean itemsCorrectFlag = true;
            //Checking if all items's budget pool matches combobox budget pool
            foreach (DataGridViewRow row in createTab_dataGridView.Rows)
            {
                if ( !(row.Cells["BudgetPool"].FormattedValue.ToString().Equals(budgetPool_createTab_comboBox.Text)) )
                {
                    Color lightRed = ControlPaint.Light(Color.Red);
                    row.Cells["BudgetPool"].Style.BackColor = lightRed;
                    itemsCorrectFlag = false;
                }
                else
                {
                    row.Cells["BudgetPool"].Style.BackColor = (Color)System.Drawing.SystemColors.Window;
                }
            }

            if (itemsCorrectFlag)
            {
                MessageBox.Show("All item's budget pool match with selected Budget Pool.");
            }
            else
            {
                MessageBox.Show("Highlighted item's budget pool doesn't match with selected Budget Pool.");
                return;
            }

            //To confirm if you want to Submit MSR
            DialogResult result = MessageBox.Show("Are you sure you want to submit the MSR?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Selected YES.");
                //...
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Selected NO.");
                return;
            }
            else
            {
                MessageBox.Show("Selected NO.");
                return;
            }

            //Obtain approver info of selected
            Domain.ApproverInfo approverInfo = (Domain.ApproverInfo)approval_createTab_comboBox.SelectedItem;

            Domain.MSRInfo mSRInfo = new Domain.MSRInfo(project_createTab_textBox.Text, wellVL_createTab_textBox.Text, comments_createTab_textBox.Text, budgetYear_createTab_comboBox.Text, budgetPool_createTab_comboBox.Text, AFE_createTab_textBox.Text, suggVendor_createTab_textBox.Text, vendorContact_createTab_textBox.Text, BusinessAPI.BusinessSingleton.Instance.userInfo.UserId, approverInfo.UserId, changeDate_createTab_dateTimePicker.Value, "CREATED");

            int tempMSRID = DatabaseAPI.DBAccessSingleton.Instance.MSRInfoAPI.CreateInitialMSR(mSRInfo);

            //testing
            MessageBox.Show("MSR ID is: " + tempMSRID.ToString());

        }

        private void ClearAllFields_createTab_button_Click(object sender, EventArgs e)
        {
            //First Basic Reset
            UserInterfaceAPI.UserInterfaceSIngleton.Instance.ResetAllControls(createNewMSR_tabPage);

            //Reset Budget GroupBox
            budgetYear_createTab_comboBox.SelectedIndex = -1;
            budgetPool_createTab_comboBox.SelectedIndex = -1;

            //Reset SignDate GroupBox
            approval_createTab_comboBox.SelectedIndex = -1;

            //Reset Buttons
            addStock_createTab_button.Enabled = false;
            addNonStock_createTab_button.Enabled = false;


        }


    }
}
