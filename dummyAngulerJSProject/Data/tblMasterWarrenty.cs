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
    
    public partial class tblMasterWarrenty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMasterWarrenty()
        {
            this.tblWarrentyExtendedDates = new HashSet<tblWarrentyExtendedDate>();
            this.tblWarrentyhistories = new HashSet<tblWarrentyhistory>();
        }
    
        public int mWarrentyId { get; set; }
        public Nullable<int> inventoryId { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual tblInventoryData tblInventoryData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWarrentyExtendedDate> tblWarrentyExtendedDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWarrentyhistory> tblWarrentyhistories { get; set; }
    }
}