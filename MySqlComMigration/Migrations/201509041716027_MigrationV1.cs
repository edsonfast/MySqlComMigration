namespace MySqlComMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contato",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, unicode: false),
                        email = c.String(unicode: false),
                        telefone = c.String(unicode: false),
                        salario = c.Double(),
                        NotaAluno = c.Decimal(nullable: false, precision: 18, scale: 2),
                        rowversion = c.DateTime(precision: 0),
                        obs = c.String(unicode: false),
                        id_cliente = c.Int(),
                        deleted = c.Long(nullable: false, defaultValueSql: "0"),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.pessoa", t => t.id_cliente)
                .Index(t => t.id_cliente);
            
            CreateTable(
                "dbo.pessoa",
                c => new
                    {
                        id_pessoa = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, unicode: false),
                        id_pes_rep = c.Int(),
                        id_pes_tra = c.Int(),
                        tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_pessoa)
                .ForeignKey("dbo.pessoa", t => t.id_pes_rep)
                .ForeignKey("dbo.pessoa", t => t.id_pes_tra)
                .Index(t => t.id_pes_rep)
                .Index(t => t.id_pes_tra);
            
            CreateTable(
                "dbo.endereco",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        id_cliente = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.pessoa", t => t.id_cliente)
                .Index(t => t.id_cliente);
            
            CreateTable(
                "dbo.standard",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.StandardId);
            
            CreateTable(
                "dbo.student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(unicode: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        id_standard = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.standard", t => t.id_standard)
                .Index(t => t.id_standard);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.student", "id_standard", "dbo.standard");
            DropForeignKey("dbo.pessoa", "id_pes_tra", "dbo.pessoa");
            DropForeignKey("dbo.pessoa", "id_pes_rep", "dbo.pessoa");
            DropForeignKey("dbo.endereco", "id_cliente", "dbo.pessoa");
            DropForeignKey("dbo.contato", "id_cliente", "dbo.pessoa");
            DropIndex("dbo.student", new[] { "id_standard" });
            DropIndex("dbo.endereco", new[] { "id_cliente" });
            DropIndex("dbo.pessoa", new[] { "id_pes_tra" });
            DropIndex("dbo.pessoa", new[] { "id_pes_rep" });
            DropIndex("dbo.contato", new[] { "id_cliente" });
            DropTable("dbo.student");
            DropTable("dbo.standard");
            DropTable("dbo.endereco");
            DropTable("dbo.pessoa");
            DropTable("dbo.contato");
        }
    }
}
