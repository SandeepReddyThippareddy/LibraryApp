using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsLibrarian = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsLibrarian", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0fa1ef75-e675-49b3-b6e4-edca6ef451ca", 0, "5217299e-7f51-4c32-9467-217d75482525", "Jazmyne26@hotmail.com", false, false, false, null, "NATHAN.SCHAEFER20@HOTMAIL.COM", "MURIEL10", "AQAAAAIAAYagAAAAEJ6kAZ1qchyig+UT6qhYa24nEPDPfCVX2J+WDZlMw65JVYOA264jVe+Tk70zpHBB1A==", null, false, "9826f6a8-f412-4ac4-b24f-ca4e812cc7d4", false, "Floy.Leffler99" },
                    { "29ff7b35-167f-450a-9fa3-315d0c666724", 0, "4781e553-a373-41d4-ac17-f3464b1a9a47", "Adela.Legros@gmail.com", false, false, false, null, "XANDER_ROHAN78@HOTMAIL.COM", "CONSTANCE72", "AQAAAAIAAYagAAAAEC91cfeETfzO878DQCHOxPy2I2Ui74SNABZauPRHC8ZKzNuOYDKrDX7KTanZl6Cv6g==", null, false, "3c2e84c7-408f-49b7-8327-be65f86e06f7", false, "Fletcher9" },
                    { "2ed7fe43-3e5e-4124-9f78-357dd5a719da", 0, "a6cf48d5-b28c-4dde-a3b7-0dcf3279b89d", "Eve47@gmail.com", false, true, false, null, "LEMUEL_LIND@HOTMAIL.COM", "MILES_MOHR", "AQAAAAIAAYagAAAAENsETr27wEsreB4yo6MXYgZH6gwn/36V8lj+avDok48l+rJnuRLcz5hbf/gCfMy9iw==", null, false, "ae723d3b-19bd-4d78-b652-078d648824ab", false, "Karelle_Will17" },
                    { "36335a6c-5104-4aed-8d8e-278d91f6bd8b", 0, "3d1ff317-6004-4f0e-8d35-062f815d851a", "Mohamed.Steuber43@gmail.com", false, true, false, null, "TAMIA58@GMAIL.COM", "SYDNEE.YOST45", "AQAAAAIAAYagAAAAEC+sKmzZWm6jfyl0SNynkkPbqKHmIneFCetUbXfiwe2SA8fiVrTLxeFDKxmS7GyAhA==", null, false, "20c1a762-627c-4134-8198-5886c06986e1", false, "Dillan_Lynch93" },
                    { "4ac2132a-f25e-46b8-a4b1-fc4e0d01228b", 0, "0cc29c71-b8b5-4ac0-b893-fc27bb9d147a", "Richard_Stanton@yahoo.com", false, false, false, null, "CONRAD_MCCULLOUGH79@HOTMAIL.COM", "LONNIE57", "AQAAAAIAAYagAAAAEP2i2HtHIY2SdHerb2nT4CaDDbQ40xWyptp8UozCTc9ili/GrhUM/5zINOwJsB1+0g==", null, false, "8eee2d37-8f21-464f-8464-4acdab06dc7a", false, "Jade_Moore46" },
                    { "50becd4a-bda0-406b-92d1-e1225dd8090e", 0, "64d606d1-6485-4dcc-8d20-8abdfa05f142", "Rasheed_Marquardt@hotmail.com", false, false, false, null, "IMANI_DENESIK@GMAIL.COM", "DARRION.DIETRICH45", "AQAAAAIAAYagAAAAEFYcmx6q0g+4y71D4ahNi++ry7m87/WaQvfsIldxxSduZMFzmJsPbFt2gcM0xuM1uQ==", null, false, "0a3e867c-d395-49e6-847d-7c1414b0f752", false, "Hermann.Gutmann40" },
                    { "5abeb6ac-ef87-4bfa-b19f-52e43d373fb0", 0, "9243b059-f572-4c2e-b7c5-4f0b32f57e14", "Rosalee.Konopelski@gmail.com", false, false, false, null, "BRADEN_CARROLL39@HOTMAIL.COM", "NATASHA17", "AQAAAAIAAYagAAAAEEiZJuP+WisDlrzpX5eQ5mrZp/QiIK9im+vhzp6DIqZCAwPVkL5wVYzPoOJs0zgUJw==", null, false, "1f068afe-9413-4f90-a716-7a3e06d5ec3f", false, "Kennedi_Smitham" },
                    { "9fdfcc5b-8cf7-44d3-979e-0a99966ab7c1", 0, "31b8cfc7-9f74-473e-95de-434e3ebcbeee", "Georgiana_Cummerata66@yahoo.com", false, true, false, null, "OMARI37@GMAIL.COM", "WILSON.TOY14", "AQAAAAIAAYagAAAAENuS8DQmkGZpDHvqoHX9XNPpIRmzxr1PsPSTjv/M2UsGYg8T8u6W+ntfqbvS1hpqXQ==", null, false, "7feac5e9-a75c-4884-92b9-c004fdde5f23", false, "Jaquan32" },
                    { "a9444d29-60d5-456e-840d-25f5533fb2ca", 0, "1174587b-0f51-41a8-971b-e1fc9b950f82", "Kaycee66@gmail.com", false, true, false, null, "DANIELLE.CRONA38@HOTMAIL.COM", "ALENE_HARTMANN11", "AQAAAAIAAYagAAAAEPqMfmGphT3Q5AWNRs6WIVaOiaroHlYXmgsB1b/xGgKFQsjtU7jtPF15B7Nig4NLlw==", null, false, "01d9b695-29a0-43be-a901-86d74af9413a", false, "Lizzie.Rolfson" },
                    { "d0aa8f2a-1b45-4eb5-a1cb-efe8236d91a0", 0, "d8c46728-4d53-4646-b558-9194afc3f9fd", "Leopold_Parisian@yahoo.com", false, true, false, null, "KATHLEEN.GUSIKOWSKI@HOTMAIL.COM", "LOTTIE_KUTCH89", "AQAAAAIAAYagAAAAEKeYc3wzP22Bjuy5v518uvmfjk0RTmVXjxrdoS1hXTmhiZ4CLKNv4Uf083neJZQs9Q==", null, false, "626e5dbe-1d8e-4474-922b-2c905af4946c", false, "Elsa_Witting" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AverageRating", "Category", "CoverImage", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Tabitha Orn", 0.0, "Kids", null, "Voluptate velit quos temporibus qui saepe ullam quas. Qui expedita perferendis aut reiciendis similique atque est minus impedit.", "1820921796795", 770, new DateTime(2024, 4, 2, 13, 47, 39, 653, DateTimeKind.Local).AddTicks(9202), "Rau Group", "Eligendi magni eaque.", null },
                    { 2, "Betty Johnson", 0.0, "Electronics", null, "At et enim. Sequi saepe adipisci omnis vitae.", "1116983171909", 552, new DateTime(2011, 9, 22, 17, 34, 19, 970, DateTimeKind.Local).AddTicks(8801), "Rutherford and Sons", "Delectus dolores natus.", null },
                    { 3, "Lionel Mills", 0.0, "Music", null, "Minima voluptatibus aut et exercitationem excepturi. Tempora placeat iste. Eos deleniti rerum occaecati dolores ut sapiente animi adipisci. Et accusantium dicta sint.", "7127883603890", 910, new DateTime(2018, 8, 29, 17, 6, 9, 110, DateTimeKind.Local).AddTicks(5396), "Ferry, Davis and Maggio", "Molestiae ullam eligendi.", null },
                    { 4, "Regina Raynor", 0.0, "Games", null, "Ex nostrum eveniet dolor cumque velit repellat. Autem cumque perspiciatis eaque modi consequatur. Ea dicta possimus sit sequi vel ut deleniti eum. Mollitia a ut. Laudantium aliquid earum sed et reiciendis numquam exercitationem hic et.", "8331536789506", 926, new DateTime(2020, 11, 8, 21, 25, 30, 574, DateTimeKind.Local).AddTicks(4152), "Prosacco, Lang and Murray", "Sequi sed et.", null },
                    { 5, "Rachael Adams", 0.0, "Shoes", null, "Recusandae rem reprehenderit itaque porro. Culpa velit et magnam sequi vel reprehenderit consectetur. Voluptatem ut velit repellat ducimus.", "4246945053336", 544, new DateTime(2022, 6, 18, 7, 2, 7, 594, DateTimeKind.Local).AddTicks(4289), "Kuhn, MacGyver and Bernhard", "Quia tempora eligendi.", null },
                    { 6, "Lora Mraz", 0.0, "Garden", null, "Odio eum quia hic nisi. Amet eveniet amet facere laudantium soluta est.", "5320625797662", 672, new DateTime(2022, 10, 15, 20, 54, 16, 22, DateTimeKind.Local).AddTicks(6538), "Russel Group", "Omnis voluptatum in.", null },
                    { 7, "Eduardo Turcotte", 0.0, "Electronics", null, "A rem doloribus quibusdam in. Error quia sit dolorem quam et. Assumenda omnis ut qui. Eos occaecati suscipit ad expedita quod commodi. Sit rerum earum.", "1561194364020", 666, new DateTime(2004, 12, 13, 13, 1, 11, 285, DateTimeKind.Local).AddTicks(3876), "Jacobson LLC", "Sunt optio molestiae.", null },
                    { 8, "Diane Yundt", 0.0, "Electronics", null, "Et iste velit similique in. Dignissimos unde voluptas pariatur omnis et. Deserunt eveniet sed. Nostrum rem earum minus dolorum sed eligendi.", "4007723246421", 588, new DateTime(2023, 7, 16, 18, 32, 12, 848, DateTimeKind.Local).AddTicks(875), "Beatty, Morissette and Zemlak", "Eum inventore voluptates.", null },
                    { 9, "Dwight Heaney", 0.0, "Beauty", null, "Dolore laborum numquam molestias. Nesciunt et aut unde sint optio animi quibusdam ut rerum.", "7739133736830", 463, new DateTime(2007, 6, 16, 3, 50, 18, 44, DateTimeKind.Local).AddTicks(8329), "Friesen - Kiehn", "Provident repudiandae id.", null },
                    { 10, "Vera Hettinger", 0.0, "Outdoors", null, "Ab porro dolor nulla qui deleniti. Aut nihil non officia impedit suscipit inventore quia. Aut est esse exercitationem doloremque molestiae.", "0188733749400", 710, new DateTime(2022, 4, 15, 10, 28, 40, 353, DateTimeKind.Local).AddTicks(9638), "Stokes, Carter and Casper", "Aut quidem ipsam.", null },
                    { 11, "Elijah Schaden", 0.0, "Electronics", null, "Ea repudiandae explicabo. Sit ut qui minus itaque repellendus ut nulla non nobis. Voluptatibus perferendis provident amet voluptatem. Eos id omnis enim et. Ea a ipsum aspernatur aut.", "1209282832968", 573, new DateTime(2014, 5, 30, 14, 15, 38, 434, DateTimeKind.Local).AddTicks(2851), "Frami, Rice and Bernier", "Ex autem quisquam.", null },
                    { 12, "Andrea Ward", 0.0, "Grocery", null, "Ut itaque sit non nihil et enim sit laborum. Velit exercitationem dolor rem est veniam placeat ut tenetur dolor. Debitis quod nostrum aut est. Tenetur et laborum quisquam porro recusandae repudiandae. Quia aut praesentium rerum ipsa.", "2416290053813", 196, new DateTime(2007, 12, 16, 18, 42, 7, 300, DateTimeKind.Local).AddTicks(7977), "Dare Inc", "Et repudiandae consequuntur.", null },
                    { 13, "Melissa Torphy", 0.0, "Tools", null, "Quidem perspiciatis facilis mollitia veniam accusamus natus doloremque. Aut modi saepe. Commodi cupiditate cum molestiae numquam ut quis.", "9902894969481", 451, new DateTime(2019, 4, 5, 18, 2, 8, 855, DateTimeKind.Local).AddTicks(2793), "Cummerata, Schowalter and Lebsack", "Et rerum non.", null },
                    { 14, "Paulette Cole", 0.0, "Shoes", null, "Illo voluptate impedit est. Totam adipisci nemo ipsum soluta. Id ab provident nam rem. Rem ad blanditiis nihil enim sunt labore quidem quae quia.", "7637362041131", 883, new DateTime(2006, 11, 4, 20, 42, 59, 232, DateTimeKind.Local).AddTicks(2589), "Brekke, Olson and Hahn", "Hic ea dolorem.", null },
                    { 15, "Laverne Beahan", 0.0, "Computers", null, "Eum dolorum et dolor est. Ducimus a sint ipsum dolores excepturi iusto. Quaerat reprehenderit tenetur aut. Nisi veritatis eum sit cupiditate exercitationem quia.", "9797949899604", 337, new DateTime(2021, 12, 19, 18, 26, 46, 321, DateTimeKind.Local).AddTicks(7258), "Macejkovic, Leannon and Dach", "Perspiciatis cupiditate quidem.", null },
                    { 16, "Emma Bernhard", 0.0, "Automotive", null, "Accusamus sunt ex possimus. Ut delectus fugiat nam vel quis architecto aperiam sed. Nesciunt veritatis non vero harum quis laudantium veniam ut ad.", "4183492613036", 943, new DateTime(2010, 2, 26, 3, 26, 41, 94, DateTimeKind.Local).AddTicks(8889), "Kuhlman and Sons", "Excepturi et ullam.", null },
                    { 17, "Elias Cassin", 0.0, "Industrial", null, "Excepturi enim in quas ea. Et odit cupiditate quod iure laboriosam. Et quaerat dolorum soluta. Molestiae odio quia est exercitationem ratione minus maxime sint eveniet.", "7582312106821", 885, new DateTime(2017, 11, 6, 17, 41, 33, 747, DateTimeKind.Local).AddTicks(5461), "Satterfield - Zieme", "Et aut rerum.", null },
                    { 18, "Stuart Koss", 0.0, "Outdoors", null, "Molestias odit id quia quasi. Voluptatem corporis molestias veritatis blanditiis qui quisquam minima et. Ea unde dolorem voluptas eum corporis maxime porro. Suscipit et est vel nostrum modi repellendus.", "4331245932952", 635, new DateTime(2006, 1, 2, 21, 26, 15, 168, DateTimeKind.Local).AddTicks(59), "Blanda, Swaniawski and Hand", "Tempore quisquam enim.", null },
                    { 19, "Ignacio Kuhic", 0.0, "Kids", null, "Neque vel aperiam et culpa. Sed magnam et ratione.", "6280350342171", 189, new DateTime(2007, 8, 28, 3, 8, 9, 913, DateTimeKind.Local).AddTicks(9281), "Glover, Gaylord and Leuschke", "Recusandae cum hic.", null },
                    { 20, "Elmer Streich", 0.0, "Clothing", null, "Magni necessitatibus magni recusandae. Possimus ut autem corrupti eum. Rerum voluptatem explicabo debitis nihil. Deleniti quisquam in qui beatae inventore atque quae.", "9921113050960", 439, new DateTime(2007, 12, 15, 14, 58, 19, 245, DateTimeKind.Local).AddTicks(5075), "Keebler LLC", "Assumenda deleniti voluptatem.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
