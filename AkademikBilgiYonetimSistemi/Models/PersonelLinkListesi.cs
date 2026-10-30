using System;
using System.Collections.Generic;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class PersonelLinkListesi
{
    public int Id { get; set; }

    public string? TcKimlikNo { get; set; }

    public string? ArastirmaciId { get; set; }

    public string? KadroUnvanAdi { get; set; }

    public string? PersonelAdi { get; set; }

    public string? PersonelSoyadi { get; set; }

    public string? KadroYeri { get; set; }

    public string? YokakademikLink { get; set; }

    public string? PersonelResmiLink { get; set; }

    public string? Orcid { get; set; }

    public string? EMail { get; set; }

    public string? DahiliTelNo { get; set; }

    public string? GoogleScholarLink { get; set; }
}
