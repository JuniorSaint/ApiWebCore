using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class cep_city_uf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uf",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Sigla = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    UfName = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CityName = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    CodeIBGE = table.Column<int>(type: "integer", nullable: false),
                    UfId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Uf_UfId",
                        column: x => x.UfId,
                        principalTable: "Uf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZipCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZipCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Street = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    Number = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZipCode_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Uf",
                columns: new[] { "Id", "CreatedAt", "Sigla", "UfName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(6970), "AC", "Acre", null },
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9480), "SP", "São Paulo", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9480), "SE", "Sergipe", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9470), "SC", "Santa Catarina", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9470), "RS", "Rio Grande do Sul", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9470), "RR", "Roraima", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9460), "RO", "Rondônia", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9460), "RN", "Rio Grande do Norte", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9460), "RJ", "Rio de Janeiro", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9460), "PR", "Paraná", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9450), "PI", "Piauí", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9450), "PE", "Pernambuco", null },
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9450), "PB", "Paraíba", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9430), "PA", "Pará", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9420), "MT", "Mato Grosso", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9420), "MS", "Mato Grosso do Sul", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9420), "MG", "Minas Gerais", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9420), "MA", "Maranhão", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9410), "GO", "Goiás", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9410), "ES", "Espírito Santo", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9410), "DF", "Distrito Federal", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9400), "CE", "Ceará", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9400), "BA", "Bahia", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9400), "AP", "Amapá", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9390), "AM", "Amazonas", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9390), "AL", "Alagoas", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2021, 8, 11, 13, 29, 1, 169, DateTimeKind.Utc).AddTicks(9480), "TO", "Tocantins", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("2bcb8b73-3d96-48f3-8fd2-8ec12bb72e6f"), new DateTime(2021, 8, 11, 10, 29, 1, 171, DateTimeKind.Local).AddTicks(5090), "administrador@geral.com", "administrador", new DateTime(2021, 8, 11, 10, 29, 1, 191, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.CreateIndex(
                name: "IX_City_CodeIBGE",
                table: "City",
                column: "CodeIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_City_UfId",
                table: "City",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Uf_Sigla",
                table: "Uf",
                column: "Sigla",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZipCode_CityId",
                table: "ZipCode",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ZipCode_ZipCode",
                table: "ZipCode",
                column: "ZipCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZipCode");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Uf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2bcb8b73-3d96-48f3-8fd2-8ec12bb72e6f"));
        }
    }
}
