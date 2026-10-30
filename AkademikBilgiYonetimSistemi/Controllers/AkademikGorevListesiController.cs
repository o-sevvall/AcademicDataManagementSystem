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
    public class AkademikGorevListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public AkademikGorevListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: AkademikGorevListesi
        public async Task<IActionResult> Index()
        {
              return _context.AkademikGorevListesis != null ? 
                          View(await _context.AkademikGorevListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.AkademikGorevListesis'  is null.");

            var tarih = _context.AkademikGorevListesis.Where(x => x.TcKimlikNo == "111111111").FirstOrDefault();
            ViewBag.baslangicTarih = tarih.Bastar1;

            var unvan = _context.AkademikGorevListesis.Where(x => x.TcKimlikNo == "111111111").FirstOrDefault();
            ViewBag.kadroUnvan = unvan.KadroUnvanAdi;

            var univAd = _context.AkademikGorevListesis.Where(x => x.TcKimlikNo == "111111111").FirstOrDefault();
            ViewBag.univAdi = univAd.UnivBirimAdi;

            var fakulte = _context.AkademikGorevListesis.Where(x => x.TcKimlikNo == "111111111").FirstOrDefault();
            ViewBag.fakulteAdi = fakulte.Fakultebilgisi;

            var bolum = _context.AkademikGorevListesis.Where(x => x.TcKimlikNo == "111111111").FirstOrDefault();
            ViewBag.bolumAdi = bolum.Bolumbilgisi;
        }

        // GET: AkademikGorevListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AkademikGorevListesis == null)
            {
                return NotFound();
            }

            var akademikGorevListesi = await _context.AkademikGorevListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (akademikGorevListesi == null)
            {
                return NotFound();
            }

            return View(akademikGorevListesi);
        }

        // GET: AkademikGorevListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AkademikGorevListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,GorevId,YerId,YerAd,Bastar1,UlkeId,BilimalanAdi,UzmanlikAlani,UzmanlikAlaniAdi,UlkeAd,UnivId,UnivBirimAdi,BirimId,Fakultebilgisi,Bolumbilgisi,Alanbilgisi,KadroUnvanId,KadroUnvanAdi,AkademikDurum,AkademikDurumAdi,AkademikBirimAdi,GuncellemeTarihi,AktifPasif,AktifPasifAd")] AkademikGorevListesi akademikGorevListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(akademikGorevListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(akademikGorevListesi);
        }

        // GET: AkademikGorevListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AkademikGorevListesis == null)
            {
                return NotFound();
            }

            var akademikGorevListesi = await _context.AkademikGorevListesis.FindAsync(id);
            if (akademikGorevListesi == null)
            {
                return NotFound();
            }
            return View(akademikGorevListesi);
        }

        // POST: AkademikGorevListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,GorevId,YerId,YerAd,Bastar1,UlkeId,BilimalanAdi,UzmanlikAlani,UzmanlikAlaniAdi,UlkeAd,UnivId,UnivBirimAdi,BirimId,Fakultebilgisi,Bolumbilgisi,Alanbilgisi,KadroUnvanId,KadroUnvanAdi,AkademikDurum,AkademikDurumAdi,AkademikBirimAdi,GuncellemeTarihi,AktifPasif,AktifPasifAd")] AkademikGorevListesi akademikGorevListesi)
        {
            if (id != akademikGorevListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(akademikGorevListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AkademikGorevListesiExists(akademikGorevListesi.Id))
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
            return View(akademikGorevListesi);
        }

        // GET: AkademikGorevListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AkademikGorevListesis == null)
            {
                return NotFound();
            }

            var akademikGorevListesi = await _context.AkademikGorevListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (akademikGorevListesi == null)
            {
                return NotFound();
            }

            return View(akademikGorevListesi);
        }

        // POST: AkademikGorevListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AkademikGorevListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.AkademikGorevListesis'  is null.");
            }
            var akademikGorevListesi = await _context.AkademikGorevListesis.FindAsync(id);
            if (akademikGorevListesi != null)
            {
                _context.AkademikGorevListesis.Remove(akademikGorevListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AkademikGorevListesiExists(int id)
        {
          return (_context.AkademikGorevListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
