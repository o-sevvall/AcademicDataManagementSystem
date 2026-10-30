using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class BildiriListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? YayinId { get; set; }

    public string? KapsamId { get; set; }

    public string? KapsamAd { get; set; }

    public string? BildiriTurId { get; set; }

    public string? BildiriTur { get; set; }

    public string? BildiriAdi { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSayisi { get; set; }

    public string? Ulke { get; set; }

    public string? UlkeAdi { get; set; }

    public string? Sehir { get; set; }

    public string? EtkinlikAdi { get; set; }

    public string? YayinDili { get; set; }

    public string? YayinDiliAdi { get; set; }

    public string? EtkinlikBasTarihi { get; set; }

    public string? EtkinlikBitTarihi { get; set; }

    public string? YayinDurumu { get; set; }

    public string? YayinDurumuAd { get; set; }

    public string? BasimTarihi { get; set; }

    public string? Doi { get; set; }

    public string? PrintIsbn { get; set; }

    public string? BasimTuru { get; set; }

    public string? BasimTuruAd { get; set; }

    public string? ErisimLinki { get; set; }

    public string? AlanBilgisi { get; set; }

    public string? OzelSayi { get; set; }

    public string? YazarId { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? BildirimSunumTuru { get; set; }

    public string? BildirimSunumTuruAd { get; set; }

    public string? YayinYeri { get; set; }

    public string? Yil { get; set; }
}
