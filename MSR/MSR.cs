//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSR
{
    using System;
    using System.Collections.Generic;
    
    public partial class MSR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSR()
        {
            this.FormItems = new HashSet<FormItem>();
        }
    
        public int MSRId { get; set; }
        public string Project { get; set; }
        public string WVL { get; set; }
        public string Comments { get; set; }
        public int BudgetYear { get; set; }
        public string BP_No { get; set; }
        public string AFE { get; set; }
        public string SugVendor { get; set; }
        public string ContactVendor { get; set; }
        public int Request_Originator { get; set; }
        public int Company_Approval { get; set; }
        public System.DateTime Req_Date { get; set; }
        public Nullable<System.DateTime> Appr_Date { get; set; }
        public Nullable<int> Recieve_By { get; set; }
        public Nullable<System.DateTime> Recieve_Date { get; set; }
        public string PUR_Comment { get; set; }
        public string Decline_Comment { get; set; }
        public string Review_Comment { get; set; }
        public string StateFlag { get; set; }
    
        public virtual BudgetPool BudgetPool { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormItem> FormItems { get; set; }
        public virtual Usr Usr_CA { get; set; }
        public virtual Usr Usr_RecieveBy { get; set; }
        public virtual Usr Usr_RO { get; set; }
    }
}
