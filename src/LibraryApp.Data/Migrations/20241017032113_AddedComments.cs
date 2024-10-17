using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1289c752-78d7-425f-8fac-6c0ac38c9418");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5fc508-762c-4f24-b806-20a77f802d51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a36a95d-3dbb-4376-abd8-55cadd1c6bf7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fc9793a-a09a-4948-a6ed-b9a9db299ece");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c029dd-bca3-4363-a8f0-0bf31765d055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d88f0531-813d-4c9b-94be-5cac08a551e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e598340b-4cf9-4930-ad6f-9033719ba727");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecf67f0d-bce9-4f4b-b63c-7b3d55397240");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eef40856-8de9-41ed-80a7-802afd0ad61c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc01bd47-7524-4d6f-9407-69f033539523");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "Review",
                newName: "IX_Review_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_BookId",
                table: "Review",
                newName: "IX_Review_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "IsLibrarian", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bb1c67b-e878-414b-9b22-c56076c56260", 0, "2623e10a-cc51-4151-86da-499f61d188c6", null, "Mia.Hirthe16@hotmail.com", false, true, false, null, "MARQUES.PFANNERSTILL@GMAIL.COM", "ALEXANDRIA.MRAZ95", "AQAAAAIAAYagAAAAEEXrJlpfDnXgEdA1dM8fxQ2E8jwUn5NnzDvgHeJiOvc8w7jtS0pPVWmyMcUyxjw6JA==", null, false, "d5ee7912-57ae-4170-83af-c56820cbaaf6", false, "Dennis_Gleason14" },
                    { "1fbc9f79-d8b4-47a2-94cc-38f469f5bc6a", 0, "0c0b8edc-3214-460c-9306-f966b8df37b1", null, "Hayley_Johnston@hotmail.com", false, false, false, null, "REYMUNDO_HIRTHE@YAHOO.COM", "ONA_GREEN77", "AQAAAAIAAYagAAAAEJaCUeI/neZApI8evvnt8iVkatwgCK+hhpFjga8qcb0PL4SfYrZXAsHOrA6nomsB6Q==", null, false, "fe19c946-f0a4-4634-b612-d73b1db58db8", false, "Bryon99" },
                    { "2a6f6f57-1373-407b-ae34-de8033c96787", 0, "3b5ecc23-f06f-4ef2-85e4-4dad71a6a35f", null, "Winston.Daugherty@hotmail.com", false, true, false, null, "XZAVIER.GREENFELDER64@GMAIL.COM", "AXEL.EMMERICH99", "AQAAAAIAAYagAAAAEGm3k3D2loGUU4mjXwI3MRWipaXZ7YIfES1tWtdqcPQIjVz7TQtgfHm6h/TL7IF9NA==", null, false, "32936802-b212-4007-835a-8bd41df728fb", false, "Halie_Wolf" },
                    { "36e94aec-6206-41ac-858e-75da38cdb89f", 0, "50f151f8-934b-4233-b1b7-42273f6f972f", null, "Frida.Bernier@gmail.com", false, true, false, null, "MAFALDA79@HOTMAIL.COM", "NIGEL_KREIGER96", "AQAAAAIAAYagAAAAENm/sVDQ5eR+U0zd+A6y+Lk9AQradI9ygIFjqtXi/FZd/cqx7uik1ccmAfF7yq04kw==", null, false, "41cb2717-89d4-4813-8f07-20eb74c4ff45", false, "Leon_Kris16" },
                    { "569fef05-bac4-4436-9d04-0838dbfa30f9", 0, "f56d483e-50c7-4976-9753-d69f7991c7dc", null, "Lew.Greenfelder44@yahoo.com", false, true, false, null, "RAUL.NIENOW@GMAIL.COM", "PAMELA.BECHTELAR38", "AQAAAAIAAYagAAAAEG3ZJ//rDgbBxv64NF0zRcO4XySJmey+heiO6DDCWbTgAO1ddBtiQKaDpAhYcLIzXg==", null, false, "c5482704-9f7b-4fb5-9598-5dafa68fa0fe", false, "Ewald_Ebert63" },
                    { "68224779-b6d6-48e8-a896-73ac49cdbe7d", 0, "5c1abfbb-6a0b-4fbf-ae0b-2aa261654d24", null, "Giovanna_Monahan88@gmail.com", false, true, false, null, "CARY_OBERBRUNNER94@YAHOO.COM", "JAQUELIN_ZULAUF82", "AQAAAAIAAYagAAAAEDgVAgeMC6GOqUEltFV4KvaMT1uH50rg70xYsrBgMglpxIv51mGVFOdkQWNCTUkcZQ==", null, false, "ad30720f-bf73-4357-a1f3-620a11ee376e", false, "Emmy20" },
                    { "70ce7b93-b7c6-494c-add3-c6dfd220af01", 0, "6067c243-9752-4bc7-bd0f-0f83e2ef66e7", null, "Anjali.Yost21@hotmail.com", false, true, false, null, "ABBEY77@GMAIL.COM", "MORRIS61", "AQAAAAIAAYagAAAAEIoYv0/YelkFxnVdFkJZrsdufM6CLhspew4mk9PxrV03bWpV3Y6NT5OgtDzXdlh0bw==", null, false, "3e0e8d17-a69e-4c15-8c1c-67178f25df63", false, "Aubree_Keebler" },
                    { "ca6db449-0342-4688-952f-0e314ce446e4", 0, "7bde2844-66ba-4b96-ad64-34bb91d81288", null, "Willow.Halvorson78@yahoo.com", false, true, false, null, "ANGEL18@HOTMAIL.COM", "KAIA.KREIGER74", "AQAAAAIAAYagAAAAEFzYI9brArwj0eQrQVdFAzVSBGRfPfRfr3gGB+HWoH08F3E3kMDn79+TivuktpnJbg==", null, false, "78fd0233-54e8-4af3-9ff4-00baf84e6bc0", false, "Jermaine1" },
                    { "db2907c0-a485-4ab9-be8f-54c9110ab27d", 0, "4cf8cf64-36aa-4e6f-a076-d0dadb8d7fa5", null, "Amos26@hotmail.com", false, true, false, null, "TITUS.ONDRICKA56@GMAIL.COM", "VAN.CONNELLY59", "AQAAAAIAAYagAAAAEEjPtosazEG8BIqLTRmo4o36iUhzoVWqllO6cps4hvzJBATdgj5J8eXKdR1syWjqIA==", null, false, "44a20912-0ded-40a7-b98e-cdb3eb12eaf0", false, "Okey_Wisozk97" },
                    { "f0a16022-d60d-415e-869b-e93d84f88cf1", 0, "fff39393-307d-4228-a8a3-638e4ed51b3f", null, "Abdullah78@hotmail.com", false, false, false, null, "DUNCAN_BOSCO87@YAHOO.COM", "MARCUS_HERMAN", "AQAAAAIAAYagAAAAEPGimqT1RRH0EHX/ZfjBf6nSsP5KlEUb3m8JofMGnttQ2eZbGS4gZIvN0vlILjUDmQ==", null, false, "f48b7a64-695b-4531-8464-6c11d2ca30ed", false, "Judson55" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Herman Wilderman", "Computers", "Explicabo optio praesentium error laudantium. Tenetur sunt ratione ipsam ab illo. Voluptates modi alias.", "2685263448608", 670, new DateTime(2007, 11, 17, 17, 45, 36, 597, DateTimeKind.Local).AddTicks(1812), "Wuckert, Jast and Kuhlman", "Id eligendi ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Neil Denesik", "Sports", "Tempora quis architecto quia officia sit qui provident quam. Quibusdam quia facilis delectus vel cum unde. Beatae doloremque cum et. Adipisci aliquid recusandae mollitia.", "9439428678187", 423, new DateTime(2013, 5, 23, 4, 53, 38, 236, DateTimeKind.Local).AddTicks(7448), "Kassulke - Boyer", "Commodi assumenda voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Sara Hermiston", "Sports", "Et est sequi quia. Vitae voluptas quia animi consequatur qui a laborum esse autem.", "4861956027703", 173, new DateTime(2021, 10, 16, 18, 25, 57, 98, DateTimeKind.Local).AddTicks(692), "Stark, Pouros and McClure", "Animi ut quo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Van Langworth", "Toys", "Quas perferendis exercitationem doloribus. Aliquam quis fugiat veniam rerum. Corporis molestiae accusantium voluptatem veniam dolore laudantium tempore nemo et. Voluptatem sint id repudiandae et enim quo cum iure deserunt.", "4145346368202", 349, new DateTime(2019, 10, 10, 17, 59, 43, 817, DateTimeKind.Local).AddTicks(8290), "Volkman, Kassulke and Ernser", "Molestias reiciendis quidem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lila Wilderman", "Vitae officiis est consectetur omnis officiis assumenda dolor ea. Ea aut repudiandae sit. Exercitationem rerum sunt rerum dolorum sed nulla fugiat eaque.", "4044447615164", 699, new DateTime(2017, 9, 9, 11, 0, 19, 936, DateTimeKind.Local).AddTicks(8106), "Adams and Sons", "Et deserunt ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Olivia Runolfsdottir", "Grocery", "Dolor totam tenetur modi in. Maiores alias odio voluptatem sequi quidem fuga rerum qui. Soluta sunt velit commodi expedita ex culpa temporibus fuga. Numquam occaecati temporibus. Ratione et quo delectus et.", "5199862302294", 517, new DateTime(2007, 9, 1, 9, 1, 32, 181, DateTimeKind.Local).AddTicks(1842), "Hilpert, Dibbert and Nikolaus", "Facere fugit ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Arturo Hudson", "Games", "Minus aut quia perspiciatis sit. Minima quasi aut labore culpa sint soluta.", "2677150329213", 278, new DateTime(2007, 10, 22, 20, 18, 52, 523, DateTimeKind.Local).AddTicks(46), "Rohan - Kozey", "Quos nisi nesciunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Roberto Kozey", "Beauty", "Dolores ab necessitatibus. Dolorum illum praesentium ut et officia.", "4936366519800", 507, new DateTime(2015, 5, 25, 10, 31, 43, 177, DateTimeKind.Local).AddTicks(6900), "Ernser, Breitenberg and Kuhic", "Ut ratione doloremque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Frederick Koepp", "Beauty", "Illo minima eum sit quam aut ut eos optio similique. Voluptas quo aut in ipsa. Ea praesentium ut eligendi quod doloribus sunt maiores. Esse aut ullam. Omnis eligendi et.", "6593752130308", 162, new DateTime(2011, 1, 16, 13, 11, 37, 939, DateTimeKind.Local).AddTicks(5067), "Jacobson, Tillman and Runolfsson", "In harum omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Kim Okuneva", "Ut suscipit ut debitis. Eligendi autem et libero est architecto non numquam qui sunt. Aliquid aut laboriosam hic eaque dicta ex fugit commodi incidunt. Quos consequatur sit sit cum rem itaque omnis neque aut.", "3137119411070", 268, new DateTime(2012, 7, 26, 7, 36, 0, 112, DateTimeKind.Local).AddTicks(9458), "Lakin Group", "Aliquid est distinctio." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lucia Swaniawski", "Kids", "Quia commodi soluta commodi aut explicabo maiores facilis culpa. Dolor et aut sed numquam molestiae est adipisci molestiae.", "2802228246202", 303, new DateTime(2018, 3, 18, 10, 42, 9, 151, DateTimeKind.Local).AddTicks(4926), "Conroy Inc", "Sit libero cumque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Josh Bernier", "Beauty", "Voluptas in qui deserunt. Harum quae corporis.", "2386288669381", 777, new DateTime(2015, 11, 11, 17, 56, 23, 396, DateTimeKind.Local).AddTicks(958), "O'Kon, Cremin and Runolfsson", "Facere labore nulla." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Noel Mante", "Jewelery", "Sunt quas accusamus eius libero quaerat sapiente. Ut qui ipsum nihil consequatur nam. Odit tempora et sequi natus sed minus laudantium. Et tenetur dolorem.", "3664248129311", 839, new DateTime(2016, 9, 25, 11, 47, 46, 96, DateTimeKind.Local).AddTicks(7266), "Davis - Mills", "Neque ut molestias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Molly Heathcote", "Grocery", "Et provident laborum hic suscipit. Deserunt est sit aut est omnis esse. Ea quo in vel nisi quisquam reiciendis qui sint. Deserunt qui magni dolore asperiores aut reiciendis. Eius quod aut in.", "7366136214968", 403, new DateTime(2024, 5, 26, 7, 54, 47, 453, DateTimeKind.Local).AddTicks(3088), "Gaylord, Mante and Spencer", "Reprehenderit nostrum et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ernestine Kuphal", "Kids", "Aliquid et reprehenderit commodi sint. Explicabo facilis rerum est voluptatem.", "2822770830056", 625, new DateTime(2010, 4, 1, 2, 4, 9, 164, DateTimeKind.Local).AddTicks(5572), "Casper - Hahn", "Repellendus voluptas deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Kenny Leannon", "Home", "Molestiae porro tempore repudiandae quis ratione eos est. Recusandae dolorem quisquam eum.", "6434762950923", 861, new DateTime(2012, 8, 4, 11, 29, 14, 637, DateTimeKind.Local).AddTicks(1238), "Bode Group", "Doloribus fuga consequatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Jean Murray", "Baby", "Sit expedita non ratione ut dolores. Vel aperiam voluptatem incidunt soluta rerum et sequi. Est qui cumque cumque eius corporis cupiditate est. Illum qui ea illo. Et consequatur quod minus ea aliquid earum quos dignissimos assumenda.", "4519050362809", 377, new DateTime(2018, 2, 9, 9, 58, 38, 771, DateTimeKind.Local).AddTicks(2394), "Gibson LLC", "Consequatur non voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Molly Turcotte", "Jewelery", "Ipsam velit laborum est. Et sit fugiat quisquam. Non quos totam repudiandae sint labore ut. Numquam totam atque sit et amet.", "4088946660294", 929, new DateTime(2024, 5, 17, 1, 18, 20, 331, DateTimeKind.Local).AddTicks(6043), "Gleichner, Homenick and Blick", "Esse deleniti natus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Mattie Keeling", "Games", "Est nemo officia vitae reprehenderit placeat molestiae consequuntur. Molestias culpa at. Quis dolorem modi.", "1001923265551", 186, new DateTime(2005, 8, 9, 1, 16, 23, 515, DateTimeKind.Local).AddTicks(1642), "Pollich, Kirlin and Streich", "Omnis est labore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Kathryn Ward", "Kids", "Amet dolores fuga natus molestiae odit. Labore laborum pariatur debitis officiis fugit voluptate architecto quia magnam.", "8701624659903", 113, new DateTime(2017, 9, 15, 23, 34, 1, 820, DateTimeKind.Local).AddTicks(8905), "Christiansen and Sons", "Accusantium repellendus aut." });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Books_BookId",
                table: "Review",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Books_BookId",
                table: "Review");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bb1c67b-e878-414b-9b22-c56076c56260");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fbc9f79-d8b4-47a2-94cc-38f469f5bc6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6f6f57-1373-407b-ae34-de8033c96787");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36e94aec-6206-41ac-858e-75da38cdb89f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "569fef05-bac4-4436-9d04-0838dbfa30f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68224779-b6d6-48e8-a896-73ac49cdbe7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70ce7b93-b7c6-494c-add3-c6dfd220af01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca6db449-0342-4688-952f-0e314ce446e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db2907c0-a485-4ab9-be8f-54c9110ab27d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0a16022-d60d-415e-869b-e93d84f88cf1");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserId",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_BookId",
                table: "Reviews",
                newName: "IX_Reviews_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "IsLibrarian", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1289c752-78d7-425f-8fac-6c0ac38c9418", 0, "3cda1799-fae1-4998-818e-00ab0161b9f7", null, "Hallie.Lockman@hotmail.com", false, false, false, null, "ASHA1@GMAIL.COM", "ESTRELLA_KOHLER48", "AQAAAAIAAYagAAAAEM9pXXsVIwhLZEG/cnzKkks+TRdLBG0vRXngo+jwOaba/H4Ewzh/dK1iM9eJmZ6oYg==", null, false, "58725674-1295-4645-bffc-8a3292acaaad", false, "Savion.Schroeder" },
                    { "2c5fc508-762c-4f24-b806-20a77f802d51", 0, "dc2cee72-cec3-4a1a-bf65-530478517796", null, "Robyn80@gmail.com", false, false, false, null, "REBEKA91@YAHOO.COM", "LELAND.DAUGHERTY14", "AQAAAAIAAYagAAAAENPvbqZRzWHgnh5vlu+Fl22kj7T3E04zwYsDX33yMsW4DIE+TU1XjsV+L+52tpRdYw==", null, false, "dcc83aa7-5e2a-4eea-a193-aefa916ad1d5", false, "Anissa_Breitenberg32" },
                    { "3a36a95d-3dbb-4376-abd8-55cadd1c6bf7", 0, "fb5ab872-9828-4a12-b70c-045f78ec02fb", null, "Rossie.Bruen@yahoo.com", false, false, false, null, "ELMO13@HOTMAIL.COM", "JENSEN66", "AQAAAAIAAYagAAAAECkooyDLxDDZgN9DWBSivfN8qXQNW7/y5tTvUlFDC79kNG0mUQCu+iaJTMQSzs6O0A==", null, false, "5aa5e6f7-2083-44dd-beb4-6da05bb3fdc7", false, "Rowena0" },
                    { "4fc9793a-a09a-4948-a6ed-b9a9db299ece", 0, "16ff7189-dad7-4c54-887f-79ee334f3db7", null, "Rosalia6@hotmail.com", false, false, false, null, "CYNTHIA.KOEPP96@GMAIL.COM", "ANTWON73", "AQAAAAIAAYagAAAAEI7XRAGL+GaThAuWA4WFDMZJly5bcm62KXv3rE9O/OozRjU/xNZpMXLp4aY7aSzxKg==", null, false, "dbbbff8c-cf7d-4976-a927-e9a10caa5188", false, "Dudley55" },
                    { "59c029dd-bca3-4363-a8f0-0bf31765d055", 0, "4b669ac0-1d08-4d50-aac6-8e2db607730a", null, "Vella_Tromp@gmail.com", false, true, false, null, "MALACHI.CASSIN0@YAHOO.COM", "PATIENCE.CREMIN", "AQAAAAIAAYagAAAAEGcmH8KGC4MDMFUnUp2GqsiHAhzNeYB8ruXmRWCsKb0qEipcseHt8Dw3XRP/+mVKCA==", null, false, "fd955a84-648d-41d9-aed8-6dcb95a6d94b", false, "Adelia_Adams91" },
                    { "d88f0531-813d-4c9b-94be-5cac08a551e1", 0, "e3ff20a9-a453-444a-95e4-64ae3dd7621b", null, "Abigayle.Gulgowski85@hotmail.com", false, false, false, null, "DEMETRIS.HUELS76@GMAIL.COM", "JEVON9", "AQAAAAIAAYagAAAAEDaArXWv1ZQ2jwnaWaOdKrF95s25lQZsjKI+Z22DOLu2CeD0acFahMtThPsqf0ZslQ==", null, false, "6b5db51e-5056-490e-8494-6f48784b5d29", false, "Caesar_Walker" },
                    { "e598340b-4cf9-4930-ad6f-9033719ba727", 0, "b2632015-03ed-4809-9abd-6bcb077c2602", null, "Amy_Lockman47@yahoo.com", false, false, false, null, "KOLE66@GMAIL.COM", "LOLITA.PURDY34", "AQAAAAIAAYagAAAAEIeJrLaBQdyxE2RS05vHE6uvGtGII1glDNU6BbYPexve2V1tu0L1BPIubsY0P7DEPw==", null, false, "f3a4a1ef-6c4b-48ac-a98f-fcc7ced647ca", false, "Itzel_Schmitt43" },
                    { "ecf67f0d-bce9-4f4b-b63c-7b3d55397240", 0, "415b7d6e-4a3f-44c5-9243-b5cae8b3d081", null, "Carter25@gmail.com", false, false, false, null, "TIMOTHY.WHITE@HOTMAIL.COM", "KAYLIN33", "AQAAAAIAAYagAAAAENcyqLe3mXZf/H4iC9Ernw3ITc4amv7eZEfjhYpvRRYSxCVJZ6zCsvBn+keKhtKw1w==", null, false, "fdd5251c-bf1a-4f8b-a1e2-9fa00de11ff4", false, "Lurline_Miller" },
                    { "eef40856-8de9-41ed-80a7-802afd0ad61c", 0, "97ee092e-b462-4679-a02d-07657587f5a3", null, "Kris_Dooley80@yahoo.com", false, true, false, null, "IBRAHIM81@YAHOO.COM", "FILIBERTO43", "AQAAAAIAAYagAAAAEGIc0YVBkcrI24W8+pQwZUeVTsmeq1mx38S6ZTpKuVtbMu7pnAdzjvoMso53NCIFQQ==", null, false, "99226b37-889c-4cd7-b049-480d9db0e1a5", false, "Colton0" },
                    { "fc01bd47-7524-4d6f-9407-69f033539523", 0, "33be5172-7b84-4f7e-aa77-a4130b54a24b", null, "Newell_Schowalter89@yahoo.com", false, true, false, null, "ZELMA.WALSH7@GMAIL.COM", "GOLDA.KOHLER53", "AQAAAAIAAYagAAAAEHG606k90WO+lN4w8ZZvXGvI138rd3ECXbtIHoocqOe1foZlFofi1Rb8YK/PAvrjpQ==", null, false, "24b756da-3c9d-4b5e-b6b2-1e01a23b3526", false, "Pauline_DuBuque13" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lloyd Hauck", "Tools", "Provident ut repudiandae blanditiis aut ullam unde inventore a. Aut quod ea deleniti.", "5463000121499", 714, new DateTime(2020, 8, 13, 13, 45, 49, 764, DateTimeKind.Local).AddTicks(9666), "Wilderman, Hills and Schoen", "Vitae et eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lyle Grady", "Movies", "Earum corporis temporibus. Et reprehenderit omnis quo tempore. Odit rem ab eum omnis eum ad dolorem saepe. Rerum rem dolorem aspernatur impedit amet. Autem error molestiae.", "7738199643465", 460, new DateTime(2009, 3, 29, 18, 9, 19, 383, DateTimeKind.Local).AddTicks(4044), "Borer LLC", "Consequatur autem eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Mark Turner", "Tools", "Amet autem rerum accusantium. Dolores nihil sit doloribus sit.", "5743234091370", 548, new DateTime(2023, 12, 23, 5, 22, 44, 883, DateTimeKind.Local).AddTicks(6169), "Kuhlman LLC", "Culpa corporis ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Tommie Ondricka", "Electronics", "Velit aut atque aspernatur aliquam. Dolores voluptatem porro.", "9990457367751", 454, new DateTime(2021, 4, 3, 8, 59, 27, 80, DateTimeKind.Local).AddTicks(1328), "Reilly, Veum and Denesik", "Odit vero quam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Alonzo Swaniawski", "Eaque consequatur non. Qui natus architecto optio modi error officia maiores. Voluptatum quaerat incidunt provident ad a nulla fugiat earum.", "5948044335717", 681, new DateTime(2005, 9, 16, 7, 40, 1, 38, DateTimeKind.Local).AddTicks(776), "Littel LLC", "Consequatur rerum corporis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lynette Keeling", "Baby", "Qui doloremque ut sunt. Ad architecto vitae necessitatibus inventore. Excepturi dolorem qui maxime fuga eveniet numquam ipsum nihil voluptas. Voluptatem atque quo doloremque nulla et deserunt omnis quis.", "4446775666779", 671, new DateTime(2016, 3, 20, 11, 51, 31, 189, DateTimeKind.Local).AddTicks(6488), "Upton, Mohr and Wiegand", "Nemo alias porro." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Woodrow Kertzmann", "Sports", "Eos omnis ex ipsa maiores autem ipsa ut et. Perspiciatis neque assumenda. Quaerat numquam necessitatibus similique est sunt inventore mollitia sapiente.", "1291918133495", 355, new DateTime(2018, 9, 20, 22, 52, 33, 595, DateTimeKind.Local).AddTicks(9496), "Muller - Funk", "Optio aut minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Domingo Metz", "Electronics", "Excepturi aspernatur quos adipisci iste cumque exercitationem. Voluptatum in iure minus molestiae at sed perferendis.", "7149135979614", 709, new DateTime(2016, 11, 1, 23, 14, 30, 679, DateTimeKind.Local).AddTicks(6727), "Dooley - Kohler", "Voluptates numquam non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Jeffery Zieme", "Kids", "Quaerat est distinctio rerum dignissimos omnis id eligendi nihil. Illo est rerum repellat. Quo natus necessitatibus voluptates non.", "0287990076479", 782, new DateTime(2008, 7, 13, 4, 3, 40, 271, DateTimeKind.Local).AddTicks(1135), "Fay and Sons", "Occaecati occaecati sapiente." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Vera Monahan", "Et dignissimos ut qui qui et perspiciatis ipsum quos expedita. Error dolor neque nemo aut veritatis est.", "7959199777008", 210, new DateTime(2010, 6, 15, 23, 23, 1, 88, DateTimeKind.Local).AddTicks(9040), "Borer - Legros", "Nihil aliquid eius." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Luis Weissnat", "Industrial", "Consectetur ut aut laudantium quia. Quae quis itaque ut. Sed ducimus autem. Et debitis a veritatis qui dicta ea suscipit.", "3298972486220", 889, new DateTime(2024, 6, 11, 10, 58, 13, 757, DateTimeKind.Local).AddTicks(6406), "Dickinson, Glover and Mertz", "Ipsam earum sapiente." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Sadie McKenzie", "Outdoors", "Officiis qui odio explicabo. Voluptate voluptas similique nesciunt. Sed inventore est aut.", "7107939620637", 163, new DateTime(2005, 1, 20, 15, 27, 51, 327, DateTimeKind.Local).AddTicks(7762), "Hoeger - Kihn", "Esse sunt amet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Elbert Wolf", "Tools", "Consequuntur neque veniam saepe sunt et quasi dolore id asperiores. Optio velit tempore.", "8750224874353", 118, new DateTime(2023, 9, 7, 16, 36, 36, 678, DateTimeKind.Local).AddTicks(7124), "Gibson, Mohr and Russel", "Doloribus ea beatae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Richard Cassin", "Games", "Accusantium sequi officia laboriosam quia officiis est maxime repellendus omnis. Cum in sunt. Et expedita est molestiae minima et magnam. Ea eos doloribus quibusdam odio perspiciatis minus et.", "6373614492634", 963, new DateTime(2014, 9, 8, 19, 4, 47, 102, DateTimeKind.Local).AddTicks(4978), "Schultz - Pagac", "Mollitia enim dolor." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Nicholas Auer", "Electronics", "Sed quaerat delectus nihil asperiores facere laudantium rerum. Eum et accusantium repellendus repellendus. Voluptate impedit excepturi dolor dolorem corrupti cupiditate placeat ut aut.", "8049532261970", 280, new DateTime(2010, 6, 19, 12, 19, 43, 838, DateTimeKind.Local).AddTicks(7616), "Kovacek, Hand and Walter", "Qui enim debitis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Martin Bode", "Beauty", "Atque dolorem voluptatibus perspiciatis commodi vel sit voluptatem. Sapiente voluptas nostrum ipsum. Quo voluptatem omnis sed illo.", "2031979641718", 251, new DateTime(2024, 1, 14, 13, 59, 49, 349, DateTimeKind.Local).AddTicks(4470), "Shields, Armstrong and O'Conner", "Incidunt est fugit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Cory Cummings", "Movies", "Est nihil inventore autem voluptatum vel voluptatem tempora et officiis. Accusamus provident accusamus doloribus quidem et labore. Ut nihil qui quia quod quia id atque est consectetur. Libero nulla vero velit sit molestiae dolorem sed tempora.", "6973230631204", 362, new DateTime(2014, 1, 3, 14, 6, 0, 84, DateTimeKind.Local).AddTicks(6071), "Howe, Quitzon and Barrows", "Et cum et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Danny Vandervort", "Beauty", "Corporis blanditiis sit aut et. Aut assumenda fugiat ad quo aut incidunt dolor neque.", "2741264549680", 120, new DateTime(2021, 5, 6, 22, 20, 28, 713, DateTimeKind.Local).AddTicks(3395), "Osinski - Kuvalis", "Sequi temporibus dolores." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Martha Bogisich", "Clothing", "Doloribus qui architecto et. Dignissimos asperiores minus laudantium consectetur dicta dignissimos. Sit vel nam non sit quibusdam qui aut numquam. Autem dolor et eum dolorum et aliquid laboriosam id. Id porro nihil nesciunt.", "0800871763949", 825, new DateTime(2013, 3, 19, 1, 20, 31, 592, DateTimeKind.Local).AddTicks(9781), "Bahringer Group", "Reprehenderit a aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Peggy Beatty", "Health", "Expedita suscipit minus vero ducimus. Minima ut sunt vitae est et quos dolor quisquam. Dolorum aspernatur delectus. Id ut vero et non.", "8921536220453", 462, new DateTime(2012, 9, 25, 12, 39, 32, 674, DateTimeKind.Local).AddTicks(1437), "Kihn Inc", "Maiores quos est." });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
