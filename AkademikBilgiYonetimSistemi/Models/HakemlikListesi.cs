using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class HakemlikListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? YayinId { get; set; }

    public string? KapsamId { get; set; }

    public string? KapsamAd { get; set; }

    public string? HakemlikTuru { get; set; }

    public string? HakemlikTuruAd { get; set; }

    public string? YayinYeri { get; set; }

    public string? HakemlikSayisi { get; set; }

    public string? YayinDili { get; set; }

    public string? YayinDiliAdi { get; set; }

    public string? Ulke { get; set; }

    public string? UlkeAdi { get; set; }

    public string? EndeksId { get; set; }

    public string? Endeks { get; set; }

    public string? AlanBilgisi { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? Yil { get; set; }

    public string? TesvPuan { get; set; }
}
