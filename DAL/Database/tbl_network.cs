//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_network
    {
        public int network_id { get; set; }
        public Nullable<int> downtime_type_id { get; set; }
        public string network_code_number { get; set; }
        public string location { get; set; }
    }
}
