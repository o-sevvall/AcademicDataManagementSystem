using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class AkademikGorevListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? GorevId { get; set; }

    public string? YerId { get; set; }

    public string? YerAd { get; set; }

    public string? Bastar1 { get; set; }

    public string? UlkeId { get; set; }

    public string? BilimalanAdi { get; set; }

    public string? UzmanlikAlani { get; set; }

    public string? UzmanlikAlaniAdi { get; set; }

    public string? UlkeAd { get; set; }

    public string? UnivId { get; set; }

    public string? UnivBirimAdi { get; set; }

    public string? BirimId { get; set; }

    public string? Fakultebilgisi { get; set; }

    public string? Bolumbilgisi { get; set; }

    public string? Alanbilgisi { get; set; }

    public string? KadroUnvanId { get; set; }

    public string? KadroUnvanAdi { get; set; }

    public string? AkademikDurum { get; set; }

    public string? AkademikDurumAdi { get; set; }

    public string? AkademikBirimAdi { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
