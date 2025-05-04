namespace _3DES.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        internal string secretKey;

        [Key]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(10)]
        public string HoUser { get; set; }

        [Required]
        [StringLength(50)]
        public string TenUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(12)]
        public string Sdt { get; set; }

        [Required]
        [StringLength(50)]
        public string Gmail { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(255)]
        public string Passwordct { get; set; }
    }
}
