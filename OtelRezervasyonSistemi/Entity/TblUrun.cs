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
    
    public partial class TblUrun
    {
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public Nullable<int> UrunGrup { get; set; }
        public Nullable<int> UrunBirim { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public Nullable<decimal> UrunToplam { get; set; }
        public Nullable<byte> UrunKdv { get; set; }
        public Nullable<int> UrunDurum { get; set; }
    
        public virtual TblBirim TblBirim { get; set; }
        public virtual TblDurum TblDurum { get; set; }
        public virtual TblUrunGrup TblUrunGrup { get; set; }
    }
}