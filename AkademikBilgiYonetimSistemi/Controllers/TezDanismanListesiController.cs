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
    public class TezDanismanListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public TezDanismanListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: TezDanismanListesi
        public async Task<IActionResult> Index()
        {
              return _context.TezDanismanListesis != null ? 
                          View(await _context.TezDanismanListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.TezDanismanListesis'  is null.");

          
        }

        // GET: TezDanismanListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TezDanismanListesis == null)
            {
                return NotFound();
            }

            var tezDanismanListesi = await _context.TezDanismanListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tezDanismanListesi == null)
            {
                return NotFound();
            }

            return View(tezDanismanListesi);
        }

        // GET: TezDanismanListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TezDanismanListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,Verikaynak,YerId,YerAdi,Ulke,KayitId,Yil,TurId,TurAdi,TezAdi,DurumAdi,YazarAdi,YazarSoyadi,UniversiteAd,EnstituAd,AbdAd,GuncellemeTarihi,AktifPasif,AktifPasifAd,DanismanSirasi")] TezDanismanListesi tezDanismanListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tezDanismanListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tezDanismanListesi);
        }

        // GET: TezDanismanListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TezDanismanListesis == null)
            {
                return NotFound();
            }

            var tezDanismanListesi = await _context.TezDanismanListesis.FindAsync(id);
            if (tezDanismanListesi == null)
            {
                return NotFound();
            }
            return View(tezDanismanListesi);
        }

        // POST: TezDanismanListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,Verikaynak,YerId,YerAdi,Ulke,KayitId,Yil,TurId,TurAdi,TezAdi,DurumAdi,YazarAdi,YazarSoyadi,UniversiteAd,EnstituAd,AbdAd,GuncellemeTarihi,AktifPasif,AktifPasifAd,DanismanSirasi")] TezDanismanListesi tezDanismanListesi)
        {
            if (id != tezDanismanListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tezDanismanListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TezDanismanListesiExists(tezDanismanListesi.Id))
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
            return View(tezDanismanListesi);
        }

        // GET: TezDanismanListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TezDanismanListesis == null)
            {
                return NotFound();
            }

            var tezDanismanListesi = await _context.TezDanismanListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tezDanismanListesi == null)
            {
                return NotFound();
            }

            return View(tezDanismanListesi);
        }

        // POST: TezDanismanListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TezDanismanListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.TezDanismanListesis'  is null.");
            }
            var tezDanismanListesi = await _context.TezDanismanListesis.FindAsync(id);
            if (tezDanismanListesi != null)
            {
                _context.TezDanismanListesis.Remove(tezDanismanListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TezDanismanListesiExists(int id)
        {
          return (_context.TezDanismanListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
