using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class DeneyimListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? DeneyimId { get; set; }

    public string? KurulusAdi { get; set; }

    public string? GorevAdi { get; set; }

    public string? BasTar { get; set; }

    public string? BitTar { get; set; }

    public string? IsTanimi { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
