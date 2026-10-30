using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class ProjeListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? ProjeId { get; set; }

    public string? ProjeAd { get; set; }

    public string? ProjeKonusu { get; set; }

    public string? ProjeDurumuId { get; set; }

    public string? ProjeDurumuAd { get; set; }

    public string? BasTar { get; set; }

    public string? Butce { get; set; }

    public string? ProjeKonumuId { get; set; }

    public string? ProjeKonumuAd { get; set; }

    public string? ProjeTuruId { get; set; }

    public string? ProjeTuruAd { get; set; }

    public string? ParaBirimiId { get; set; }

    public string? ParaBirimiAd { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? Kapsam { get; set; }

    public string? KapsamAd { get; set; }

    public string? ProjeFormId { get; set; }

    public string? YazarAdi { get; set; }

    public string? BitTar { get; set; }

    public string? UnivAdi { get; set; }
}
