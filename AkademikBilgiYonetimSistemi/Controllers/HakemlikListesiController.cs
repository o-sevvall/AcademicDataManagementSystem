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
    public class HakemlikListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public HakemlikListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: HakemlikListesi
        public async Task<IActionResult> Index()
        {
              return _context.HakemlikListesis != null ? 
                          View(await _context.HakemlikListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.HakemlikListesis'  is null.");
        }

        // GET: HakemlikListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HakemlikListesis == null)
            {
                return NotFound();
            }

            var hakemlikListesi = await _context.HakemlikListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hakemlikListesi == null)
            {
                return NotFound();
            }

            return View(hakemlikListesi);
        }

        // GET: HakemlikListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HakemlikListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,HakemlikTuru,HakemlikTuruAd,YayinYeri,HakemlikSayisi,YayinDili,YayinDiliAdi,Ulke,UlkeAdi,EndeksId,Endeks,AlanBilgisi,GuncellemeTarihi,AktifPasif,AktifPasifAd,Yil,TesvPuan")] HakemlikListesi hakemlikListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hakemlikListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hakemlikListesi);
        }

        // GET: HakemlikListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HakemlikListesis == null)
            {
                return NotFound();
            }

            var hakemlikListesi = await _context.HakemlikListesis.FindAsync(id);
            if (hakemlikListesi == null)
            {
                return NotFound();
            }
            return View(hakemlikListesi);
        }

        // POST: HakemlikListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,HakemlikTuru,HakemlikTuruAd,YayinYeri,HakemlikSayisi,YayinDili,YayinDiliAdi,Ulke,UlkeAdi,EndeksId,Endeks,AlanBilgisi,GuncellemeTarihi,AktifPasif,AktifPasifAd,Yil,TesvPuan")] HakemlikListesi hakemlikListesi)
        {
            if (id != hakemlikListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hakemlikListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HakemlikListesiExists(hakemlikListesi.Id))
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
            return View(hakemlikListesi);
        }

        // GET: HakemlikListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HakemlikListesis == null)
            {
                return NotFound();
            }

            var hakemlikListesi = await _context.HakemlikListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hakemlikListesi == null)
            {
                return NotFound();
            }

            return View(hakemlikListesi);
        }

        // POST: HakemlikListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HakemlikListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.HakemlikListesis'  is null.");
            }
            var hakemlikListesi = await _context.HakemlikListesis.FindAsync(id);
            if (hakemlikListesi != null)
            {
                _context.HakemlikListesis.Remove(hakemlikListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HakemlikListesiExists(int id)
        {
          return (_context.HakemlikListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
