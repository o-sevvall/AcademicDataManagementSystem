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
    public class EditorlukListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public EditorlukListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: EditorlukListesi
        public async Task<IActionResult> Index()
        {
              return _context.EditorlukListesis != null ? 
                          View(await _context.EditorlukListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.EditorlukListesis'  is null.");
        }

        // GET: EditorlukListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EditorlukListesis == null)
            {
                return NotFound();
            }

            var editorlukListesi = await _context.EditorlukListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (editorlukListesi == null)
            {
                return NotFound();
            }

            return View(editorlukListesi);
        }

        // GET: EditorlukListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EditorlukListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,EditorlukTur,EditorlukTurAd,EditorGorev,EditorGorevAd,YayinAdi,YazarAdi,YazarSayisi,YayinEvi,YayinDili,YayinDiliAdi,EndeksId,Endeks,Yil,ErisimTuru,ErisimTuruAd,AlanBilgisi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd,TesvPuan")] EditorlukListesi editorlukListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editorlukListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editorlukListesi);
        }

        // GET: EditorlukListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EditorlukListesis == null)
            {
                return NotFound();
            }

            var editorlukListesi = await _context.EditorlukListesis.FindAsync(id);
            if (editorlukListesi == null)
            {
                return NotFound();
            }
            return View(editorlukListesi);
        }

        // POST: EditorlukListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,YayinId,KapsamId,KapsamAd,EditorlukTur,EditorlukTurAd,EditorGorev,EditorGorevAd,YayinAdi,YazarAdi,YazarSayisi,YayinEvi,YayinDili,YayinDiliAdi,EndeksId,Endeks,Yil,ErisimTuru,ErisimTuruAd,AlanBilgisi,YazarId,GuncellemeTarihi,AktifPasif,AktifPasifAd,TesvPuan")] EditorlukListesi editorlukListesi)
        {
            if (id != editorlukListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editorlukListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorlukListesiExists(editorlukListesi.Id))
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
            return View(editorlukListesi);
        }

        // GET: EditorlukListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EditorlukListesis == null)
            {
                return NotFound();
            }

            var editorlukListesi = await _context.EditorlukListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (editorlukListesi == null)
            {
                return NotFound();
            }

            return View(editorlukListesi);
        }

        // POST: EditorlukListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EditorlukListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.EditorlukListesis'  is null.");
            }
            var editorlukListesi = await _context.EditorlukListesis.FindAsync(id);
            if (editorlukListesi != null)
            {
                _context.EditorlukListesis.Remove(editorlukListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorlukListesiExists(int id)
        {
          return (_context.EditorlukListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
