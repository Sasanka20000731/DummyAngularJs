//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dummyAngulerJSProject.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTicket()
        {
            this.tblMasterTicketDetails = new HashSet<tblMasterTicketDetail>();
        }
    
        public int TicketId { get; set; }
        public Nullable<int> InventoryID { get; set; }
        public Nullable<int> CoustomerId { get; set; }
        public string TicketDiscription { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsOpen { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<System.DateTime> OpenedDate { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
    
        public virtual tblInventoryData tblInventoryData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMasterTicketDetail> tblMasterTicketDetails { get; set; }
    }
}
