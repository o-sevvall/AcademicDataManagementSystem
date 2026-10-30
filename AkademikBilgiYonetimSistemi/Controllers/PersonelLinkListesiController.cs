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
    public class PersonelLinkListesiController : Controller
    {
        private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public PersonelLinkListesiController(AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _context = context;
        }

        // GET: PersonelLinkListesi
        public async Task<IActionResult> Index()
        {
              return _context.PersonelLinkListesis != null ? 
                          View(await _context.PersonelLinkListesis.ToListAsync()) :
                          Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.PersonelLinkListesis'  is null.");

            var ad = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.adi = ad.PersonelAdi;

            var soyad = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.soyadi = soyad.PersonelSoyadi;

            var unvan = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            ViewBag.kadroUnvan = unvan.KadroUnvanAdi;
        }

        // GET: PersonelLinkListesi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PersonelLinkListesis == null)
            {
                return NotFound();
            }

            var personelLinkListesi = await _context.PersonelLinkListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personelLinkListesi == null)
            {
                return NotFound();
            }

            return View(personelLinkListesi);
        }

        // GET: PersonelLinkListesi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonelLinkListesi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcKimlikNo,ArastirmaciId,KadroUnvanAdi,PersonelAdi,PersonelSoyadi,KadroYeri,YokakademikLink,PersonelResmiLink,Orcid")] PersonelLinkListesi personelLinkListesi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personelLinkListesi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personelLinkListesi);
        }

        // GET: PersonelLinkListesi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PersonelLinkListesis == null)
            {
                return NotFound();
            }

            var personelLinkListesi = await _context.PersonelLinkListesis.FindAsync(id);
            if (personelLinkListesi == null)
            {
                return NotFound();
            }
            return View(personelLinkListesi);
        }

        // POST: PersonelLinkListesi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcKimlikNo,ArastirmaciId,KadroUnvanAdi,PersonelAdi,PersonelSoyadi,KadroYeri,YokakademikLink,PersonelResmiLink,Orcid")] PersonelLinkListesi personelLinkListesi)
        {
            if (id != personelLinkListesi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personelLinkListesi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonelLinkListesiExists(personelLinkListesi.Id))
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
            return View(personelLinkListesi);
        }

        // GET: PersonelLinkListesi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PersonelLinkListesis == null)
            {
                return NotFound();
            }

            var personelLinkListesi = await _context.PersonelLinkListesis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personelLinkListesi == null)
            {
                return NotFound();
            }

            return View(personelLinkListesi);
        }

        // POST: PersonelLinkListesi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PersonelLinkListesis == null)
            {
                return Problem("Entity set 'AkademikVeriYonetimSistemiDatabaseContext.PersonelLinkListesis'  is null.");
            }
            var personelLinkListesi = await _context.PersonelLinkListesis.FindAsync(id);
            if (personelLinkListesi != null)
            {
                _context.PersonelLinkListesis.Remove(personelLinkListesi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonelLinkListesiExists(int id)
        {
          return (_context.PersonelLinkListesis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
