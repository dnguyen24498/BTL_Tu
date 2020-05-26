using System.Collections.Generic;
using System.Linq;
using BTL_Tu.Models;
using Microsoft.AspNetCore.Mvc;
namespace BTL_Tu.Controllers
{
    public class PhuHuynhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhuHuynhController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ViewResult TrangChu()
        {
            List<PhuHuynh> danhSachPhuHuynh = _context.PhuHuynhs.ToList();
            return View(danhSachPhuHuynh);
        }

        [HttpGet]
        public ViewResult TaoMoi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TaoMoi(PhuHuynh yeuCauTaoMoi)
        {
            if (ModelState.IsValid)
            {
                _context.PhuHuynhs.Add(yeuCauTaoMoi);
                _context.SaveChanges();
                return View("TrangChu",_context.PhuHuynhs.ToList());   
            }
            return View("TrangChu",_context.PhuHuynhs.ToList());  
        }

        [HttpPost]
        public IActionResult Xoa(int MaPhuHuynh)
        {
            PhuHuynh phuHuynh = _context.PhuHuynhs.Find(MaPhuHuynh);
            if (phuHuynh != null)
            {
                _context.PhuHuynhs.Remove(phuHuynh);
                _context.SaveChanges();
            }
            return View("TrangChu",_context.PhuHuynhs.ToList());   
        }

        [HttpGet]
        public ViewResult Sua(int MaPhuHuynh)
        {
            PhuHuynh phNew = _context.PhuHuynhs.Find(MaPhuHuynh);
            return View(phNew);
        }

        [HttpPost]
        public IActionResult Sua(PhuHuynh ph)
        {
            PhuHuynh phNew = _context.PhuHuynhs.Find(ph.MaSoPhuHuynh);
            if (phNew != null)
            {
                phNew.Ten = ph.Ten;
                phNew.DiaChi = ph.DiaChi;
                phNew.QuanHe = ph.QuanHe;
                phNew.SoDienThoai = ph.SoDienThoai;
                _context.SaveChanges();
            }
            return View("TrangChu",_context.PhuHuynhs.ToList()); 
        }
    }
}