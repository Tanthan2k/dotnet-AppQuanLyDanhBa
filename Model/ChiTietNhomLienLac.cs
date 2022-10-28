namespace AppQuanLyDanhBa.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietNhomLienLac")]
    public partial class ChiTietNhomLienLac
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenGoi { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int IDNhom { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public virtual NhomLienLac NhomLienLac { get; set; }
    }
}
