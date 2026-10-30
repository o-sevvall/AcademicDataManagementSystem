using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class TezDanismanListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? Verikaynak { get; set; }

    public string? YerId { get; set; }

    public string? YerAdi { get; set; }

    public string? Ulke { get; set; }

    public string? KayitId { get; set; }

    public string? Yil { get; set; }

    public string? TurId { get; set; }

    public string? TurAdi { get; set; }

    public string? TezAdi { get; set; }

    public string? DurumAdi { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSoyadi { get; set; }

    public string? UniversiteAd { get; set; }

    public string? EnstituAd { get; set; }

    public string? AbdAd { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? DanismanSirasi { get; set; }
}
