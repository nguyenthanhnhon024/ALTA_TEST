using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace ALTA_TEST.Models
{
    [Table("HocVien")]
    public class HocVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHV { set; get; }

        [MaxLength(255)]
        public string TenHV { set; get; }

        [MaxLength(3)]
        public string Lop { set; get; }

    }
}
