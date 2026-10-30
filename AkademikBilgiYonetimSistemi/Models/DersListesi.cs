using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class DersListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? DersId { get; set; }

    public string? DersAdi { get; set; }

    public string? OgrenimId { get; set; }

    public string? OgrenimAdi { get; set; }

    public string? AkademikYil { get; set; }

    public string? DilId { get; set; }

    public string? DilAdi { get; set; }

    public string? DersSaati { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? EklemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
