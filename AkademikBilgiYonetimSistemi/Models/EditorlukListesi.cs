using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class EditorlukListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? YayinId { get; set; }

    public string? KapsamId { get; set; }

    public string? KapsamAd { get; set; }

    public string? EditorlukTur { get; set; }

    public string? EditorlukTurAd { get; set; }

    public string? EditorGorev { get; set; }

    public string? EditorGorevAd { get; set; }

    public string? YayinAdi { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSayisi { get; set; }

    public string? YayinEvi { get; set; }

    public string? YayinDili { get; set; }

    public string? YayinDiliAdi { get; set; }

    public string? EndeksId { get; set; }

    public string? Endeks { get; set; }

    public string? Yil { get; set; }

    public string? ErisimTuru { get; set; }

    public string? ErisimTuruAd { get; set; }

    public string? AlanBilgisi { get; set; }

    public string? YazarId { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }

    public string? TesvPuan { get; set; }
}
