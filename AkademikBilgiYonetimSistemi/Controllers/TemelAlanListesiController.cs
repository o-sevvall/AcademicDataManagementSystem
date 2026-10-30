using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AkademikBilgiYonetimSistemi.Models;

namespace AkademikBilgiYonetimSistemi.Controllers
{
    public class TemelAlanListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public TemelAlanListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: TemelAlanListesi
        public async Task<IActionResult> Index()
        {
              return _context.TemelAlanListesis != null ? 
                          View(await _context.TemelAlanListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.TemelAlanListesis'  is null.");
        }

        // GET: TemelAlanListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TemelAlanListesis == null)
            {
                return NotFound();
            }

            var temelAlanListesi = await _context.TemelAlanListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (temelAlanListesi == null)
            {
                return NotFound();
            }

            return View(temelAlanListesi);
        }

        // GET: TemelAlanListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TemelAlanListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,TUakId,TemelAlanId,BilimAlanId,Anahtarkelime1Id,Anahtarkelime2Id,Anahtarkelime3Id,TemelAlanAd,BilimAlanAd,Anahtarkelime1Ad,Anahterkelime2Ad,Anahtarkelime3Ad,GuncellemeTarihi,AktifPasif,AktifPasifAd")] TemelAlanListesi temelAlanListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(temelAlanListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(temelAlanListesi);
        }

        // GET: TemelAlanListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TemelAlanListesis == null)
            {
                return NotFound();
            }

            var temelAlanListesi = await _context.TemelAlanListesis.FindAsync(id);
            if (temelAlanListesi == null)
            {
                return NotFound();
            }
            return View(temelAlanListesi);
        }

        // POST: TemelAlanListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,TUakId,TemelAlanId,BilimAlanId,Anahtarkelime1Id,Anahtarkelime2Id,Anahtarkelime3Id,TemelAlanAd,BilimAlanAd,Anahtarkelime1Ad,Anahterkelime2Ad,Anahtarkelime3Ad,GuncellemeTarihi,AktifPasif,AktifPasifAd")] TemelAlanListesi temelAlanListesi)
        {
            if (id != temelAlanListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(temelAlanListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemelAlanListesiExists(temelAlanListesi.Id))
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
            return View(temelAlanListesi);
        }

        // GET: TemelAlanListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TemelAlanListesis == null)
            {
                return NotFound();
            }

            var temelAlanListesi = await _context.TemelAlanListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (temelAlanListesi == null)
            {
                return NotFound();
            }

            return View(temelAlanListesi);
        }

        // POST: TemelAlanListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TemelAlanListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.TemelAlanListesis'  is null.");
            }
            var temelAlanListesi = await _context.TemelAlanListesis.FindAsync(id);
            if (temelAlanListesi != null)
            {
                _context.TemelAlanListesis.Remove(temelAlanListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemelAlanListesiExists(int id)
        {
          return (_context.TemelAlanListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
