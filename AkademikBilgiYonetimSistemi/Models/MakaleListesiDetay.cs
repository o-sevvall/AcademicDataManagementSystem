using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class MakaleListesiDetay
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? YayinId { get; set; }

    public string? KapsamId { get; set; }

    public string? KapsamAd { get; set; }

    public string? HakemTur { get; set; }

    public string? HakemTurAd { get; set; }

    public string? EndeksId { get; set; }

    public string? Endeks { get; set; }

    public string? MakaleAdi { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSayisi { get; set; }

    public string? DergiAdi { get; set; }

    public string? YayinDili { get; set; }

    public string? YayinDiliAdi { get; set; }

    public string? Ay { get; set; }

    public string? Yil { get; set; }

    public string? Cilt { get; set; }

    public string? Sayi { get; set; }

    public string? IlkSayfa { get; set; }

    public string? SonSayfa { get; set; }

    public string? Doi { get; set; }

    public string? Issn { get; set; }

    public string? ErisimTuru { get; set; }

    public string? ErisimTuruAd { get; set; }

    public string? ErisimLinki { get; set; }

    public string? AlanBilgisi { get; set; }

    public string? YazarId { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? MakaleTuruId { get; set; }

    public string? MakaleTuruAd { get; set; }
}
