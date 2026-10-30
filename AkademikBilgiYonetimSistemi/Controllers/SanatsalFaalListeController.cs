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
    public class SanatsalFaalListeController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public SanatsalFaalListeController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: SanatsalFaalListe
        public async Task<IActionResult> Index()
        {
              return _context.SanatsalFaalListes != null ? 
                          View(await _context.SanatsalFaalListes.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.SanatsalFaalListes'  is null.");
        }

        // GET: SanatsalFaalListe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SanatsalFaalListes == null)
            {
                return NotFound();
            }

            var sanatsalFaalListe = await _context.SanatsalFaalListes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sanatsalFaalListe == null)
            {
                return NotFound();
            }

            return View(sanatsalFaalListe);
        }

        // GET: SanatsalFaalListe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SanatsalFaalListe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,SId,AnaTur,AnaturAdi,Kapsam,KapsamAd,Tip,TipAdi,EtkinlikAdi,EtkinlikYeri,EtkinlikTuru,BasTarih,BitTarih,Duzenleyenler,Ulke,UlkeAdi,Sehir,EtkinlikDili,DilAdi,KisiSayisi,KisiSirasi,EtkinlikTuruAd,UnvanId,UnvanAd,KurumAd,TesvPuani,GuncellemeTarihi,AktifPasif,AktifPasifAd")] SanatsalFaalListe sanatsalFaalListe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanatsalFaalListe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sanatsalFaalListe);
        }

        // GET: SanatsalFaalListe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SanatsalFaalListes == null)
            {
                return NotFound();
            }

            var sanatsalFaalListe = await _context.SanatsalFaalListes.FindAsync(id);
            if (sanatsalFaalListe == null)
            {
                return NotFound();
            }
            return View(sanatsalFaalListe);
        }

        // POST: SanatsalFaalListe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,SId,AnaTur,AnaturAdi,Kapsam,KapsamAd,Tip,TipAdi,EtkinlikAdi,EtkinlikYeri,EtkinlikTuru,BasTarih,BitTarih,Duzenleyenler,Ulke,UlkeAdi,Sehir,EtkinlikDili,DilAdi,KisiSayisi,KisiSirasi,EtkinlikTuruAd,UnvanId,UnvanAd,KurumAd,TesvPuani,GuncellemeTarihi,AktifPasif,AktifPasifAd")] SanatsalFaalListe sanatsalFaalListe)
        {
            if (id != sanatsalFaalListe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanatsalFaalListe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanatsalFaalListeExists(sanatsalFaalListe.Id))
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
            return View(sanatsalFaalListe);
        }

        // GET: SanatsalFaalListe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SanatsalFaalListes == null)
            {
                return NotFound();
            }

            var sanatsalFaalListe = await _context.SanatsalFaalListes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sanatsalFaalListe == null)
            {
                return NotFound();
            }

            return View(sanatsalFaalListe);
        }

        // POST: SanatsalFaalListe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SanatsalFaalListes == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.SanatsalFaalListes'  is null.");
            }
            var sanatsalFaalListe = await _context.SanatsalFaalListes.FindAsync(id);
            if (sanatsalFaalListe != null)
            {
                _context.SanatsalFaalListes.Remove(sanatsalFaalListe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanatsalFaalListeExists(int id)
        {
          return (_context.SanatsalFaalListes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
