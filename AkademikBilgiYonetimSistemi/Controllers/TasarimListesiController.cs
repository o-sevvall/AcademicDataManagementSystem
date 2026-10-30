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
    public class TasarimListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public TasarimListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: TasarimListesi
        public async Task<IActionResult> Index()
        {
              return _context.TasarimListesis != null ? 
                          View(await _context.TasarimListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.TasarimListesis'  is null.");
        }

        // GET: TasarimListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TasarimListesis == null)
            {
                return NotFound();
            }

            var tasarimListesi = await _context.TasarimListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tasarimListesi == null)
            {
                return NotFound();
            }

            return View(tasarimListesi);
        }

        // GET: TasarimListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TasarimListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,PTasarimId,TasarimSahipleri,TasarimTuru,TasarimTuruAdi,TasarimTuruDetay,TasarimTuruDetayAd,Kapsam,KapsamAd,TasarimAdi,TasarimOzeti,BasTarihi,BitisTarihi,UnvanId,UnvanAd,KurumId,KurumAd,KisiSayisi,GuncellemeTarihi,AktifPasif,AktifPasifAd")] TasarimListesi tasarimListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tasarimListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasarimListesi);
        }

        // GET: TasarimListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TasarimListesis == null)
            {
                return NotFound();
            }

            var tasarimListesi = await _context.TasarimListesis.FindAsync(id);
            if (tasarimListesi == null)
            {
                return NotFound();
            }
            return View(tasarimListesi);
        }

        // POST: TasarimListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,PTasarimId,TasarimSahipleri,TasarimTuru,TasarimTuruAdi,TasarimTuruDetay,TasarimTuruDetayAd,Kapsam,KapsamAd,TasarimAdi,TasarimOzeti,BasTarihi,BitisTarihi,UnvanId,UnvanAd,KurumId,KurumAd,KisiSayisi,GuncellemeTarihi,AktifPasif,AktifPasifAd")] TasarimListesi tasarimListesi)
        {
            if (id != tasarimListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tasarimListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TasarimListesiExists(tasarimListesi.Id))
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
            return View(tasarimListesi);
        }

        // GET: TasarimListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TasarimListesis == null)
            {
                return NotFound();
            }

            var tasarimListesi = await _context.TasarimListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tasarimListesi == null)
            {
                return NotFound();
            }

            return View(tasarimListesi);
        }

        // POST: TasarimListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TasarimListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.TasarimListesis'  is null.");
            }
            var tasarimListesi = await _context.TasarimListesis.FindAsync(id);
            if (tasarimListesi != null)
            {
                _context.TasarimListesis.Remove(tasarimListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TasarimListesiExists(int id)
        {
          return (_context.TasarimListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
