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
    
    public partial class tbl_gantt_chart
    {
        public int gant_chart_id { get; set; }
        public string details_id { get; set; }
        public string work_package { get; set; }
        public string branches { get; set; }
        public string functions { get; set; }
        public Nullable<System.DateTime> date_started { get; set; }
        public Nullable<System.DateTime> date_ended { get; set; }
    }
}
