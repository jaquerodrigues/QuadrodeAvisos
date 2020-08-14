﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuadroAvisos.Migrations
{
    public partial class AvisoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avisos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Mensagem = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avisos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avisos");
        }
    }
}
