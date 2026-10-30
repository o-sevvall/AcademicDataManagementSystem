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
    public class OgrenimBilgisiListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public OgrenimBilgisiListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: OgrenimBilgisiListesi
        public async Task<IActionResult> Index()
        {
              return _context.OgrenimBilgisiListesis != null ? 
                          View(await _context.OgrenimBilgisiListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.OgrenimBilgisiListesis'  is null.");
        }

        // GET: OgrenimBilgisiListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OgrenimBilgisiListesis == null)
            {
                return NotFound();
            }

            var ogrenimBilgisiListesi = await _context.OgrenimBilgisiListesis
                .FirstOrDefaultAsync(m => m.TabloId == id);
            if (ogrenimBilgisiListesi == null)
            {
                return NotFound();
            }

            return View(ogrenimBilgisiListesi);
        }

        // GET: OgrenimBilgisiListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OgrenimBilgisiListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TabloId,TcKimlikNo,Id,YerId,YerAd,Bastar1,Bittar1,UlkeId,BirimYok,UlkeAd,ProgramId,ProgramAdi,TezAsamasi,TezAsamasiAd,UnivId,UnvBirimAdi,AkademikBirimId,AkademikBirimAdi,Fakultebilgisi,Bolumbilgisi,TezAdi,TezBasTar,TezBitTar,DanismanAdSoyad,AktifPasif,GuncellemeTarihi,AktifPasifAd")] OgrenimBilgisiListesi ogrenimBilgisiListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ogrenimBilgisiListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ogrenimBilgisiListesi);
        }

        // GET: OgrenimBilgisiListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OgrenimBilgisiListesis == null)
            {
                return NotFound();
            }

            var ogrenimBilgisiListesi = await _context.OgrenimBilgisiListesis.FindAsync(id);
            if (ogrenimBilgisiListesi == null)
            {
                return NotFound();
            }
            return View(ogrenimBilgisiListesi);
        }

        // POST: OgrenimBilgisiListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TabloId,TcKimlikNo,Id,YerId,YerAd,Bastar1,Bittar1,UlkeId,BirimYok,UlkeAd,ProgramId,ProgramAdi,TezAsamasi,TezAsamasiAd,UnivId,UnvBirimAdi,AkademikBirimId,AkademikBirimAdi,Fakultebilgisi,Bolumbilgisi,TezAdi,TezBasTar,TezBitTar,DanismanAdSoyad,AktifPasif,GuncellemeTarihi,AktifPasifAd")] OgrenimBilgisiListesi ogrenimBilgisiListesi)
        {
            if (id != ogrenimBilgisiListesi.TabloId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ogrenimBilgisiListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OgrenimBilgisiListesiExists(ogrenimBilgisiListesi.TabloId))
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
            return View(ogrenimBilgisiListesi);
        }

        // GET: OgrenimBilgisiListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OgrenimBilgisiListesis == null)
            {
                return NotFound();
            }

            var ogrenimBilgisiListesi = await _context.OgrenimBilgisiListesis
                .FirstOrDefaultAsync(m => m.TabloId == id);
            if (ogrenimBilgisiListesi == null)
            {
                return NotFound();
            }

            return View(ogrenimBilgisiListesi);
        }

        // POST: OgrenimBilgisiListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OgrenimBilgisiListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.OgrenimBilgisiListesis'  is null.");
            }
            var ogrenimBilgisiListesi = await _context.OgrenimBilgisiListesis.FindAsync(id);
            if (ogrenimBilgisiListesi != null)
            {
                _context.OgrenimBilgisiListesis.Remove(ogrenimBilgisiListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OgrenimBilgisiListesiExists(int id)
        {
          return (_context.OgrenimBilgisiListesis?.Any(e => e.TabloId == id)).GetValueOrDefault();
        }
    }
}
