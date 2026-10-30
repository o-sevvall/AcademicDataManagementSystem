using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class OgrenimBilgisiListesi
{
    public int TabloId { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? Id { get; set; }

    public string? YerId { get; set; }

    public string? YerAd { get; set; }

    public string? Bastar1 { get; set; }

    public string? Bittar1 { get; set; }

    public string? UlkeId { get; set; }

    public string? BirimYok { get; set; }

    public string? UlkeAd { get; set; }

    public string? ProgramId { get; set; }

    public string? ProgramAdi { get; set; }

    public string? TezAsamasi { get; set; }

    public string? TezAsamasiAd { get; set; }

    public string? UnivId { get; set; }

    public string? UnvBirimAdi { get; set; }

    public string? AkademikBirimId { get; set; }

    public string? AkademikBirimAdi { get; set; }

    public string? Fakultebilgisi { get; set; }

    public string? Bolumbilgisi { get; set; }

    public string? TezAdi { get; set; }

    public string? TezBasTar { get; set; }

    public string? TezBitTar { get; set; }

    public string? DanismanAdSoyad { get; set; }

    public string? AktifPasif { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasifAd { get; set; }
}
