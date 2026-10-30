using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class ArastirmaListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? SId { get; set; }

    public string? TurId { get; set; }

    public string? TurAdi { get; set; }

    public string? Adi { get; set; }

    public string? Icerik { get; set; }

    public string? Yer { get; set; }

    public string? Kapsam { get; set; }

    public string? KapsamAd { get; set; }

    public string? Sure { get; set; }

    public string? Bastar { get; set; }

    public string? Bittar { get; set; }

    public string? UnvanId { get; set; }

    public string? UnvanAd { get; set; }

    public string? KurumAd { get; set; }

    public string? KurumId { get; set; }

    public string? KisiSayisi { get; set; }

    public string? UlkeSehir { get; set; }

    public string? GuncellemeTarihi { get; set; }

    public string? AktifPasif { get; set; }

    public string? AktifPasifAd { get; set; }
}
