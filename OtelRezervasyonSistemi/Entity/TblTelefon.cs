//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyonSistemi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblTelefon
    {
        public int TelefonID { get; set; }
        public string TelefonAciklama { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> TelefonDurum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
    }
}
