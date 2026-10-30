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
    public class MakaleListesiDetayController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public MakaleListesiDetayController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: MakaleListesiDetay
        public async Task<IActionResult> Index()
        {
              return _context.MakaleListesiDetays != null ? 
                          View(await _context.MakaleListesiDetays.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.MakaleListesiDetays'  is null.");

            

            var makaleAd = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.makaleAdi = makaleAd.MakaleAdi;

            var yazarAd = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.yazarAdi = yazarAd.YazarAdi;

            var yayinYer = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.yayinYeri = yayinYer.DergiAdi;

            var yil = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.Yil = yil.Yil;

            var kapsamAd = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.kapsamAdi = kapsamAd.KapsamAd;

            var hakemAd = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.hakemAdi = hakemAd.HakemTurAd;

            var endeksAd = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.endeksAdi = endeksAd.Endeks;

            var makaleTuruAd = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.makaleTuruAdi = makaleTuruAd.MakaleTuruAd;
        }

        

        // GET: MakaleListesiDetay/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MakaleListesiDetays == null)
            {
                return NotFound();
            }

            var makaleListesiDetay = await _context.MakaleListesiDetays
                .FirstOrDefaultAsync(m => m.Id == id);
            if (makaleListesiDetay == null)
            {
                return NotFound();
            }

            return View(makaleListesiDetay);
        }

        // GET: MakaleListesiDetay/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MakaleListesiDetay/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,HakemTur,HakemTurAd,EndeksId,Endeks,MakaleAdi,YazarAdi,YazarSayisi,DergiAdi,YayinDili,YayinDiliAdi,Ay,Yil,Cilt,Sayi,IlkSayfa,SonSayfa,Doi,Issn,ErisimTuru,ErisimTuruAd,ErisimLinki,AlanBilgisi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd,MakaleTuruId,MakaleTuruAd")] MakaleListesiDetay makaleListesiDetay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(makaleListesiDetay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(makaleListesiDetay);
        }

        // GET: MakaleListesiDetay/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MakaleListesiDetays == null)
            {
                return NotFound();
            }

            var makaleListesiDetay = await _context.MakaleListesiDetays.FindAsync(id);
            if (makaleListesiDetay == null)
            {
                return NotFound();
            }
            return View(makaleListesiDetay);
        }

        // POST: MakaleListesiDetay/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,HakemTur,HakemTurAd,EndeksId,Endeks,MakaleAdi,YazarAdi,YazarSayisi,DergiAdi,YayinDili,YayinDiliAdi,Ay,Yil,Cilt,Sayi,IlkSayfa,SonSayfa,Doi,Issn,ErisimTuru,ErisimTuruAd,ErisimLinki,AlanBilgisi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd,MakaleTuruId,MakaleTuruAd")] MakaleListesiDetay makaleListesiDetay)
        {
            if (id != makaleListesiDetay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(makaleListesiDetay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakaleListesiDetayExists(makaleListesiDetay.Id))
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
            return View(makaleListesiDetay);
        }

        // GET: MakaleListesiDetay/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MakaleListesiDetays == null)
            {
                return NotFound();
            }

            var makaleListesiDetay = await _context.MakaleListesiDetays
                .FirstOrDefaultAsync(m => m.Id == id);
            if (makaleListesiDetay == null)
            {
                return NotFound();
            }

            return View(makaleListesiDetay);
        }

        // POST: MakaleListesiDetay/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MakaleListesiDetays == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.MakaleListesiDetays'  is null.");
            }
            var makaleListesiDetay = await _context.MakaleListesiDetays.FindAsync(id);
            if (makaleListesiDetay != null)
            {
                _context.MakaleListesiDetays.Remove(makaleListesiDetay);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MakaleListesiDetayExists(int id)
        {
          return (_context.MakaleListesiDetays?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
