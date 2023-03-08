using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALTA_TEST.Models
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaMH { set; get; }

        [MaxLength(255)]
        public string TenMH { set; get; }
    }
}
