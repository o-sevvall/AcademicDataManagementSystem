using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class PatentListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? PatentId { get; set; }

    public string? PatentNo { get; set; }

    public string? PatentTarihi { get; set; }

    public string? BasvuruSahipleri { get; set; }

    public string? BulusSahipleri { get; set; }

    public string? Kategori { get; set; }

    public string? KategoriId { get; set; }

    public string? DosyaTipi { get; set; }

    public string? DosyaTipiId { get; set; }

    public string? Kapsam { get; set; }

    public string? KapsamId { get; set; }

    public string? PatentAdi { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? KisiSayisi { get; set; }

    public string? TesvPuan { get; set; }
}
