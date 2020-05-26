using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
        
        // GET
        public IActionResult TrangChu()
        {
            List<PhuHuynh> danhSachPhuHuynh = _context.PhuHuynhs.ToList();
            return View(danhSachPhuHuynh);
        }
    }
}