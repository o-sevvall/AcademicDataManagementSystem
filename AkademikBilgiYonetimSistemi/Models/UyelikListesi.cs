using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class UyelikListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? UyelikId { get; set; }

    public string? KurulusAdi { get; set; }

    public string? BasTar { get; set; }

    public string? UyelikDurumu { get; set; }

    public string? UyelikDurumuAd { get; set; }

    public string? KurulusTuru { get; set; }

    public string? KurulusTuruAd { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
