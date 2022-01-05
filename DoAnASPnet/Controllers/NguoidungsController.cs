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

        public iactionresult search(int? manguoidung, string hoten, string email, string matkhau, string dienthoai, int phanquyen, string diachi)
        {
            list<nguoidung> acc = _context.nguoidung.include(acc => acc.phanquyen).tolist();
            selectlist phan_quyen = new selectlist(_context.phanquyen, "id", "tenquyen");
            viewbag.phanquyen = phan_quyen;
            if (manguoidung < 0)
                acc = acc.where(acc => acc.manguoidung == manguoidung).tolist();
            if (hoten != null)
                acc = acc.where(acc => acc.hoten.contains(hoten)).tolist();
            if (email != null)
                acc = acc.where(acc => acc.email.contains(email)).tolist();
            if (matkhau != null)
                acc = acc.where(acc => acc.matkhau.contains(matkhau)).tolist();
            if (dienthoai != null)
                acc = acc.where(acc => acc.dienthoai.contains(dienthoai)).tolist();
            if (phanquyen < 0)
                acc = acc.where(acc => acc.phanquyenid == phanquyen).tolist();
            if (diachi != null)
                acc = acc.where(acc => acc.diachi.contains(diachi)).tolist();
            return view(acc);
        }

    }
}
