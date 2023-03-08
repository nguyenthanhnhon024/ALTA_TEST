using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALTA_TEST.Models
{
    [Table("BangDiem")]
    public class BangDiem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHP { set; get; }

        public int MaHV { set; get; }

        public int MaMH { set; get; }

        public float Diem { set; get; }

        public int HeSo { set; get; }

        public int NamHoc { set; get; }

        public HocVien? HocVien { set; get; }

        public MonHoc? MonHoc { set; get; }
    }
}
