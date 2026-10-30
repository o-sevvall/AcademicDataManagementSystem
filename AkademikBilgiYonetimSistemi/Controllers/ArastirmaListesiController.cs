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
    public class ArastirmaListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public ArastirmaListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: ArastirmaListesi
        public async Task<IActionResult> Index()
        {
              return _context.ArastirmaListesis != null ? 
                          View(await _context.ArastirmaListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.ArastirmaListesis'  is null.");
        }

        // GET: ArastirmaListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArastirmaListesis == null)
            {
                return NotFound();
            }

            var arastirmaListesi = await _context.ArastirmaListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arastirmaListesi == null)
            {
                return NotFound();
            }

            return View(arastirmaListesi);
        }

        // GET: ArastirmaListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArastirmaListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,SId,TurId,TurAdi,Adi,Icerik,Yer,Kapsam,KapsamAd,Sure,Bastar,Bittar,UnvanId,UnvanAd,KurumAd,KurumId,KisiSayisi,UlkeSehir,GuncellemeTarihi,AktifPasif,AktifPasifAd")] ArastirmaListesi arastirmaListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arastirmaListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arastirmaListesi);
        }

        // GET: ArastirmaListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArastirmaListesis == null)
            {
                return NotFound();
            }

            var arastirmaListesi = await _context.ArastirmaListesis.FindAsync(id);
            if (arastirmaListesi == null)
            {
                return NotFound();
            }
            return View(arastirmaListesi);
        }

        // POST: ArastirmaListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,SId,TurId,TurAdi,Adi,Icerik,Yer,Kapsam,KapsamAd,Sure,Bastar,Bittar,UnvanId,UnvanAd,KurumAd,KurumId,KisiSayisi,UlkeSehir,GuncellemeTarihi,AktifPasif,AktifPasifAd")] ArastirmaListesi arastirmaListesi)
        {
            if (id != arastirmaListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arastirmaListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArastirmaListesiExists(arastirmaListesi.Id))
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
            return View(arastirmaListesi);
        }

        // GET: ArastirmaListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArastirmaListesis == null)
            {
                return NotFound();
            }

            var arastirmaListesi = await _context.ArastirmaListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arastirmaListesi == null)
            {
                return NotFound();
            }

            return View(arastirmaListesi);
        }

        // POST: ArastirmaListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArastirmaListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.ArastirmaListesis'  is null.");
            }
            var arastirmaListesi = await _context.ArastirmaListesis.FindAsync(id);
            if (arastirmaListesi != null)
            {
                _context.ArastirmaListesis.Remove(arastirmaListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArastirmaListesiExists(int id)
        {
          return (_context.ArastirmaListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
