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
    public class KitapListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public KitapListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: KitapListesi
        public async Task<IActionResult> Index()
        {
              return _context.KitapListesis != null ? 
                          View(await _context.KitapListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.KitapListesis'  is null.");
        }

        // GET: KitapListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.KitapListesis == null)
            {
                return NotFound();
            }

            var kitapListesi = await _context.KitapListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kitapListesi == null)
            {
                return NotFound();
            }

            return View(kitapListesi);
        }

        // GET: KitapListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KitapListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,KitapTurId,KitapTur,KitapAdi,KatkiDuzeyi,KatkiDuzeyiAd,YazarAdi,YazarSayisi,YayinEvi,YayinDili,YayinDiliAdi,Yil,Isbn,KacinciBasim,SaysaSayisi,BasimTuru,BasimTuruAd,AlanBilgisi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd")] KitapListesi kitapListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kitapListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kitapListesi);
        }

        // GET: KitapListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.KitapListesis == null)
            {
                return NotFound();
            }

            var kitapListesi = await _context.KitapListesis.FindAsync(id);
            if (kitapListesi == null)
            {
                return NotFound();
            }
            return View(kitapListesi);
        }

        // POST: KitapListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,KitapTurId,KitapTur,KitapAdi,KatkiDuzeyi,KatkiDuzeyiAd,YazarAdi,YazarSayisi,YayinEvi,YayinDili,YayinDiliAdi,Yil,Isbn,KacinciBasim,SaysaSayisi,BasimTuru,BasimTuruAd,AlanBilgisi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd")] KitapListesi kitapListesi)
        {
            if (id != kitapListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitapListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KitapListesiExists(kitapListesi.Id))
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
            return View(kitapListesi);
        }

        // GET: KitapListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.KitapListesis == null)
            {
                return NotFound();
            }

            var kitapListesi = await _context.KitapListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kitapListesi == null)
            {
                return NotFound();
            }

            return View(kitapListesi);
        }

        // POST: KitapListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.KitapListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.KitapListesis'  is null.");
            }
            var kitapListesi = await _context.KitapListesis.FindAsync(id);
            if (kitapListesi != null)
            {
                _context.KitapListesis.Remove(kitapListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KitapListesiExists(int id)
        {
          return (_context.KitapListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
