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
    public class DersListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public DersListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: DersListesi
        public async Task<IActionResult> Index()
        {
              return _context.DersListesis != null ? 
                          View(await _context.DersListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.DersListesis'  is null.");

            var dersAd = _context.DersListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.dersAdi = dersAd.DersAdi;

            var ogrenimTur = _context.DersListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.ogrenımTuruAd = ogrenimTur.OgrenimAdi;

            var tarih = _context.DersListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.akademikTarih = tarih.AkademikYil;

            var dilAd = _context.DersListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.dil = dilAd.DilAdi;

            var dersSaat = _context.DersListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.dersSaati = dersSaat.DersSaati;
        }

        // GET: DersListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DersListesis == null)
            {
                return NotFound();
            }

            var dersListesi = await _context.DersListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dersListesi == null)
            {
                return NotFound();
            }

            return View(dersListesi);
        }

        // GET: DersListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DersListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,DersId,DersAdi,OgrenimId,OgrenimAdi,AkademikYil,DilId,DilAdi,DersSaati,GuncellemeTarihi,EklemeTarihi,AktifPasif,AktifPasifAd")] DersListesi dersListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dersListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dersListesi);
        }

        // GET: DersListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DersListesis == null)
            {
                return NotFound();
            }

            var dersListesi = await _context.DersListesis.FindAsync(id);
            if (dersListesi == null)
            {
                return NotFound();
            }
            return View(dersListesi);
        }

        // POST: DersListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,DersId,DersAdi,OgrenimId,OgrenimAdi,AkademikYil,DilId,DilAdi,DersSaati,GuncellemeTarihi,EklemeTarihi,AktifPasif,AktifPasifAd")] DersListesi dersListesi)
        {
            if (id != dersListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dersListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DersListesiExists(dersListesi.Id))
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
            return View(dersListesi);
        }

        // GET: DersListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DersListesis == null)
            {
                return NotFound();
            }

            var dersListesi = await _context.DersListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dersListesi == null)
            {
                return NotFound();
            }

            return View(dersListesi);
        }

        // POST: DersListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DersListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.DersListesis'  is null.");
            }
            var dersListesi = await _context.DersListesis.FindAsync(id);
            if (dersListesi != null)
            {
                _context.DersListesis.Remove(dersListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DersListesiExists(int id)
        {
          return (_context.DersListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
