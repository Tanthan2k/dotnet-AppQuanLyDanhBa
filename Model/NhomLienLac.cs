namespace AppQuanLyDanhBa.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomLienLac")]
    public partial class NhomLienLac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomLienLac()
        {
            ChiTietNhomLienLacs = new HashSet<ChiTietNhomLienLac>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietNhomLienLac> ChiTietNhomLienLacs { get; set; }
    }
}
