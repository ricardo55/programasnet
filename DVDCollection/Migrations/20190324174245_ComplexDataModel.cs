using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DVDCollection.Migrations
{
    public partial class ComplexDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActorFullName = table.Column<string>(nullable: true),
                    ActorNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    CertificateID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.CertificateID);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    ProducerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProducerName = table.Column<string>(nullable: true),
                    ProducerEmail = table.Column<string>(nullable: true),
                    ProducerWeb = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.ProducerID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RolName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "FilmTitle",
                columns: table => new
                {
                    FilmTitleID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreID = table.Column<int>(nullable: false),
                    CertificateID = table.Column<int>(nullable: false),
                    FilmName = table.Column<string>(nullable: true),
                    FilmStory = table.Column<string>(nullable: true),
                    FilmReleaseDate = table.Column<DateTime>(nullable: false),
                    FilmDuration = table.Column<int>(nullable: false),
                    FilmAdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTitle", x => x.FilmTitleID);
                    table.ForeignKey(
                        name: "FK_FilmTitle_Certificate_CertificateID",
                        column: x => x.CertificateID,
                        principalTable: "Certificate",
                        principalColumn: "CertificateID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmTitle_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmActorRole",
                columns: table => new
                {
                    FilmTitleID = table.Column<int>(nullable: false),
                    ActorID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    CharacterName = table.Column<string>(nullable: false),
                    CharacterDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActorRole", x => new { x.FilmTitleID, x.ActorID, x.RoleID, x.CharacterName });
                    table.ForeignKey(
                        name: "FK_FilmActorRole_Actor_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actor",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActorRole_FilmTitle_FilmTitleID",
                        column: x => x.FilmTitleID,
                        principalTable: "FilmTitle",
                        principalColumn: "FilmTitleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActorRole_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmTitleProducer",
                columns: table => new
                {
                    FilmTitleID = table.Column<int>(nullable: false),
                    ProducerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTitleProducer", x => new { x.ProducerID, x.FilmTitleID });
                    table.ForeignKey(
                        name: "FK_FilmTitleProducer_FilmTitle_FilmTitleID",
                        column: x => x.FilmTitleID,
                        principalTable: "FilmTitle",
                        principalColumn: "FilmTitleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmTitleProducer_Producer_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Producer",
                        principalColumn: "ProducerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmActorRole_ActorID",
                table: "FilmActorRole",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActorRole_RoleID",
                table: "FilmActorRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmTitle_CertificateID",
                table: "FilmTitle",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmTitle_GenreID",
                table: "FilmTitle",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmTitleProducer_FilmTitleID",
                table: "FilmTitleProducer",
                column: "FilmTitleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmActorRole");

            migrationBuilder.DropTable(
                name: "FilmTitleProducer");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "FilmTitle");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
