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
    public class UyelikListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public UyelikListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: UyelikListesi
        public async Task<IActionResult> Index()
        {
              return _context.UyelikListesis != null ? 
                          View(await _context.UyelikListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.UyelikListesis'  is null.");

            var kurulusAd = _context.UyelikListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.kurulusAdi = kurulusAd.KurulusAdi;

            var tarih = _context.UyelikListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.baslangicTarihi = tarih.BasTar;

            var uyelikDurumu = _context.UyelikListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.uyelikDurumuAdi = uyelikDurumu.UyelikDurumuAd;
        }

        // GET: UyelikListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UyelikListesis == null)
            {
                return NotFound();
            }

            var uyelikListesi = await _context.UyelikListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uyelikListesi == null)
            {
                return NotFound();
            }

            return View(uyelikListesi);
        }

        // GET: UyelikListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UyelikListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,UyelikId,KurulusAdi,BasTar,UyelikDurumu,UyelikDurumuAd,KurulusTuru,KurulusTuruAd,GuncellemeTarihi,AktifPasif,AktifPasifAd")] UyelikListesi uyelikListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uyelikListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uyelikListesi);
        }

        // GET: UyelikListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UyelikListesis == null)
            {
                return NotFound();
            }

            var uyelikListesi = await _context.UyelikListesis.FindAsync(id);
            if (uyelikListesi == null)
            {
                return NotFound();
            }
            return View(uyelikListesi);
        }

        // POST: UyelikListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,UyelikId,KurulusAdi,BasTar,UyelikDurumu,UyelikDurumuAd,KurulusTuru,KurulusTuruAd,GuncellemeTarihi,AktifPasif,AktifPasifAd")] UyelikListesi uyelikListesi)
        {
            if (id != uyelikListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uyelikListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UyelikListesiExists(uyelikListesi.Id))
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
            return View(uyelikListesi);
        }

        // GET: UyelikListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UyelikListesis == null)
            {
                return NotFound();
            }

            var uyelikListesi = await _context.UyelikListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uyelikListesi == null)
            {
                return NotFound();
            }

            return View(uyelikListesi);
        }

        // POST: UyelikListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UyelikListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.UyelikListesis'  is null.");
            }
            var uyelikListesi = await _context.UyelikListesis.FindAsync(id);
            if (uyelikListesi != null)
            {
                _context.UyelikListesis.Remove(uyelikListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UyelikListesiExists(int id)
        {
          return (_context.UyelikListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
