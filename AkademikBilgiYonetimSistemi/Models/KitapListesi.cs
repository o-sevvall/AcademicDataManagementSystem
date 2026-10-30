using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class KitapListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? YayinId { get; set; }

    public string? KapsamId { get; set; }

    public string? KapsamAd { get; set; }

    public string? KitapTurId { get; set; }

    public string? KitapTur { get; set; }

    public string? KitapAdi { get; set; }

    public string? KatkiDuzeyi { get; set; }

    public string? KatkiDuzeyiAd { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSayisi { get; set; }

    public string? YayinEvi { get; set; }

    public string? YayinDili { get; set; }

    public string? YayinDiliAdi { get; set; }

    public string? Yil { get; set; }

    public string? Isbn { get; set; }

    public string? KacinciBasim { get; set; }

    public string? SaysaSayisi { get; set; }

    public string? BasimTuru { get; set; }

    public string? BasimTuruAd { get; set; }

    public string? AlanBilgisi { get; set; }

    public string? YazarId { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
