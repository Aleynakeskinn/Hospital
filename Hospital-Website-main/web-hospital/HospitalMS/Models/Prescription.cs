//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        public int PrescriptionID { get; set; }
        public System.DateTime PrescriptionDate { get; set; }
        public string Dosage { get; set; }
        public string FrequencyOfUse { get; set; }
        public string PatientsName { get; set; }
        public string Medicine { get; set; }
        public string DoktorName { get; set; }
        public string AdditionalMessage { get; set; }
    }
}
