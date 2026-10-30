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
    public class IdariGorevListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public IdariGorevListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: IdariGorevListesi
        public async Task<IActionResult> Index()
        {
              return _context.IdariGorevListesis != null ? 
                          View(await _context.IdariGorevListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.IdariGorevListesis'  is null.");
        }

        // GET: IdariGorevListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IdariGorevListesis == null)
            {
                return NotFound();
            }

            var idariGorevListesi = await _context.IdariGorevListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (idariGorevListesi == null)
            {
                return NotFound();
            }

            return View(idariGorevListesi);
        }

        // GET: IdariGorevListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IdariGorevListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,IdgorId,YerId,YerAdi,UlkeId,UlkeAdi,GorevId,GorevAdi,UnvBirimId,UnvBirimAdi,BasTar,GuncellemeTarihi,AktifPasif,AktifPasifAd")] IdariGorevListesi idariGorevListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(idariGorevListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(idariGorevListesi);
        }

        // GET: IdariGorevListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IdariGorevListesis == null)
            {
                return NotFound();
            }

            var idariGorevListesi = await _context.IdariGorevListesis.FindAsync(id);
            if (idariGorevListesi == null)
            {
                return NotFound();
            }
            return View(idariGorevListesi);
        }

        // POST: IdariGorevListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,IdgorId,YerId,YerAdi,UlkeId,UlkeAdi,GorevId,GorevAdi,UnvBirimId,UnvBirimAdi,BasTar,GuncellemeTarihi,AktifPasif,AktifPasifAd")] IdariGorevListesi idariGorevListesi)
        {
            if (id != idariGorevListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(idariGorevListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdariGorevListesiExists(idariGorevListesi.Id))
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
            return View(idariGorevListesi);
        }

        // GET: IdariGorevListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IdariGorevListesis == null)
            {
                return NotFound();
            }

            var idariGorevListesi = await _context.IdariGorevListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (idariGorevListesi == null)
            {
                return NotFound();
            }

            return View(idariGorevListesi);
        }

        // POST: IdariGorevListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IdariGorevListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.IdariGorevListesis'  is null.");
            }
            var idariGorevListesi = await _context.IdariGorevListesis.FindAsync(id);
            if (idariGorevListesi != null)
            {
                _context.IdariGorevListesis.Remove(idariGorevListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdariGorevListesiExists(int id)
        {
          return (_context.IdariGorevListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
