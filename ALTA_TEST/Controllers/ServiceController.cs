using ALTA_TEST.DTO;
using ALTA_TEST.Models;
using BAITAP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ALTA_TEST.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly AppDBContext _context;

        public ServiceController(AppDBContext context)
        {
            _context = context;
        }

        [HttpPost("create/hocvien")]
        public IActionResult CreateHocVien([FromForm] HocVienCreateDto model)
        {
            try
            {
                var hocVien = new HocVien
                {
                    TenHV = model.TenHV,
                    Lop = model.Lop
                };
                _context.HocVien.Add(hocVien);
                _context.SaveChanges();
                return Ok(hocVien);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("create/monhoc")]
        public IActionResult CreateMonHoc([FromForm] MonHocCreateDto model)
        {
            try
            {
                var monHoc = new MonHoc
                {
                    TenMH = model.TenMH
                };
                _context.MonHoc.Add(monHoc);
                _context.SaveChanges();
                return Ok(monHoc);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost("create/bangdiem")]
        public IActionResult CreateBangDiem([FromForm] BangDiemCreateDto model)
        {
            try
            {
                var bangDiem = new BangDiem
                {
                    MaHV = model.MaHV,
                    MaMH = model.MaMH,
                    Diem = model.Diem,
                    HeSo = model.HeSo,
                    NamHoc = model.NamHoc

                };
                _context.BangDiem.Add(bangDiem);
                _context.SaveChanges();
                return Ok(bangDiem);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
