using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class SanatsalFaalListe
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? SId { get; set; }

    public string? AnaTur { get; set; }

    public string? AnaturAdi { get; set; }

    public string? Kapsam { get; set; }

    public string? KapsamAd { get; set; }

    public string? Tip { get; set; }

    public string? TipAdi { get; set; }

    public string? EtkinlikAdi { get; set; }

    public string? EtkinlikYeri { get; set; }

    public string? EtkinlikTuru { get; set; }

    public string? BasTarih { get; set; }

    public string? BitTarih { get; set; }

    public string? Duzenleyenler { get; set; }

    public string? Ulke { get; set; }

    public string? UlkeAdi { get; set; }

    public string? Sehir { get; set; }

    public string? EtkinlikDili { get; set; }

    public string? DilAdi { get; set; }

    public string? KisiSayisi { get; set; }

    public string? KisiSirasi { get; set; }

    public string? EtkinlikTuruAd { get; set; }

    public string? UnvanId { get; set; }

    public string? UnvanAd { get; set; }

    public string? KurumAd { get; set; }

    public string? TesvPuani { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
