using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class OdulListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? OdulId { get; set; }

    public string? OdulAdi { get; set; }

    public string? OdulTarih { get; set; }

    public string? FaalDetayId { get; set; }

    public string? FaalDetayAdi { get; set; }

    public string? OdulTurId { get; set; }

    public string? OdulTuru { get; set; }

    public string? KurulusAdi { get; set; }

    public string? PUnvanId { get; set; }

    public string? PUnvanAd { get; set; }

    public string? PKurumId { get; set; }

    public string? PKurumAd { get; set; }

    public string? IsyeriTuruId { get; set; }

    public string? IsyeriTuruAdi { get; set; }

    public string? UlkeId { get; set; }

    public string? UlkeAd { get; set; }

    public string? OdulAciklama { get; set; }

    public string? KisiSayisi { get; set; }

    public string? OdulKisiSira { get; set; }

    public string? TesvPuan { get; set; }

    public string? GuncellemeTarihi { get; set; }
}
