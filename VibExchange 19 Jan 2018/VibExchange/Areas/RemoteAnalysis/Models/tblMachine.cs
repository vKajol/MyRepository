//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VibExchange.Areas.RemoteAnalysis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMachine
    {
        public int MachineID { get; set; }
        public string MachineName { get; set; }
        public string MachineDetail { get; set; }
        public string MachineClass { get; set; }
        public double RPMDriven { get; set; }
        public double PulseRevolution { get; set; }
        public int FileID { get; set; }
        public int ParentID { get; set; }
        public string NodeType { get; set; }
    }
}