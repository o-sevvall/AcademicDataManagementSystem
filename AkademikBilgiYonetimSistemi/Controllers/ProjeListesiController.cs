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
    public class ProjeListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public ProjeListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: ProjeListesi
        public async Task<IActionResult> Index()
        {
              return _context.ProjeListesis != null ? 
                          View(await _context.ProjeListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.ProjeListesis'  is null.");
            
            //Veritabanından projeler menüsü için gerekli olan bilgilerin çekilmesi

            var projeKonu = _context.ProjeListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.projeKonusu = projeKonu.ProjeKonusu;

            var projeTuru = _context.ProjeListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.projeTuruAdi = projeTuru.ProjeTuruAd;

            var projeDurumu = _context.ProjeListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.projeDurumuAdi = projeDurumu.ProjeDurumuAd;

            var tarih = _context.ProjeListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.baslangicTarihi = tarih.BasTar;
            var butce = _context.ProjeListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.butceDurumu = butce.Butce;

            var paraBirimi = _context.ProjeListesis.Where(x => x.TcKimlikNo == "11111111").FirstOrDefault();
            ViewBag.paraBirimiAdi = paraBirimi.ParaBirimiAd;
        }

        // GET: ProjeListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjeListesis == null)
            {
                return NotFound();
            }

            var projeListesi = await _context.ProjeListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projeListesi == null)
            {
                return NotFound();
            }

            return View(projeListesi);
        }

        // GET: ProjeListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjeListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,ProjeId,ProjeAd,ProjeKonusu,ProjeDurumuId,ProjeDurumuAd,BasTar,Butce,ProjeKonumuId,ProjeKonumuAd,ProjeTuruId,ProjeTuruAd,ParaBirimiId,ParaBirimiAd,GuncellemeTarihi,AktifPasif,AktifPasifAd,Kapsam,KapsamAd,ProjeFormId")] ProjeListesi projeListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projeListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projeListesi);
        }

        // GET: ProjeListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjeListesis == null)
            {
                return NotFound();
            }

            var projeListesi = await _context.ProjeListesis.FindAsync(id);
            if (projeListesi == null)
            {
                return NotFound();
            }
            return View(projeListesi);
        }

        // POST: ProjeListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,ProjeId,ProjeAd,ProjeKonusu,ProjeDurumuId,ProjeDurumuAd,BasTar,Butce,ProjeKonumuId,ProjeKonumuAd,ProjeTuruId,ProjeTuruAd,ParaBirimiId,ParaBirimiAd,GuncellemeTarihi,AktifPasif,AktifPasifAd,Kapsam,KapsamAd,ProjeFormId")] ProjeListesi projeListesi)
        {
            if (id != projeListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projeListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjeListesiExists(projeListesi.Id))
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
            return View(projeListesi);
        }

        // GET: ProjeListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjeListesis == null)
            {
                return NotFound();
            }

            var projeListesi = await _context.ProjeListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projeListesi == null)
            {
                return NotFound();
            }

            return View(projeListesi);
        }

        // POST: ProjeListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjeListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.ProjeListesis'  is null.");
            }
            var projeListesi = await _context.ProjeListesis.FindAsync(id);
            if (projeListesi != null)
            {
                _context.ProjeListesis.Remove(projeListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjeListesiExists(int id)
        {
          return (_context.ProjeListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
