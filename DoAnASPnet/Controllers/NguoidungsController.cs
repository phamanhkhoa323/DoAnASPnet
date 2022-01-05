using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASPnet.Data;
using DoAnASPnet.Models;

namespace DoAnASPnet.Controllers
{
    public class NguoidungsController : Controller
    {
        private readonly DoAnASPnetContext _context;

        public NguoidungsController(DoAnASPnetContext context)
        {
            _context = context;
        }

        // GET: Nguoidungs
        public async Task<IActionResult> Index()
        {
            var doAnASPnetContext = _context.Nguoidung.Include(n => n.Phanquyen);
            return View(await doAnASPnetContext.ToListAsync());
        }

        // GET: Nguoidungs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.Nguoidung
                .Include(n => n.Phanquyen)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // GET: Nguoidungs/Create
        public IActionResult Create()
        {
            ViewData["PhanquyenId"] = new SelectList(_context.Set<Phanquyen>(), "Id", "Tenquyen");
            return View();
        }

        // POST: Nguoidungs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaNguoiDung,Hoten,Email,Matkhau,Dienthoai,PhanquyenId,Diachi")] Nguoidung nguoidung)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nguoidung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhanquyenId"] = new SelectList(_context.Set<Phanquyen>(), "Id", "Tenquyen", nguoidung.PhanquyenId);
            return View(nguoidung);
        }

        // GET: Nguoidungs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.Nguoidung.FindAsync(id);
            if (nguoidung == null)
            {
                return NotFound();
            }
            ViewData["PhanquyenId"] = new SelectList(_context.Set<Phanquyen>(), "Id", "Tenquyen", nguoidung.PhanquyenId);
            return View(nguoidung);
        }

        // POST: Nguoidungs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaNguoiDung,Hoten,Email,Matkhau,Dienthoai,PhanquyenId,Diachi")] Nguoidung nguoidung)
        {
            if (id != nguoidung.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nguoidung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoidungExists(nguoidung.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PhanquyenId"] = new SelectList(_context.Set<Phanquyen>(), "Id", "Tenquyen", nguoidung.PhanquyenId);
            return View(nguoidung);
        }

        // GET: Nguoidungs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoidung = await _context.Nguoidung
                .Include(n => n.Phanquyen)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nguoidung == null)
            {
                return NotFound();
            }

            return View(nguoidung);
        }

        // POST: Nguoidungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoidung = await _context.Nguoidung.FindAsync(id);
            _context.Nguoidung.Remove(nguoidung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoidungExists(int id)
        {
            return _context.Nguoidung.Any(e => e.Id == id);
        }

        public IActionResult Search( int? manguoidung, string hoten, string email, string matkhau, string dienthoai, int phanquyen,  string diachi)
        {
            List<Nguoidung> acc = _context.Nguoidung.Include(acc=>acc.Phanquyen).ToList();
            SelectList phan_quyen = new SelectList(_context.Phanquyen, "Id", "Tenquyen");
            ViewBag.Phanquyen = phan_quyen;
            if (manguoidung < 0)
                acc = acc.Where(acc => acc.MaNguoiDung==manguoidung).ToList();
            if (hoten != null)
                acc = acc.Where(acc => acc.Hoten.Contains(hoten)).ToList();
            if (email != null)
                acc = acc.Where(acc => acc.Email.Contains(email)).ToList();
            if (matkhau != null)
                acc = acc.Where(acc => acc.Matkhau.Contains(matkhau)).ToList();
            if (dienthoai != null)
                acc = acc.Where(acc => acc.Dienthoai.Contains(dienthoai)).ToList();
            if (phanquyen < 0)
                acc = acc.Where(acc => acc.PhanquyenId==phanquyen).ToList();
            if (diachi != null)
                acc = acc.Where(acc => acc.Diachi.Contains(diachi)).ToList();
            return View(acc);
        }

    }
}
