//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKH_v3
{
    using System;
    using System.Collections.Generic;
    
    public partial class interestRate
    {
        public interestRate()
        {
            this.customers = new HashSet<customer>();
            this.historyInterestRates = new HashSet<historyInterestRate>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string Note { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<customer> customers { get; set; }
        public virtual ICollection<historyInterestRate> historyInterestRates { get; set; }
    }
}
