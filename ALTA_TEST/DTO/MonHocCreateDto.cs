using System.ComponentModel.DataAnnotations;

namespace ALTA_TEST.DTO
{
    public class MonHocCreateDto
    {
        [MaxLength(255)]
        public string TenMH { get; set; }
    }
}
