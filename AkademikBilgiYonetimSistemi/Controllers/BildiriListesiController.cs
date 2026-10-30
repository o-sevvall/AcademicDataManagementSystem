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
    public class BildiriListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public BildiriListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: BildiriListesi
        public async Task<IActionResult> Index()
        {
              return _context.BildiriListesis != null ? 
                          View(await _context.BildiriListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.BildiriListesis'  is null.");

            var bildiriAd = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.bildiriAdi = bildiriAd.BildiriAdi;

            var yazarAd = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.yazarAdi = yazarAd.YazarAdi;

            var basTarih = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.baslangicTarih = basTarih.EtkinlikBasTarihi;

            var bitTarih = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.bitisTarih = bitTarih.EtkinlikBitTarihi;

            var yayinYeri = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.yer = yayinYeri.EtkinlikAdi;

            var kapsamAd = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.kapsamAdi = kapsamAd.KapsamAd;

            var bildiriTur = _context.BildiriListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.bildiriTuru = bildiriTur.BildiriTur;
        }

        // GET: BildiriListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BildiriListesis == null)
            {
                return NotFound();
            }

            var bildiriListesi = await _context.BildiriListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bildiriListesi == null)
            {
                return NotFound();
            }

            return View(bildiriListesi);
        }

        // GET: BildiriListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BildiriListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,BildiriTurId,BildiriTur,BildiriAdi,YazarAdi,YazarSayisi,Ulke,UlkeAdi,Sehir,EtkinlikAdi,YayinDili,YayinDiliAdi,EtkinlikBasTarihi,EtkinlikBitTarihi,YayinDurumu,YayinDurumuAd,BasimTarihi,Doi,PrintIsbn,BasimTuru,BasimTuruAd,ErisimLinki,AlanBilgisi,OzelSayi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd,BildirimSunumTuru,BildirimSunumTuruAd")] BildiriListesi bildiriListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bildiriListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bildiriListesi);
        }

        // GET: BildiriListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BildiriListesis == null)
            {
                return NotFound();
            }

            var bildiriListesi = await _context.BildiriListesis.FindAsync(id);
            if (bildiriListesi == null)
            {
                return NotFound();
            }
            return View(bildiriListesi);
        }

        // POST: BildiriListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,BildiriTurId,BildiriTur,BildiriAdi,YazarAdi,YazarSayisi,Ulke,UlkeAdi,Sehir,EtkinlikAdi,YayinDili,YayinDiliAdi,EtkinlikBasTarihi,EtkinlikBitTarihi,YayinDurumu,YayinDurumuAd,BasimTarihi,Doi,PrintIsbn,BasimTuru,BasimTuruAd,ErisimLinki,AlanBilgisi,OzelSayi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd,BildirimSunumTuru,BildirimSunumTuruAd")] BildiriListesi bildiriListesi)
        {
            if (id != bildiriListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bildiriListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BildiriListesiExists(bildiriListesi.Id))
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
            return View(bildiriListesi);
        }

        // GET: BildiriListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BildiriListesis == null)
            {
                return NotFound();
            }

            var bildiriListesi = await _context.BildiriListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bildiriListesi == null)
            {
                return NotFound();
            }

            return View(bildiriListesi);
        }

        // POST: BildiriListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BildiriListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.BildiriListesis'  is null.");
            }
            var bildiriListesi = await _context.BildiriListesis.FindAsync(id);
            if (bildiriListesi != null)
            {
                _context.BildiriListesis.Remove(bildiriListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BildiriListesiExists(int id)
        {
          return (_context.BildiriListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
