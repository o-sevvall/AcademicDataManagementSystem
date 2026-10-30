using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class TasarimListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? PTasarimId { get; set; }

    public string? TasarimSahipleri { get; set; }

    public string? TasarimTuru { get; set; }

    public string? TasarimTuruAdi { get; set; }

    public string? TasarimTuruDetay { get; set; }

    public string? TasarimTuruDetayAd { get; set; }

    public string? Kapsam { get; set; }

    public string? KapsamAd { get; set; }

    public string? TasarimAdi { get; set; }

    public string? TasarimOzeti { get; set; }

    public string? BasTarihi { get; set; }

    public string? BitisTarihi { get; set; }

    public string? UnvanId { get; set; }

    public string? UnvanAd { get; set; }

    public string? KurumId { get; set; }

    public string? KurumAd { get; set; }

    public string? KisiSayisi { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
