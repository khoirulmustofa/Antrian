//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Antrian.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BidangPelayanan
    {
        public BidangPelayanan()
        {
            this.Pelayanan = new HashSet<Pelayanan>();
            this.AntrianPelayanan = new HashSet<AntrianPelayanan>();
        }
    
        public int BidangId { get; set; }
        public string NamaBidangPelayanan { get; set; }
        public Nullable<int> Loket { get; set; }
    
        public virtual ICollection<Pelayanan> Pelayanan { get; set; }
        public virtual ICollection<AntrianPelayanan> AntrianPelayanan { get; set; }
    }
}
