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
    
    public partial class Pelayanan
    {
        public Pelayanan()
        {
            this.AntrianPelayanan = new HashSet<AntrianPelayanan>();
        }
    
        public int PelayananId { get; set; }
        public string NamaPelayanan { get; set; }
        public Nullable<int> Bidang { get; set; }
    
        public virtual BidangPelayanan BidangPelayanan { get; set; }
        public virtual ICollection<AntrianPelayanan> AntrianPelayanan { get; set; }
    }
}
