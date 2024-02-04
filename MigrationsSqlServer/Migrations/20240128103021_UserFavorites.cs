using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationsSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class UserFavorites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Favorites_Customers_UserId",
                        column: x => x.UserId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favorites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0032497d-8b96-4806-986b-377b7dec29db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("004d4520-1db7-48ad-98dd-a3691409a9ec"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00cfb94b-be82-401c-8f39-060883bf469c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("018a6515-43a9-471d-8238-bd2d62bd0677"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0197a8a8-f9d5-4665-9f66-5f1cc2d6567b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01c0e09d-f897-49af-aa21-8d89edb2994f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02773ce1-8359-400d-9fa1-eb187184ab4a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0282e57b-6b86-47d3-8c35-c8b44b8a3434"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02d497cb-625d-4bd3-ae06-ab4dd1555698"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("031dba15-d01f-4ac6-9e3a-8b525d65be73"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04378db7-1072-40ef-a8b9-ac33b15c2008"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("048aec57-4c8a-4a6b-8efa-10692a745c12"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0503ed8a-d994-4327-9cf4-be51b929b52b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0519d6d1-1402-4cf9-8360-cac307ad2718"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06af60aa-0609-497b-ae71-6f87fc517b20"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e22a22-af51-4281-bee8-dd4526deb0ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("076bb637-5a3e-4f08-bfeb-4ff9fd9f587e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0792fc73-dba3-49e7-93b8-043dcd6cdf77"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07ae9609-8b2e-41f7-9f44-b316f89254f7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07cf369a-bea0-4493-be84-db09d65d577c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07d9b59c-5933-4890-b2dd-72cfb808a10a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07e1005f-7efe-480c-9cdb-2e4460378a9e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0810b0aa-d347-471d-8343-9ce3a0f22431"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08298e6c-60fd-4857-9d5a-db0420f4c01e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("085c8847-af2a-44c5-b0c0-b00b5ea07e8a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08a53539-cb45-446d-97df-ec73fa965b93"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("092ad296-fc99-45ed-8137-8c83117c0fc5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("093bc13c-2ce7-4152-a371-523bbcdf5bd9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("098d02f7-ecac-41d3-bf23-d971f4edbeab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09b860e9-5a34-4234-bca3-795ca0b5e68e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09cc6c3a-f3f2-49a0-9ec6-c526b625e813"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09de8f5d-47af-4513-8520-94e28dce8488"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a1ce5c7-3e03-41ce-bf72-53f92277a9cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a3aa2e6-fdc6-46ae-83d4-471a1910dcee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a546239-396d-4cc6-b99f-3761e8f88f8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a5c55f8-4eb8-424e-b54b-cead2eca099c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a8ac04a-4344-4558-ac1b-b4a714522a73"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ae356ea-c2d7-4426-b355-3984eadee0e5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0a1eb1-d441-4bfe-8222-60c7ed8fe419"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0b3de3-9246-4349-a532-702eb6b41200"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0e6ddc-8b2d-4f58-a668-725cb7267899"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b172546-05e2-4715-be78-5e57484928dd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b34e4f8-e7d6-452a-bfba-804090d9035a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b75edcc-d3e2-4f67-9a9a-d3252ece882e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b95c6cf-c848-4e7f-b242-1fd37ce5a8b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d0f6323-796a-4bbe-8d73-1282350d6de4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d1bc95f-92f0-4dad-a552-c0f51c888d37"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d31f86e-5bc0-4757-a8a9-8c2a658c98db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dae9717-fafc-45b7-a6f9-7628e354f366"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dcc7aeb-e31b-4392-94ad-b250e21fd3ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dde1d77-191e-4b8c-980a-52a178e2bc4a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0df998dc-f850-4cc1-a1a5-5cf071fb000a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dff4984-97ac-4d7f-be18-c534eb01b36f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e1916d0-8127-4279-b8f4-eee6564a2ac8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e1c975e-915c-410b-860d-7cefa2f2cf2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e35211a-4731-4a34-aa69-12f6c8a3e58d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e4ced63-53bb-4a99-afea-c56a8ac943a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7b0280-9cf1-45c4-8941-1bc2f20ad05e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ebe3097-28f7-4017-89ae-c3446269f46c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f74096a-3114-4eee-8384-dca37feab9bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f8497a7-e086-4d0d-b427-376ac708509e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fa3cb9d-75d2-4c98-803a-7ced41dcf0a9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fbc5216-88f5-4f12-8f01-085bd080f5fa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1043d26b-e397-4cc8-8c21-001f89ccdc0a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("106e631c-d051-4c32-b0fb-998e4e2fa24c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("108deb24-430f-4efd-b589-a794cdcd01cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("109db990-c429-4f8e-8c07-29ca7691f674"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10bb6d69-89ec-4291-84e6-4ee873ba49c7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10e31139-aa28-41c6-80be-373f4cb79993"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10f58454-ae2d-4e34-8d6a-7fc388abb820"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11389371-4613-4421-8c96-1ab81cded836"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1171b951-8b4c-423a-87a5-4e345991b14e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11cb8d8c-26e2-4da1-a3b9-7b6fe9dcd24b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11d429e5-9eff-4ad9-aa9c-3d70f45917e7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("122ca4d3-51d1-471c-b2cd-873eec91aeeb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("123a787c-9068-4a33-830d-0c0593a8ffbb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("123ddbee-8e00-4e02-908b-4148fe25b663"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("126b15c1-4d38-4220-a06c-4bd6fd51c853"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12af7390-2070-466d-a973-abf8fd79717d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12fc5cdb-cc30-4863-8050-b3ac1d55b221"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("136075b8-c945-4c77-af49-ae4fea7e2718"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("137ab7a3-7cef-45e0-bf8a-14bd9eecef68"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("139d8ea7-58d5-4832-b68b-5f0e62c0e3cc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("143e1702-c166-4ccd-b515-2aed6f3685ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14e594bc-a4cb-4421-8fbf-e2b14a1149d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("151d7cca-bb59-4690-b0b9-13f42523d5d0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1578de0f-a853-493d-b563-550aa0a281b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15e4637c-ae50-436a-8baf-6e299efcd06b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1625166e-5f56-4407-a580-390ee5045b49"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("166e07e9-088e-4fe0-8dc9-4b1c1ba4bfae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16c7961f-cdac-4b46-a4f1-12207a82e39c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17145a35-071e-4c71-98d1-b94f577a07a8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17177d8d-d337-464f-b115-9f1d9d6dcc6e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("174adf1a-54f0-465a-90b4-1d549fd9287f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("174dfe8c-098e-4726-a585-bdeeb4d75047"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176a586e-f34a-4887-9b49-778620a23f50"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177939ed-ed6f-4ee1-a578-f1dff65606c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18f46397-b731-4e47-bcf6-5a35d60f1240"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19347b6e-b95e-4ef4-b0ae-c6b49a05c9a5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1951f320-b2f6-4402-916d-549d8fac9021"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1977e58f-2fa2-4ed0-ac7e-052b9c99d594"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19790bd1-cbee-4544-9bbb-f1834d8f55db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19f17cd3-0da0-4d61-8ead-a2ff7dd5b6d5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a20629c-e2f8-43c2-866b-5169be765f64"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a4ef664-7d04-43b4-83eb-7a829443fd22"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a6df83b-e54b-45f9-a712-caef35095e29"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a9b27e6-61d8-4234-b9da-d100da1f9a2e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b374a39-3415-4aa5-abb9-e1f86a1a11dc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b5dcb89-6c6c-4c2a-be1f-3862bcb4c852"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bc1d18e-17a7-4691-816c-5a38adf41f27"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1be61044-9378-4b20-9a81-856fcd30b84e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c8efbcb-8c8e-44b0-92df-d4ce19ca9aca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ca4048e-5572-4b39-aa1f-d2a378351d16"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cfde542-3b36-4a3c-89ce-e94f90e7e6e7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d385d73-1b1f-4b76-a3d0-6b89a1a67c58"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d8730e2-c4b5-4c45-b987-7b9b84c977d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1db5d338-a83c-420f-961c-bd43e41ce6ad"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dd91a56-5f52-40b8-8ea5-44c3bdbac96c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ed54d15-34b1-4a45-95f2-78d684973990"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ef73995-a12a-41b5-9c8e-979da8db49dd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f15bc2b-6ab6-4607-b8ce-52cd8534cdae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f31f22c-4192-426b-b0a3-a0ebc3af2e75"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f3cfcb0-5f8f-41ed-829c-2a9cb9eb84c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f41300a-c275-4616-8422-6f70d17be6b3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f49dcea-8d80-4a4b-b119-04e2d2e5a25b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6542df-d748-4742-b401-9aa095698e5b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6a873d-4957-4859-8a50-c618d64ff456"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f99ee26-6a65-43b2-a539-7b751da241b1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1fae1925-1c49-48c7-875f-292acde2df12"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("200d6c87-8289-4fa0-907e-abba46440ae4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20270d3d-9a1a-4ab1-9f34-411e4b565245"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("202a01c6-c888-42b8-bd7e-d417e7c80581"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("206d6cb1-d0be-4d9e-ace7-623ace7b90b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208ac801-78bd-48f0-8ed0-690ded0b04c1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21052533-4987-40e8-a64c-7ad9ff62939f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2161c6ef-a38d-44a9-a2e5-0b52bf2147f1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2195f8ab-3ea3-4f6f-8855-c8889786e682"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21d28bac-e8a2-4dfe-ad92-b8cda509f6f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("220f3315-33bf-4f2c-b051-4288e8caa9bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22297355-a788-4ef2-bf36-99982489c1ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("225e275c-6e72-468b-a778-5c19d2379cbb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("231fea01-02d7-4888-b5d6-f7641ead6e19"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23332688-ad0f-46cb-93ff-4500c6633492"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("238270b7-0722-42c5-9f70-29d16232389e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b25e22-68a5-4317-b5fb-238e861cd45e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23e962f2-0a8e-4d73-8227-11070c4560d7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("245ea1b8-3b9e-4984-8e46-7ae9e6037dae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24a9f1d5-3fc0-47f8-a6d4-52453133fb8c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c03bd8-55be-4361-b543-da1b0f57ee9a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24ff6e46-d376-4100-9672-264319c40677"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("251d69a0-7a2b-484b-bf42-e5ad09dd976d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2556d805-b77a-4055-acb0-4a0188456adf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("255980f2-36c2-4998-9536-04d6b3474086"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2579f878-f76e-4a2d-8acd-b3361bdc0613"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("258ffa27-b7d3-411d-8897-d0a854acef9f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25d2c301-2cca-4001-a21e-6ff0a49a4e12"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2605c771-2b7e-4330-86de-9ae809249a1d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26145733-d5a1-48b0-a1db-f7b51907b2ef"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26388ac4-dd20-47ef-b97c-432eb9be718a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26825586-4f93-4699-bdc9-b5fa1ad765c6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26b4e612-30cf-4298-a8c4-413cd2dfb2b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2765e173-babe-43e9-8664-df3299217e3e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("277c1db6-1321-46e8-8009-a8cf66ca46bc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27b7b295-5f64-4b1c-9008-70a713470b2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27dd431c-5a56-4212-b1ad-5c654649e09f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27e3f38d-8579-427f-b98b-a30ef725e8f4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("284d2058-bf48-4f37-add4-3bf4d3cf7102"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("284fcc9e-d925-4ce9-aa6f-66f63b116fb7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("286c507b-952b-4f59-9d54-3261904031f2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("286c7917-c10b-47ed-ad55-66e97607494b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28afce44-5891-4579-9594-71b5cb2714f1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28c355a9-4c1c-4504-bf47-1ce901978364"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2950d433-bb20-4370-baec-1616fce97f8b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29f7d229-32ef-4668-97e9-822243caa274"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a05407d-7ea1-42fa-8cab-1cbc81359aa4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a48296b-ff03-4901-bf3e-03a6e207fb86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a5d22f7-d243-4200-be42-99aa0e85b38d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a7cb963-b9b0-44ab-9a8a-f35b5537de87"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2aa26e2c-407b-4f49-81e5-28395de74624"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2afcaf0f-532a-4c36-aa0a-e91e739955f2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bba50ff-b65e-4cc2-a17a-074d5d89612c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bdaa253-5a2a-47f7-b7e4-aaaf0433fe42"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c0e77b6-a54c-4014-bf51-a90b1ee5fd47"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c4f8be4-8393-45b9-80b8-6030e3b9a4e7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c5714d0-6fb5-4e1d-abf8-7d9ea4b15cd7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c625925-ef3e-4545-87f8-609ca021061f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cd9747b-8325-45da-92b6-c01dc43c8675"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d077109-6b33-44de-8e27-62e3ce694f23"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dab82f3-fb9e-4c81-a39f-cc0f874e0a86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2db9c650-ef03-4ae4-933f-12c253a21edf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e179cfa-7570-4684-b810-e5054f287b1d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e3ece6f-71aa-427e-addf-723c60e238c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e5167f4-ea19-4180-85ae-8ef36aff53a1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e8ff1aa-0f81-4001-9b68-f8536a615dc6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2eb1bb02-9374-4a54-a8a1-3e73a81b4611"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ebcc0ad-cc4b-4ecc-9019-2d14c3567207"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2eeb47af-55ed-4b1f-8079-2ae2ea9307a2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f70464a-5259-4a91-a40c-0d967c101774"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fb65a17-3212-4bb6-9a7c-6e365d00884a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("305cb84f-f3e1-487f-84ae-e12242dcc4ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30b60447-1543-4f69-8b80-bc514138997f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30e08403-3479-48d3-9dae-be2a6aa01c5c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3131fd82-e6b3-4ae5-bef6-80aa974d7d91"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3167036b-fb20-4d1c-8d62-07097ddd7418"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31bb91bf-c20a-4c49-b125-f3c9cfb2464c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31c8fb68-866e-4fd6-ad95-3ab3b90a4572"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("328a04a0-0732-4945-b358-6e6d17378bd0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32c003ad-1cbd-4b07-962e-0e4e38f59fbe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32e4e467-5c7f-4646-8d39-45a2353aef55"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33653f46-a2de-4afb-bedb-8997ab6dbe4f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("336e221d-df82-4ca8-acd9-b1c531a13ac4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33e2ebd6-e013-4b60-be6e-e261c4e2485d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("340cf8a0-a74f-4e2d-a5c8-56c0425cb317"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("343b4117-fa3f-4668-982a-ad646a94d858"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("347ca935-5221-4cab-8ac0-628f04d6614e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34dabd04-2800-4eae-9b01-41e1873c195a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34ec56aa-5f6e-48a5-8531-b0aee6f3e211"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3519337c-0020-4cfb-8fe5-9f70977ef43d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3599d907-6c00-4578-b569-365f4360b9ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("366d4078-7bf3-474e-a0ed-f44a65d21245"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36f8bfac-e8a5-4f84-9460-b4f2e71fe63c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("372a9fa5-f37d-47dd-9ff7-148d970386f8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3737fcdc-797b-4df5-a5b9-2c577644f518"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("373d9110-9004-4ce7-ae09-9e29b5ed6818"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3783af9d-e63a-4e62-b623-34486bd8364a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37d5149d-3418-4a28-9fbd-5d2c8a5d012e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37e852bb-a398-4fde-8cd0-54b21d4c7c4b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37ee17ec-1fcd-4d51-b104-d4f377e2726b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("380532fa-b7b0-448e-81f2-f53f631b6fd4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38422627-ac54-4d24-b683-f3486a8aadae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("386ae6a1-9d35-483f-8016-2e99f1e3583b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("388905c6-a90f-4e0d-8714-7efb9f64e10a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("388ed71a-0da6-4413-967a-3258428a24c3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38b67a68-7466-4b6c-a132-ddfd48a368af"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38bc68f5-21e8-449c-ad59-093d412b255a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38dd4a49-f1dd-40f9-bb5f-1dc2bdbc062e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38e64dbb-b6fe-46df-b3a7-75fa98dcfdfc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("390dc0be-5c2a-428b-a868-320f0c9b2bae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("391fb77d-fd83-45fd-92bb-058a6453dcd0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3926eb28-453f-48a8-a264-1906b904ecc6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39784d63-d02c-45df-95f1-a7493c09ba30"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3aabc5e3-65a6-4dd7-9f71-c4a87dd4badd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ab5bf3d-d812-4b7f-a9c1-6e3ba4db9126"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3adab313-b6f6-4d50-b2b4-a3beb77f806b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bf6f21b-7c69-4451-991d-25294e4818fd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c12b40c-146f-4752-ae7e-ec8fe6b3ba89"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c6b6e40-87ad-4126-a91e-4dc8bc2f5a7b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c9f9438-5727-4bb3-bebb-9fb700ebd2f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cb598e6-c6ed-4887-bd03-257d7c983876"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d8db475-4e1e-4cd5-aa28-109d69b1dffc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dd21acf-5194-4f49-897a-e33f03d55aba"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3deb96bb-6519-4f17-9bfe-cb78195a8dd7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e131ece-f768-487d-b0ed-e27cea8e4f7c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e16acd5-dca6-4d01-bd9b-96de0eac5212"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e2f5478-c288-4cb7-bb90-dcf865daf78c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e6216eb-8be8-41d3-a210-3f65b1a2ff66"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f064f45-9c58-4f69-abc0-64176e125c8a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f09ad30-392d-4c50-b99f-5ebb35be8ecf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f0ef02c-2869-4626-9a93-5345ddb62466"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f29236e-cc27-4c14-b212-9152ff739f62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2ba015-299a-4329-9853-c24aea7aea0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fbf5385-77d7-45f8-b2f5-4791215a6e4b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("401c5aae-ca98-4277-8b0a-5a20fe111619"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("403a38e3-495e-4dfd-bb3d-3938e841aa01"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40427032-5241-4597-a924-a844ca50f810"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40bbbf04-633c-4c79-ba82-2e67c3340ee0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40d3940e-0fc2-4f1d-8e18-16d447bc8337"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40fef1d7-a82c-4e99-87fb-a1872c94f7a9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4106e93d-1cae-45fb-8e6d-6fe0d0bd8772"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41098c1c-1ee0-4216-bbdc-03012ee5f619"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41592956-88c0-41f1-80c6-c269beac12dd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4178a2ea-afd5-4ea7-a787-2ef200cd4e98"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41b21c31-d144-425e-9028-7794eef589d2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41ea509d-7b9b-4006-b682-c1ae058bf148"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41fc2429-c98b-4733-9517-e3244c7b120b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4244700c-5f0b-47da-a519-8773c62df52c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4264ba81-8c3f-4fd5-bc77-925886ae9e8c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("427c7fc7-adc9-4f93-83cf-dc9684bf84e1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42816e21-3375-4c73-9472-6f6719ce1994"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4295ced6-ef7b-4e95-9030-fb5c799031de"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42ed6310-cbae-44e9-acb8-d1b94b93503c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43a0290c-5006-4099-96bd-2aa52dc30924"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("442d1d2b-23b3-4748-8e7a-0e5c1f547791"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44ae1077-43b8-4e3d-9de5-ecc704ce8496"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44afc871-58bb-465b-8d7f-86c63f645c91"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44e9d546-ecbd-45db-9603-660fd186f44f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45127df8-2eb0-41e2-b89c-f9e37face533"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4584e878-c766-4946-99ae-6c60c1d5f334"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("461e3ee5-1b2f-4c1f-8459-f8be72761a0e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4629a669-ee9f-47bd-87f9-09a1ac1ce8f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4636d146-8793-49dc-8602-063770db5089"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46de4ea6-c366-4b39-8864-f0640e13abe1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4718b0a5-e6a7-4606-9421-015ec02160c6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("471d4fc1-c344-48e4-a8ec-f7f7050ee238"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4778523b-507a-4c94-843c-98403193c8fa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("479b0068-e03a-4757-aaac-abe9953a8ed1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4888ee6c-6ff3-415a-8782-f980faed4d41"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48e243d0-3e73-4562-a984-90792b98b160"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("498a3148-4e16-4e27-a16b-d6a88ad4e4e0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a6e5e1a-1fd9-4b17-a40e-aff6b9bb745b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ab288e2-60b6-40ea-833f-045964f29cc3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b53e27d-4f01-46ba-b7aa-f68833bf0347"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b9b6e4a-854d-4a65-a6fc-58aa4cdf5d38"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bbea68b-cea3-44dd-9da3-6fd4dec28bf7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bcc3b90-fe46-4303-9eac-fa30aeb2be67"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bea9356-a8c6-48f9-b28c-6da92805a219"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c16ec58-79c8-4337-b05b-6fca14be6c96"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c56828c-7b3e-423d-af76-cd382e7cb071"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d17da67-bb02-426b-9352-872a2b6b7221"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d39be5c-4838-4af7-be47-020c14d2788f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d7e9a4b-7a74-4770-8f7b-dfb80d513e43"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ddb3727-847d-4934-9d96-d4ca8f155e8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4deb0724-6c9d-4db1-933c-3213185ac40d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e017fd8-f9a0-4bf6-8ece-7df7c5f14d48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e089db8-feb6-4069-a42d-cce7ed221355"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e3f79b4-a5c5-46e1-8289-2cd606ee389f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e4a08d4-edc0-46a7-956e-8886f2fa70f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e9a5cd1-2f51-4ce4-9355-fdc52f62e6ea"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ed1bad9-b352-4bf4-af8d-53182603bc99"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0e6b7e-104e-4e03-82ec-7059191b5533"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f77168e-252a-424e-9ac5-bde9e041b353"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f812544-9929-48bf-82a5-6f5c7dab20c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f9e77e3-db8c-48ba-9a39-e59273e951f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fbb3eab-3e09-44f2-b978-5c251760eb89"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fc85375-968b-4bd2-aa80-50bdb36db320"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5019c726-ad08-4c50-92d3-82d505d8fe2f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("506bc753-8847-4a1c-a16e-633c25947904"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50f58d9a-77a8-4754-a448-221289923bd0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51055135-5a99-4584-b9dc-cb7a4f34e398"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5135b95f-7acd-4b5e-a65f-ef1dcaf29791"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5187187e-5acd-4e15-bc91-0bb5d3a0543c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51ee1cf6-f72b-4151-9261-e37fdb90816f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52218408-71db-4642-ba58-6104a92fec74"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52342fc5-cf8e-4210-8f48-b3625a137c2f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("524d9006-0a89-4fb9-a799-c1560d7c3b28"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("529339d5-ebbb-41e1-9770-5dc4a747fc75"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52cabc26-d159-4a6a-8191-54c8e69e41bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53bdcbd7-a3b8-4d45-b5d8-93b53f8b4913"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5413bb90-b857-4ea5-8902-ae170e2038b6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54e87c39-383c-4fd4-afe3-ebe5764583cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55599ead-9408-4772-ad0a-8bc6b2f7c84f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("557a417a-ee9e-45d8-b18a-14aab221d22a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55968491-3a72-4cca-8e44-5923915a2370"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55a9adbf-c7ab-4d56-b00f-ac83b024fc9b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5620d05e-175c-4d56-b3e1-90dd363be9d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56328e44-88f5-4504-a041-6b5d4cc17226"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("566325ef-98eb-4c9c-84b1-fe2319e97c4b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56673be6-6950-4015-aa16-96db27641cd6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("568b2484-869a-49b9-b526-e4272295ccd6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56e47f8a-5a50-45ef-8d81-cfea14741e5d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56f68871-d930-4ae6-ace5-15ccafd25d4d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("570d1f44-9310-4a72-af6d-03940fbe693f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57762ba8-8558-44ea-820e-501650fba948"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57a0911d-a2ec-4060-84b8-d86993d1b504"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57a3c22d-0941-4d4b-bab6-1661be414ed6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57f981cc-8467-4c2b-8715-b3e2311580f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57fb9cc9-7260-47c7-b20f-fbee310b7363"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("586a90b6-8876-407e-9cde-f53fe1a9079a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58bc6eeb-cc1e-44a5-aae7-21acd1373ce4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59922ec9-3a1b-42f5-bb25-9c044021e819"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59fb02d7-39c1-44d7-9f7a-9a839dfe15d9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a22fad9-222a-4b66-9f82-b91cb1c20eae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a77fab9-3f00-46b2-b8e1-e552fa31e596"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aa72556-2cec-443e-920a-f95c60949c01"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aef90b6-32f3-415d-ac9a-ed1cbd9e0071"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b10baa6-77cc-4764-8d70-07d8c5687aa7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b4c4940-d9d8-4cc3-8dd4-152b2f2e5e88"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5be324a6-b9d1-46dc-adc6-d38773f45e47"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c38b9ba-9509-419a-ab3f-53d7908cf855"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c45c652-d2f1-420c-b730-a9e1fa5a32f5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c67b787-1179-49d3-9c64-21b433f7b6b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cfede72-a343-464d-8125-eb80f51d9ec7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1b374f-a850-433e-a849-a6aa0ed690fe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e40cf1b-6089-4409-a0e6-a84e510e3896"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e69cc09-a34a-4ec8-b0b5-74dbc60dadac"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e9705ba-0c42-4312-bc1f-65a91b79b384"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ea7f7af-7673-4b2b-948f-bc759a55346f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f2979a4-ef18-4fd5-b63d-5a290305baca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f3fd848-a56a-4655-aedc-6b1f282f86cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f52f3f9-0819-4b7a-a461-942d9ef8a5ae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60e6b0-e0c3-4ad2-94ce-7f33972d9003"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f64f596-3d54-4c54-8795-b76b84755685"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f69f22a-6459-437a-938c-33b8c8f05345"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f95eba6-2bb2-4923-9aae-dcea38a13336"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fc6a44d-01cd-44cd-a946-0caabce44655"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fd74fa8-a8a4-43ca-b4b9-56299e7e3622"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ffbebc2-81d8-4987-b8ec-fef6369fd38c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ffd5fcb-4c6f-4797-8975-0651b90735e4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6049ef00-7125-4a3c-afc7-f137d756e3f7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60721ec1-5299-4f8a-b53b-2988147dca9a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6120a74e-a2bd-432f-b3ee-3e098b26276f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61c9a15e-9d4d-44e8-bcb3-2009f6fed06c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61fc5a3d-ee90-41f5-9e6b-a6d2cd64972b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6226d3e8-47ea-4107-b06f-a0da63960090"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("625437ba-fa22-4f4c-8ba3-c557509a3b62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62a3daff-d541-4bfd-8517-872c2e796ee2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f52ab2-2214-4da2-b858-f827fcf17e8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("636509ed-9301-4eaa-9713-eb03404a52ed"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6396d9ca-7ddf-42d4-b496-18468f1f8653"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63db219c-ba0d-42db-bd13-116dcfee96a6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("642860ff-835c-4d45-9e94-62aeb606ec86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("645ee195-e337-4454-9963-fa74c020da21"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6487425c-08f1-4ce1-b160-61579c4e55df"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("650da18f-fdbd-464c-bb6e-306698047288"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65453352-1250-4981-8c77-ebe7707f440b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("657c0aef-9665-41d5-a891-ffbb2bdcc380"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c5df06-c23b-420b-9a2c-8160a2daf859"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c9d072-648a-43a3-be5b-45a29047444d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6622f536-4912-456d-acbf-aa061c4769a0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6635a271-757c-40cd-9516-01fce5288907"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66693d79-5968-4d37-b7ad-26b1f76d311d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66b00af8-13e4-492c-9b1c-8ef3fcfdec5b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6709af28-1c2c-4370-a878-c7d64e94c4b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67c1fb63-0e61-49a2-8b4c-87beb8c3f9e9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("680052ef-60ff-44a3-b1b7-a65b98e8d701"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("697d24c2-9a3d-467f-beba-00ce320a45ca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6995f05e-ef15-44f2-8fa4-0ea1b8174b70"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a5aa40b-124d-4306-9858-3e14d021fb86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a7b4e3e-f8f7-437e-8806-83fc03f27293"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b2b5f26-62b9-4613-97f2-d1929998da9d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b346627-4c6f-49da-b8d7-0343e9495fff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b4c05ad-251f-4179-908a-b9c17dbee3e3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b529526-a9a4-4f35-9617-66f8b882bb51"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b53ef34-26cf-4a0a-b4db-7637dec181d0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b7c814d-e0f0-4484-a687-9210e65ac69f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b9a381f-dffa-426f-8f9b-1a054d827a1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bc63621-ed5a-418a-b201-3f23dedb9fa3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bf2a200-f42b-4075-ae5b-a91b3b50a3b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c1c6b94-8d53-45fd-b765-c321da356adf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c41b321-fc23-4095-9a95-6fd768277417"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c53c07b-e4e3-47f3-8f1b-4a4e779277f5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cee756e-bba6-4942-a7d4-0165773d21e3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dcf220d-5916-4cf1-aeaf-2dce93c59a1f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e1a6089-9343-46ab-9b93-ae7d0fccc752"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e3da614-2674-493f-8f7f-a4094ccb8a8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6efa8c95-a768-49b9-a98d-359aba65aa3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f324b7c-99da-4933-bb49-12b30bde1ab9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fe28582-79d3-466d-959b-96279aeb95d9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fee6906-64f7-41b0-8162-81cd5e7ec2fc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("702f15ed-8fa7-4c2d-86aa-b6c7ac521739"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("704eb4eb-bb31-4e43-b5e0-d8a95884dff4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7065242c-7f2d-4ec8-8f65-1a87131e9085"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70d06f6a-9a1f-446c-9088-0e7c56fae870"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("717b71fc-6468-47b3-bc3f-9504430dd5c8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b2b69a-1b18-42cd-b3e9-49b4a74d985b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b39282-3ef4-434c-88a4-f8fe53aeb7f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71c46acb-f36e-49f8-87d6-45a80f48b0e9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71dcb3d2-785b-442c-8bda-796d6dd14dbe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7221ac57-b0df-4792-a231-125583e16089"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("724d9b5f-4f62-4653-b5b4-d6c4a221e9be"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72da4113-1530-4383-9414-c10f9ad2de66"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("734f6281-f438-490d-909d-0e6350108ef0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("739c9950-1665-4362-a1b4-a7a7318d3de8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73c64542-6d77-4e87-80ad-7c646a467e6f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73d1cd1c-ae2f-4359-bed6-f65915f7f471"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("746f2bd2-f9dd-4456-b113-1b8079e9c4d5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("747f0803-aac1-498d-ac38-6bf9a256f353"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("749a939a-c369-4c0d-af45-17d913dd3e1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7503c2a9-c6c0-4e67-b114-027fef7575c1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75519efe-d186-4633-99ed-5868b15c7e1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75c193ec-f7dc-4511-9f42-aade8f811513"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7661e0be-af83-47ba-843a-771084a32019"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7737fa11-6373-4f8e-952a-cb46b2e0c507"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("776360f8-6c29-44f1-8a86-692171333c40"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7765f961-e8ff-48ee-889b-ebae92074903"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77868af2-fd76-4439-9970-0f5eb87c8a11"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("778c9a14-f4e9-4fe4-80a2-325d93c9c368"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("778e7d7e-d037-4337-b48b-b8b094657778"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7826017d-69a9-4f84-9e52-3cca427e2f13"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("787cabb3-429e-4589-a557-c232803e6a6f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78ec1e41-f932-458f-ad49-fcf36cdeea2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("790e3eaa-832c-44f4-9e44-e824ecc957b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("793b5dba-da4f-412d-affa-3b12c7cd0b9b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("794858e1-1841-470a-bbe4-ee64ddb7a3b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79833465-e45a-473e-bb70-84b7270269d1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7992f58e-b0cb-4636-894a-737567e4b354"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79dd45c8-6abb-4cc1-a6d7-176fcb4dba3a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a254063-9b37-46c5-a372-dfa2880d9cb4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a32b3b5-984a-4b3d-acf8-cc90e39d43f0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aa17d48-9920-46f9-b5b3-c34a9b368255"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ab108b5-62f3-40f8-aceb-d2b9047676e6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7af822e0-b632-4865-a60c-ad65c886abf1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b4e2151-4a32-4420-9970-7a5e3f231a09"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ba0b59f-f112-450e-8c29-a474cc474b48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c1b14cd-e3af-4f7f-b88b-71537a0bd41e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c3ce1e9-70cf-4157-bdec-2a251fe09153"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d10eeb6-f88c-473e-8d27-9dea4adc9e0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d94416d-bf8c-46aa-a41e-e1ee6e19ed6b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7da7df46-8c76-4d47-b240-f72c64f2bb44"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7da8e54e-4138-4bda-9175-75d19780bdae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dc8c871-8b88-4283-a909-d7405f90b8e3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dff0ff7-1493-47d4-b9e0-ac954ad432da"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e133375-316d-4fda-930f-03983c98209c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ebfcb9d-c503-42db-a2c2-b74a6cb68d28"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7efc9bb3-879c-4af9-abfe-7dea20329e20"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f259b69-a39b-420e-99b1-10d0e82664de"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f977275-a355-45bc-9187-d3391977c138"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fa76ba9-e6bd-490b-8ec6-d45b3909eaee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fb293b6-0728-448e-b1ce-f974b3edc675"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ffdd858-1d71-4455-8434-553b7a3149a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8087a090-515e-4987-9b84-f9544ef31329"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80ce9564-5fa7-4f5f-8d3b-59c6e58bba19"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("815991e1-e273-41f2-b5f2-dc849ac6e808"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81ad6589-ca34-4418-8cbe-c43b6321d2ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82026bf4-9c85-4d7d-aa73-88ed5ff1c1f8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("828be8d7-09e2-4620-ae07-d6cf15af902f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8295594d-bbd1-4a0b-9d19-7594586a7821"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82d59e38-d980-4aa9-8d40-8fa03cac5178"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83097d13-8402-4560-9c48-bfce3b0b1297"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8362802e-199b-4e06-bfc1-2fc3d60260fb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84465576-4476-4ca4-825b-7a84e22038ae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84b0817a-a6a9-4935-ab97-c6283f2990aa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84d49021-d945-4456-8a47-627231c0e23c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8572e313-ed6d-41ac-87e3-51a23435cfe2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86423ecc-616e-4784-bbbd-0c6472409e8c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("868ff154-b52d-473f-a68d-c44003b15cec"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86923a18-b47a-458d-a6d6-b61b51e93781"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86a4eb6a-4082-4932-bc4c-8cf3cbcec138"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("870c1e8d-6e6d-4b77-870b-ab73217ef0bc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8712b613-4456-47ea-8710-84cfcd8e84ec"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8727a524-fc51-4360-bb2d-6350a7c17004"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8757cca8-4d52-41d0-8069-329cb0e1c854"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("876f1699-90f9-424f-a2cc-547dd131f7ca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("877434c9-c129-4d91-83d7-2b01439e132e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8809fbd0-4cd5-4100-81bc-d7e0791942a6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88171ed4-997d-4a57-8ce8-f49fd6294355"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("882bfbb8-3532-4e9f-937e-f1b83b5d1da7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883afdef-6a15-498c-8a2a-259fedb503a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883c963c-d6fe-489e-be2a-acaebd47aa7f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("885b7be8-045d-4c1b-bbb8-06ab0b519196"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8887063f-1d3d-4aea-a4a0-e8a263353685"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88c42d1c-03b2-4b59-8164-92691e0f8b29"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88e56318-fc45-4601-b626-2b8ca7042092"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8941d78d-a48d-4448-bc13-e81626e36a57"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89447d9a-5c48-4297-a5e9-a19040b7510e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89a22a45-5f1d-4610-ac36-d97711789889"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a1ed767-8217-4b34-a918-874a7aa4059a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a517609-4ea8-40a2-9967-d324bf4c6414"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a53c517-f131-4136-8fda-a027747f1488"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a7465cd-3a4e-4100-b2d3-8bf3deadab87"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ab4088e-14ca-422c-a87c-a92bc99b6a86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b277ea2-aa42-4ad6-aa5a-a4cd27af8cfa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b7c4cf1-45de-4cfc-8718-8be0ce208914"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b9806ff-5a3c-4a64-b8f2-7de000d8d74d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bc55920-dd5a-4c4f-bc3c-6f93fb22e42b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cc138e0-9e08-4292-8c6c-49f4fc1d5099"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cd062fd-13e4-4527-81a1-527d53942614"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d1c5b1c-aec5-4a81-8b41-e6b4c5739ed0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ddec21e-b0b3-4d3d-bcec-567feac74d5e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e67efeb-5141-4ffd-a27d-08f370e57b4a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e894f1c-8734-4c73-ae97-24212eb21e8d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f38fd54-33ac-4e98-a362-1eac37c448e5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fc591c1-080c-4b50-826e-8e86a6a0697c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fca484e-b390-49ae-8a0d-54715d46ed43"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff2bb54-cbb7-4195-a2f9-dfb1349d4581"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("901de49a-fc48-47b4-a8fa-4aadc5608afe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("907d4d2f-9d8e-43a0-91be-7c49c2c35db3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90872bc9-0b98-44d9-bda4-a75c5e43eba1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90f6ba30-3864-4819-a0ba-82fc516d430e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90f7ec70-49d5-486b-90d3-457b638091a8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91299716-4322-420e-949c-70a689cbc7cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("915fccb3-afe3-4765-a7a1-dfea551f7631"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91a76692-c51c-48b7-a29a-cb53af3ea431"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91d54624-af9a-4723-bba7-12c1b5d54653"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91fc05c5-9f3b-4e80-80d8-947bbe3dff62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93112c3a-8722-4406-a675-3f2fc60955a3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9324f241-2c9e-4cc2-8452-422e47b78df1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93351c9a-6420-4628-a60e-9c786106382e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("935a202e-eeb6-49cf-86a2-99c18aed1b5c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("937bd132-75e1-4555-81b8-ed9560973701"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93aae39f-bbad-449a-b2e8-e2e37f7b3f5d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93dcdd6a-2e5c-48a2-aac5-dc680675fe87"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93f1aec9-62ae-4f28-bdbe-841234bd47a2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("944fa28d-a4fd-4fd9-9d32-1e1a349e67f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("949a35bf-98cc-4cfe-813f-15a848e492a6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("950eca40-2183-4294-bfea-13d24b185e1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9512d932-92de-4734-b3e4-22d3d50ee234"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("951780c0-13b1-4d1b-b932-98eb8b3230f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9568d653-06c7-4432-bf6d-9927893b8f99"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95d24193-ed78-4cd8-80a0-c99150269aa0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9638609c-23e6-4979-afab-8343cf352444"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9674b2fc-2b23-4654-888d-c22e11fb18a9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96ee3419-df86-4850-a688-f469f01b45e9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9704deb6-c4b0-479b-865b-101886698939"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9707e772-8133-4cdb-a2f8-7b5ad53a9c64"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97092039-ef1a-4500-8c6b-b061b3cc0e96"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97579585-e5c7-46b0-a05a-bfcf2e8994b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("979a1474-2f16-4c5c-a890-63adcccde97f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97ef0c6c-8b62-4302-9364-d1e9df2e5c56"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9818f6bc-b494-4371-821a-399de111fa8d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("984c50ab-5311-4bcb-ba76-66c315d03faa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("987b7341-ce8b-42fd-b5da-3f983ffa2f65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("988afced-2a41-4d3d-ac8e-972936fff723"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e6367f-9f32-4e75-b9cc-9811c797434b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98f133e5-69c5-4e30-b37d-36020c88bcbb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99402327-b033-4730-8cf8-b87d66e4426f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("994ae634-cbe3-4b63-a688-fb4836a5cff2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a315e71-2541-41a3-b9c9-b9d0ebbcced6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a42d4bd-f48c-4a2c-b05e-7bdda7dfd313"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a5516d1-b062-4eab-a393-973fc4d0a5f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a6697c9-8cc2-4574-9e6e-76c3f1e8588b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a76247d-5004-43c8-83e0-9812b3f4da28"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b02d7ef-cd11-47ab-a8d0-f63297d33a60"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b23f35c-56a2-42b0-922a-ed06812db002"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b6cd566-53e5-420d-b248-b361cef2e157"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b7275a5-092e-4b3f-a8d9-a3bfe8047ddf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bdcfe52-cd60-41f3-b95d-29bf1e3699cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c554c35-d206-48f7-8135-29ec271a274f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c75812c-f720-4013-9fef-0d70c9b6406d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c7d5aa4-d29c-401b-bf17-c8cb09b94b3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c860c72-2bf8-45fa-92d1-3a3c3eb52718"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cd328a6-b189-4e2e-a939-4aa42406ca61"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cfa6ff6-a5e9-479f-807e-fda82590a360"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d225e00-c00f-47c1-a726-a8e56f8d581f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d268bcb-fab4-4bed-b563-699d574fb7df"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d480cfa-a3f0-4d04-9f15-0dbf00aaa442"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d5b2c52-3480-4a21-baa5-50c33ea44614"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9db37099-89d4-4002-81e4-66e2bd6b561e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e5ccbaa-8108-4e2f-ba2a-90aa5dbebb54"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e9e0524-5400-41c8-9525-965c29d52bb7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ead92d1-cc06-45a7-a591-8e479cc34824"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ed426de-3809-42d6-920c-16c4a9d376b2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9efedf3e-5bdf-4e27-be12-c16c598eeb0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f216c71-b994-4c77-bdc8-60d13359c4cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f2685b5-f20f-4953-9a9b-3ed2234ff3c9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f5a3687-a523-4ef0-811d-65f3cb445b93"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9faaa4a8-a964-476d-9bf5-6a6a572e72b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ff98384-25b1-4cbb-ae6a-9afaa0da7669"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a01be4e5-59ab-475b-9e9a-ae2e8c673aa0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0366810-fbcb-4a07-b438-45bfa8be178b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0735573-01d3-415b-b5e3-3aa314bec806"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0d19745-4061-4cee-8b5d-aa498478cd65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a192410a-4f2d-4f87-82d4-ced5e9c15d38"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1aad95e-cd8c-47e4-ad6c-e116e136a372"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1ac9226-b8c5-4a60-bd69-e1d96f116b52"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a279ba83-4bba-4885-a04b-4a9281a1b08a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2ceed47-99e2-4a54-a651-6a38af00ecc8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2e1ca42-ae36-4625-938f-56ab7f1fc370"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a304f80d-497f-4475-8b08-ff7db56fb697"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a37903bf-facd-4e8f-b5c0-ac2105de69ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a38e2e0a-9747-460b-b745-a6a797a6459a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4738500-58c6-413e-89e0-882187d74017"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f6f494-a174-46c9-9b2c-cb460636942d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a51c371c-db14-4dd2-b4ec-46e4da6c4bcd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5e2a93b-697c-4d42-80b8-5ff124c9a972"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5eba125-276a-4f22-b508-81d5b66f2757"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6575091-5049-47f0-86de-dea1c92c1689"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a673c6b0-6085-4a14-a694-e3537fb0c9bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6798064-0a51-4c85-a15e-75b88faeef04"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6b1c5a0-65b1-40da-9f22-6f58e15c7a36"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7ca12ba-4230-40d9-8762-c381aa5d1006"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7dc5447-fdd5-4fce-818a-0245f0273099"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a85d0bfa-8b10-46bd-96c6-6b42eb9b3924"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a878a08f-7432-4ad1-a511-f9c7def2b8da"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a878b474-4d4c-4ac8-8050-23f552170059"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a92c4725-a849-4805-8d72-1060001e3cae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a94b1b95-ba33-48b6-9c6a-bbc9ef3b6583"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9978320-ee47-4ff0-b9e4-9371f166fdfc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa443b89-2879-4fcf-bcbe-b80e001e5bc5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa619ef1-8190-4261-a550-63efc9ddb148"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa691d6b-02ab-49bb-9f66-9a95354aa067"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa782566-883f-4c5d-800d-b2bcee0808fc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aacf602d-6a0e-404e-9b32-d18aa6d91cad"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab3a7e70-2956-4b5e-a8ee-2c0ac52783cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aba5df5e-97d6-4517-a28b-5ed91f313714"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ababd03f-82a0-4520-a64e-fe9e7e1cec3a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac6dbf13-25ee-4e5d-97d4-472ecefc7f86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad1cab04-74bd-4614-8444-79282358633d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad8a7d77-aadd-4be2-9e5f-d86236c51851"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae19613a-491c-4538-90e3-45deecc17fea"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae3e4851-631b-4f8e-b990-545a3cb40c34"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae9d3dde-a12a-4eeb-b0f2-dc533ed5e38a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeb3e494-a12e-4550-91c1-f984e6290ec7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af3bab1d-ae81-487f-9c86-d670f5c6e9a7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af3bf1f3-eb62-4f47-b118-de5dcc3bed3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af4ebf18-c429-434f-bff6-43b42c7d966a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af83bb0c-a869-4890-b2b1-848f28a0ffce"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aff85e97-4817-45b2-9897-97b0cf8d20c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aff98b56-882c-4997-9e6f-063f17801a7e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b02bc556-8873-4fc5-ac2f-1e462dcdf522"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b05a6558-a6f8-4d76-9824-90d6ef1ba784"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b084c7a0-69d1-42fd-a4b1-4d2035f3b409"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0aa293f-e267-44cc-8583-8c2be520afce"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0cd364d-e494-436f-888f-6a37ecd4006e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b12fee30-ba6e-4d1f-980e-5702218979d2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1300d47-8e99-4add-831f-e70655f32a59"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1576050-1be4-4450-abaa-0088f18156fe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1ab475d-6b32-4808-8cf3-38a7b3bd53ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1af4420-0a17-4aef-b6fc-44d9aad7ab62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1fb26d6-b3e3-4d74-89d8-94cacd01eddc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b22b1cdd-0aa4-490d-a10d-f03fa0abb9c7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b24739ca-66cf-4b63-bd34-07cd42df347f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b289387a-ff9e-4ddf-875c-428d527ca30f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2dc90a0-f182-403e-850e-0c47eebb617e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3100018-2645-4ecf-a507-e2eebee712d0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b331ce3f-4a21-4df6-836a-e0908819f430"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3ca38c0-19c0-4ab9-9f25-914e0773276f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4375e06-4234-4c9b-971f-276669761eb5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b45f5951-5d02-459b-a221-cb3ed94f86c9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4a661cc-97ea-4261-8dd6-8b2ded826ef8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4b80d5b-a914-4094-a132-2614a7ae056b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4f5361f-79bc-44c6-9f76-1229826e8421"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4ff52d4-7297-4584-8fb4-ce5725a395b6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b54204de-3855-4ae8-bc16-63e2ebacef4e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5644275-0d2b-49bc-8ba8-79b1af802e75"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b57ef255-f552-478c-b47a-abd979832313"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b29a2f-190a-4263-9b63-f7a091d0d12b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5fef59e-6b11-43a3-8957-dbd6a2ebe962"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6d109ac-41cb-4cbf-9253-ef39f4782530"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe56b-ee92-41da-bb47-76231b042270"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6dde842-af74-4680-87c1-e440c7bdc9f8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b73ef93b-723d-42b5-8111-7a426bd6a362"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8010cc0-d86f-4c38-8490-22d1bab318e5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b83e9472-2844-488b-ad03-ed487d6ebefe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b844bde8-761a-4c63-9d94-8a03914abe25"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8498edb-7f49-466c-8254-dab678629d78"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b895fdee-d5ca-4c07-ba66-a98b213d551c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8dc1de8-7325-4987-a864-cb38414ad066"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8fe6e90-dde6-4902-8d16-fb51159269b9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b919e7f7-d946-4f3d-963a-6371714bb899"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b930b795-a9ab-49dd-8c98-4bba9e96787b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9a2833c-ffff-498a-8eb0-ffc5b94c92c8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9d68350-99d4-4e94-b7d2-d8bff1bcbac6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9f7276b-962b-4c24-9b88-63590a5e7d5d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9fd1081-91ca-4682-99cc-5b2e89157586"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bac78566-b1e0-4b2d-9756-90e10597437a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baec383c-54c1-4eff-8aa5-1b552a1e5c48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baf0ea29-b12c-4653-a2cb-4a6f95f7ba37"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baf30168-a5b0-4b06-a1fc-087f96349ef4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb230ad9-002b-47b6-96a5-926fb203ce0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb60ce14-d7d0-47c0-b084-d4ac55a2ea07"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb88b1fb-c075-4d78-9e1c-84468fa10172"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb955e4b-6b32-4d7b-9171-10e1ba28825b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc104700-57c1-4516-8b9d-fa02fe9d971a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc464297-c7f8-4395-b004-332bf1b813a0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc57b54d-43bc-491f-bef8-3aabf30cc924"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcba6750-42f5-414f-8222-c3058e4a09ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcc6d10a-5634-4fd1-8d67-22bd5ed6e807"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcce2f80-f21b-413a-876e-b2b6af170563"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcf1c1a6-1aa1-4c13-9f60-1f24f4e8fac1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd246710-f2e6-4ad1-8332-c7f136d74966"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be1692fb-184a-4df4-981b-bbaea77df19f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be21e542-b821-4eca-ae08-6f26d76f1000"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be2985aa-2158-4d17-b93e-89b50457b2fb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be2b305d-474c-4dd4-b1e0-2a6413e79ed3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be8d14f0-c1ce-46a2-b090-a09fd9e3ac5c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf094208-888f-4899-8c3b-dfca9687b0eb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf33ee74-8b81-4742-bf91-7bf54742b32c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf606fd6-57e5-47c0-aec6-41fce83dfbc2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf801835-bf93-4abd-8bd9-9f28f7fa953c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf9491ab-dfed-40a8-9f7a-470ced4d023c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfac89bd-435c-4c0e-87e7-49493876ece4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfc528fc-4ef9-42e0-930f-89592d81ab92"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfcbea48-5e89-4371-bd94-43ee47ec5cc2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfe1b4bf-bc65-4171-aebb-59b9433eac82"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfe61564-0403-476d-a0bb-cf46f07e3e7a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c04735c5-6e9c-413a-bf01-94a4e24769bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c165ca72-656a-4123-88a5-aefd1290508f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1f3c0c7-cdd2-45e3-b380-c1df47b8fbc8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1f971d7-1e1d-4971-bf15-3ed6b2e323f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2230a23-6d14-4f2d-b8ce-db21efd8c566"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c23bac34-2e72-4a64-9504-f5660ee42bc1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c26e3b28-e899-426e-8381-4a59a2338ca8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2898606-4a5a-4563-9144-8d69c8f410a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c28a07db-601e-4d54-ac94-e35ee31d8eae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3d5d302-e2b6-4e77-9501-a8da9ddfaac6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4752586-02b8-4eea-b0f0-1f9f5b129b2c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4764c2e-834b-40f6-9af0-f97169359f7e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c49cba04-84da-42bb-aca4-499d62b952c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4c54ce8-24f3-4f3b-9454-6d3e3126a85a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4d8ff2a-8b6c-4de2-abd1-19e78844f36f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4dee1b0-482f-4f5f-988a-5cc9f8771689"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c57a84a4-43a7-4e74-b67b-d3c50daae0c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c57cb701-8165-4f8e-8965-9e0b913c7256"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5c548e9-c21d-4418-b4eb-e5b83cb4ad5a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c60aa8d6-7774-4c03-8750-56d792c34714"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6275a36-36a3-4827-8f75-39bdac3e483e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6924e2d-6125-4a2b-99b0-e21af30494fd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6a40310-d603-424b-a74b-2670d11ade7c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6ac5fa0-fe19-4099-b543-dd48e20f9da5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6eccd96-f894-4dd8-8444-0c561897ed2e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c71bdbe6-0167-4cf9-a65e-851922978e65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c730c780-bf9a-4447-ba74-0c848d9b661c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7c11827-4ccb-43ff-9387-e09190f63c33"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c88250ff-9f7b-4478-9cc7-2413b966f865"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c898fa77-68cb-47cc-a74a-1ddfaeaf6e1c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8c10e62-27ac-4843-a3c5-9c1cac0fb962"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c942e652-ed87-4614-8ca6-4bf773fbdb90"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c96619e0-00df-4ffd-8351-d16e377e04f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9eba354-f401-4a6c-acb5-09a7c4afe021"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca1e2e3e-3982-4b90-ba9f-6d563764a065"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb10447b-19b2-4446-b384-a5930fd0737d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb846a0a-24cd-4f09-bfb1-ddfa7fc93fbe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc655258-3f82-433a-b834-da5e43a49465"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccae9be7-43e7-4558-9baa-9fdb536808d9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdc53d76-9211-4550-a651-e516de59723c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdfe05de-807f-4c63-b24a-63071c4f3024"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce51b0e2-3953-49b5-959e-8428b6569bf3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce54bcf4-1244-4227-b429-840b9118b493"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf033129-159a-4325-93fa-640316095ce0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf08ad30-603d-4b04-9541-d03ca58b421f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf293094-dbdf-429e-a60e-9de6d5ee7fb0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf39b261-5214-45f4-8bac-f9ea719a8dde"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf52601d-af9e-42fc-b9ea-8e0a17a1e387"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf77d508-be18-419a-95fb-0da7e4b7464a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf9c8d40-b10c-4a2c-9069-e8d418d84a55"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfe18bd4-4799-4240-9dff-f95ca617622e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfebc795-ea9f-43e8-836f-7a8438203a33"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cff344f7-c9ef-4bd4-a332-3d76772d5439"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0b701ca-12d1-43d7-9d00-0e35c03dd4b9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0d4831b-b5fd-45ff-b577-ba106806c807"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d15f81d9-9bcd-4067-827b-82974b6ce46f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d191ced7-40ae-480c-8fc8-ec955f6cf842"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1adbc03-f325-4fc8-a412-38adc2f68ae7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1af1ea3-111f-4433-be66-47bc7afbda78"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1bf0b82-f23d-4dab-a91d-ab4b915c64cd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1cb9bd8-17e7-4df4-9a75-ffba2716b503"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1dd73be-4451-4b46-b298-bbecfbf3d6d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1efab83-c6c8-430f-b6d8-afbfd8dfc57b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d21b0d2e-b965-4a0a-a1d1-4ba374fc6639"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d271c158-42fd-420b-ad0c-6f6cce6e1dd4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2aeb91d-f565-4d03-a2be-346a6e6cbe39"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2fad058-68c9-43bc-82b2-70a5c2acd67d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d302873a-7f24-4f2f-b12c-5905bc97df14"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3086f1d-ea70-4eae-9d47-154ad9a5dfe1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d320592c-c14c-4821-9ae0-fc40401c5169"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3532e4c-a8bf-43bd-b9ed-3b8065b5955a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d398cb63-d154-4920-9301-818f9adeb213"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3bd2cd1-864b-4f12-960a-89a0200ce4aa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ecdcbe-0102-493a-b2bc-c4c0832c06fb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d44298dd-7c13-4514-b61c-783eba3385cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d44b48cf-891c-4fa6-ba85-14502cddc59d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4703a9c-8551-42a8-b0ff-889e1d1b18fe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4781ba2-20ec-48a1-b9c1-9301492db3b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d47c75c9-8130-406a-a890-e1d336a7415e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4c30afb-c9b8-4750-a544-6943c9d04ed1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d57d8158-466c-4c2d-87fd-3ac70cab14db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d58bbb5f-5d99-410b-8073-f0b812cc0cb7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e667da-621e-41a6-8073-292dcc919328"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5ef249a-5d00-412e-b66e-c3763a387344"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5f0aaf7-0aa3-4bb4-824e-c0295edb6c0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6557fdf-9bf9-4dbe-9759-977a83b3f07a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d65f9ee9-5cb9-4312-b839-974b50a220b3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6668131-8c47-49c8-a9dd-3bba8dd7709b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d66b57bc-81d3-4ef5-8c4c-0b1e8c02a134"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6ebc7fb-054d-442a-8109-e731363b724b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d71e9b90-a847-40f6-b00c-94b903d61925"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7399f01-d819-4df9-a7a6-d9faf5b60d19"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d73a95b0-1028-41aa-b327-977ea9888ed8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d852b30e-5122-4959-abc7-ef81b0e89b94"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8623b78-83c2-4428-8a6c-eae08ff31419"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8c7c8cd-20fb-425f-94a1-6ddb52f38e6c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9478ad8-c375-4982-8990-0f4a0bb155b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d97b60f8-fdef-4be8-b895-2b6e37165b02"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d98ae8f3-a858-4d99-82ef-faaad304c7e4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9acf79c-4d14-4a89-9268-2f6386889272"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9bcfc9b-3f99-493a-bd6f-fc31968fd341"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9cc467f-13ef-4d79-9c87-42db5d598a27"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9cd852a-b2b0-4311-8aca-ba7df2050ea9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d51385-2329-40e5-8770-9a3558b4a489"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d72761-edab-4e2c-a07a-1f06f8675145"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9f21199-97f4-45de-93f4-bee8c0864158"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da13c5e6-b6bc-4d63-a0d0-5ac911e8f516"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da1427a3-c1e8-49ce-a3ad-55e62c041369"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da19bea3-cac3-4233-a2b7-f261b3fb728b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db4b3c93-3f65-4a80-8cce-cd76e39a43f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db6ea18f-1a4c-4895-940b-b6f8c3633e43"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db847cda-01cb-40f8-9633-3964ff59b0db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db89ff70-cd6c-48b8-a627-1bbfb4376f40"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db9018da-62ca-4d64-ac74-2de5dc8b2ada"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbb55a16-e848-41b0-9d72-7297a0b91dab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbfa3914-ae1c-4c0d-8d1a-e9dbe53011d5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc0f323c-6afb-4182-8040-fa795e65657d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcb1d809-4480-4a10-b4c3-14549b75c7ab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcc19478-e6be-456c-9c47-950210df0444"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcea9a3e-e98d-4ba5-908f-970a352c767f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcf643ac-52ce-4e16-bc5f-1045e4da0a2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd5a434c-3f8a-4365-809b-9e5a919012aa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd7a1385-86be-4eb7-8e74-18cd911287fa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dededf39-9e18-49c3-924a-c226254affa0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df0ab974-23f3-43da-a39c-96d94d4d3760"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df38dfff-f288-43fd-a57a-15daa3f2b74b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df8cdbcd-2845-48ab-ba34-ff607e1d7bf0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfa0f918-d2c0-449f-ba1b-37c6faf02664"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfa4bc69-8fde-4021-b186-7c97d113bf0d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e01d45b4-e590-4356-b6ee-91aa2d9b3ee4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0adc567-88cb-4516-8f1c-33b3b740ea78"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c9a282-10b6-45f0-9981-c08fc23d7694"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0dc742f-fc16-4d31-a690-95219753ab8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e14c74e7-b097-474f-ab2a-55bac3719238"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e158444b-cf85-4d8f-8a69-a8279dd3007d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e15d8790-665d-492e-9841-6691989282c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e185ec17-f3a2-4264-bf97-86acb7e6bf1b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e18c6560-3d5f-4c8e-8748-a04131864489"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e19cd768-7f1b-4e33-9145-5e0f729f9627"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1ae9e2d-5af4-4a3e-9ce0-587b60d61e8f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1c9d0a4-55e7-4de7-8848-f072369a2bf6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1f9a8bd-4cf2-4955-97ec-caa584e10054"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3327061-08b0-46ec-adfc-bed7afee9bf6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e378f849-14ed-45b2-a73c-53f35c67d96d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3d17310-053b-47fc-add2-09c27003d48e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e430c8fa-07ff-48e4-91a1-2d70b77e3bdb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e440d817-161d-47a1-b8f2-f13c22450342"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e48ff210-5fe6-4b77-98da-b80e267d6ba9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e51b4e87-3c98-42d0-aa09-ed9dcfdfd875"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e52c0917-532c-4094-a367-6ee742c12d27"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e558fca0-a1ca-4020-a526-1fd1ea604fc0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e598137c-5dc9-44ca-b11d-876837ea4dd8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5d0450e-e9fc-4064-a0ff-a5bc977b6589"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5de65eb-5652-4047-a1e5-8cffa45066d8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6a3978c-8952-44c9-a404-59f5d3753aeb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6a78f08-9c2f-4d41-b394-f52edf065457"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e758d19f-2c39-463b-bb97-bd32e1925629"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e772c67d-7e00-45e9-9758-53f7cf1a8d65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e789d16b-b925-4ab4-80dc-aeda9bcc093a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7c06b3b-4255-4dba-9366-ff3a2342bbb2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7e75953-6e2c-4ee7-989b-75b2b50202a1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e901eb38-b5b7-403b-aa90-d3f040737cc3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97c9c60-1c56-4648-bc11-1542eb6d696a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9881108-781c-415b-a40c-ac6ccaeb49e0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9f9d8e8-1fdd-49be-aa9c-7b1de34c30bf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea4ada09-abb6-44cf-8e59-fd85867d0ecc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea6671d8-4006-44fb-8e37-015d267b8ce5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eafe65c0-2f6c-4c0c-9c19-65e14ba8c55f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb18bab2-5eea-4e06-a140-40159d6895c2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb4591e9-76ee-41d6-9677-6810fc910dc2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb834e6f-3c6e-4bd1-8f3f-1fa3f85b30f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebb9b0ef-08bd-460e-be1b-43499aec1729"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecd4f84b-d7ae-4971-99db-d8bce919fa46"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed4acadd-9b4a-4d64-ab79-f9363752cde2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed764f23-0c0a-408e-81bb-c90ec63e053e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee3819fb-32f2-4d41-bcf9-7fbe0dd30de4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee3baf08-12b0-4680-a783-acffce493d55"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee4489a8-ef13-47b2-aa0a-4d4d367215bb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee4948ce-c20f-4591-99af-68169976e965"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee5930e8-87f8-4eae-ad7d-404a8b726392"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eec88267-d370-44c4-bc1a-d4d8a30c3afd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eef0b362-cfc3-470c-a2ef-0c00ff5e2a26"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3596de-fc44-4eb0-b873-881bd4ce7206"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef5c4d87-9360-4b03-9c80-db64dca56b63"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efa9ea43-641d-487f-9e9c-f2dbb324e0bf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eff45f99-0abb-4472-9d3c-dadeac378f6c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0438638-54eb-4b3a-804d-a527426ffafa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f046c8f6-b990-4e4f-a50e-6c7350e4c3b2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f07f17b3-1eca-44a6-acbf-ee7832621316"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f088fa90-0620-4464-99a9-b175b8dd96f0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0fe0b81-d8a8-43e5-a082-6cad59d7f7de"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f101af49-9b0b-4bf4-a995-c90e50016fd6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f10aff88-09b3-4be1-bd7f-3e57ed91aba1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f11323d6-b8dd-44fb-9e74-0f27b71dbf50"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1e68ad0-264e-4f23-a981-7f168d615f45"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f20c4f9f-52c5-44a5-af12-5712a482ad37"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2b6625a-ddbd-4adc-893f-b470d6a68e02"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2b67080-7d0c-4c9a-9495-26b54d442069"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f366e08e-ce6b-472f-a713-1974e533541c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3ca907a-c84f-4b1a-8d5f-44d14eed512b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3e4b1e8-8e68-4f55-8e4d-5c58435f50ab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3f8957c-e57a-4fcf-b019-19c1e2f7a4bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4622db8-f2cc-4793-ae51-bba81432a676"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4845c58-e8d7-48cb-8e80-acdef23caaa7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f487ee95-ba63-4ed5-a2eb-bc3131219efe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f0c6f6-030e-44ca-936b-6d1fb2d3b922"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f51127e3-98d9-4983-adf1-e5fc56ecd5df"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f517ca9d-be25-4c5a-8b4d-b41f25f3588f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5582659-25d9-420e-b64b-7bd411377abd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5d63150-f078-4e31-b726-a6fefd65084d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6286ee2-8495-4c67-81f4-87b1d193db6f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6a984d2-ffe8-4c8f-b87a-30153cf47d94"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7747260-b91f-40b9-a70b-ef7d234d320a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7e58cd4-87db-4ca5-88a2-a837149b2acd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f80d8779-dd2f-4955-b5c1-c1ea32cc00d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8514970-b010-4625-ab76-f59e41766a60"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8dd6a69-6de4-4c35-8128-7cf1be44324b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e418f0-1bee-411a-a911-6dc86942bc48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9cf9fbc-260b-4493-bb23-2e1555d198bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9f33555-85a8-43b4-831c-b31e9ba0028e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9f79ae7-99b8-4da5-9dfb-1b731dddb01e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa2c1054-46c3-46b5-bd13-77e224246ee7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa4ee7fb-2c7a-4d16-9f65-e0245dc35573"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa5d50ec-c47b-48b6-bbed-d683db21f01d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa7f9679-68d8-4429-9e05-405a786eee13"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa7fc26e-bc31-4f0a-9e17-0e5450716969"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabd4a7c-3067-4931-9240-3713b8583d61"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fad8dc8a-378f-4bde-8f4f-fb75c9a13ad4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb9138af-85ae-4830-b96e-80d3ccc79e51"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc1461ba-57e4-482e-b194-b1baed150694"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc486c83-1607-4fcb-9677-44492fb5fb89"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc77614f-7fb8-4452-aae3-dd738fe637d3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcb8d105-ed65-46d9-91bb-3624d1a3260b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd3fbfb9-4365-47f5-b026-a9124a1b8aac"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd69ded9-e714-4d80-8f3a-c15bfa80c5d7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd83d5e0-6aa1-4127-95da-fcd8036536b9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fda8bf50-1b30-48fc-a5ef-2064a5c2ab96"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe7d4dc9-b078-4e89-a40e-ae2148bcbf3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe932681-932a-4b35-9783-e730981616ba"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe9ff8de-d65d-45aa-a54e-0994656f92c7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("febdd888-57d7-4fef-a459-b11357a72d15"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("febea71d-0bff-4486-ba33-f4e5d125813c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff56e358-788d-43cb-9868-b1feb4839316"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff726f5b-5d4f-4f0f-996e-5915c76e7be0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0032497d-8b96-4806-986b-377b7dec29db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("004d4520-1db7-48ad-98dd-a3691409a9ec"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00cfb94b-be82-401c-8f39-060883bf469c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("018a6515-43a9-471d-8238-bd2d62bd0677"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0197a8a8-f9d5-4665-9f66-5f1cc2d6567b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01c0e09d-f897-49af-aa21-8d89edb2994f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02773ce1-8359-400d-9fa1-eb187184ab4a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0282e57b-6b86-47d3-8c35-c8b44b8a3434"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02d497cb-625d-4bd3-ae06-ab4dd1555698"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("031dba15-d01f-4ac6-9e3a-8b525d65be73"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04378db7-1072-40ef-a8b9-ac33b15c2008"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("048aec57-4c8a-4a6b-8efa-10692a745c12"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0503ed8a-d994-4327-9cf4-be51b929b52b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0519d6d1-1402-4cf9-8360-cac307ad2718"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06af60aa-0609-497b-ae71-6f87fc517b20"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e22a22-af51-4281-bee8-dd4526deb0ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("076bb637-5a3e-4f08-bfeb-4ff9fd9f587e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0792fc73-dba3-49e7-93b8-043dcd6cdf77"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07ae9609-8b2e-41f7-9f44-b316f89254f7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07cf369a-bea0-4493-be84-db09d65d577c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07d9b59c-5933-4890-b2dd-72cfb808a10a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07e1005f-7efe-480c-9cdb-2e4460378a9e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0810b0aa-d347-471d-8343-9ce3a0f22431"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08298e6c-60fd-4857-9d5a-db0420f4c01e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("085c8847-af2a-44c5-b0c0-b00b5ea07e8a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08a53539-cb45-446d-97df-ec73fa965b93"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("092ad296-fc99-45ed-8137-8c83117c0fc5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("093bc13c-2ce7-4152-a371-523bbcdf5bd9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("098d02f7-ecac-41d3-bf23-d971f4edbeab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09b860e9-5a34-4234-bca3-795ca0b5e68e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09cc6c3a-f3f2-49a0-9ec6-c526b625e813"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09de8f5d-47af-4513-8520-94e28dce8488"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a1ce5c7-3e03-41ce-bf72-53f92277a9cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a3aa2e6-fdc6-46ae-83d4-471a1910dcee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a546239-396d-4cc6-b99f-3761e8f88f8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a5c55f8-4eb8-424e-b54b-cead2eca099c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a8ac04a-4344-4558-ac1b-b4a714522a73"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ae356ea-c2d7-4426-b355-3984eadee0e5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0a1eb1-d441-4bfe-8222-60c7ed8fe419"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0b3de3-9246-4349-a532-702eb6b41200"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b0e6ddc-8b2d-4f58-a668-725cb7267899"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b172546-05e2-4715-be78-5e57484928dd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b34e4f8-e7d6-452a-bfba-804090d9035a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b75edcc-d3e2-4f67-9a9a-d3252ece882e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b95c6cf-c848-4e7f-b242-1fd37ce5a8b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d0f6323-796a-4bbe-8d73-1282350d6de4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d1bc95f-92f0-4dad-a552-c0f51c888d37"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d31f86e-5bc0-4757-a8a9-8c2a658c98db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dae9717-fafc-45b7-a6f9-7628e354f366"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dcc7aeb-e31b-4392-94ad-b250e21fd3ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dde1d77-191e-4b8c-980a-52a178e2bc4a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0df998dc-f850-4cc1-a1a5-5cf071fb000a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dff4984-97ac-4d7f-be18-c534eb01b36f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e1916d0-8127-4279-b8f4-eee6564a2ac8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e1c975e-915c-410b-860d-7cefa2f2cf2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e35211a-4731-4a34-aa69-12f6c8a3e58d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e4ced63-53bb-4a99-afea-c56a8ac943a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e7b0280-9cf1-45c4-8941-1bc2f20ad05e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ebe3097-28f7-4017-89ae-c3446269f46c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f74096a-3114-4eee-8384-dca37feab9bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f8497a7-e086-4d0d-b427-376ac708509e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fa3cb9d-75d2-4c98-803a-7ced41dcf0a9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fbc5216-88f5-4f12-8f01-085bd080f5fa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1043d26b-e397-4cc8-8c21-001f89ccdc0a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("106e631c-d051-4c32-b0fb-998e4e2fa24c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("108deb24-430f-4efd-b589-a794cdcd01cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("109db990-c429-4f8e-8c07-29ca7691f674"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10bb6d69-89ec-4291-84e6-4ee873ba49c7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10e31139-aa28-41c6-80be-373f4cb79993"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10f58454-ae2d-4e34-8d6a-7fc388abb820"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11389371-4613-4421-8c96-1ab81cded836"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1171b951-8b4c-423a-87a5-4e345991b14e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11cb8d8c-26e2-4da1-a3b9-7b6fe9dcd24b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11d429e5-9eff-4ad9-aa9c-3d70f45917e7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("122ca4d3-51d1-471c-b2cd-873eec91aeeb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("123a787c-9068-4a33-830d-0c0593a8ffbb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("123ddbee-8e00-4e02-908b-4148fe25b663"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("126b15c1-4d38-4220-a06c-4bd6fd51c853"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12af7390-2070-466d-a973-abf8fd79717d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12fc5cdb-cc30-4863-8050-b3ac1d55b221"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("136075b8-c945-4c77-af49-ae4fea7e2718"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("137ab7a3-7cef-45e0-bf8a-14bd9eecef68"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("139d8ea7-58d5-4832-b68b-5f0e62c0e3cc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("143e1702-c166-4ccd-b515-2aed6f3685ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14e594bc-a4cb-4421-8fbf-e2b14a1149d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("151d7cca-bb59-4690-b0b9-13f42523d5d0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1578de0f-a853-493d-b563-550aa0a281b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15e4637c-ae50-436a-8baf-6e299efcd06b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1625166e-5f56-4407-a580-390ee5045b49"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("166e07e9-088e-4fe0-8dc9-4b1c1ba4bfae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("16c7961f-cdac-4b46-a4f1-12207a82e39c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17145a35-071e-4c71-98d1-b94f577a07a8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17177d8d-d337-464f-b115-9f1d9d6dcc6e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("174adf1a-54f0-465a-90b4-1d549fd9287f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("174dfe8c-098e-4726-a585-bdeeb4d75047"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("176a586e-f34a-4887-9b49-778620a23f50"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177939ed-ed6f-4ee1-a578-f1dff65606c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18f46397-b731-4e47-bcf6-5a35d60f1240"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19347b6e-b95e-4ef4-b0ae-c6b49a05c9a5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1951f320-b2f6-4402-916d-549d8fac9021"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1977e58f-2fa2-4ed0-ac7e-052b9c99d594"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19790bd1-cbee-4544-9bbb-f1834d8f55db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19f17cd3-0da0-4d61-8ead-a2ff7dd5b6d5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a20629c-e2f8-43c2-866b-5169be765f64"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a4ef664-7d04-43b4-83eb-7a829443fd22"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a6df83b-e54b-45f9-a712-caef35095e29"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a9b27e6-61d8-4234-b9da-d100da1f9a2e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b374a39-3415-4aa5-abb9-e1f86a1a11dc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b5dcb89-6c6c-4c2a-be1f-3862bcb4c852"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bc1d18e-17a7-4691-816c-5a38adf41f27"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1be61044-9378-4b20-9a81-856fcd30b84e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c8efbcb-8c8e-44b0-92df-d4ce19ca9aca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ca4048e-5572-4b39-aa1f-d2a378351d16"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cfde542-3b36-4a3c-89ce-e94f90e7e6e7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d385d73-1b1f-4b76-a3d0-6b89a1a67c58"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d8730e2-c4b5-4c45-b987-7b9b84c977d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1db5d338-a83c-420f-961c-bd43e41ce6ad"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dd91a56-5f52-40b8-8ea5-44c3bdbac96c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ed54d15-34b1-4a45-95f2-78d684973990"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ef73995-a12a-41b5-9c8e-979da8db49dd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f15bc2b-6ab6-4607-b8ce-52cd8534cdae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f31f22c-4192-426b-b0a3-a0ebc3af2e75"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f3cfcb0-5f8f-41ed-829c-2a9cb9eb84c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f41300a-c275-4616-8422-6f70d17be6b3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f49dcea-8d80-4a4b-b119-04e2d2e5a25b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6542df-d748-4742-b401-9aa095698e5b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6a873d-4957-4859-8a50-c618d64ff456"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f99ee26-6a65-43b2-a539-7b751da241b1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1fae1925-1c49-48c7-875f-292acde2df12"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("200d6c87-8289-4fa0-907e-abba46440ae4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20270d3d-9a1a-4ab1-9f34-411e4b565245"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("202a01c6-c888-42b8-bd7e-d417e7c80581"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("206d6cb1-d0be-4d9e-ace7-623ace7b90b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208ac801-78bd-48f0-8ed0-690ded0b04c1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21052533-4987-40e8-a64c-7ad9ff62939f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2161c6ef-a38d-44a9-a2e5-0b52bf2147f1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2195f8ab-3ea3-4f6f-8855-c8889786e682"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21d28bac-e8a2-4dfe-ad92-b8cda509f6f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("220f3315-33bf-4f2c-b051-4288e8caa9bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22297355-a788-4ef2-bf36-99982489c1ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("225e275c-6e72-468b-a778-5c19d2379cbb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("231fea01-02d7-4888-b5d6-f7641ead6e19"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23332688-ad0f-46cb-93ff-4500c6633492"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("238270b7-0722-42c5-9f70-29d16232389e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23b25e22-68a5-4317-b5fb-238e861cd45e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23e962f2-0a8e-4d73-8227-11070c4560d7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("245ea1b8-3b9e-4984-8e46-7ae9e6037dae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24a9f1d5-3fc0-47f8-a6d4-52453133fb8c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24c03bd8-55be-4361-b543-da1b0f57ee9a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24ff6e46-d376-4100-9672-264319c40677"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("251d69a0-7a2b-484b-bf42-e5ad09dd976d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2556d805-b77a-4055-acb0-4a0188456adf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("255980f2-36c2-4998-9536-04d6b3474086"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2579f878-f76e-4a2d-8acd-b3361bdc0613"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("258ffa27-b7d3-411d-8897-d0a854acef9f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25d2c301-2cca-4001-a21e-6ff0a49a4e12"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2605c771-2b7e-4330-86de-9ae809249a1d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26145733-d5a1-48b0-a1db-f7b51907b2ef"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26388ac4-dd20-47ef-b97c-432eb9be718a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26825586-4f93-4699-bdc9-b5fa1ad765c6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26b4e612-30cf-4298-a8c4-413cd2dfb2b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2765e173-babe-43e9-8664-df3299217e3e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("277c1db6-1321-46e8-8009-a8cf66ca46bc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27b7b295-5f64-4b1c-9008-70a713470b2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27dd431c-5a56-4212-b1ad-5c654649e09f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27e3f38d-8579-427f-b98b-a30ef725e8f4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("284d2058-bf48-4f37-add4-3bf4d3cf7102"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("284fcc9e-d925-4ce9-aa6f-66f63b116fb7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("286c507b-952b-4f59-9d54-3261904031f2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("286c7917-c10b-47ed-ad55-66e97607494b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28afce44-5891-4579-9594-71b5cb2714f1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28c355a9-4c1c-4504-bf47-1ce901978364"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2950d433-bb20-4370-baec-1616fce97f8b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29f7d229-32ef-4668-97e9-822243caa274"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a05407d-7ea1-42fa-8cab-1cbc81359aa4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a48296b-ff03-4901-bf3e-03a6e207fb86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a5d22f7-d243-4200-be42-99aa0e85b38d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a7cb963-b9b0-44ab-9a8a-f35b5537de87"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2aa26e2c-407b-4f49-81e5-28395de74624"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2afcaf0f-532a-4c36-aa0a-e91e739955f2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bba50ff-b65e-4cc2-a17a-074d5d89612c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bdaa253-5a2a-47f7-b7e4-aaaf0433fe42"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c0e77b6-a54c-4014-bf51-a90b1ee5fd47"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c4f8be4-8393-45b9-80b8-6030e3b9a4e7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c5714d0-6fb5-4e1d-abf8-7d9ea4b15cd7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c625925-ef3e-4545-87f8-609ca021061f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cd9747b-8325-45da-92b6-c01dc43c8675"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d077109-6b33-44de-8e27-62e3ce694f23"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dab82f3-fb9e-4c81-a39f-cc0f874e0a86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2db9c650-ef03-4ae4-933f-12c253a21edf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e179cfa-7570-4684-b810-e5054f287b1d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e3ece6f-71aa-427e-addf-723c60e238c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e5167f4-ea19-4180-85ae-8ef36aff53a1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e8ff1aa-0f81-4001-9b68-f8536a615dc6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2eb1bb02-9374-4a54-a8a1-3e73a81b4611"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ebcc0ad-cc4b-4ecc-9019-2d14c3567207"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2eeb47af-55ed-4b1f-8079-2ae2ea9307a2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f70464a-5259-4a91-a40c-0d967c101774"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fb65a17-3212-4bb6-9a7c-6e365d00884a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("305cb84f-f3e1-487f-84ae-e12242dcc4ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30b60447-1543-4f69-8b80-bc514138997f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30e08403-3479-48d3-9dae-be2a6aa01c5c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3131fd82-e6b3-4ae5-bef6-80aa974d7d91"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3167036b-fb20-4d1c-8d62-07097ddd7418"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31bb91bf-c20a-4c49-b125-f3c9cfb2464c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31c8fb68-866e-4fd6-ad95-3ab3b90a4572"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("328a04a0-0732-4945-b358-6e6d17378bd0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32c003ad-1cbd-4b07-962e-0e4e38f59fbe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32e4e467-5c7f-4646-8d39-45a2353aef55"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33653f46-a2de-4afb-bedb-8997ab6dbe4f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("336e221d-df82-4ca8-acd9-b1c531a13ac4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33e2ebd6-e013-4b60-be6e-e261c4e2485d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("340cf8a0-a74f-4e2d-a5c8-56c0425cb317"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("343b4117-fa3f-4668-982a-ad646a94d858"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("347ca935-5221-4cab-8ac0-628f04d6614e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34dabd04-2800-4eae-9b01-41e1873c195a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34ec56aa-5f6e-48a5-8531-b0aee6f3e211"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3519337c-0020-4cfb-8fe5-9f70977ef43d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3599d907-6c00-4578-b569-365f4360b9ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("366d4078-7bf3-474e-a0ed-f44a65d21245"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36f8bfac-e8a5-4f84-9460-b4f2e71fe63c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("372a9fa5-f37d-47dd-9ff7-148d970386f8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3737fcdc-797b-4df5-a5b9-2c577644f518"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("373d9110-9004-4ce7-ae09-9e29b5ed6818"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3783af9d-e63a-4e62-b623-34486bd8364a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37d5149d-3418-4a28-9fbd-5d2c8a5d012e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37e852bb-a398-4fde-8cd0-54b21d4c7c4b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37ee17ec-1fcd-4d51-b104-d4f377e2726b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("380532fa-b7b0-448e-81f2-f53f631b6fd4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38422627-ac54-4d24-b683-f3486a8aadae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("386ae6a1-9d35-483f-8016-2e99f1e3583b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("388905c6-a90f-4e0d-8714-7efb9f64e10a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("388ed71a-0da6-4413-967a-3258428a24c3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38b67a68-7466-4b6c-a132-ddfd48a368af"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38bc68f5-21e8-449c-ad59-093d412b255a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38dd4a49-f1dd-40f9-bb5f-1dc2bdbc062e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38e64dbb-b6fe-46df-b3a7-75fa98dcfdfc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("390dc0be-5c2a-428b-a868-320f0c9b2bae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("391fb77d-fd83-45fd-92bb-058a6453dcd0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3926eb28-453f-48a8-a264-1906b904ecc6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39784d63-d02c-45df-95f1-a7493c09ba30"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3aabc5e3-65a6-4dd7-9f71-c4a87dd4badd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ab5bf3d-d812-4b7f-a9c1-6e3ba4db9126"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3adab313-b6f6-4d50-b2b4-a3beb77f806b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bf6f21b-7c69-4451-991d-25294e4818fd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c12b40c-146f-4752-ae7e-ec8fe6b3ba89"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c6b6e40-87ad-4126-a91e-4dc8bc2f5a7b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c9f9438-5727-4bb3-bebb-9fb700ebd2f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cb598e6-c6ed-4887-bd03-257d7c983876"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d8db475-4e1e-4cd5-aa28-109d69b1dffc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dd21acf-5194-4f49-897a-e33f03d55aba"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3deb96bb-6519-4f17-9bfe-cb78195a8dd7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e131ece-f768-487d-b0ed-e27cea8e4f7c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e16acd5-dca6-4d01-bd9b-96de0eac5212"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e2f5478-c288-4cb7-bb90-dcf865daf78c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e6216eb-8be8-41d3-a210-3f65b1a2ff66"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f064f45-9c58-4f69-abc0-64176e125c8a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f09ad30-392d-4c50-b99f-5ebb35be8ecf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f0ef02c-2869-4626-9a93-5345ddb62466"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f29236e-cc27-4c14-b212-9152ff739f62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2ba015-299a-4329-9853-c24aea7aea0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fbf5385-77d7-45f8-b2f5-4791215a6e4b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("401c5aae-ca98-4277-8b0a-5a20fe111619"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("403a38e3-495e-4dfd-bb3d-3938e841aa01"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40427032-5241-4597-a924-a844ca50f810"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40bbbf04-633c-4c79-ba82-2e67c3340ee0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40d3940e-0fc2-4f1d-8e18-16d447bc8337"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40fef1d7-a82c-4e99-87fb-a1872c94f7a9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4106e93d-1cae-45fb-8e6d-6fe0d0bd8772"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41098c1c-1ee0-4216-bbdc-03012ee5f619"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41592956-88c0-41f1-80c6-c269beac12dd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4178a2ea-afd5-4ea7-a787-2ef200cd4e98"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41b21c31-d144-425e-9028-7794eef589d2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41ea509d-7b9b-4006-b682-c1ae058bf148"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41fc2429-c98b-4733-9517-e3244c7b120b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4244700c-5f0b-47da-a519-8773c62df52c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4264ba81-8c3f-4fd5-bc77-925886ae9e8c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("427c7fc7-adc9-4f93-83cf-dc9684bf84e1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42816e21-3375-4c73-9472-6f6719ce1994"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4295ced6-ef7b-4e95-9030-fb5c799031de"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42ed6310-cbae-44e9-acb8-d1b94b93503c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43a0290c-5006-4099-96bd-2aa52dc30924"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("442d1d2b-23b3-4748-8e7a-0e5c1f547791"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44ae1077-43b8-4e3d-9de5-ecc704ce8496"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44afc871-58bb-465b-8d7f-86c63f645c91"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44e9d546-ecbd-45db-9603-660fd186f44f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45127df8-2eb0-41e2-b89c-f9e37face533"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4584e878-c766-4946-99ae-6c60c1d5f334"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("461e3ee5-1b2f-4c1f-8459-f8be72761a0e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4629a669-ee9f-47bd-87f9-09a1ac1ce8f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4636d146-8793-49dc-8602-063770db5089"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46de4ea6-c366-4b39-8864-f0640e13abe1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4718b0a5-e6a7-4606-9421-015ec02160c6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("471d4fc1-c344-48e4-a8ec-f7f7050ee238"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4778523b-507a-4c94-843c-98403193c8fa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("479b0068-e03a-4757-aaac-abe9953a8ed1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4888ee6c-6ff3-415a-8782-f980faed4d41"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48e243d0-3e73-4562-a984-90792b98b160"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("498a3148-4e16-4e27-a16b-d6a88ad4e4e0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a6e5e1a-1fd9-4b17-a40e-aff6b9bb745b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ab288e2-60b6-40ea-833f-045964f29cc3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b53e27d-4f01-46ba-b7aa-f68833bf0347"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b9b6e4a-854d-4a65-a6fc-58aa4cdf5d38"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bbea68b-cea3-44dd-9da3-6fd4dec28bf7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bcc3b90-fe46-4303-9eac-fa30aeb2be67"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bea9356-a8c6-48f9-b28c-6da92805a219"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c16ec58-79c8-4337-b05b-6fca14be6c96"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c56828c-7b3e-423d-af76-cd382e7cb071"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d17da67-bb02-426b-9352-872a2b6b7221"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d39be5c-4838-4af7-be47-020c14d2788f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d7e9a4b-7a74-4770-8f7b-dfb80d513e43"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ddb3727-847d-4934-9d96-d4ca8f155e8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4deb0724-6c9d-4db1-933c-3213185ac40d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e017fd8-f9a0-4bf6-8ece-7df7c5f14d48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e089db8-feb6-4069-a42d-cce7ed221355"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e3f79b4-a5c5-46e1-8289-2cd606ee389f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e4a08d4-edc0-46a7-956e-8886f2fa70f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e9a5cd1-2f51-4ce4-9355-fdc52f62e6ea"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ed1bad9-b352-4bf4-af8d-53182603bc99"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f0e6b7e-104e-4e03-82ec-7059191b5533"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f77168e-252a-424e-9ac5-bde9e041b353"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f812544-9929-48bf-82a5-6f5c7dab20c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f9e77e3-db8c-48ba-9a39-e59273e951f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fbb3eab-3e09-44f2-b978-5c251760eb89"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fc85375-968b-4bd2-aa80-50bdb36db320"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5019c726-ad08-4c50-92d3-82d505d8fe2f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("506bc753-8847-4a1c-a16e-633c25947904"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50f58d9a-77a8-4754-a448-221289923bd0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51055135-5a99-4584-b9dc-cb7a4f34e398"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5135b95f-7acd-4b5e-a65f-ef1dcaf29791"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5187187e-5acd-4e15-bc91-0bb5d3a0543c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51ee1cf6-f72b-4151-9261-e37fdb90816f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52218408-71db-4642-ba58-6104a92fec74"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52342fc5-cf8e-4210-8f48-b3625a137c2f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("524d9006-0a89-4fb9-a799-c1560d7c3b28"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("529339d5-ebbb-41e1-9770-5dc4a747fc75"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52cabc26-d159-4a6a-8191-54c8e69e41bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("53bdcbd7-a3b8-4d45-b5d8-93b53f8b4913"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5413bb90-b857-4ea5-8902-ae170e2038b6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54e87c39-383c-4fd4-afe3-ebe5764583cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55599ead-9408-4772-ad0a-8bc6b2f7c84f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("557a417a-ee9e-45d8-b18a-14aab221d22a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55968491-3a72-4cca-8e44-5923915a2370"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55a9adbf-c7ab-4d56-b00f-ac83b024fc9b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5620d05e-175c-4d56-b3e1-90dd363be9d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56328e44-88f5-4504-a041-6b5d4cc17226"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("566325ef-98eb-4c9c-84b1-fe2319e97c4b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56673be6-6950-4015-aa16-96db27641cd6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("568b2484-869a-49b9-b526-e4272295ccd6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56e47f8a-5a50-45ef-8d81-cfea14741e5d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56f68871-d930-4ae6-ace5-15ccafd25d4d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("570d1f44-9310-4a72-af6d-03940fbe693f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57762ba8-8558-44ea-820e-501650fba948"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57a0911d-a2ec-4060-84b8-d86993d1b504"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57a3c22d-0941-4d4b-bab6-1661be414ed6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57f981cc-8467-4c2b-8715-b3e2311580f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57fb9cc9-7260-47c7-b20f-fbee310b7363"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("586a90b6-8876-407e-9cde-f53fe1a9079a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58bc6eeb-cc1e-44a5-aae7-21acd1373ce4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59922ec9-3a1b-42f5-bb25-9c044021e819"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59fb02d7-39c1-44d7-9f7a-9a839dfe15d9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a22fad9-222a-4b66-9f82-b91cb1c20eae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a77fab9-3f00-46b2-b8e1-e552fa31e596"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aa72556-2cec-443e-920a-f95c60949c01"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aef90b6-32f3-415d-ac9a-ed1cbd9e0071"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b10baa6-77cc-4764-8d70-07d8c5687aa7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b4c4940-d9d8-4cc3-8dd4-152b2f2e5e88"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5be324a6-b9d1-46dc-adc6-d38773f45e47"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c38b9ba-9509-419a-ab3f-53d7908cf855"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c45c652-d2f1-420c-b730-a9e1fa5a32f5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c67b787-1179-49d3-9c64-21b433f7b6b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cfede72-a343-464d-8125-eb80f51d9ec7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d1b374f-a850-433e-a849-a6aa0ed690fe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e40cf1b-6089-4409-a0e6-a84e510e3896"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e69cc09-a34a-4ec8-b0b5-74dbc60dadac"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e9705ba-0c42-4312-bc1f-65a91b79b384"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ea7f7af-7673-4b2b-948f-bc759a55346f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f2979a4-ef18-4fd5-b63d-5a290305baca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f3fd848-a56a-4655-aedc-6b1f282f86cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f52f3f9-0819-4b7a-a461-942d9ef8a5ae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f60e6b0-e0c3-4ad2-94ce-7f33972d9003"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f64f596-3d54-4c54-8795-b76b84755685"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f69f22a-6459-437a-938c-33b8c8f05345"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f95eba6-2bb2-4923-9aae-dcea38a13336"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fc6a44d-01cd-44cd-a946-0caabce44655"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fd74fa8-a8a4-43ca-b4b9-56299e7e3622"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ffbebc2-81d8-4987-b8ec-fef6369fd38c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ffd5fcb-4c6f-4797-8975-0651b90735e4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6049ef00-7125-4a3c-afc7-f137d756e3f7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60721ec1-5299-4f8a-b53b-2988147dca9a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6120a74e-a2bd-432f-b3ee-3e098b26276f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61c9a15e-9d4d-44e8-bcb3-2009f6fed06c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61fc5a3d-ee90-41f5-9e6b-a6d2cd64972b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6226d3e8-47ea-4107-b06f-a0da63960090"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("625437ba-fa22-4f4c-8ba3-c557509a3b62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62a3daff-d541-4bfd-8517-872c2e796ee2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62f52ab2-2214-4da2-b858-f827fcf17e8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("636509ed-9301-4eaa-9713-eb03404a52ed"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6396d9ca-7ddf-42d4-b496-18468f1f8653"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63db219c-ba0d-42db-bd13-116dcfee96a6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("642860ff-835c-4d45-9e94-62aeb606ec86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("645ee195-e337-4454-9963-fa74c020da21"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6487425c-08f1-4ce1-b160-61579c4e55df"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("650da18f-fdbd-464c-bb6e-306698047288"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65453352-1250-4981-8c77-ebe7707f440b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("657c0aef-9665-41d5-a891-ffbb2bdcc380"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c5df06-c23b-420b-9a2c-8160a2daf859"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65c9d072-648a-43a3-be5b-45a29047444d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6622f536-4912-456d-acbf-aa061c4769a0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6635a271-757c-40cd-9516-01fce5288907"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66693d79-5968-4d37-b7ad-26b1f76d311d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66b00af8-13e4-492c-9b1c-8ef3fcfdec5b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6709af28-1c2c-4370-a878-c7d64e94c4b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67c1fb63-0e61-49a2-8b4c-87beb8c3f9e9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("680052ef-60ff-44a3-b1b7-a65b98e8d701"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("697d24c2-9a3d-467f-beba-00ce320a45ca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6995f05e-ef15-44f2-8fa4-0ea1b8174b70"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a5aa40b-124d-4306-9858-3e14d021fb86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a7b4e3e-f8f7-437e-8806-83fc03f27293"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b2b5f26-62b9-4613-97f2-d1929998da9d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b346627-4c6f-49da-b8d7-0343e9495fff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b4c05ad-251f-4179-908a-b9c17dbee3e3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b529526-a9a4-4f35-9617-66f8b882bb51"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b53ef34-26cf-4a0a-b4db-7637dec181d0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b7c814d-e0f0-4484-a687-9210e65ac69f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b9a381f-dffa-426f-8f9b-1a054d827a1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bc63621-ed5a-418a-b201-3f23dedb9fa3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bf2a200-f42b-4075-ae5b-a91b3b50a3b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c1c6b94-8d53-45fd-b765-c321da356adf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c41b321-fc23-4095-9a95-6fd768277417"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c53c07b-e4e3-47f3-8f1b-4a4e779277f5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cee756e-bba6-4942-a7d4-0165773d21e3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dcf220d-5916-4cf1-aeaf-2dce93c59a1f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e1a6089-9343-46ab-9b93-ae7d0fccc752"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e3da614-2674-493f-8f7f-a4094ccb8a8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6efa8c95-a768-49b9-a98d-359aba65aa3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f324b7c-99da-4933-bb49-12b30bde1ab9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fe28582-79d3-466d-959b-96279aeb95d9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fee6906-64f7-41b0-8162-81cd5e7ec2fc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("702f15ed-8fa7-4c2d-86aa-b6c7ac521739"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("704eb4eb-bb31-4e43-b5e0-d8a95884dff4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7065242c-7f2d-4ec8-8f65-1a87131e9085"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("70d06f6a-9a1f-446c-9088-0e7c56fae870"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("717b71fc-6468-47b3-bc3f-9504430dd5c8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b2b69a-1b18-42cd-b3e9-49b4a74d985b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71b39282-3ef4-434c-88a4-f8fe53aeb7f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71c46acb-f36e-49f8-87d6-45a80f48b0e9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71dcb3d2-785b-442c-8bda-796d6dd14dbe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7221ac57-b0df-4792-a231-125583e16089"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("724d9b5f-4f62-4653-b5b4-d6c4a221e9be"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72da4113-1530-4383-9414-c10f9ad2de66"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("734f6281-f438-490d-909d-0e6350108ef0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("739c9950-1665-4362-a1b4-a7a7318d3de8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73c64542-6d77-4e87-80ad-7c646a467e6f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73d1cd1c-ae2f-4359-bed6-f65915f7f471"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("746f2bd2-f9dd-4456-b113-1b8079e9c4d5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("747f0803-aac1-498d-ac38-6bf9a256f353"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("749a939a-c369-4c0d-af45-17d913dd3e1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7503c2a9-c6c0-4e67-b114-027fef7575c1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75519efe-d186-4633-99ed-5868b15c7e1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75c193ec-f7dc-4511-9f42-aade8f811513"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7661e0be-af83-47ba-843a-771084a32019"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7737fa11-6373-4f8e-952a-cb46b2e0c507"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("776360f8-6c29-44f1-8a86-692171333c40"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7765f961-e8ff-48ee-889b-ebae92074903"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77868af2-fd76-4439-9970-0f5eb87c8a11"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("778c9a14-f4e9-4fe4-80a2-325d93c9c368"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("778e7d7e-d037-4337-b48b-b8b094657778"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7826017d-69a9-4f84-9e52-3cca427e2f13"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("787cabb3-429e-4589-a557-c232803e6a6f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78ec1e41-f932-458f-ad49-fcf36cdeea2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("790e3eaa-832c-44f4-9e44-e824ecc957b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("793b5dba-da4f-412d-affa-3b12c7cd0b9b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("794858e1-1841-470a-bbe4-ee64ddb7a3b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79833465-e45a-473e-bb70-84b7270269d1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7992f58e-b0cb-4636-894a-737567e4b354"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79dd45c8-6abb-4cc1-a6d7-176fcb4dba3a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a254063-9b37-46c5-a372-dfa2880d9cb4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a32b3b5-984a-4b3d-acf8-cc90e39d43f0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aa17d48-9920-46f9-b5b3-c34a9b368255"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ab108b5-62f3-40f8-aceb-d2b9047676e6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7af822e0-b632-4865-a60c-ad65c886abf1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b4e2151-4a32-4420-9970-7a5e3f231a09"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ba0b59f-f112-450e-8c29-a474cc474b48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c1b14cd-e3af-4f7f-b88b-71537a0bd41e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c3ce1e9-70cf-4157-bdec-2a251fe09153"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d10eeb6-f88c-473e-8d27-9dea4adc9e0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d94416d-bf8c-46aa-a41e-e1ee6e19ed6b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7da7df46-8c76-4d47-b240-f72c64f2bb44"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7da8e54e-4138-4bda-9175-75d19780bdae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dc8c871-8b88-4283-a909-d7405f90b8e3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7dff0ff7-1493-47d4-b9e0-ac954ad432da"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e133375-316d-4fda-930f-03983c98209c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ebfcb9d-c503-42db-a2c2-b74a6cb68d28"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7efc9bb3-879c-4af9-abfe-7dea20329e20"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f259b69-a39b-420e-99b1-10d0e82664de"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f977275-a355-45bc-9187-d3391977c138"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fa76ba9-e6bd-490b-8ec6-d45b3909eaee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fb293b6-0728-448e-b1ce-f974b3edc675"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ffdd858-1d71-4455-8434-553b7a3149a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8087a090-515e-4987-9b84-f9544ef31329"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80ce9564-5fa7-4f5f-8d3b-59c6e58bba19"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("815991e1-e273-41f2-b5f2-dc849ac6e808"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81ad6589-ca34-4418-8cbe-c43b6321d2ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82026bf4-9c85-4d7d-aa73-88ed5ff1c1f8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("828be8d7-09e2-4620-ae07-d6cf15af902f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8295594d-bbd1-4a0b-9d19-7594586a7821"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82d59e38-d980-4aa9-8d40-8fa03cac5178"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83097d13-8402-4560-9c48-bfce3b0b1297"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8362802e-199b-4e06-bfc1-2fc3d60260fb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84465576-4476-4ca4-825b-7a84e22038ae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84b0817a-a6a9-4935-ab97-c6283f2990aa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84d49021-d945-4456-8a47-627231c0e23c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8572e313-ed6d-41ac-87e3-51a23435cfe2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86423ecc-616e-4784-bbbd-0c6472409e8c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("868ff154-b52d-473f-a68d-c44003b15cec"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86923a18-b47a-458d-a6d6-b61b51e93781"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86a4eb6a-4082-4932-bc4c-8cf3cbcec138"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("870c1e8d-6e6d-4b77-870b-ab73217ef0bc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8712b613-4456-47ea-8710-84cfcd8e84ec"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8727a524-fc51-4360-bb2d-6350a7c17004"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8757cca8-4d52-41d0-8069-329cb0e1c854"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("876f1699-90f9-424f-a2cc-547dd131f7ca"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("877434c9-c129-4d91-83d7-2b01439e132e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8809fbd0-4cd5-4100-81bc-d7e0791942a6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88171ed4-997d-4a57-8ce8-f49fd6294355"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("882bfbb8-3532-4e9f-937e-f1b83b5d1da7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883afdef-6a15-498c-8a2a-259fedb503a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("883c963c-d6fe-489e-be2a-acaebd47aa7f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("885b7be8-045d-4c1b-bbb8-06ab0b519196"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8887063f-1d3d-4aea-a4a0-e8a263353685"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88c42d1c-03b2-4b59-8164-92691e0f8b29"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88e56318-fc45-4601-b626-2b8ca7042092"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8941d78d-a48d-4448-bc13-e81626e36a57"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89447d9a-5c48-4297-a5e9-a19040b7510e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89a22a45-5f1d-4610-ac36-d97711789889"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a1ed767-8217-4b34-a918-874a7aa4059a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a517609-4ea8-40a2-9967-d324bf4c6414"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a53c517-f131-4136-8fda-a027747f1488"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a7465cd-3a4e-4100-b2d3-8bf3deadab87"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ab4088e-14ca-422c-a87c-a92bc99b6a86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b277ea2-aa42-4ad6-aa5a-a4cd27af8cfa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b7c4cf1-45de-4cfc-8718-8be0ce208914"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b9806ff-5a3c-4a64-b8f2-7de000d8d74d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bc55920-dd5a-4c4f-bc3c-6f93fb22e42b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cc138e0-9e08-4292-8c6c-49f4fc1d5099"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cd062fd-13e4-4527-81a1-527d53942614"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d1c5b1c-aec5-4a81-8b41-e6b4c5739ed0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ddec21e-b0b3-4d3d-bcec-567feac74d5e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e67efeb-5141-4ffd-a27d-08f370e57b4a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e894f1c-8734-4c73-ae97-24212eb21e8d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f38fd54-33ac-4e98-a362-1eac37c448e5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fc591c1-080c-4b50-826e-8e86a6a0697c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fca484e-b390-49ae-8a0d-54715d46ed43"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff2bb54-cbb7-4195-a2f9-dfb1349d4581"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("901de49a-fc48-47b4-a8fa-4aadc5608afe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("907d4d2f-9d8e-43a0-91be-7c49c2c35db3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90872bc9-0b98-44d9-bda4-a75c5e43eba1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90f6ba30-3864-4819-a0ba-82fc516d430e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90f7ec70-49d5-486b-90d3-457b638091a8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91299716-4322-420e-949c-70a689cbc7cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("915fccb3-afe3-4765-a7a1-dfea551f7631"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91a76692-c51c-48b7-a29a-cb53af3ea431"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91d54624-af9a-4723-bba7-12c1b5d54653"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91fc05c5-9f3b-4e80-80d8-947bbe3dff62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93112c3a-8722-4406-a675-3f2fc60955a3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9324f241-2c9e-4cc2-8452-422e47b78df1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93351c9a-6420-4628-a60e-9c786106382e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("935a202e-eeb6-49cf-86a2-99c18aed1b5c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("937bd132-75e1-4555-81b8-ed9560973701"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93aae39f-bbad-449a-b2e8-e2e37f7b3f5d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93dcdd6a-2e5c-48a2-aac5-dc680675fe87"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93f1aec9-62ae-4f28-bdbe-841234bd47a2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("944fa28d-a4fd-4fd9-9d32-1e1a349e67f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("949a35bf-98cc-4cfe-813f-15a848e492a6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("950eca40-2183-4294-bfea-13d24b185e1e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9512d932-92de-4734-b3e4-22d3d50ee234"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("951780c0-13b1-4d1b-b932-98eb8b3230f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9568d653-06c7-4432-bf6d-9927893b8f99"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95d24193-ed78-4cd8-80a0-c99150269aa0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9638609c-23e6-4979-afab-8343cf352444"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9674b2fc-2b23-4654-888d-c22e11fb18a9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96ee3419-df86-4850-a688-f469f01b45e9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9704deb6-c4b0-479b-865b-101886698939"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9707e772-8133-4cdb-a2f8-7b5ad53a9c64"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97092039-ef1a-4500-8c6b-b061b3cc0e96"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97579585-e5c7-46b0-a05a-bfcf2e8994b8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("979a1474-2f16-4c5c-a890-63adcccde97f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97ef0c6c-8b62-4302-9364-d1e9df2e5c56"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9818f6bc-b494-4371-821a-399de111fa8d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("984c50ab-5311-4bcb-ba76-66c315d03faa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("987b7341-ce8b-42fd-b5da-3f983ffa2f65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("988afced-2a41-4d3d-ac8e-972936fff723"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e6367f-9f32-4e75-b9cc-9811c797434b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98f133e5-69c5-4e30-b37d-36020c88bcbb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99402327-b033-4730-8cf8-b87d66e4426f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("994ae634-cbe3-4b63-a688-fb4836a5cff2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a315e71-2541-41a3-b9c9-b9d0ebbcced6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a42d4bd-f48c-4a2c-b05e-7bdda7dfd313"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a5516d1-b062-4eab-a393-973fc4d0a5f6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a6697c9-8cc2-4574-9e6e-76c3f1e8588b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a76247d-5004-43c8-83e0-9812b3f4da28"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b02d7ef-cd11-47ab-a8d0-f63297d33a60"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b23f35c-56a2-42b0-922a-ed06812db002"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b6cd566-53e5-420d-b248-b361cef2e157"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b7275a5-092e-4b3f-a8d9-a3bfe8047ddf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bdcfe52-cd60-41f3-b95d-29bf1e3699cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c554c35-d206-48f7-8135-29ec271a274f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c75812c-f720-4013-9fef-0d70c9b6406d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c7d5aa4-d29c-401b-bf17-c8cb09b94b3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c860c72-2bf8-45fa-92d1-3a3c3eb52718"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cd328a6-b189-4e2e-a939-4aa42406ca61"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cfa6ff6-a5e9-479f-807e-fda82590a360"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d225e00-c00f-47c1-a726-a8e56f8d581f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d268bcb-fab4-4bed-b563-699d574fb7df"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d480cfa-a3f0-4d04-9f15-0dbf00aaa442"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d5b2c52-3480-4a21-baa5-50c33ea44614"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9db37099-89d4-4002-81e4-66e2bd6b561e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e5ccbaa-8108-4e2f-ba2a-90aa5dbebb54"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e9e0524-5400-41c8-9525-965c29d52bb7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ead92d1-cc06-45a7-a591-8e479cc34824"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ed426de-3809-42d6-920c-16c4a9d376b2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9efedf3e-5bdf-4e27-be12-c16c598eeb0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f216c71-b994-4c77-bdc8-60d13359c4cf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f2685b5-f20f-4953-9a9b-3ed2234ff3c9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f5a3687-a523-4ef0-811d-65f3cb445b93"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9faaa4a8-a964-476d-9bf5-6a6a572e72b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ff98384-25b1-4cbb-ae6a-9afaa0da7669"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a01be4e5-59ab-475b-9e9a-ae2e8c673aa0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0366810-fbcb-4a07-b438-45bfa8be178b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0735573-01d3-415b-b5e3-3aa314bec806"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0d19745-4061-4cee-8b5d-aa498478cd65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a192410a-4f2d-4f87-82d4-ced5e9c15d38"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1aad95e-cd8c-47e4-ad6c-e116e136a372"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1ac9226-b8c5-4a60-bd69-e1d96f116b52"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a279ba83-4bba-4885-a04b-4a9281a1b08a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2ceed47-99e2-4a54-a651-6a38af00ecc8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a2e1ca42-ae36-4625-938f-56ab7f1fc370"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a304f80d-497f-4475-8b08-ff7db56fb697"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a37903bf-facd-4e8f-b5c0-ac2105de69ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a38e2e0a-9747-460b-b745-a6a797a6459a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4738500-58c6-413e-89e0-882187d74017"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4f6f494-a174-46c9-9b2c-cb460636942d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a51c371c-db14-4dd2-b4ec-46e4da6c4bcd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5e2a93b-697c-4d42-80b8-5ff124c9a972"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5eba125-276a-4f22-b508-81d5b66f2757"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6575091-5049-47f0-86de-dea1c92c1689"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a673c6b0-6085-4a14-a694-e3537fb0c9bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6798064-0a51-4c85-a15e-75b88faeef04"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6b1c5a0-65b1-40da-9f22-6f58e15c7a36"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7ca12ba-4230-40d9-8762-c381aa5d1006"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7dc5447-fdd5-4fce-818a-0245f0273099"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a85d0bfa-8b10-46bd-96c6-6b42eb9b3924"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a878a08f-7432-4ad1-a511-f9c7def2b8da"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a878b474-4d4c-4ac8-8050-23f552170059"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a92c4725-a849-4805-8d72-1060001e3cae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a94b1b95-ba33-48b6-9c6a-bbc9ef3b6583"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9978320-ee47-4ff0-b9e4-9371f166fdfc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa443b89-2879-4fcf-bcbe-b80e001e5bc5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa619ef1-8190-4261-a550-63efc9ddb148"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa691d6b-02ab-49bb-9f66-9a95354aa067"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa782566-883f-4c5d-800d-b2bcee0808fc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aacf602d-6a0e-404e-9b32-d18aa6d91cad"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab3a7e70-2956-4b5e-a8ee-2c0ac52783cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aba5df5e-97d6-4517-a28b-5ed91f313714"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ababd03f-82a0-4520-a64e-fe9e7e1cec3a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac6dbf13-25ee-4e5d-97d4-472ecefc7f86"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad1cab04-74bd-4614-8444-79282358633d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad8a7d77-aadd-4be2-9e5f-d86236c51851"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae19613a-491c-4538-90e3-45deecc17fea"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae3e4851-631b-4f8e-b990-545a3cb40c34"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae9d3dde-a12a-4eeb-b0f2-dc533ed5e38a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aeb3e494-a12e-4550-91c1-f984e6290ec7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af3bab1d-ae81-487f-9c86-d670f5c6e9a7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af3bf1f3-eb62-4f47-b118-de5dcc3bed3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af4ebf18-c429-434f-bff6-43b42c7d966a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af83bb0c-a869-4890-b2b1-848f28a0ffce"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aff85e97-4817-45b2-9897-97b0cf8d20c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aff98b56-882c-4997-9e6f-063f17801a7e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b02bc556-8873-4fc5-ac2f-1e462dcdf522"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b05a6558-a6f8-4d76-9824-90d6ef1ba784"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b084c7a0-69d1-42fd-a4b1-4d2035f3b409"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0aa293f-e267-44cc-8583-8c2be520afce"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0cd364d-e494-436f-888f-6a37ecd4006e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b12fee30-ba6e-4d1f-980e-5702218979d2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1300d47-8e99-4add-831f-e70655f32a59"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1576050-1be4-4450-abaa-0088f18156fe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1ab475d-6b32-4808-8cf3-38a7b3bd53ff"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1af4420-0a17-4aef-b6fc-44d9aad7ab62"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1fb26d6-b3e3-4d74-89d8-94cacd01eddc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b22b1cdd-0aa4-490d-a10d-f03fa0abb9c7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b24739ca-66cf-4b63-bd34-07cd42df347f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b289387a-ff9e-4ddf-875c-428d527ca30f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2dc90a0-f182-403e-850e-0c47eebb617e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3100018-2645-4ecf-a507-e2eebee712d0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b331ce3f-4a21-4df6-836a-e0908819f430"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3ca38c0-19c0-4ab9-9f25-914e0773276f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4375e06-4234-4c9b-971f-276669761eb5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b45f5951-5d02-459b-a221-cb3ed94f86c9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4a661cc-97ea-4261-8dd6-8b2ded826ef8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4b80d5b-a914-4094-a132-2614a7ae056b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4f5361f-79bc-44c6-9f76-1229826e8421"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4ff52d4-7297-4584-8fb4-ce5725a395b6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b54204de-3855-4ae8-bc16-63e2ebacef4e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5644275-0d2b-49bc-8ba8-79b1af802e75"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b57ef255-f552-478c-b47a-abd979832313"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b29a2f-190a-4263-9b63-f7a091d0d12b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5fef59e-6b11-43a3-8957-dbd6a2ebe962"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6d109ac-41cb-4cbf-9253-ef39f4782530"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6dbe56b-ee92-41da-bb47-76231b042270"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6dde842-af74-4680-87c1-e440c7bdc9f8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b73ef93b-723d-42b5-8111-7a426bd6a362"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8010cc0-d86f-4c38-8490-22d1bab318e5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b83e9472-2844-488b-ad03-ed487d6ebefe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b844bde8-761a-4c63-9d94-8a03914abe25"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8498edb-7f49-466c-8254-dab678629d78"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b895fdee-d5ca-4c07-ba66-a98b213d551c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8dc1de8-7325-4987-a864-cb38414ad066"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8fe6e90-dde6-4902-8d16-fb51159269b9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b919e7f7-d946-4f3d-963a-6371714bb899"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b930b795-a9ab-49dd-8c98-4bba9e96787b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9a2833c-ffff-498a-8eb0-ffc5b94c92c8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9d68350-99d4-4e94-b7d2-d8bff1bcbac6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9f7276b-962b-4c24-9b88-63590a5e7d5d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9fd1081-91ca-4682-99cc-5b2e89157586"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bac78566-b1e0-4b2d-9756-90e10597437a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baec383c-54c1-4eff-8aa5-1b552a1e5c48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baf0ea29-b12c-4653-a2cb-4a6f95f7ba37"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baf30168-a5b0-4b06-a1fc-087f96349ef4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb230ad9-002b-47b6-96a5-926fb203ce0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb60ce14-d7d0-47c0-b084-d4ac55a2ea07"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb88b1fb-c075-4d78-9e1c-84468fa10172"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb955e4b-6b32-4d7b-9171-10e1ba28825b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc104700-57c1-4516-8b9d-fa02fe9d971a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc464297-c7f8-4395-b004-332bf1b813a0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc57b54d-43bc-491f-bef8-3aabf30cc924"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcba6750-42f5-414f-8222-c3058e4a09ee"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcc6d10a-5634-4fd1-8d67-22bd5ed6e807"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcce2f80-f21b-413a-876e-b2b6af170563"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcf1c1a6-1aa1-4c13-9f60-1f24f4e8fac1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd246710-f2e6-4ad1-8332-c7f136d74966"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be1692fb-184a-4df4-981b-bbaea77df19f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be21e542-b821-4eca-ae08-6f26d76f1000"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be2985aa-2158-4d17-b93e-89b50457b2fb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be2b305d-474c-4dd4-b1e0-2a6413e79ed3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be8d14f0-c1ce-46a2-b090-a09fd9e3ac5c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf094208-888f-4899-8c3b-dfca9687b0eb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf33ee74-8b81-4742-bf91-7bf54742b32c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf606fd6-57e5-47c0-aec6-41fce83dfbc2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf801835-bf93-4abd-8bd9-9f28f7fa953c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf9491ab-dfed-40a8-9f7a-470ced4d023c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfac89bd-435c-4c0e-87e7-49493876ece4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfc528fc-4ef9-42e0-930f-89592d81ab92"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfcbea48-5e89-4371-bd94-43ee47ec5cc2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfe1b4bf-bc65-4171-aebb-59b9433eac82"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfe61564-0403-476d-a0bb-cf46f07e3e7a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c04735c5-6e9c-413a-bf01-94a4e24769bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c165ca72-656a-4123-88a5-aefd1290508f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1f3c0c7-cdd2-45e3-b380-c1df47b8fbc8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1f971d7-1e1d-4971-bf15-3ed6b2e323f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2230a23-6d14-4f2d-b8ce-db21efd8c566"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c23bac34-2e72-4a64-9504-f5660ee42bc1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c26e3b28-e899-426e-8381-4a59a2338ca8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2898606-4a5a-4563-9144-8d69c8f410a4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c28a07db-601e-4d54-ac94-e35ee31d8eae"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3d5d302-e2b6-4e77-9501-a8da9ddfaac6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4752586-02b8-4eea-b0f0-1f9f5b129b2c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4764c2e-834b-40f6-9af0-f97169359f7e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c49cba04-84da-42bb-aca4-499d62b952c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4c54ce8-24f3-4f3b-9454-6d3e3126a85a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4d8ff2a-8b6c-4de2-abd1-19e78844f36f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4dee1b0-482f-4f5f-988a-5cc9f8771689"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c57a84a4-43a7-4e74-b67b-d3c50daae0c4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c57cb701-8165-4f8e-8965-9e0b913c7256"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5c548e9-c21d-4418-b4eb-e5b83cb4ad5a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c60aa8d6-7774-4c03-8750-56d792c34714"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6275a36-36a3-4827-8f75-39bdac3e483e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6924e2d-6125-4a2b-99b0-e21af30494fd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6a40310-d603-424b-a74b-2670d11ade7c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6ac5fa0-fe19-4099-b543-dd48e20f9da5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6eccd96-f894-4dd8-8444-0c561897ed2e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c71bdbe6-0167-4cf9-a65e-851922978e65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c730c780-bf9a-4447-ba74-0c848d9b661c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7c11827-4ccb-43ff-9387-e09190f63c33"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c88250ff-9f7b-4478-9cc7-2413b966f865"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c898fa77-68cb-47cc-a74a-1ddfaeaf6e1c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8c10e62-27ac-4843-a3c5-9c1cac0fb962"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c942e652-ed87-4614-8ca6-4bf773fbdb90"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c96619e0-00df-4ffd-8351-d16e377e04f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9eba354-f401-4a6c-acb5-09a7c4afe021"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca1e2e3e-3982-4b90-ba9f-6d563764a065"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb10447b-19b2-4446-b384-a5930fd0737d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb846a0a-24cd-4f09-bfb1-ddfa7fc93fbe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc655258-3f82-433a-b834-da5e43a49465"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccae9be7-43e7-4558-9baa-9fdb536808d9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdc53d76-9211-4550-a651-e516de59723c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cdfe05de-807f-4c63-b24a-63071c4f3024"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce51b0e2-3953-49b5-959e-8428b6569bf3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce54bcf4-1244-4227-b429-840b9118b493"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf033129-159a-4325-93fa-640316095ce0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf08ad30-603d-4b04-9541-d03ca58b421f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf293094-dbdf-429e-a60e-9de6d5ee7fb0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf39b261-5214-45f4-8bac-f9ea719a8dde"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf52601d-af9e-42fc-b9ea-8e0a17a1e387"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf77d508-be18-419a-95fb-0da7e4b7464a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf9c8d40-b10c-4a2c-9069-e8d418d84a55"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfe18bd4-4799-4240-9dff-f95ca617622e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfebc795-ea9f-43e8-836f-7a8438203a33"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cff344f7-c9ef-4bd4-a332-3d76772d5439"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0b701ca-12d1-43d7-9d00-0e35c03dd4b9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0d4831b-b5fd-45ff-b577-ba106806c807"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d15f81d9-9bcd-4067-827b-82974b6ce46f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d191ced7-40ae-480c-8fc8-ec955f6cf842"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1adbc03-f325-4fc8-a412-38adc2f68ae7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1af1ea3-111f-4433-be66-47bc7afbda78"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1bf0b82-f23d-4dab-a91d-ab4b915c64cd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1cb9bd8-17e7-4df4-9a75-ffba2716b503"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1dd73be-4451-4b46-b298-bbecfbf3d6d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1efab83-c6c8-430f-b6d8-afbfd8dfc57b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d21b0d2e-b965-4a0a-a1d1-4ba374fc6639"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d271c158-42fd-420b-ad0c-6f6cce6e1dd4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2aeb91d-f565-4d03-a2be-346a6e6cbe39"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2fad058-68c9-43bc-82b2-70a5c2acd67d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d302873a-7f24-4f2f-b12c-5905bc97df14"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3086f1d-ea70-4eae-9d47-154ad9a5dfe1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d320592c-c14c-4821-9ae0-fc40401c5169"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3532e4c-a8bf-43bd-b9ed-3b8065b5955a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d398cb63-d154-4920-9301-818f9adeb213"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3bd2cd1-864b-4f12-960a-89a0200ce4aa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3ecdcbe-0102-493a-b2bc-c4c0832c06fb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d44298dd-7c13-4514-b61c-783eba3385cb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d44b48cf-891c-4fa6-ba85-14502cddc59d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4703a9c-8551-42a8-b0ff-889e1d1b18fe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4781ba2-20ec-48a1-b9c1-9301492db3b5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d47c75c9-8130-406a-a890-e1d336a7415e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4c30afb-c9b8-4750-a544-6943c9d04ed1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d57d8158-466c-4c2d-87fd-3ac70cab14db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d58bbb5f-5d99-410b-8073-f0b812cc0cb7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5e667da-621e-41a6-8073-292dcc919328"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5ef249a-5d00-412e-b66e-c3763a387344"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5f0aaf7-0aa3-4bb4-824e-c0295edb6c0c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6557fdf-9bf9-4dbe-9759-977a83b3f07a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d65f9ee9-5cb9-4312-b839-974b50a220b3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6668131-8c47-49c8-a9dd-3bba8dd7709b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d66b57bc-81d3-4ef5-8c4c-0b1e8c02a134"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6ebc7fb-054d-442a-8109-e731363b724b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d71e9b90-a847-40f6-b00c-94b903d61925"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7399f01-d819-4df9-a7a6-d9faf5b60d19"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d73a95b0-1028-41aa-b327-977ea9888ed8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d852b30e-5122-4959-abc7-ef81b0e89b94"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8623b78-83c2-4428-8a6c-eae08ff31419"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8c7c8cd-20fb-425f-94a1-6ddb52f38e6c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9478ad8-c375-4982-8990-0f4a0bb155b7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d97b60f8-fdef-4be8-b895-2b6e37165b02"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d98ae8f3-a858-4d99-82ef-faaad304c7e4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9acf79c-4d14-4a89-9268-2f6386889272"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9bcfc9b-3f99-493a-bd6f-fc31968fd341"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9cc467f-13ef-4d79-9c87-42db5d598a27"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9cd852a-b2b0-4311-8aca-ba7df2050ea9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d51385-2329-40e5-8770-9a3558b4a489"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d72761-edab-4e2c-a07a-1f06f8675145"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9f21199-97f4-45de-93f4-bee8c0864158"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da13c5e6-b6bc-4d63-a0d0-5ac911e8f516"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da1427a3-c1e8-49ce-a3ad-55e62c041369"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da19bea3-cac3-4233-a2b7-f261b3fb728b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db4b3c93-3f65-4a80-8cce-cd76e39a43f3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db6ea18f-1a4c-4895-940b-b6f8c3633e43"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db847cda-01cb-40f8-9633-3964ff59b0db"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db89ff70-cd6c-48b8-a627-1bbfb4376f40"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db9018da-62ca-4d64-ac74-2de5dc8b2ada"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbb55a16-e848-41b0-9d72-7297a0b91dab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbfa3914-ae1c-4c0d-8d1a-e9dbe53011d5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc0f323c-6afb-4182-8040-fa795e65657d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcb1d809-4480-4a10-b4c3-14549b75c7ab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcc19478-e6be-456c-9c47-950210df0444"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcea9a3e-e98d-4ba5-908f-970a352c767f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcf643ac-52ce-4e16-bc5f-1045e4da0a2d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd5a434c-3f8a-4365-809b-9e5a919012aa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd7a1385-86be-4eb7-8e74-18cd911287fa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dededf39-9e18-49c3-924a-c226254affa0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df0ab974-23f3-43da-a39c-96d94d4d3760"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df38dfff-f288-43fd-a57a-15daa3f2b74b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df8cdbcd-2845-48ab-ba34-ff607e1d7bf0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfa0f918-d2c0-449f-ba1b-37c6faf02664"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfa4bc69-8fde-4021-b186-7c97d113bf0d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e01d45b4-e590-4356-b6ee-91aa2d9b3ee4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0adc567-88cb-4516-8f1c-33b3b740ea78"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0c9a282-10b6-45f0-9981-c08fc23d7694"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0dc742f-fc16-4d31-a690-95219753ab8e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e14c74e7-b097-474f-ab2a-55bac3719238"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e158444b-cf85-4d8f-8a69-a8279dd3007d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e15d8790-665d-492e-9841-6691989282c0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e185ec17-f3a2-4264-bf97-86acb7e6bf1b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e18c6560-3d5f-4c8e-8748-a04131864489"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e19cd768-7f1b-4e33-9145-5e0f729f9627"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1ae9e2d-5af4-4a3e-9ce0-587b60d61e8f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1c9d0a4-55e7-4de7-8848-f072369a2bf6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1f9a8bd-4cf2-4955-97ec-caa584e10054"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3327061-08b0-46ec-adfc-bed7afee9bf6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e378f849-14ed-45b2-a73c-53f35c67d96d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3d17310-053b-47fc-add2-09c27003d48e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e430c8fa-07ff-48e4-91a1-2d70b77e3bdb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e440d817-161d-47a1-b8f2-f13c22450342"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e48ff210-5fe6-4b77-98da-b80e267d6ba9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e51b4e87-3c98-42d0-aa09-ed9dcfdfd875"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e52c0917-532c-4094-a367-6ee742c12d27"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e558fca0-a1ca-4020-a526-1fd1ea604fc0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e598137c-5dc9-44ca-b11d-876837ea4dd8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5d0450e-e9fc-4064-a0ff-a5bc977b6589"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5de65eb-5652-4047-a1e5-8cffa45066d8"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6a3978c-8952-44c9-a404-59f5d3753aeb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6a78f08-9c2f-4d41-b394-f52edf065457"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e758d19f-2c39-463b-bb97-bd32e1925629"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e772c67d-7e00-45e9-9758-53f7cf1a8d65"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e789d16b-b925-4ab4-80dc-aeda9bcc093a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7c06b3b-4255-4dba-9366-ff3a2342bbb2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7e75953-6e2c-4ee7-989b-75b2b50202a1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e901eb38-b5b7-403b-aa90-d3f040737cc3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e97c9c60-1c56-4648-bc11-1542eb6d696a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9881108-781c-415b-a40c-ac6ccaeb49e0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9f9d8e8-1fdd-49be-aa9c-7b1de34c30bf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea4ada09-abb6-44cf-8e59-fd85867d0ecc"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea6671d8-4006-44fb-8e37-015d267b8ce5"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eafe65c0-2f6c-4c0c-9c19-65e14ba8c55f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb18bab2-5eea-4e06-a140-40159d6895c2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb4591e9-76ee-41d6-9677-6810fc910dc2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb834e6f-3c6e-4bd1-8f3f-1fa3f85b30f9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ebb9b0ef-08bd-460e-be1b-43499aec1729"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ecd4f84b-d7ae-4971-99db-d8bce919fa46"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed4acadd-9b4a-4d64-ab79-f9363752cde2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed764f23-0c0a-408e-81bb-c90ec63e053e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee3819fb-32f2-4d41-bcf9-7fbe0dd30de4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee3baf08-12b0-4680-a783-acffce493d55"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee4489a8-ef13-47b2-aa0a-4d4d367215bb"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee4948ce-c20f-4591-99af-68169976e965"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee5930e8-87f8-4eae-ad7d-404a8b726392"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eec88267-d370-44c4-bc1a-d4d8a30c3afd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eef0b362-cfc3-470c-a2ef-0c00ff5e2a26"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef3596de-fc44-4eb0-b873-881bd4ce7206"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ef5c4d87-9360-4b03-9c80-db64dca56b63"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efa9ea43-641d-487f-9e9c-f2dbb324e0bf"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eff45f99-0abb-4472-9d3c-dadeac378f6c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0438638-54eb-4b3a-804d-a527426ffafa"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f046c8f6-b990-4e4f-a50e-6c7350e4c3b2"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f07f17b3-1eca-44a6-acbf-ee7832621316"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f088fa90-0620-4464-99a9-b175b8dd96f0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0fe0b81-d8a8-43e5-a082-6cad59d7f7de"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f101af49-9b0b-4bf4-a995-c90e50016fd6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f10aff88-09b3-4be1-bd7f-3e57ed91aba1"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f11323d6-b8dd-44fb-9e74-0f27b71dbf50"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1e68ad0-264e-4f23-a981-7f168d615f45"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f20c4f9f-52c5-44a5-af12-5712a482ad37"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2b6625a-ddbd-4adc-893f-b470d6a68e02"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2b67080-7d0c-4c9a-9495-26b54d442069"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f366e08e-ce6b-472f-a713-1974e533541c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3ca907a-c84f-4b1a-8d5f-44d14eed512b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3e4b1e8-8e68-4f55-8e4d-5c58435f50ab"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3f8957c-e57a-4fcf-b019-19c1e2f7a4bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4622db8-f2cc-4793-ae51-bba81432a676"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4845c58-e8d7-48cb-8e80-acdef23caaa7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f487ee95-ba63-4ed5-a2eb-bc3131219efe"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4f0c6f6-030e-44ca-936b-6d1fb2d3b922"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f51127e3-98d9-4983-adf1-e5fc56ecd5df"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f517ca9d-be25-4c5a-8b4d-b41f25f3588f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5582659-25d9-420e-b64b-7bd411377abd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5d63150-f078-4e31-b726-a6fefd65084d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6286ee2-8495-4c67-81f4-87b1d193db6f"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6a984d2-ffe8-4c8f-b87a-30153cf47d94"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7747260-b91f-40b9-a70b-ef7d234d320a"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7e58cd4-87db-4ca5-88a2-a837149b2acd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f80d8779-dd2f-4955-b5c1-c1ea32cc00d6"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8514970-b010-4625-ab76-f59e41766a60"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8dd6a69-6de4-4c35-8128-7cf1be44324b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8e418f0-1bee-411a-a911-6dc86942bc48"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9cf9fbc-260b-4493-bb23-2e1555d198bd"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9f33555-85a8-43b4-831c-b31e9ba0028e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9f79ae7-99b8-4da5-9dfb-1b731dddb01e"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa2c1054-46c3-46b5-bd13-77e224246ee7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa4ee7fb-2c7a-4d16-9f65-e0245dc35573"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa5d50ec-c47b-48b6-bbed-d683db21f01d"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa7f9679-68d8-4429-9e05-405a786eee13"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa7fc26e-bc31-4f0a-9e17-0e5450716969"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fabd4a7c-3067-4931-9240-3713b8583d61"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fad8dc8a-378f-4bde-8f4f-fb75c9a13ad4"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb9138af-85ae-4830-b96e-80d3ccc79e51"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc1461ba-57e4-482e-b194-b1baed150694"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc486c83-1607-4fcb-9677-44492fb5fb89"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc77614f-7fb8-4452-aae3-dd738fe637d3"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fcb8d105-ed65-46d9-91bb-3624d1a3260b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd3fbfb9-4365-47f5-b026-a9124a1b8aac"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd69ded9-e714-4d80-8f3a-c15bfa80c5d7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd83d5e0-6aa1-4127-95da-fcd8036536b9"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fda8bf50-1b30-48fc-a5ef-2064a5c2ab96"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe7d4dc9-b078-4e89-a40e-ae2148bcbf3b"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe932681-932a-4b35-9783-e730981616ba"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe9ff8de-d65d-45aa-a54e-0994656f92c7"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("febdd888-57d7-4fef-a459-b11357a72d15"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("febea71d-0bff-4486-ba33-f4e5d125813c"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 213, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff56e358-788d-43cb-9868-b1feb4839316"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff726f5b-5d4f-4f0f-996e-5915c76e7be0"),
                column: "DateCreated",
                value: new DateTime(2024, 1, 14, 9, 59, 19, 214, DateTimeKind.Utc).AddTicks(3346));
        }
    }
}
