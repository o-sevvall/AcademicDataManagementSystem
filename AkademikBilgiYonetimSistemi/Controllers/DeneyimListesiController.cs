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
    public class DeneyimListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public DeneyimListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: DeneyimListesi
        public async Task<IActionResult> Index()
        {
              return _context.DeneyimListesis != null ? 
                          View(await _context.DeneyimListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.DeneyimListesis'  is null.");
        }

        // GET: DeneyimListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DeneyimListesis == null)
            {
                return NotFound();
            }

            var deneyimListesi = await _context.DeneyimListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deneyimListesi == null)
            {
                return NotFound();
            }

            return View(deneyimListesi);
        }

        // GET: DeneyimListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeneyimListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,DeneyimId,KurulusAdi,GorevAdi,BasTar,BitTar,IsTanimi,GuncellemeTarihi,AktifPasif,AktifPasifAd")] DeneyimListesi deneyimListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deneyimListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deneyimListesi);
        }

        // GET: DeneyimListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DeneyimListesis == null)
            {
                return NotFound();
            }

            var deneyimListesi = await _context.DeneyimListesis.FindAsync(id);
            if (deneyimListesi == null)
            {
                return NotFound();
            }
            return View(deneyimListesi);
        }

        // POST: DeneyimListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,DeneyimId,KurulusAdi,GorevAdi,BasTar,BitTar,IsTanimi,GuncellemeTarihi,AktifPasif,AktifPasifAd")] DeneyimListesi deneyimListesi)
        {
            if (id != deneyimListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deneyimListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeneyimListesiExists(deneyimListesi.Id))
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
            return View(deneyimListesi);
        }

        // GET: DeneyimListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DeneyimListesis == null)
            {
                return NotFound();
            }

            var deneyimListesi = await _context.DeneyimListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deneyimListesi == null)
            {
                return NotFound();
            }

            return View(deneyimListesi);
        }

        // POST: DeneyimListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DeneyimListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.DeneyimListesis'  is null.");
            }
            var deneyimListesi = await _context.DeneyimListesis.FindAsync(id);
            if (deneyimListesi != null)
            {
                _context.DeneyimListesis.Remove(deneyimListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeneyimListesiExists(int id)
        {
          return (_context.DeneyimListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
