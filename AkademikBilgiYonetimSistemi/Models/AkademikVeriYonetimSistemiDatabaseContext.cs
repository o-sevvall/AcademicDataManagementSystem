using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AkademikBilgiYonetimSistemi.Models;

public partial class AkademikVeriYonetimSistemiDatabaseContext : DbContext
{
    public AkademikVeriYonetimSistemiDatabaseContext()
    {
    }

    public AkademikVeriYonetimSistemiDatabaseContext(DbContextOptions<AkademikVeriYonetimSistemiDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AkademikGorevListesi> AkademikGorevListesis { get; set; }

    public virtual DbSet<ArastirmaListesi> ArastirmaListesis { get; set; }

    public virtual DbSet<BildiriListesi> BildiriListesis { get; set; }

    public virtual DbSet<DeneyimListesi> DeneyimListesis { get; set; }

    public virtual DbSet<DersListesi> DersListesis { get; set; }

    public virtual DbSet<EditorlukListesi> EditorlukListesis { get; set; }

    public virtual DbSet<HakemlikListesi> HakemlikListesis { get; set; }

    public virtual DbSet<IdariGorevListesi> IdariGorevListesis { get; set; }

    public virtual DbSet<KitapListesi> KitapListesis { get; set; }

    public virtual DbSet<MakaleListesiDetay> MakaleListesiDetays { get; set; }

    public virtual DbSet<OdulListesi> OdulListesis { get; set; }

    public virtual DbSet<OgrenimBilgisiListesi> OgrenimBilgisiListesis { get; set; }

    public virtual DbSet<PatentListesi> PatentListesis { get; set; }

    public virtual DbSet<PersonelLinkListesi> PersonelLinkListesis { get; set; }

    public virtual DbSet<PersonelTable> PersonelTables { get; set; }

    public virtual DbSet<ProjeListesi> ProjeListesis { get; set; }

    public virtual DbSet<SanatsalFaalListe> SanatsalFaalListes { get; set; }

    public virtual DbSet<TasarimListesi> TasarimListesis { get; set; }

    public virtual DbSet<TemelAlanListesi> TemelAlanListesis { get; set; }

    public virtual DbSet<TezDanismanListesi> TezDanismanListesis { get; set; }

    public virtual DbSet<UyelikListesi> UyelikListesis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=AkademikVeriYonetimSistemiDatabase;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AkademikGorevListesi>(entity =>
        {
            entity.ToTable("akademikGorevListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AkademikBirimAdi)
                .HasMaxLength(4000)
                .HasColumnName("AKADEMIK_BIRIM_ADI");
            entity.Property(e => e.AkademikDurum)
                .HasMaxLength(4000)
                .HasColumnName("AKADEMIK_DURUM");
            entity.Property(e => e.AkademikDurumAdi)
                .HasMaxLength(4000)
                .HasColumnName("AKADEMIK_DURUM_ADI");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.Alanbilgisi)
                .HasMaxLength(4000)
                .HasColumnName("ALANBILGISI");
            entity.Property(e => e.Bastar1)
                .HasMaxLength(4000)
                .HasColumnName("BASTAR1");
            entity.Property(e => e.BilimalanAdi)
                .HasMaxLength(4000)
                .HasColumnName("BILIMALAN_ADI");
            entity.Property(e => e.BirimId)
                .HasMaxLength(4000)
                .HasColumnName("BIRIM_ID");
            entity.Property(e => e.Bolumbilgisi)
                .HasMaxLength(4000)
                .HasColumnName("BOLUMBILGISI");
            entity.Property(e => e.Fakultebilgisi)
                .HasMaxLength(4000)
                .HasColumnName("FAKULTEBILGISI");
            entity.Property(e => e.GorevId)
                .HasMaxLength(4000)
                .HasColumnName("GOREV_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.KadroUnvanAdi)
                .HasMaxLength(4000)
                .HasColumnName("KADRO_UNVAN_ADI");
            entity.Property(e => e.KadroUnvanId)
                .HasMaxLength(4000)
                .HasColumnName("KADRO_UNVAN_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.UlkeAd)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_AD");
            entity.Property(e => e.UlkeId)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ID");
            entity.Property(e => e.UnivBirimAdi)
                .HasMaxLength(4000)
                .HasColumnName("UNIV_BIRIM_ADI");
            entity.Property(e => e.UnivId)
                .HasMaxLength(4000)
                .HasColumnName("UNIV_ID");
            entity.Property(e => e.UzmanlikAlani)
                .HasMaxLength(4000)
                .HasColumnName("UZMANLIK_ALANI");
            entity.Property(e => e.UzmanlikAlaniAdi)
                .HasMaxLength(4000)
                .HasColumnName("UZMANLIK_ALANI_ADI");
            entity.Property(e => e.YerAd)
                .HasMaxLength(4000)
                .HasColumnName("YER_AD");
            entity.Property(e => e.YerId)
                .HasMaxLength(4000)
                .HasColumnName("YER_ID");
        });

        modelBuilder.Entity<ArastirmaListesi>(entity =>
        {
            entity.ToTable("arastirmaListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(4000)
                .HasColumnName("ADI");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.Bastar)
                .HasMaxLength(4000)
                .HasColumnName("BASTAR");
            entity.Property(e => e.Bittar)
                .HasMaxLength(4000)
                .HasColumnName("BITTAR");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Icerik)
                .HasMaxLength(4000)
                .HasColumnName("ICERIK");
            entity.Property(e => e.Kapsam)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KisiSayisi)
                .HasMaxLength(4000)
                .HasColumnName("KISI_SAYISI");
            entity.Property(e => e.KurumAd)
                .HasMaxLength(4000)
                .HasColumnName("KURUM_AD");
            entity.Property(e => e.KurumId)
                .HasMaxLength(4000)
                .HasColumnName("KURUM_ID");
            entity.Property(e => e.SId)
                .HasMaxLength(4000)
                .HasColumnName("S_ID");
            entity.Property(e => e.Sure)
                .HasMaxLength(4000)
                .HasColumnName("SURE");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TurAdi)
                .HasMaxLength(4000)
                .HasColumnName("TUR_ADI");
            entity.Property(e => e.TurId)
                .HasMaxLength(4000)
                .HasColumnName("TUR_ID");
            entity.Property(e => e.UlkeSehir)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_SEHIR");
            entity.Property(e => e.UnvanAd)
                .HasMaxLength(4000)
                .HasColumnName("UNVAN_AD");
            entity.Property(e => e.UnvanId)
                .HasMaxLength(4000)
                .HasColumnName("UNVAN_ID");
            entity.Property(e => e.Yer)
                .HasMaxLength(4000)
                .HasColumnName("YER");
        });

        modelBuilder.Entity<BildiriListesi>(entity =>
        {
            entity.ToTable("bildiriListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.AlanBilgisi)
                .HasMaxLength(4000)
                .HasColumnName("ALAN_BILGISI");
            entity.Property(e => e.BasimTarihi)
                .HasMaxLength(4000)
                .HasColumnName("BASIM_TARIHI");
            entity.Property(e => e.BasimTuru)
                .HasMaxLength(4000)
                .HasColumnName("BASIM_TURU");
            entity.Property(e => e.BasimTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("BASIM_TURU_AD");
            entity.Property(e => e.BildiriAdi)
                .HasMaxLength(4000)
                .HasColumnName("BILDIRI_ADI");
            entity.Property(e => e.BildiriTur)
                .HasMaxLength(4000)
                .HasColumnName("BILDIRI_TUR");
            entity.Property(e => e.BildiriTurId)
                .HasMaxLength(4000)
                .HasColumnName("BILDIRI_TUR_ID");
            entity.Property(e => e.BildirimSunumTuru)
                .HasMaxLength(4000)
                .HasColumnName("BILDIRIM_SUNUM_TURU");
            entity.Property(e => e.BildirimSunumTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("BILDIRIM_SUNUM_TURU_AD");
            entity.Property(e => e.Doi)
                .HasMaxLength(4000)
                .HasColumnName("DOI");
            entity.Property(e => e.ErisimLinki)
                .HasMaxLength(4000)
                .HasColumnName("ERISIM_LINKI");
            entity.Property(e => e.EtkinlikAdi)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_ADI");
            entity.Property(e => e.EtkinlikBasTarihi)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_BAS_TARIHI");
            entity.Property(e => e.EtkinlikBitTarihi)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_BIT_TARIHI");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KapsamId)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_ID");
            entity.Property(e => e.OzelSayi)
                .HasMaxLength(4000)
                .HasColumnName("OZEL_SAYI");
            entity.Property(e => e.PrintIsbn)
                .HasMaxLength(4000)
                .HasColumnName("PRINT_ISBN");
            entity.Property(e => e.Sehir)
                .HasMaxLength(4000)
                .HasColumnName("SEHIR");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.Ulke)
                .HasMaxLength(4000)
                .HasColumnName("ULKE");
            entity.Property(e => e.UlkeAdi)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ADI");
            entity.Property(e => e.YayinDili)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI");
            entity.Property(e => e.YayinDiliAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI_ADI");
            entity.Property(e => e.YayinDurumu)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DURUMU");
            entity.Property(e => e.YayinDurumuAd)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DURUMU_AD");
            entity.Property(e => e.YayinId)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_ID");
            entity.Property(e => e.YayinYeri)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_YERI");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ADI");
            entity.Property(e => e.YazarId)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ID");
            entity.Property(e => e.YazarSayisi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_SAYISI");
            entity.Property(e => e.Yil)
                .HasMaxLength(4000)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<DeneyimListesi>(entity =>
        {
            entity.ToTable("deneyimListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.BasTar)
                .HasMaxLength(4000)
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.BitTar)
                .HasMaxLength(4000)
                .HasColumnName("BIT_TAR");
            entity.Property(e => e.DeneyimId)
                .HasMaxLength(4000)
                .HasColumnName("DENEYIM_ID");
            entity.Property(e => e.GorevAdi)
                .HasMaxLength(4000)
                .HasColumnName("GOREV_ADI");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.IsTanimi)
                .HasMaxLength(4000)
                .HasColumnName("IS_TANIMI");
            entity.Property(e => e.KurulusAdi)
                .HasMaxLength(4000)
                .HasColumnName("KURULUS_ADI");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
        });

        modelBuilder.Entity<DersListesi>(entity =>
        {
            entity.ToTable("dersListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AkademikYil)
                .HasMaxLength(50)
                .HasColumnName("AKADEMIK_YIL");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.DersAdi)
                .HasMaxLength(4000)
                .HasColumnName("DERS_ADI");
            entity.Property(e => e.DersId)
                .HasMaxLength(4000)
                .HasColumnName("DERS_ID");
            entity.Property(e => e.DersSaati)
                .HasMaxLength(4000)
                .HasColumnName("DERS_SAATI");
            entity.Property(e => e.DilAdi)
                .HasMaxLength(4000)
                .HasColumnName("DIL_ADI");
            entity.Property(e => e.DilId)
                .HasMaxLength(4000)
                .HasColumnName("DIL_ID");
            entity.Property(e => e.EklemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("EKLEME_TARIHI");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.OgrenimAdi)
                .HasMaxLength(4000)
                .HasColumnName("OGRENIM_ADI");
            entity.Property(e => e.OgrenimId)
                .HasMaxLength(4000)
                .HasColumnName("OGRENIM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
        });

        modelBuilder.Entity<EditorlukListesi>(entity =>
        {
            entity.ToTable("editorlukListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.AlanBilgisi)
                .HasMaxLength(4000)
                .HasColumnName("ALAN_BILGISI");
            entity.Property(e => e.EditorGorev)
                .HasMaxLength(4000)
                .HasColumnName("EDITOR_GOREV");
            entity.Property(e => e.EditorGorevAd)
                .HasMaxLength(4000)
                .HasColumnName("EDITOR_GOREV_AD");
            entity.Property(e => e.EditorlukTur)
                .HasMaxLength(4000)
                .HasColumnName("EDITORLUK_TUR");
            entity.Property(e => e.EditorlukTurAd)
                .HasMaxLength(4000)
                .HasColumnName("EDITORLUK_TUR_AD");
            entity.Property(e => e.Endeks)
                .HasMaxLength(4000)
                .HasColumnName("ENDEKS");
            entity.Property(e => e.EndeksId)
                .HasMaxLength(4000)
                .HasColumnName("ENDEKS_ID");
            entity.Property(e => e.ErisimTuru)
                .HasMaxLength(4000)
                .HasColumnName("ERISIM_TURU");
            entity.Property(e => e.ErisimTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("ERISIM_TURU_AD");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KapsamId)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TesvPuan)
                .HasMaxLength(4000)
                .HasColumnName("TESV_PUAN");
            entity.Property(e => e.YayinAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_ADI");
            entity.Property(e => e.YayinDili)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI");
            entity.Property(e => e.YayinDiliAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI_ADI");
            entity.Property(e => e.YayinEvi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_EVI");
            entity.Property(e => e.YayinId)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_ID");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ADI");
            entity.Property(e => e.YazarId)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ID");
            entity.Property(e => e.YazarSayisi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_SAYISI");
            entity.Property(e => e.Yil)
                .HasMaxLength(4000)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<HakemlikListesi>(entity =>
        {
            entity.ToTable("hakemlikListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.AlanBilgisi)
                .HasMaxLength(4000)
                .HasColumnName("ALAN_BILGISI");
            entity.Property(e => e.Endeks)
                .HasMaxLength(4000)
                .HasColumnName("ENDEKS");
            entity.Property(e => e.EndeksId)
                .HasMaxLength(4000)
                .HasColumnName("ENDEKS_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.HakemlikSayisi)
                .HasMaxLength(4000)
                .HasColumnName("HAKEMLIK_SAYISI");
            entity.Property(e => e.HakemlikTuru)
                .HasMaxLength(4000)
                .HasColumnName("HAKEMLIK_TURU");
            entity.Property(e => e.HakemlikTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("HAKEMLIK_TURU_AD");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KapsamId)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TesvPuan)
                .HasMaxLength(4000)
                .HasColumnName("TESV_PUAN");
            entity.Property(e => e.Ulke)
                .HasMaxLength(4000)
                .HasColumnName("ULKE");
            entity.Property(e => e.UlkeAdi)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ADI");
            entity.Property(e => e.YayinDili)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI");
            entity.Property(e => e.YayinDiliAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI_ADI");
            entity.Property(e => e.YayinId)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_ID");
            entity.Property(e => e.YayinYeri)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_YERI");
            entity.Property(e => e.Yil)
                .HasMaxLength(4000)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<IdariGorevListesi>(entity =>
        {
            entity.ToTable("idariGorevListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.BasTar)
                .HasMaxLength(4000)
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.BitTar)
                .HasMaxLength(4000)
                .HasColumnName("BIT_TAR");
            entity.Property(e => e.Fakultebilgisi)
                .HasMaxLength(4000)
                .HasColumnName("FAKULTEBILGISI");
            entity.Property(e => e.GorevAdi)
                .HasMaxLength(4000)
                .HasColumnName("GOREV_ADI");
            entity.Property(e => e.GorevId)
                .HasMaxLength(4000)
                .HasColumnName("GOREV_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.IdgorId)
                .HasMaxLength(4000)
                .HasColumnName("IDGOR_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.UlkeAdi)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ADI");
            entity.Property(e => e.UlkeId)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ID");
            entity.Property(e => e.UnvBirimAdi)
                .HasMaxLength(4000)
                .HasColumnName("UNV_BIRIM_ADI");
            entity.Property(e => e.UnvBirimId)
                .HasMaxLength(4000)
                .HasColumnName("UNV_BIRIM_ID");
            entity.Property(e => e.YerAdi)
                .HasMaxLength(4000)
                .HasColumnName("YER_ADI");
            entity.Property(e => e.YerId)
                .HasMaxLength(4000)
                .HasColumnName("YER_ID");
        });

        modelBuilder.Entity<KitapListesi>(entity =>
        {
            entity.ToTable("kitapListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.AlanBilgisi)
                .HasMaxLength(4000)
                .HasColumnName("ALAN_BILGISI");
            entity.Property(e => e.BasimTuru)
                .HasMaxLength(4000)
                .HasColumnName("BASIM_TURU");
            entity.Property(e => e.BasimTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("BASIM_TURU_AD");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Isbn)
                .HasMaxLength(4000)
                .HasColumnName("ISBN");
            entity.Property(e => e.KacinciBasim)
                .HasMaxLength(4000)
                .HasColumnName("KACINCI_BASIM");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KapsamId)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_ID");
            entity.Property(e => e.KatkiDuzeyi)
                .HasMaxLength(4000)
                .HasColumnName("KATKI_DUZEYI");
            entity.Property(e => e.KatkiDuzeyiAd)
                .HasMaxLength(4000)
                .HasColumnName("KATKI_DUZEYI_AD");
            entity.Property(e => e.KitapAdi)
                .HasMaxLength(4000)
                .HasColumnName("KITAP_ADI");
            entity.Property(e => e.KitapTur)
                .HasMaxLength(4000)
                .HasColumnName("KITAP_TUR");
            entity.Property(e => e.KitapTurId)
                .HasMaxLength(4000)
                .HasColumnName("KITAP_TUR_ID");
            entity.Property(e => e.SaysaSayisi)
                .HasMaxLength(4000)
                .HasColumnName("SAYSA_SAYISI");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.YayinDili)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI");
            entity.Property(e => e.YayinDiliAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI_ADI");
            entity.Property(e => e.YayinEvi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_EVI");
            entity.Property(e => e.YayinId)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_ID");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ADI");
            entity.Property(e => e.YazarId)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ID");
            entity.Property(e => e.YazarSayisi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_SAYISI");
            entity.Property(e => e.Yil)
                .HasMaxLength(4000)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<MakaleListesiDetay>(entity =>
        {
            entity.ToTable("makaleListesiDetay");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.AlanBilgisi)
                .HasMaxLength(4000)
                .HasColumnName("ALAN_BILGISI");
            entity.Property(e => e.Ay)
                .HasMaxLength(4000)
                .HasColumnName("AY");
            entity.Property(e => e.Cilt)
                .HasMaxLength(4000)
                .HasColumnName("CILT");
            entity.Property(e => e.DergiAdi)
                .HasMaxLength(4000)
                .HasColumnName("DERGI_ADI");
            entity.Property(e => e.Doi)
                .HasMaxLength(4000)
                .HasColumnName("DOI");
            entity.Property(e => e.Endeks)
                .HasMaxLength(4000)
                .HasColumnName("ENDEKS");
            entity.Property(e => e.EndeksId)
                .HasMaxLength(4000)
                .HasColumnName("ENDEKS_ID");
            entity.Property(e => e.ErisimLinki)
                .HasMaxLength(4000)
                .HasColumnName("ERISIM_LINKI");
            entity.Property(e => e.ErisimTuru)
                .HasMaxLength(4000)
                .HasColumnName("ERISIM_TURU");
            entity.Property(e => e.ErisimTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("ERISIM_TURU_AD");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.HakemTur)
                .HasMaxLength(4000)
                .HasColumnName("HAKEM_TUR");
            entity.Property(e => e.HakemTurAd)
                .HasMaxLength(4000)
                .HasColumnName("HAKEM_TUR_AD");
            entity.Property(e => e.IlkSayfa)
                .HasMaxLength(4000)
                .HasColumnName("ILK_SAYFA");
            entity.Property(e => e.Issn)
                .HasMaxLength(4000)
                .HasColumnName("ISSN");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KapsamId)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_ID");
            entity.Property(e => e.MakaleAdi)
                .HasMaxLength(4000)
                .HasColumnName("MAKALE_ADI");
            entity.Property(e => e.MakaleTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("MAKALE_TURU_AD");
            entity.Property(e => e.MakaleTuruId)
                .HasMaxLength(4000)
                .HasColumnName("MAKALE_TURU_ID");
            entity.Property(e => e.Sayi)
                .HasMaxLength(4000)
                .HasColumnName("SAYI");
            entity.Property(e => e.SonSayfa)
                .HasMaxLength(4000)
                .HasColumnName("SON_SAYFA");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.YayinDili)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI");
            entity.Property(e => e.YayinDiliAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_DILI_ADI");
            entity.Property(e => e.YayinId)
                .HasMaxLength(4000)
                .HasColumnName("YAYIN_ID");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ADI");
            entity.Property(e => e.YazarId)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ID");
            entity.Property(e => e.YazarSayisi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_SAYISI");
            entity.Property(e => e.Yil)
                .HasMaxLength(4000)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<OdulListesi>(entity =>
        {
            entity.ToTable("odulListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FaalDetayAdi)
                .HasMaxLength(4000)
                .HasColumnName("FAAL_DETAY_ADI");
            entity.Property(e => e.FaalDetayId)
                .HasMaxLength(4000)
                .HasColumnName("FAAL_DETAY_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.IsyeriTuruAdi)
                .HasMaxLength(4000)
                .HasColumnName("ISYERI_TURU_ADI");
            entity.Property(e => e.IsyeriTuruId)
                .HasMaxLength(4000)
                .HasColumnName("ISYERI_TURU_ID");
            entity.Property(e => e.KisiSayisi)
                .HasMaxLength(4000)
                .HasColumnName("KISI_SAYISI");
            entity.Property(e => e.KurulusAdi)
                .HasMaxLength(4000)
                .HasColumnName("KURULUS_ADI");
            entity.Property(e => e.OdulAciklama)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_ACIKLAMA");
            entity.Property(e => e.OdulAdi)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_ADI");
            entity.Property(e => e.OdulId)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_ID");
            entity.Property(e => e.OdulKisiSira)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_KISI_SIRA");
            entity.Property(e => e.OdulTarih)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_TARIH");
            entity.Property(e => e.OdulTurId)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_TUR_ID");
            entity.Property(e => e.OdulTuru)
                .HasMaxLength(4000)
                .HasColumnName("ODUL_TURU");
            entity.Property(e => e.PKurumAd)
                .HasMaxLength(4000)
                .HasColumnName("P_KURUM_AD");
            entity.Property(e => e.PKurumId)
                .HasMaxLength(4000)
                .HasColumnName("P_KURUM_ID");
            entity.Property(e => e.PUnvanAd)
                .HasMaxLength(4000)
                .HasColumnName("P_UNVAN_AD");
            entity.Property(e => e.PUnvanId)
                .HasMaxLength(4000)
                .HasColumnName("P_UNVAN_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TesvPuan)
                .HasMaxLength(4000)
                .HasColumnName("TESV_PUAN");
            entity.Property(e => e.UlkeAd)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_AD");
            entity.Property(e => e.UlkeId)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ID");
        });

        modelBuilder.Entity<OgrenimBilgisiListesi>(entity =>
        {
            entity.HasKey(e => e.TabloId);

            entity.ToTable("OgrenimBilgisiListesi");

            entity.Property(e => e.TabloId).HasColumnName("TABLO_ID");
            entity.Property(e => e.AkademikBirimAdi)
                .HasMaxLength(4000)
                .HasColumnName("AKADEMIK_BIRIM_ADI");
            entity.Property(e => e.AkademikBirimId)
                .HasMaxLength(4000)
                .HasColumnName("AKADEMIK_BIRIM_ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.Bastar1)
                .HasMaxLength(4000)
                .HasColumnName("BASTAR1");
            entity.Property(e => e.BirimYok)
                .HasMaxLength(4000)
                .HasColumnName("BIRIM_YOK");
            entity.Property(e => e.Bittar1)
                .HasMaxLength(4000)
                .HasColumnName("BITTAR1");
            entity.Property(e => e.Bolumbilgisi)
                .HasMaxLength(4000)
                .HasColumnName("BOLUMBILGISI");
            entity.Property(e => e.DanismanAdSoyad)
                .HasMaxLength(4000)
                .HasColumnName("DANISMAN_AD_SOYAD");
            entity.Property(e => e.Fakultebilgisi)
                .HasMaxLength(4000)
                .HasColumnName("FAKULTEBILGISI");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Id)
                .HasMaxLength(4000)
                .HasColumnName("ID");
            entity.Property(e => e.ProgramAdi)
                .HasMaxLength(4000)
                .HasColumnName("PROGRAM_ADI");
            entity.Property(e => e.ProgramId)
                .HasMaxLength(4000)
                .HasColumnName("PROGRAM_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TezAdi)
                .HasMaxLength(4000)
                .HasColumnName("TEZ_ADI");
            entity.Property(e => e.TezAsamasi)
                .HasMaxLength(4000)
                .HasColumnName("TEZ_ASAMASI");
            entity.Property(e => e.TezAsamasiAd)
                .HasMaxLength(4000)
                .HasColumnName("TEZ_ASAMASI_AD");
            entity.Property(e => e.TezBasTar)
                .HasMaxLength(4000)
                .HasColumnName("TEZ_BAS_TAR");
            entity.Property(e => e.TezBitTar)
                .HasMaxLength(4000)
                .HasColumnName("TEZ_BIT_TAR");
            entity.Property(e => e.UlkeAd)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_AD");
            entity.Property(e => e.UlkeId)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ID");
            entity.Property(e => e.UnivId)
                .HasMaxLength(4000)
                .HasColumnName("UNIV_ID");
            entity.Property(e => e.UnvBirimAdi)
                .HasMaxLength(4000)
                .HasColumnName("UNV_BIRIM_ADI");
            entity.Property(e => e.YerAd)
                .HasMaxLength(4000)
                .HasColumnName("YER_AD");
            entity.Property(e => e.YerId)
                .HasMaxLength(4000)
                .HasColumnName("YER_ID");
        });

        modelBuilder.Entity<PatentListesi>(entity =>
        {
            entity.ToTable("patentListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.BasvuruSahipleri)
                .HasMaxLength(4000)
                .HasColumnName("BASVURU_SAHIPLERI");
            entity.Property(e => e.BulusSahipleri)
                .HasMaxLength(4000)
                .HasColumnName("BULUS_SAHIPLERI");
            entity.Property(e => e.DosyaTipi)
                .HasMaxLength(4000)
                .HasColumnName("DOSYA_TIPI");
            entity.Property(e => e.DosyaTipiId)
                .HasMaxLength(4000)
                .HasColumnName("DOSYA_TIPI_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Kapsam)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM");
            entity.Property(e => e.KapsamId)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_ID");
            entity.Property(e => e.Kategori)
                .HasMaxLength(4000)
                .HasColumnName("KATEGORI");
            entity.Property(e => e.KategoriId)
                .HasMaxLength(4000)
                .HasColumnName("KATEGORI_ID");
            entity.Property(e => e.KisiSayisi)
                .HasMaxLength(4000)
                .HasColumnName("KISI_SAYISI");
            entity.Property(e => e.PatentAdi)
                .HasMaxLength(4000)
                .HasColumnName("PATENT_ADI");
            entity.Property(e => e.PatentId)
                .HasMaxLength(4000)
                .HasColumnName("PATENT_ID");
            entity.Property(e => e.PatentNo)
                .HasMaxLength(4000)
                .HasColumnName("PATENT_NO");
            entity.Property(e => e.PatentTarihi)
                .HasMaxLength(4000)
                .HasColumnName("PATENT_TARIHI");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TesvPuan)
                .HasMaxLength(4000)
                .HasColumnName("TESV_PUAN");
        });

        modelBuilder.Entity<PersonelLinkListesi>(entity =>
        {
            entity.ToTable("personelLinkListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArastirmaciId)
                .HasMaxLength(4000)
                .HasColumnName("ARASTIRMACI_ID");
            entity.Property(e => e.DahiliTelNo)
                .HasMaxLength(4000)
                .HasColumnName("DAHILI_TEL_NO");
            entity.Property(e => e.EMail)
                .HasMaxLength(4000)
                .HasColumnName("E-MAIL");
            entity.Property(e => e.GoogleScholarLink)
                .HasMaxLength(4000)
                .HasColumnName("GOOGLE_SCHOLAR_LINK");
            entity.Property(e => e.KadroUnvanAdi)
                .HasMaxLength(4000)
                .HasColumnName("KADRO_UNVAN_ADI");
            entity.Property(e => e.KadroYeri)
                .HasMaxLength(4000)
                .HasColumnName("KADRO_YERI");
            entity.Property(e => e.Orcid)
                .HasMaxLength(4000)
                .HasColumnName("ORCID");
            entity.Property(e => e.PersonelAdi)
                .HasMaxLength(4000)
                .HasColumnName("PERSONEL_ADI");
            entity.Property(e => e.PersonelResmiLink)
                .HasMaxLength(4000)
                .HasColumnName("PERSONEL_RESMI_LINK");
            entity.Property(e => e.PersonelSoyadi)
                .HasMaxLength(4000)
                .HasColumnName("PERSONEL_SOYADI");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.YokakademikLink)
                .HasMaxLength(4000)
                .HasColumnName("YOKAKADEMIK_LINK");
        });

        modelBuilder.Entity<PersonelTable>(entity =>
        {
            entity.ToTable("personel_table");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(4000)
                .HasColumnName("email");
            entity.Property(e => e.Tc)
                .HasMaxLength(4000)
                .HasColumnName("tc");
        });

        modelBuilder.Entity<ProjeListesi>(entity =>
        {
            entity.ToTable("projeListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.BasTar)
                .HasMaxLength(4000)
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.BitTar)
                .HasMaxLength(4000)
                .HasColumnName("BIT_TAR");
            entity.Property(e => e.Butce)
                .HasMaxLength(4000)
                .HasColumnName("BUTCE");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Kapsam)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.ParaBirimiAd)
                .HasMaxLength(4000)
                .HasColumnName("PARA_BIRIMI_AD");
            entity.Property(e => e.ParaBirimiId)
                .HasMaxLength(4000)
                .HasColumnName("PARA_BIRIMI_ID");
            entity.Property(e => e.ProjeAd)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_AD");
            entity.Property(e => e.ProjeDurumuAd)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_DURUMU_AD");
            entity.Property(e => e.ProjeDurumuId)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_DURUMU_ID");
            entity.Property(e => e.ProjeFormId)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_FORM_ID");
            entity.Property(e => e.ProjeId)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_ID");
            entity.Property(e => e.ProjeKonumuAd)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_KONUMU_AD");
            entity.Property(e => e.ProjeKonumuId)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_KONUMU_ID");
            entity.Property(e => e.ProjeKonusu)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_KONUSU");
            entity.Property(e => e.ProjeTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_TURU_AD");
            entity.Property(e => e.ProjeTuruId)
                .HasMaxLength(4000)
                .HasColumnName("PROJE_TURU_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.UnivAdi)
                .HasMaxLength(4000)
                .HasColumnName("UNIV_ADI");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ADI");
        });

        modelBuilder.Entity<SanatsalFaalListe>(entity =>
        {
            entity.ToTable("sanatsalFaalListe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.AnaTur)
                .HasMaxLength(4000)
                .HasColumnName("ANA_TUR");
            entity.Property(e => e.AnaturAdi)
                .HasMaxLength(4000)
                .HasColumnName("ANATUR_ADI");
            entity.Property(e => e.BasTarih)
                .HasMaxLength(4000)
                .HasColumnName("BAS_TARIH");
            entity.Property(e => e.BitTarih)
                .HasMaxLength(4000)
                .HasColumnName("BIT_TARIH");
            entity.Property(e => e.DilAdi)
                .HasMaxLength(4000)
                .HasColumnName("DIL_ADI");
            entity.Property(e => e.Duzenleyenler)
                .HasMaxLength(4000)
                .HasColumnName("DUZENLEYENLER");
            entity.Property(e => e.EtkinlikAdi)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_ADI");
            entity.Property(e => e.EtkinlikDili)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_DILI");
            entity.Property(e => e.EtkinlikTuru)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_TURU");
            entity.Property(e => e.EtkinlikTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_TURU_AD");
            entity.Property(e => e.EtkinlikYeri)
                .HasMaxLength(4000)
                .HasColumnName("ETKINLIK_YERI");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Kapsam)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KisiSayisi)
                .HasMaxLength(4000)
                .HasColumnName("KISI_SAYISI");
            entity.Property(e => e.KisiSirasi)
                .HasMaxLength(4000)
                .HasColumnName("KISI_SIRASI");
            entity.Property(e => e.KurumAd)
                .HasMaxLength(4000)
                .HasColumnName("KURUM_AD");
            entity.Property(e => e.SId)
                .HasMaxLength(4000)
                .HasColumnName("S_ID");
            entity.Property(e => e.Sehir)
                .HasMaxLength(4000)
                .HasColumnName("SEHIR");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TesvPuani)
                .HasMaxLength(4000)
                .HasColumnName("TESV_PUANI");
            entity.Property(e => e.Tip)
                .HasMaxLength(4000)
                .HasColumnName("TIP");
            entity.Property(e => e.TipAdi)
                .HasMaxLength(4000)
                .HasColumnName("TIP_ADI");
            entity.Property(e => e.Ulke)
                .HasMaxLength(4000)
                .HasColumnName("ULKE");
            entity.Property(e => e.UlkeAdi)
                .HasMaxLength(4000)
                .HasColumnName("ULKE_ADI");
            entity.Property(e => e.UnvanAd)
                .HasMaxLength(4000)
                .HasColumnName("UNVAN_AD");
            entity.Property(e => e.UnvanId)
                .HasMaxLength(4000)
                .HasColumnName("UNVAN_ID");
        });

        modelBuilder.Entity<TasarimListesi>(entity =>
        {
            entity.ToTable("tasarimListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.BasTarihi)
                .HasMaxLength(4000)
                .HasColumnName("BAS_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasMaxLength(4000)
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.Kapsam)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM");
            entity.Property(e => e.KapsamAd)
                .HasMaxLength(4000)
                .HasColumnName("KAPSAM_AD");
            entity.Property(e => e.KisiSayisi)
                .HasMaxLength(4000)
                .HasColumnName("KISI_SAYISI");
            entity.Property(e => e.KurumAd)
                .HasMaxLength(4000)
                .HasColumnName("KURUM_AD");
            entity.Property(e => e.KurumId)
                .HasMaxLength(4000)
                .HasColumnName("KURUM_ID");
            entity.Property(e => e.PTasarimId)
                .HasMaxLength(4000)
                .HasColumnName("P_TASARIM_ID");
            entity.Property(e => e.TasarimAdi)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_ADI");
            entity.Property(e => e.TasarimOzeti)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_OZETI");
            entity.Property(e => e.TasarimSahipleri)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_SAHIPLERI");
            entity.Property(e => e.TasarimTuru)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_TURU");
            entity.Property(e => e.TasarimTuruAdi)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_TURU_ADI");
            entity.Property(e => e.TasarimTuruDetay)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_TURU_DETAY");
            entity.Property(e => e.TasarimTuruDetayAd)
                .HasMaxLength(4000)
                .HasColumnName("TASARIM_TURU_DETAY_AD");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.UnvanAd)
                .HasMaxLength(4000)
                .HasColumnName("UNVAN_AD");
            entity.Property(e => e.UnvanId)
                .HasMaxLength(4000)
                .HasColumnName("UNVAN_ID");
        });

        modelBuilder.Entity<TemelAlanListesi>(entity =>
        {
            entity.ToTable("temelAlanListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.Anahtarkelime1Ad)
                .HasMaxLength(4000)
                .HasColumnName("ANAHTARKELIME1_AD");
            entity.Property(e => e.Anahtarkelime1Id)
                .HasMaxLength(4000)
                .HasColumnName("ANAHTARKELIME1_ID");
            entity.Property(e => e.Anahtarkelime2Id)
                .HasMaxLength(4000)
                .HasColumnName("ANAHTARKELIME2_ID");
            entity.Property(e => e.Anahtarkelime3Ad)
                .HasMaxLength(4000)
                .HasColumnName("ANAHTARKELIME3_AD");
            entity.Property(e => e.Anahtarkelime3Id)
                .HasMaxLength(4000)
                .HasColumnName("ANAHTARKELIME3_ID");
            entity.Property(e => e.Anahterkelime2Ad)
                .HasMaxLength(4000)
                .HasColumnName("ANAHTERKELIME2_AD");
            entity.Property(e => e.BilimAlanAd)
                .HasMaxLength(4000)
                .HasColumnName("BILIM_ALAN_AD");
            entity.Property(e => e.BilimAlanId)
                .HasMaxLength(4000)
                .HasColumnName("BILIM_ALAN_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.TUakId)
                .HasMaxLength(4000)
                .HasColumnName("T_UAK_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TemelAlanAd)
                .HasMaxLength(4000)
                .HasColumnName("TEMEL_ALAN_AD");
            entity.Property(e => e.TemelAlanId)
                .HasMaxLength(4000)
                .HasColumnName("TEMEL_ALAN_ID");
        });

        modelBuilder.Entity<TezDanismanListesi>(entity =>
        {
            entity.ToTable("tezDanismanListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AbdAd)
                .HasMaxLength(4000)
                .HasColumnName("ABD_AD");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.DanismanSirasi)
                .HasMaxLength(4000)
                .HasColumnName("DANISMAN_SIRASI");
            entity.Property(e => e.DurumAdi)
                .HasMaxLength(4000)
                .HasColumnName("DURUM_ADI");
            entity.Property(e => e.EnstituAd)
                .HasMaxLength(4000)
                .HasColumnName("ENSTITU_AD");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.KayitId)
                .HasMaxLength(4000)
                .HasColumnName("KAYIT_ID");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.TezAdi)
                .HasMaxLength(4000)
                .HasColumnName("TEZ_ADI");
            entity.Property(e => e.TurAdi)
                .HasMaxLength(4000)
                .HasColumnName("TUR_ADI");
            entity.Property(e => e.TurId)
                .HasMaxLength(4000)
                .HasColumnName("TUR_ID");
            entity.Property(e => e.Ulke)
                .HasMaxLength(4000)
                .HasColumnName("ULKE");
            entity.Property(e => e.UniversiteAd)
                .HasMaxLength(4000)
                .HasColumnName("UNIVERSITE_AD");
            entity.Property(e => e.Verikaynak)
                .HasMaxLength(4000)
                .HasColumnName("VERIKAYNAK");
            entity.Property(e => e.YazarAdi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_ADI");
            entity.Property(e => e.YazarSoyadi)
                .HasMaxLength(4000)
                .HasColumnName("YAZAR_SOYADI");
            entity.Property(e => e.YerAdi)
                .HasMaxLength(4000)
                .HasColumnName("YER_ADI");
            entity.Property(e => e.YerId)
                .HasMaxLength(4000)
                .HasColumnName("YER_ID");
            entity.Property(e => e.Yil)
                .HasMaxLength(4000)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<UyelikListesi>(entity =>
        {
            entity.ToTable("uyelikListesi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AktifPasif)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF");
            entity.Property(e => e.AktifPasifAd)
                .HasMaxLength(4000)
                .HasColumnName("AKTIF_PASIF_AD");
            entity.Property(e => e.BasTar)
                .HasMaxLength(4000)
                .HasColumnName("BAS_TAR");
            entity.Property(e => e.GuncellemeTarihi)
                .HasMaxLength(4000)
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.KurulusAdi)
                .HasMaxLength(4000)
                .HasColumnName("KURULUS_ADI");
            entity.Property(e => e.KurulusTuru)
                .HasMaxLength(4000)
                .HasColumnName("KURULUS_TURU");
            entity.Property(e => e.KurulusTuruAd)
                .HasMaxLength(4000)
                .HasColumnName("KURULUS_TURU_AD");
            entity.Property(e => e.TcKimlikNo)
                .HasMaxLength(4000)
                .HasColumnName("TC_KIMLIK_NO");
            entity.Property(e => e.UyelikDurumu)
                .HasMaxLength(4000)
                .HasColumnName("UYELIK_DURUMU");
            entity.Property(e => e.UyelikDurumuAd)
                .HasMaxLength(4000)
                .HasColumnName("UYELIK_DURUMU_AD");
            entity.Property(e => e.UyelikId)
                .HasMaxLength(4000)
                .HasColumnName("UYELIK_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
