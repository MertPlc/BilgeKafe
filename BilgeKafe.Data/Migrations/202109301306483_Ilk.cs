namespace BilgeKafe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MasaNo = c.Int(nullable: false),
                        Durum = c.Int(nullable: false),
                        OdenenTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AcilisZamani = c.DateTime(),
                        KapanisZamani = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiparisDetaylar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(nullable: false, maxLength: 100),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Adet = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        SiparisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId)
                .Index(t => t.SiparisId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(nullable: false, maxLength: 100),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylar", "SiparisId", "dbo.Siparisler");
            DropIndex("dbo.SiparisDetaylar", new[] { "SiparisId" });
            DropIndex("dbo.SiparisDetaylar", new[] { "UrunId" });
            DropTable("dbo.Urunler");
            DropTable("dbo.SiparisDetaylar");
            DropTable("dbo.Siparisler");
        }
    }
}
