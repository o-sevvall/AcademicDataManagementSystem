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
    public class PatentListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public PatentListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: PatentListesi
        public async Task<IActionResult> Index()
        {
              return _context.PatentListesis != null ? 
                          View(await _context.PatentListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.PatentListesis'  is null.");
        }

        // GET: PatentListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PatentListesis == null)
            {
                return NotFound();
            }

            var patentListesi = await _context.PatentListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patentListesi == null)
            {
                return NotFound();
            }

            return View(patentListesi);
        }

        // GET: PatentListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatentListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,PatentId,PatentNo,PatentTarihi,BasvuruSahipleri,BulusSahipleri,Kategori,KategoriId,DosyaTipi,DosyaTipiId,Kapsam,KapsamId,PatentAdi,GuncellemeTarihi,AktifPasif,AktifPasifAd,KisiSayisi,TesvPuan")] PatentListesi patentListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patentListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patentListesi);
        }

        // GET: PatentListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PatentListesis == null)
            {
                return NotFound();
            }

            var patentListesi = await _context.PatentListesis.FindAsync(id);
            if (patentListesi == null)
            {
                return NotFound();
            }
            return View(patentListesi);
        }

        // POST: PatentListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,PatentId,PatentNo,PatentTarihi,BasvuruSahipleri,BulusSahipleri,Kategori,KategoriId,DosyaTipi,DosyaTipiId,Kapsam,KapsamId,PatentAdi,GuncellemeTarihi,AktifPasif,AktifPasifAd,KisiSayisi,TesvPuan")] PatentListesi patentListesi)
        {
            if (id != patentListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patentListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatentListesiExists(patentListesi.Id))
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
            return View(patentListesi);
        }

        // GET: PatentListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PatentListesis == null)
            {
                return NotFound();
            }

            var patentListesi = await _context.PatentListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patentListesi == null)
            {
                return NotFound();
            }

            return View(patentListesi);
        }

        // POST: PatentListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PatentListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.PatentListesis'  is null.");
            }
            var patentListesi = await _context.PatentListesis.FindAsync(id);
            if (patentListesi != null)
            {
                _context.PatentListesis.Remove(patentListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatentListesiExists(int id)
        {
          return (_context.PatentListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
