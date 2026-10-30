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
    public class OdulListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public OdulListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: OdulListesi
        public async Task<IActionResult> Index()
        {
              return _context.OdulListesis != null ? 
                          View(await _context.OdulListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.OdulListesis'  is null.");
        }

        // GET: OdulListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OdulListesis == null)
            {
                return NotFound();
            }

            var odulListesi = await _context.OdulListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odulListesi == null)
            {
                return NotFound();
            }

            return View(odulListesi);
        }

        // GET: OdulListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OdulListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,OdulId,OdulAdi,OdulTarih,FaalDetayId,FaalDetayAdi,OdulTurId,OdulTuru,KurulusAdi,PUnvanId,PUnvanAd,PKurumId,PKurumAd,IsyeriTuruId,IsyeriTuruAdi,UlkeId,UlkeAd,OdulAciklama,KisiSayisi,OdulKisiSira,TesvPuan,GuncellemeTarihi")] OdulListesi odulListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odulListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(odulListesi);
        }

        // GET: OdulListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OdulListesis == null)
            {
                return NotFound();
            }

            var odulListesi = await _context.OdulListesis.FindAsync(id);
            if (odulListesi == null)
            {
                return NotFound();
            }
            return View(odulListesi);
        }

        // POST: OdulListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,OdulId,OdulAdi,OdulTarih,FaalDetayId,FaalDetayAdi,OdulTurId,OdulTuru,KurulusAdi,PUnvanId,PUnvanAd,PKurumId,PKurumAd,IsyeriTuruId,IsyeriTuruAdi,UlkeId,UlkeAd,OdulAciklama,KisiSayisi,OdulKisiSira,TesvPuan,GuncellemeTarihi")] OdulListesi odulListesi)
        {
            if (id != odulListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odulListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OdulListesiExists(odulListesi.Id))
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
            return View(odulListesi);
        }

        // GET: OdulListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OdulListesis == null)
            {
                return NotFound();
            }

            var odulListesi = await _context.OdulListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odulListesi == null)
            {
                return NotFound();
            }

            return View(odulListesi);
        }

        // POST: OdulListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OdulListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.OdulListesis'  is null.");
            }
            var odulListesi = await _context.OdulListesis.FindAsync(id);
            if (odulListesi != null)
            {
                _context.OdulListesis.Remove(odulListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OdulListesiExists(int id)
        {
          return (_context.OdulListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
