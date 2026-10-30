using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class TemelAlanListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? TUakId { get; set; }

    public string? TemelAlanId { get; set; }

    public string? BilimAlanId { get; set; }

    public string? Anahtarkelime1Id { get; set; }

    public string? Anahtarkelime2Id { get; set; }

    public string? Anahtarkelime3Id { get; set; }

    public string? TemelAlanAd { get; set; }

    public string? BilimAlanAd { get; set; }

    public string? Anahtarkelime1Ad { get; set; }

    public string? Anahterkelime2Ad { get; set; }

    public string? Anahtarkelime3Ad { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
