using AkademikBilgiYonetimSistemi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AkademikBilgiYonetimSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; private readonly AkademikVeriYonetimSistemiDatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, AkademikVeriYonetimSistemiDatabaseContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
            ViewBag.makaleSayisi = _context.MakaleListesiDetays.Where(x => x.TcKimlikNo == "1111").Count();
            ViewBag.bildiriSayisi = _context.BildiriListesis.Where(x => x.TcKimlikNo == "1111").Count();
            ViewBag.projeSayisi = _context.ProjeListesis.Where(x => x.TcKimlikNo == "1111").Count();
            ViewBag.danismanlikSayisi = _context.TezDanismanListesis.Where(x => x.TcKimlikNo == "1111").Count();
            ViewBag.patentSayisi = _context.PatentListesis.Where(x => x.TcKimlikNo == "1111").Count();
            ViewData["akademikgorev"] = _context.AkademikGorevListesis.Where(x => x.TcKimlikNo == "1111").ToList();
            ViewData["ogrenimBilgisi"] = _context.OgrenimBilgisiListesis.Where(x => x.TcKimlikNo == "1111").ToList();

            var personelAd = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("ad", personelAd.PersonelAdi != null? personelAd.PersonelAdi : string.Empty);
            ViewBag.ad = personelAd.PersonelAdi;

            var personelSoyad = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("soyad", personelSoyad.PersonelSoyadi != null? personelSoyad.PersonelSoyadi : string.Empty);
            ViewBag.soyad = personelSoyad.PersonelSoyadi;

            var unvan = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("unvan", unvan.KadroUnvanAdi != null? unvan.KadroUnvanAdi : string.Empty);
            ViewBag.kadroUnvan = unvan.KadroUnvanAdi;

            var googlescholar = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("google_scholar", googlescholar.GoogleScholarLink != null? googlescholar.GoogleScholarLink : string.Empty);
            ViewBag.yoksisLink = googlescholar.GoogleScholarLink;

            var orcid = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("orcid", orcid.Orcid != null ? orcid.Orcid : string.Empty);
            ViewBag.yoksisLink = orcid.Orcid;

            var yoksis = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("yoksis", yoksis.YokakademikLink!=null? yoksis.YokakademikLink : string.Empty );
            ViewBag.yoksisLink = yoksis.YokakademikLink;

            var personellink =  _context.PersonelLinkListesis.Where(x=>x.TcKimlikNo== "1111").FirstOrDefault();
            ViewBag.kadro = personellink.KadroYeri;

            var temelalan = _context.TemelAlanListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            if (temelalan!=null)
            {
ViewBag.arastirmaAlani = temelalan.Anahtarkelime1Ad + ", "+ temelalan.Anahterkelime2Ad +", "+ temelalan.Anahtarkelime3Ad;
            }
            

          

            var mail = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("eemail", mail.EMail != null ? mail.EMail : string.Empty);
            ViewBag.email = mail.EMail;

            var telefonNo = _context.PersonelLinkListesis.Where(x => x.TcKimlikNo == "1111").FirstOrDefault();
            HttpContext.Session.SetString("telefonNumarasi", telefonNo.DahiliTelNo != null ? telefonNo.DahiliTelNo : string.Empty);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}