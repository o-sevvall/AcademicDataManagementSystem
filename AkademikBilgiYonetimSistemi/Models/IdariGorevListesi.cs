using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class IdariGorevListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? IdgorId { get; set; }

    public string? YerId { get; set; }

    public string? YerAdi { get; set; }

    public string? UlkeId { get; set; }

    public string? UlkeAdi { get; set; }

    public string? GorevId { get; set; }

    public string? GorevAdi { get; set; }

    public string? UnvBirimId { get; set; }

    public string? UnvBirimAdi { get; set; }

    public string? BasTar { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? Fakultebilgisi { get; set; }

    public string? BitTar { get; set; }
}
