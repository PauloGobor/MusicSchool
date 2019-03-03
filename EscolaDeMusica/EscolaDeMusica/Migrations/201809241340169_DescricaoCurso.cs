namespace EscolaDeMusica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescricaoCurso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        Cpf = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        Telefone = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Cpf);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Cpf = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Cpf);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        IdCurso = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Professor = c.String(),
                        QtdVagas = c.Int(nullable: false),
                        ValorMensal = c.Double(nullable: false),
                        Descricao = c.String(),
                        DiaSemana_DiaSemanaId = c.Int(),
                    })
                .PrimaryKey(t => t.IdCurso)
                .ForeignKey("dbo.DiaSemana", t => t.DiaSemana_DiaSemanaId)
                .Index(t => t.DiaSemana_DiaSemanaId);
            
            CreateTable(
                "dbo.DiaSemana",
                c => new
                    {
                        DiaSemanaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.DiaSemanaId);
            
            CreateTable(
                "dbo.Instrumento",
                c => new
                    {
                        InstrumentoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preço = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InstrumentoId);
            
            CreateTable(
                "dbo.Matricula",
                c => new
                    {
                        IdMatricula = c.Int(nullable: false, identity: true),
                        Aluno_Cpf = c.String(maxLength: 128),
                        Curso_IdCurso = c.Int(),
                    })
                .PrimaryKey(t => t.IdMatricula)
                .ForeignKey("dbo.Aluno", t => t.Aluno_Cpf)
                .ForeignKey("dbo.Curso", t => t.Curso_IdCurso)
                .Index(t => t.Aluno_Cpf)
                .Index(t => t.Curso_IdCurso);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        IdVenda = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Cliente_Cpf = c.String(maxLength: 128),
                        Vendedor_Cpf = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IdVenda)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Cpf)
                .ForeignKey("dbo.Vendedor", t => t.Vendedor_Cpf)
                .Index(t => t.Cliente_Cpf)
                .Index(t => t.Vendedor_Cpf);
            
            CreateTable(
                "dbo.ItemVenda",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        PrecoVenda = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Subtotal = c.Double(nullable: false),
                        Instrumento_InstrumentoId = c.Int(),
                        Venda_IdVenda = c.Int(),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.Instrumento", t => t.Instrumento_InstrumentoId)
                .ForeignKey("dbo.Venda", t => t.Venda_IdVenda)
                .Index(t => t.Instrumento_InstrumentoId)
                .Index(t => t.Venda_IdVenda);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        Cpf = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Cpf);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "Vendedor_Cpf", "dbo.Vendedor");
            DropForeignKey("dbo.ItemVenda", "Venda_IdVenda", "dbo.Venda");
            DropForeignKey("dbo.ItemVenda", "Instrumento_InstrumentoId", "dbo.Instrumento");
            DropForeignKey("dbo.Venda", "Cliente_Cpf", "dbo.Cliente");
            DropForeignKey("dbo.Matricula", "Curso_IdCurso", "dbo.Curso");
            DropForeignKey("dbo.Matricula", "Aluno_Cpf", "dbo.Aluno");
            DropForeignKey("dbo.Curso", "DiaSemana_DiaSemanaId", "dbo.DiaSemana");
            DropIndex("dbo.ItemVenda", new[] { "Venda_IdVenda" });
            DropIndex("dbo.ItemVenda", new[] { "Instrumento_InstrumentoId" });
            DropIndex("dbo.Venda", new[] { "Vendedor_Cpf" });
            DropIndex("dbo.Venda", new[] { "Cliente_Cpf" });
            DropIndex("dbo.Matricula", new[] { "Curso_IdCurso" });
            DropIndex("dbo.Matricula", new[] { "Aluno_Cpf" });
            DropIndex("dbo.Curso", new[] { "DiaSemana_DiaSemanaId" });
            DropTable("dbo.Vendedor");
            DropTable("dbo.ItemVenda");
            DropTable("dbo.Venda");
            DropTable("dbo.Matricula");
            DropTable("dbo.Instrumento");
            DropTable("dbo.DiaSemana");
            DropTable("dbo.Curso");
            DropTable("dbo.Cliente");
            DropTable("dbo.Aluno");
        }
    }
}
