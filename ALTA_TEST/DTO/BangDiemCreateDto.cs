using System.ComponentModel.DataAnnotations;

namespace ALTA_TEST.DTO
{
    public class BangDiemCreateDto
    {
        public int MaHV { get; set; }

        public int MaMH { get; set; }

        public float Diem { get; set; }

        public int HeSo { get; set; }

        public int NamHoc { get; set; }
    }
}
