﻿namespace MSR
{
    partial class MSRMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMSR_tabControl = new System.Windows.Forms.TabControl();
            this.createNewMSR_tabPage = new System.Windows.Forms.TabPage();
            this.clearAllFields_createTab_button = new System.Windows.Forms.Button();
            this.submit_createTab_button = new System.Windows.Forms.Button();
            this.addNonStock_createTab_button = new System.Windows.Forms.Button();
            this.addStock_createTab_button = new System.Windows.Forms.Button();
            this.signDate_createTab_groupBox = new System.Windows.Forms.GroupBox();
            this.changeDate_createTab_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.changeDate_createTab_checkBox = new System.Windows.Forms.CheckBox();
            this.approval_createTab_comboBox = new System.Windows.Forms.ComboBox();
            this.approval_createTab_label = new System.Windows.Forms.Label();
            this.originator_createTab_comboBox = new System.Windows.Forms.ComboBox();
            this.originator_createTab_label = new System.Windows.Forms.Label();
            this.createTab_dataGridView = new System.Windows.Forms.DataGridView();
            this.BudgetPool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROS_Date = new MSR.Domain.CalendarColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorContact_createTab_groupBox = new System.Windows.Forms.GroupBox();
            this.vendorContact_createTab_textBox = new System.Windows.Forms.TextBox();
            this.vendorContact_createTab_label = new System.Windows.Forms.Label();
            this.suggVendor_createTab_groupBox = new System.Windows.Forms.GroupBox();
            this.suggVendor_createTab_textBox = new System.Windows.Forms.TextBox();
            this.suggVendor_createTab_label = new System.Windows.Forms.Label();
            this.budget_createTab_groupBox = new System.Windows.Forms.GroupBox();
            this.AFE_createTab_label = new System.Windows.Forms.Label();
            this.budgetPool_createTab_comboBox = new System.Windows.Forms.ComboBox();
            this.AFE_createTab_textBox = new System.Windows.Forms.TextBox();
            this.budgetYear_createTab_comboBox = new System.Windows.Forms.ComboBox();
            this.budgetPool_createTab_label = new System.Windows.Forms.Label();
            this.budgetYear_createTab_label = new System.Windows.Forms.Label();
            this.project_createTab_groupBox = new System.Windows.Forms.GroupBox();
            this.comments_createTab_label = new System.Windows.Forms.Label();
            this.comments_createTab_textBox = new System.Windows.Forms.TextBox();
            this.wellVL_createTab_textBox = new System.Windows.Forms.TextBox();
            this.project_createTab_textBox = new System.Windows.Forms.TextBox();
            this.wellVL_createTab_label = new System.Windows.Forms.Label();
            this.project_createTab_label = new System.Windows.Forms.Label();
            this.waitApproval_tabPage = new System.Windows.Forms.TabPage();
            this.Test_ShowMSR = new System.Windows.Forms.Button();
            this.waitApprovalTab_dataGridView = new System.Windows.Forms.DataGridView();
            this.search_waitApprovalTab_groupBox = new System.Windows.Forms.GroupBox();
            this.apSearch_waitApprovalTab_textBox = new System.Windows.Forms.TextBox();
            this.apSearch_waitApprovalTab_label = new System.Windows.Forms.Label();
            this.ogSearch_waitApprovalTab_textBox = new System.Windows.Forms.TextBox();
            this.ogSearch_waitApprovalTab_label = new System.Windows.Forms.Label();
            this.deptSearch_waitApprovalTab_textBox = new System.Windows.Forms.TextBox();
            this.deptSearch_waitApprovalTab_label = new System.Windows.Forms.Label();
            this.idSearch_waitApprovalTab_textBox = new System.Windows.Forms.TextBox();
            this.idSearch_waitApprovalTab_label = new System.Windows.Forms.Label();
            this.MSRMain_menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMSR_tabControl.SuspendLayout();
            this.createNewMSR_tabPage.SuspendLayout();
            this.signDate_createTab_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createTab_dataGridView)).BeginInit();
            this.vendorContact_createTab_groupBox.SuspendLayout();
            this.suggVendor_createTab_groupBox.SuspendLayout();
            this.budget_createTab_groupBox.SuspendLayout();
            this.project_createTab_groupBox.SuspendLayout();
            this.waitApproval_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitApprovalTab_dataGridView)).BeginInit();
            this.search_waitApprovalTab_groupBox.SuspendLayout();
            this.MSRMain_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMSR_tabControl
            // 
            this.mainMSR_tabControl.Controls.Add(this.createNewMSR_tabPage);
            this.mainMSR_tabControl.Controls.Add(this.waitApproval_tabPage);
            this.mainMSR_tabControl.Location = new System.Drawing.Point(12, 27);
            this.mainMSR_tabControl.Name = "mainMSR_tabControl";
            this.mainMSR_tabControl.SelectedIndex = 0;
            this.mainMSR_tabControl.Size = new System.Drawing.Size(1160, 812);
            this.mainMSR_tabControl.TabIndex = 0;
            // 
            // createNewMSR_tabPage
            // 
            this.createNewMSR_tabPage.Controls.Add(this.clearAllFields_createTab_button);
            this.createNewMSR_tabPage.Controls.Add(this.submit_createTab_button);
            this.createNewMSR_tabPage.Controls.Add(this.addNonStock_createTab_button);
            this.createNewMSR_tabPage.Controls.Add(this.addStock_createTab_button);
            this.createNewMSR_tabPage.Controls.Add(this.signDate_createTab_groupBox);
            this.createNewMSR_tabPage.Controls.Add(this.createTab_dataGridView);
            this.createNewMSR_tabPage.Controls.Add(this.vendorContact_createTab_groupBox);
            this.createNewMSR_tabPage.Controls.Add(this.suggVendor_createTab_groupBox);
            this.createNewMSR_tabPage.Controls.Add(this.budget_createTab_groupBox);
            this.createNewMSR_tabPage.Controls.Add(this.project_createTab_groupBox);
            this.createNewMSR_tabPage.Location = new System.Drawing.Point(4, 22);
            this.createNewMSR_tabPage.Name = "createNewMSR_tabPage";
            this.createNewMSR_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createNewMSR_tabPage.Size = new System.Drawing.Size(1152, 786);
            this.createNewMSR_tabPage.TabIndex = 0;
            this.createNewMSR_tabPage.Text = "Create New MSR";
            this.createNewMSR_tabPage.UseVisualStyleBackColor = true;
            // 
            // clearAllFields_createTab_button
            // 
            this.clearAllFields_createTab_button.AutoSize = true;
            this.clearAllFields_createTab_button.Location = new System.Drawing.Point(1026, 730);
            this.clearAllFields_createTab_button.Name = "clearAllFields_createTab_button";
            this.clearAllFields_createTab_button.Size = new System.Drawing.Size(120, 50);
            this.clearAllFields_createTab_button.TabIndex = 14;
            this.clearAllFields_createTab_button.Text = "Clear All Fields";
            this.clearAllFields_createTab_button.UseVisualStyleBackColor = true;
            this.clearAllFields_createTab_button.Click += new System.EventHandler(this.ClearAllFields_createTab_button_Click);
            // 
            // submit_createTab_button
            // 
            this.submit_createTab_button.AutoSize = true;
            this.submit_createTab_button.Location = new System.Drawing.Point(436, 730);
            this.submit_createTab_button.Name = "submit_createTab_button";
            this.submit_createTab_button.Size = new System.Drawing.Size(120, 50);
            this.submit_createTab_button.TabIndex = 13;
            this.submit_createTab_button.Text = "Submit";
            this.submit_createTab_button.UseVisualStyleBackColor = true;
            this.submit_createTab_button.Click += new System.EventHandler(this.Save_createTab_button_Click);
            // 
            // addNonStock_createTab_button
            // 
            this.addNonStock_createTab_button.AutoSize = true;
            this.addNonStock_createTab_button.Enabled = false;
            this.addNonStock_createTab_button.Location = new System.Drawing.Point(436, 676);
            this.addNonStock_createTab_button.Name = "addNonStock_createTab_button";
            this.addNonStock_createTab_button.Size = new System.Drawing.Size(120, 50);
            this.addNonStock_createTab_button.TabIndex = 12;
            this.addNonStock_createTab_button.Text = "Add Non Stock Item";
            this.addNonStock_createTab_button.UseVisualStyleBackColor = true;
            this.addNonStock_createTab_button.Click += new System.EventHandler(this.AddNonStock_createTab_button_Click);
            // 
            // addStock_createTab_button
            // 
            this.addStock_createTab_button.AutoSize = true;
            this.addStock_createTab_button.Enabled = false;
            this.addStock_createTab_button.Location = new System.Drawing.Point(436, 620);
            this.addStock_createTab_button.Name = "addStock_createTab_button";
            this.addStock_createTab_button.Size = new System.Drawing.Size(120, 50);
            this.addStock_createTab_button.TabIndex = 11;
            this.addStock_createTab_button.Text = "Add Stock Item";
            this.addStock_createTab_button.UseVisualStyleBackColor = true;
            this.addStock_createTab_button.Click += new System.EventHandler(this.AddStock_createTab_button_Click);
            // 
            // signDate_createTab_groupBox
            // 
            this.signDate_createTab_groupBox.Controls.Add(this.changeDate_createTab_dateTimePicker);
            this.signDate_createTab_groupBox.Controls.Add(this.changeDate_createTab_checkBox);
            this.signDate_createTab_groupBox.Controls.Add(this.approval_createTab_comboBox);
            this.signDate_createTab_groupBox.Controls.Add(this.approval_createTab_label);
            this.signDate_createTab_groupBox.Controls.Add(this.originator_createTab_comboBox);
            this.signDate_createTab_groupBox.Controls.Add(this.originator_createTab_label);
            this.signDate_createTab_groupBox.Location = new System.Drawing.Point(17, 621);
            this.signDate_createTab_groupBox.Name = "signDate_createTab_groupBox";
            this.signDate_createTab_groupBox.Size = new System.Drawing.Size(413, 161);
            this.signDate_createTab_groupBox.TabIndex = 10;
            this.signDate_createTab_groupBox.TabStop = false;
            // 
            // changeDate_createTab_dateTimePicker
            // 
            this.changeDate_createTab_dateTimePicker.Enabled = false;
            this.changeDate_createTab_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.changeDate_createTab_dateTimePicker.Location = new System.Drawing.Point(181, 45);
            this.changeDate_createTab_dateTimePicker.Name = "changeDate_createTab_dateTimePicker";
            this.changeDate_createTab_dateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.changeDate_createTab_dateTimePicker.TabIndex = 11;
            // 
            // changeDate_createTab_checkBox
            // 
            this.changeDate_createTab_checkBox.AutoSize = true;
            this.changeDate_createTab_checkBox.Location = new System.Drawing.Point(181, 22);
            this.changeDate_createTab_checkBox.Name = "changeDate_createTab_checkBox";
            this.changeDate_createTab_checkBox.Size = new System.Drawing.Size(131, 17);
            this.changeDate_createTab_checkBox.TabIndex = 0;
            this.changeDate_createTab_checkBox.Text = "Change Creation Date";
            this.changeDate_createTab_checkBox.UseVisualStyleBackColor = true;
            this.changeDate_createTab_checkBox.CheckedChanged += new System.EventHandler(this.ChangeDate_createTab_checkBox_CheckedChanged);
            // 
            // approval_createTab_comboBox
            // 
            this.approval_createTab_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.approval_createTab_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approval_createTab_comboBox.Enabled = false;
            this.approval_createTab_comboBox.FormattingEnabled = true;
            this.approval_createTab_comboBox.Location = new System.Drawing.Point(25, 96);
            this.approval_createTab_comboBox.Name = "approval_createTab_comboBox";
            this.approval_createTab_comboBox.Size = new System.Drawing.Size(130, 21);
            this.approval_createTab_comboBox.TabIndex = 10;
            // 
            // approval_createTab_label
            // 
            this.approval_createTab_label.AutoSize = true;
            this.approval_createTab_label.Location = new System.Drawing.Point(22, 80);
            this.approval_createTab_label.Name = "approval_createTab_label";
            this.approval_createTab_label.Size = new System.Drawing.Size(123, 13);
            this.approval_createTab_label.TabIndex = 9;
            this.approval_createTab_label.Text = "COMPANY APPROVAL:";
            // 
            // originator_createTab_comboBox
            // 
            this.originator_createTab_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.originator_createTab_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originator_createTab_comboBox.Enabled = false;
            this.originator_createTab_comboBox.FormattingEnabled = true;
            this.originator_createTab_comboBox.Location = new System.Drawing.Point(25, 42);
            this.originator_createTab_comboBox.Name = "originator_createTab_comboBox";
            this.originator_createTab_comboBox.Size = new System.Drawing.Size(130, 21);
            this.originator_createTab_comboBox.TabIndex = 8;
            // 
            // originator_createTab_label
            // 
            this.originator_createTab_label.AutoSize = true;
            this.originator_createTab_label.Location = new System.Drawing.Point(22, 26);
            this.originator_createTab_label.Name = "originator_createTab_label";
            this.originator_createTab_label.Size = new System.Drawing.Size(133, 13);
            this.originator_createTab_label.TabIndex = 6;
            this.originator_createTab_label.Text = "REQUEST ORIGINATOR:";
            // 
            // createTab_dataGridView
            // 
            this.createTab_dataGridView.AllowUserToAddRows = false;
            this.createTab_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.createTab_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createTab_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BudgetPool,
            this.ItemCode,
            this.ItemDesc,
            this.Quantity,
            this.Unit,
            this.UnitPrice,
            this.Currency,
            this.ROS_Date,
            this.Comments,
            this.AC_No});
            this.createTab_dataGridView.Location = new System.Drawing.Point(17, 214);
            this.createTab_dataGridView.Name = "createTab_dataGridView";
            this.createTab_dataGridView.Size = new System.Drawing.Size(1006, 400);
            this.createTab_dataGridView.TabIndex = 8;
            // 
            // BudgetPool
            // 
            this.BudgetPool.HeaderText = "BudgetPool";
            this.BudgetPool.Name = "BudgetPool";
            this.BudgetPool.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            // 
            // ItemDesc
            // 
            this.ItemDesc.HeaderText = "ItemDesc";
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            // 
            // ROS_Date
            // 
            this.ROS_Date.HeaderText = "ROS_Date";
            this.ROS_Date.Name = "ROS_Date";
            this.ROS_Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ROS_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            // 
            // AC_No
            // 
            this.AC_No.HeaderText = "AC_No";
            this.AC_No.Name = "AC_No";
            this.AC_No.ReadOnly = true;
            // 
            // vendorContact_createTab_groupBox
            // 
            this.vendorContact_createTab_groupBox.Controls.Add(this.vendorContact_createTab_textBox);
            this.vendorContact_createTab_groupBox.Controls.Add(this.vendorContact_createTab_label);
            this.vendorContact_createTab_groupBox.Location = new System.Drawing.Point(523, 124);
            this.vendorContact_createTab_groupBox.Name = "vendorContact_createTab_groupBox";
            this.vendorContact_createTab_groupBox.Size = new System.Drawing.Size(500, 75);
            this.vendorContact_createTab_groupBox.TabIndex = 7;
            this.vendorContact_createTab_groupBox.TabStop = false;
            // 
            // vendorContact_createTab_textBox
            // 
            this.vendorContact_createTab_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorContact_createTab_textBox.Location = new System.Drawing.Point(9, 32);
            this.vendorContact_createTab_textBox.Name = "vendorContact_createTab_textBox";
            this.vendorContact_createTab_textBox.Size = new System.Drawing.Size(485, 20);
            this.vendorContact_createTab_textBox.TabIndex = 2;
            // 
            // vendorContact_createTab_label
            // 
            this.vendorContact_createTab_label.AutoSize = true;
            this.vendorContact_createTab_label.Location = new System.Drawing.Point(6, 16);
            this.vendorContact_createTab_label.Name = "vendorContact_createTab_label";
            this.vendorContact_createTab_label.Size = new System.Drawing.Size(138, 13);
            this.vendorContact_createTab_label.TabIndex = 0;
            this.vendorContact_createTab_label.Text = "VENDOR CONTACT INFO:";
            // 
            // suggVendor_createTab_groupBox
            // 
            this.suggVendor_createTab_groupBox.Controls.Add(this.suggVendor_createTab_textBox);
            this.suggVendor_createTab_groupBox.Controls.Add(this.suggVendor_createTab_label);
            this.suggVendor_createTab_groupBox.Location = new System.Drawing.Point(17, 124);
            this.suggVendor_createTab_groupBox.Name = "suggVendor_createTab_groupBox";
            this.suggVendor_createTab_groupBox.Size = new System.Drawing.Size(500, 75);
            this.suggVendor_createTab_groupBox.TabIndex = 6;
            this.suggVendor_createTab_groupBox.TabStop = false;
            // 
            // suggVendor_createTab_textBox
            // 
            this.suggVendor_createTab_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggVendor_createTab_textBox.Location = new System.Drawing.Point(9, 32);
            this.suggVendor_createTab_textBox.Name = "suggVendor_createTab_textBox";
            this.suggVendor_createTab_textBox.Size = new System.Drawing.Size(485, 20);
            this.suggVendor_createTab_textBox.TabIndex = 2;
            // 
            // suggVendor_createTab_label
            // 
            this.suggVendor_createTab_label.AutoSize = true;
            this.suggVendor_createTab_label.Location = new System.Drawing.Point(6, 16);
            this.suggVendor_createTab_label.Name = "suggVendor_createTab_label";
            this.suggVendor_createTab_label.Size = new System.Drawing.Size(126, 13);
            this.suggVendor_createTab_label.TabIndex = 0;
            this.suggVendor_createTab_label.Text = "SUGGESTED VENDOR:";
            // 
            // budget_createTab_groupBox
            // 
            this.budget_createTab_groupBox.Controls.Add(this.AFE_createTab_label);
            this.budget_createTab_groupBox.Controls.Add(this.budgetPool_createTab_comboBox);
            this.budget_createTab_groupBox.Controls.Add(this.AFE_createTab_textBox);
            this.budget_createTab_groupBox.Controls.Add(this.budgetYear_createTab_comboBox);
            this.budget_createTab_groupBox.Controls.Add(this.budgetPool_createTab_label);
            this.budget_createTab_groupBox.Controls.Add(this.budgetYear_createTab_label);
            this.budget_createTab_groupBox.Location = new System.Drawing.Point(523, 18);
            this.budget_createTab_groupBox.Name = "budget_createTab_groupBox";
            this.budget_createTab_groupBox.Size = new System.Drawing.Size(500, 100);
            this.budget_createTab_groupBox.TabIndex = 1;
            this.budget_createTab_groupBox.TabStop = false;
            // 
            // AFE_createTab_label
            // 
            this.AFE_createTab_label.AutoSize = true;
            this.AFE_createTab_label.Location = new System.Drawing.Point(87, 68);
            this.AFE_createTab_label.Name = "AFE_createTab_label";
            this.AFE_createTab_label.Size = new System.Drawing.Size(30, 13);
            this.AFE_createTab_label.TabIndex = 7;
            this.AFE_createTab_label.Text = "AFE:";
            // 
            // budgetPool_createTab_comboBox
            // 
            this.budgetPool_createTab_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.budgetPool_createTab_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.budgetPool_createTab_comboBox.FormattingEnabled = true;
            this.budgetPool_createTab_comboBox.Location = new System.Drawing.Point(123, 40);
            this.budgetPool_createTab_comboBox.Name = "budgetPool_createTab_comboBox";
            this.budgetPool_createTab_comboBox.Size = new System.Drawing.Size(121, 21);
            this.budgetPool_createTab_comboBox.TabIndex = 9;
            this.budgetPool_createTab_comboBox.SelectedIndexChanged += new System.EventHandler(this.BudgetPool_createTab_comboBox_SelectedIndexChanged);
            // 
            // AFE_createTab_textBox
            // 
            this.AFE_createTab_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AFE_createTab_textBox.Location = new System.Drawing.Point(123, 65);
            this.AFE_createTab_textBox.Name = "AFE_createTab_textBox";
            this.AFE_createTab_textBox.Size = new System.Drawing.Size(121, 20);
            this.AFE_createTab_textBox.TabIndex = 6;
            // 
            // budgetYear_createTab_comboBox
            // 
            this.budgetYear_createTab_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.budgetYear_createTab_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.budgetYear_createTab_comboBox.FormattingEnabled = true;
            this.budgetYear_createTab_comboBox.Location = new System.Drawing.Point(123, 13);
            this.budgetYear_createTab_comboBox.Name = "budgetYear_createTab_comboBox";
            this.budgetYear_createTab_comboBox.Size = new System.Drawing.Size(121, 21);
            this.budgetYear_createTab_comboBox.TabIndex = 8;
            // 
            // budgetPool_createTab_label
            // 
            this.budgetPool_createTab_label.AutoSize = true;
            this.budgetPool_createTab_label.Location = new System.Drawing.Point(30, 42);
            this.budgetPool_createTab_label.Name = "budgetPool_createTab_label";
            this.budgetPool_createTab_label.Size = new System.Drawing.Size(87, 13);
            this.budgetPool_createTab_label.TabIndex = 7;
            this.budgetPool_createTab_label.Text = "BUDGET POOL:";
            // 
            // budgetYear_createTab_label
            // 
            this.budgetYear_createTab_label.AutoSize = true;
            this.budgetYear_createTab_label.Location = new System.Drawing.Point(30, 16);
            this.budgetYear_createTab_label.Name = "budgetYear_createTab_label";
            this.budgetYear_createTab_label.Size = new System.Drawing.Size(87, 13);
            this.budgetYear_createTab_label.TabIndex = 6;
            this.budgetYear_createTab_label.Text = "BUDGET YEAR:";
            // 
            // project_createTab_groupBox
            // 
            this.project_createTab_groupBox.Controls.Add(this.comments_createTab_label);
            this.project_createTab_groupBox.Controls.Add(this.comments_createTab_textBox);
            this.project_createTab_groupBox.Controls.Add(this.wellVL_createTab_textBox);
            this.project_createTab_groupBox.Controls.Add(this.project_createTab_textBox);
            this.project_createTab_groupBox.Controls.Add(this.wellVL_createTab_label);
            this.project_createTab_groupBox.Controls.Add(this.project_createTab_label);
            this.project_createTab_groupBox.Location = new System.Drawing.Point(17, 18);
            this.project_createTab_groupBox.Name = "project_createTab_groupBox";
            this.project_createTab_groupBox.Size = new System.Drawing.Size(500, 100);
            this.project_createTab_groupBox.TabIndex = 0;
            this.project_createTab_groupBox.TabStop = false;
            // 
            // comments_createTab_label
            // 
            this.comments_createTab_label.AutoSize = true;
            this.comments_createTab_label.Location = new System.Drawing.Point(6, 68);
            this.comments_createTab_label.Name = "comments_createTab_label";
            this.comments_createTab_label.Size = new System.Drawing.Size(72, 13);
            this.comments_createTab_label.TabIndex = 5;
            this.comments_createTab_label.Text = "COMMENTS:";
            // 
            // comments_createTab_textBox
            // 
            this.comments_createTab_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comments_createTab_textBox.Location = new System.Drawing.Point(85, 65);
            this.comments_createTab_textBox.Name = "comments_createTab_textBox";
            this.comments_createTab_textBox.Size = new System.Drawing.Size(385, 20);
            this.comments_createTab_textBox.TabIndex = 4;
            // 
            // wellVL_createTab_textBox
            // 
            this.wellVL_createTab_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wellVL_createTab_textBox.Location = new System.Drawing.Point(162, 39);
            this.wellVL_createTab_textBox.Name = "wellVL_createTab_textBox";
            this.wellVL_createTab_textBox.Size = new System.Drawing.Size(308, 20);
            this.wellVL_createTab_textBox.TabIndex = 3;
            // 
            // project_createTab_textBox
            // 
            this.project_createTab_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.project_createTab_textBox.Location = new System.Drawing.Point(70, 13);
            this.project_createTab_textBox.Name = "project_createTab_textBox";
            this.project_createTab_textBox.Size = new System.Drawing.Size(400, 20);
            this.project_createTab_textBox.TabIndex = 2;
            // 
            // wellVL_createTab_label
            // 
            this.wellVL_createTab_label.AutoSize = true;
            this.wellVL_createTab_label.Location = new System.Drawing.Point(6, 42);
            this.wellVL_createTab_label.Name = "wellVL_createTab_label";
            this.wellVL_createTab_label.Size = new System.Drawing.Size(149, 13);
            this.wellVL_createTab_label.TabIndex = 1;
            this.wellVL_createTab_label.Text = "WELL/VEHICLE/LOCATION:";
            // 
            // project_createTab_label
            // 
            this.project_createTab_label.AutoSize = true;
            this.project_createTab_label.Location = new System.Drawing.Point(6, 16);
            this.project_createTab_label.Name = "project_createTab_label";
            this.project_createTab_label.Size = new System.Drawing.Size(59, 13);
            this.project_createTab_label.TabIndex = 0;
            this.project_createTab_label.Text = "PROJECT:";
            // 
            // waitApproval_tabPage
            // 
            this.waitApproval_tabPage.Controls.Add(this.Test_ShowMSR);
            this.waitApproval_tabPage.Controls.Add(this.waitApprovalTab_dataGridView);
            this.waitApproval_tabPage.Controls.Add(this.search_waitApprovalTab_groupBox);
            this.waitApproval_tabPage.Location = new System.Drawing.Point(4, 22);
            this.waitApproval_tabPage.Name = "waitApproval_tabPage";
            this.waitApproval_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.waitApproval_tabPage.Size = new System.Drawing.Size(1152, 786);
            this.waitApproval_tabPage.TabIndex = 1;
            this.waitApproval_tabPage.Text = "MSRs Waiting for Approval";
            this.waitApproval_tabPage.UseVisualStyleBackColor = true;
            // 
            // Test_ShowMSR
            // 
            this.Test_ShowMSR.AutoSize = true;
            this.Test_ShowMSR.Location = new System.Drawing.Point(1013, 33);
            this.Test_ShowMSR.Name = "Test_ShowMSR";
            this.Test_ShowMSR.Size = new System.Drawing.Size(95, 23);
            this.Test_ShowMSR.TabIndex = 2;
            this.Test_ShowMSR.Text = "Test_ShowMSR";
            this.Test_ShowMSR.UseVisualStyleBackColor = true;
            this.Test_ShowMSR.Click += new System.EventHandler(this.Test_ShowMSR_Click);
            // 
            // waitApprovalTab_dataGridView
            // 
            this.waitApprovalTab_dataGridView.AllowUserToAddRows = false;
            this.waitApprovalTab_dataGridView.AllowUserToDeleteRows = false;
            this.waitApprovalTab_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitApprovalTab_dataGridView.Location = new System.Drawing.Point(19, 113);
            this.waitApprovalTab_dataGridView.Name = "waitApprovalTab_dataGridView";
            this.waitApprovalTab_dataGridView.ReadOnly = true;
            this.waitApprovalTab_dataGridView.Size = new System.Drawing.Size(930, 450);
            this.waitApprovalTab_dataGridView.TabIndex = 1;
            // 
            // search_waitApprovalTab_groupBox
            // 
            this.search_waitApprovalTab_groupBox.Controls.Add(this.apSearch_waitApprovalTab_textBox);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.apSearch_waitApprovalTab_label);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.ogSearch_waitApprovalTab_textBox);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.ogSearch_waitApprovalTab_label);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.deptSearch_waitApprovalTab_textBox);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.deptSearch_waitApprovalTab_label);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.idSearch_waitApprovalTab_textBox);
            this.search_waitApprovalTab_groupBox.Controls.Add(this.idSearch_waitApprovalTab_label);
            this.search_waitApprovalTab_groupBox.Location = new System.Drawing.Point(19, 18);
            this.search_waitApprovalTab_groupBox.Name = "search_waitApprovalTab_groupBox";
            this.search_waitApprovalTab_groupBox.Size = new System.Drawing.Size(930, 89);
            this.search_waitApprovalTab_groupBox.TabIndex = 0;
            this.search_waitApprovalTab_groupBox.TabStop = false;
            this.search_waitApprovalTab_groupBox.Text = "Search";
            // 
            // apSearch_waitApprovalTab_textBox
            // 
            this.apSearch_waitApprovalTab_textBox.Location = new System.Drawing.Point(349, 53);
            this.apSearch_waitApprovalTab_textBox.Name = "apSearch_waitApprovalTab_textBox";
            this.apSearch_waitApprovalTab_textBox.Size = new System.Drawing.Size(100, 20);
            this.apSearch_waitApprovalTab_textBox.TabIndex = 7;
            this.apSearch_waitApprovalTab_textBox.TextChanged += new System.EventHandler(this.ApSearch_waitApprovalTab_textBox_TextChanged);
            // 
            // apSearch_waitApprovalTab_label
            // 
            this.apSearch_waitApprovalTab_label.AutoSize = true;
            this.apSearch_waitApprovalTab_label.Location = new System.Drawing.Point(346, 37);
            this.apSearch_waitApprovalTab_label.Name = "apSearch_waitApprovalTab_label";
            this.apSearch_waitApprovalTab_label.Size = new System.Drawing.Size(50, 13);
            this.apSearch_waitApprovalTab_label.TabIndex = 6;
            this.apSearch_waitApprovalTab_label.Text = "Approver";
            // 
            // ogSearch_waitApprovalTab_textBox
            // 
            this.ogSearch_waitApprovalTab_textBox.Location = new System.Drawing.Point(243, 53);
            this.ogSearch_waitApprovalTab_textBox.Name = "ogSearch_waitApprovalTab_textBox";
            this.ogSearch_waitApprovalTab_textBox.Size = new System.Drawing.Size(100, 20);
            this.ogSearch_waitApprovalTab_textBox.TabIndex = 5;
            this.ogSearch_waitApprovalTab_textBox.TextChanged += new System.EventHandler(this.OgSearch_waitApprovalTab_textBox_TextChanged);
            // 
            // ogSearch_waitApprovalTab_label
            // 
            this.ogSearch_waitApprovalTab_label.AutoSize = true;
            this.ogSearch_waitApprovalTab_label.Location = new System.Drawing.Point(240, 37);
            this.ogSearch_waitApprovalTab_label.Name = "ogSearch_waitApprovalTab_label";
            this.ogSearch_waitApprovalTab_label.Size = new System.Drawing.Size(52, 13);
            this.ogSearch_waitApprovalTab_label.TabIndex = 4;
            this.ogSearch_waitApprovalTab_label.Text = "Originator";
            // 
            // deptSearch_waitApprovalTab_textBox
            // 
            this.deptSearch_waitApprovalTab_textBox.Location = new System.Drawing.Point(137, 53);
            this.deptSearch_waitApprovalTab_textBox.Name = "deptSearch_waitApprovalTab_textBox";
            this.deptSearch_waitApprovalTab_textBox.Size = new System.Drawing.Size(100, 20);
            this.deptSearch_waitApprovalTab_textBox.TabIndex = 3;
            this.deptSearch_waitApprovalTab_textBox.TextChanged += new System.EventHandler(this.DeptSearch_waitApprovalTab_textBox_TextChanged);
            // 
            // deptSearch_waitApprovalTab_label
            // 
            this.deptSearch_waitApprovalTab_label.AutoSize = true;
            this.deptSearch_waitApprovalTab_label.Location = new System.Drawing.Point(134, 37);
            this.deptSearch_waitApprovalTab_label.Name = "deptSearch_waitApprovalTab_label";
            this.deptSearch_waitApprovalTab_label.Size = new System.Drawing.Size(62, 13);
            this.deptSearch_waitApprovalTab_label.TabIndex = 2;
            this.deptSearch_waitApprovalTab_label.Text = "Department";
            // 
            // idSearch_waitApprovalTab_textBox
            // 
            this.idSearch_waitApprovalTab_textBox.Location = new System.Drawing.Point(31, 53);
            this.idSearch_waitApprovalTab_textBox.Name = "idSearch_waitApprovalTab_textBox";
            this.idSearch_waitApprovalTab_textBox.Size = new System.Drawing.Size(100, 20);
            this.idSearch_waitApprovalTab_textBox.TabIndex = 1;
            this.idSearch_waitApprovalTab_textBox.TextChanged += new System.EventHandler(this.IdSearch_waitApprovalTab_textBox_TextChanged);
            // 
            // idSearch_waitApprovalTab_label
            // 
            this.idSearch_waitApprovalTab_label.AutoSize = true;
            this.idSearch_waitApprovalTab_label.Location = new System.Drawing.Point(28, 37);
            this.idSearch_waitApprovalTab_label.Name = "idSearch_waitApprovalTab_label";
            this.idSearch_waitApprovalTab_label.Size = new System.Drawing.Size(45, 13);
            this.idSearch_waitApprovalTab_label.TabIndex = 0;
            this.idSearch_waitApprovalTab_label.Text = "MSR ID";
            // 
            // MSRMain_menuStrip
            // 
            this.MSRMain_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.MSRMain_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.MSRMain_menuStrip.Name = "MSRMain_menuStrip";
            this.MSRMain_menuStrip.Size = new System.Drawing.Size(1181, 24);
            this.MSRMain_menuStrip.TabIndex = 1;
            this.MSRMain_menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // MSRMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 847);
            this.Controls.Add(this.mainMSR_tabControl);
            this.Controls.Add(this.MSRMain_menuStrip);
            this.Name = "MSRMainForm";
            this.Text = "MSR Main Form";
            this.mainMSR_tabControl.ResumeLayout(false);
            this.createNewMSR_tabPage.ResumeLayout(false);
            this.createNewMSR_tabPage.PerformLayout();
            this.signDate_createTab_groupBox.ResumeLayout(false);
            this.signDate_createTab_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createTab_dataGridView)).EndInit();
            this.vendorContact_createTab_groupBox.ResumeLayout(false);
            this.vendorContact_createTab_groupBox.PerformLayout();
            this.suggVendor_createTab_groupBox.ResumeLayout(false);
            this.suggVendor_createTab_groupBox.PerformLayout();
            this.budget_createTab_groupBox.ResumeLayout(false);
            this.budget_createTab_groupBox.PerformLayout();
            this.project_createTab_groupBox.ResumeLayout(false);
            this.project_createTab_groupBox.PerformLayout();
            this.waitApproval_tabPage.ResumeLayout(false);
            this.waitApproval_tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitApprovalTab_dataGridView)).EndInit();
            this.search_waitApprovalTab_groupBox.ResumeLayout(false);
            this.search_waitApprovalTab_groupBox.PerformLayout();
            this.MSRMain_menuStrip.ResumeLayout(false);
            this.MSRMain_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainMSR_tabControl;
        private System.Windows.Forms.TabPage createNewMSR_tabPage;
        private System.Windows.Forms.TabPage waitApproval_tabPage;
        private System.Windows.Forms.MenuStrip MSRMain_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox project_createTab_groupBox;
        private System.Windows.Forms.GroupBox budget_createTab_groupBox;
        private System.Windows.Forms.Label comments_createTab_label;
        private System.Windows.Forms.TextBox comments_createTab_textBox;
        private System.Windows.Forms.TextBox wellVL_createTab_textBox;
        private System.Windows.Forms.TextBox project_createTab_textBox;
        private System.Windows.Forms.Label wellVL_createTab_label;
        private System.Windows.Forms.Label project_createTab_label;
        private System.Windows.Forms.Label budgetPool_createTab_label;
        private System.Windows.Forms.Label budgetYear_createTab_label;
        private System.Windows.Forms.ComboBox budgetYear_createTab_comboBox;
        private System.Windows.Forms.Label AFE_createTab_label;
        private System.Windows.Forms.ComboBox budgetPool_createTab_comboBox;
        private System.Windows.Forms.TextBox AFE_createTab_textBox;
        private System.Windows.Forms.GroupBox vendorContact_createTab_groupBox;
        private System.Windows.Forms.TextBox vendorContact_createTab_textBox;
        private System.Windows.Forms.Label vendorContact_createTab_label;
        private System.Windows.Forms.GroupBox suggVendor_createTab_groupBox;
        private System.Windows.Forms.TextBox suggVendor_createTab_textBox;
        private System.Windows.Forms.Label suggVendor_createTab_label;
        private System.Windows.Forms.DataGridView createTab_dataGridView;
        private System.Windows.Forms.GroupBox signDate_createTab_groupBox;
        private System.Windows.Forms.ComboBox originator_createTab_comboBox;
        private System.Windows.Forms.Label originator_createTab_label;
        private System.Windows.Forms.ComboBox approval_createTab_comboBox;
        private System.Windows.Forms.Label approval_createTab_label;
        private System.Windows.Forms.DateTimePicker changeDate_createTab_dateTimePicker;
        private System.Windows.Forms.CheckBox changeDate_createTab_checkBox;
        private System.Windows.Forms.Button addStock_createTab_button;
        private System.Windows.Forms.Button submit_createTab_button;
        private System.Windows.Forms.Button addNonStock_createTab_button;
        private System.Windows.Forms.Button clearAllFields_createTab_button;
        private System.Windows.Forms.GroupBox search_waitApprovalTab_groupBox;
        private System.Windows.Forms.TextBox idSearch_waitApprovalTab_textBox;
        private System.Windows.Forms.Label idSearch_waitApprovalTab_label;
        private System.Windows.Forms.DataGridView waitApprovalTab_dataGridView;
        private System.Windows.Forms.Button Test_ShowMSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BudgetPool;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private Domain.CalendarColumn ROS_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC_No;
        private System.Windows.Forms.TextBox apSearch_waitApprovalTab_textBox;
        private System.Windows.Forms.Label apSearch_waitApprovalTab_label;
        private System.Windows.Forms.TextBox ogSearch_waitApprovalTab_textBox;
        private System.Windows.Forms.Label ogSearch_waitApprovalTab_label;
        private System.Windows.Forms.TextBox deptSearch_waitApprovalTab_textBox;
        private System.Windows.Forms.Label deptSearch_waitApprovalTab_label;
    }
}

