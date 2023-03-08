using System.ComponentModel.DataAnnotations;

namespace ALTA_TEST.DTO
{
    public class HocVienCreateDto
    {
        [MaxLength(255)]
        public string TenHV { get; set; }

        [MaxLength(3)]
        public string Lop { get; set; }
    }
}
