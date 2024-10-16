using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "150ac7c1-0f72-4b79-8f45-1a646ea72904");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3153e56b-f607-4778-91d1-ba9a3b2e1921");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34c507ba-0e39-407d-b458-64b4a9c47dd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35bed9ca-2858-4e4b-90a6-9994558d88e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7123e4e5-1e3d-487f-af25-1612d0021a28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb4b5d1-953a-4854-aa9b-e73ba06582bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3aa8d03-e594-4390-b054-ac1c236da961");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceb3aa78-947c-43d3-a132-12da0c24d504");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6293a71-df80-46b7-923c-3dded9d2af51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0cc4272-52fa-4e1f-81b9-2a182b96b73b");

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
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Alonzo Swaniawski", "Games", "Eaque consequatur non. Qui natus architecto optio modi error officia maiores. Voluptatum quaerat incidunt provident ad a nulla fugiat earum.", "5948044335717", 681, new DateTime(2005, 9, 16, 7, 40, 1, 38, DateTimeKind.Local).AddTicks(776), "Littel LLC", "Consequatur rerum corporis." });

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
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Vera Monahan", "Jewelery", "Et dignissimos ut qui qui et perspiciatis ipsum quos expedita. Error dolor neque nemo aut veritatis est.", "7959199777008", 210, new DateTime(2010, 6, 15, 23, 23, 1, 88, DateTimeKind.Local).AddTicks(9040), "Borer - Legros", "Nihil aliquid eius." });

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
                columns: new[] { "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Elbert Wolf", "Consequuntur neque veniam saepe sunt et quasi dolore id asperiores. Optio velit tempore.", "8750224874353", 118, new DateTime(2023, 9, 7, 16, 36, 36, 678, DateTimeKind.Local).AddTicks(7124), "Gibson, Mohr and Russel", "Doloribus ea beatae." });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "IsLibrarian", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "150ac7c1-0f72-4b79-8f45-1a646ea72904", 0, "6576ab1f-3b38-4729-8a19-8d507ee2249e", null, "Jerod3@yahoo.com", false, false, false, null, "LILLY.LARSON17@YAHOO.COM", "BRADEN_SCHROEDER", "AQAAAAIAAYagAAAAEMVx+suZ9XLkGPAccCQWFfE4zklD0Z1ej18QJPxb2tMdliLpQDIRO3+fkrYVk9mb3g==", null, false, "1beadb6c-c349-40e9-8d97-ee688f0211cd", false, "Brenden.Ernser31" },
                    { "3153e56b-f607-4778-91d1-ba9a3b2e1921", 0, "a8ea4e4f-2f83-4aac-aef0-f29c6d6f6b7b", null, "Zakary43@hotmail.com", false, false, false, null, "TREVOR_BROWN12@GMAIL.COM", "MARCELLE_BARTELL86", "AQAAAAIAAYagAAAAEPwt4hY35HWhHVk4jHfT8cvierIzyd/KhyGy7xAlgcbKtl9MCvwRtnYqu3LQyrD1eg==", null, false, "adb1bbbf-f537-448b-a829-97c9eda76d22", false, "Elvie24" },
                    { "34c507ba-0e39-407d-b458-64b4a9c47dd0", 0, "273e2bd0-87e2-487d-87ba-6d0ab3591f59", null, "Leopold_Crooks24@yahoo.com", false, true, false, null, "JOHNNIE.GOTTLIEB@GMAIL.COM", "MARTINA_HESSEL", "AQAAAAIAAYagAAAAEF5HihbugHLJsxIEayQhiVxzTq4xq2bv9EZNcCnJ577Jq+YKb93KEBMRT59TGF3/RA==", null, false, "20b6dcd7-c84b-4c0c-975a-4449c4322a96", false, "Hardy38" },
                    { "35bed9ca-2858-4e4b-90a6-9994558d88e2", 0, "8ce406d3-4cda-4e1c-b0e1-4887d28893aa", null, "Kaylin.Mraz87@gmail.com", false, false, false, null, "NORBERTO_SCHULTZ70@HOTMAIL.COM", "KALE.KEMMER55", "AQAAAAIAAYagAAAAEOQ19/uwFlSk4EBgJXFjNBX9ioTRbG90Vlwgw0XD1xqeuVJmdnZomEmg5pC9ETj2cg==", null, false, "bef5584f-b83a-4a7a-9105-d1a5e5bd9d21", false, "Adrain18" },
                    { "7123e4e5-1e3d-487f-af25-1612d0021a28", 0, "3e0ae8e1-42df-411c-b462-4789d0eb9f49", null, "Terry67@gmail.com", false, true, false, null, "CAMRYN54@HOTMAIL.COM", "ESTELLA.LOWE84", "AQAAAAIAAYagAAAAEBpjctdFJ0SSzGb4xpxCmgsJF1ikRjajY8XEeNUPEsf59teJzvVrn8bqGKyKAvc8Dg==", null, false, "39e7cd03-3d0a-41fe-a3de-988045eeba1a", false, "Lolita_Deckow" },
                    { "9eb4b5d1-953a-4854-aa9b-e73ba06582bb", 0, "d0b305e6-9b61-441c-886d-66f2a94a804e", null, "Alvina.Thompson@yahoo.com", false, true, false, null, "AIDEN.QUIGLEY65@HOTMAIL.COM", "ESTELL64", "AQAAAAIAAYagAAAAEHja77KSnWcEM3v/qohXU1Gffr7mUOhqAhNAsKZELAlusZIczr+UI6eqAymHeJKVrA==", null, false, "6d7eae96-764b-42d1-a399-c69c5b081518", false, "Duane12" },
                    { "a3aa8d03-e594-4390-b054-ac1c236da961", 0, "989741d8-c1e5-44b0-8791-2761336388e1", null, "Vada.Padberg41@yahoo.com", false, false, false, null, "JEFFREY.KOHLER@GMAIL.COM", "DAX15", "AQAAAAIAAYagAAAAECrNyhZt3/lYjwSkEcvfbp0rrYxeFxSpstLAybYE2UGG3MDphG47mGrbBrOmgVkvyw==", null, false, "07ce9eff-fe98-4e1f-b568-c915ad8e3055", false, "Cristian.Jones" },
                    { "ceb3aa78-947c-43d3-a132-12da0c24d504", 0, "ca643e8b-0c5c-49e3-811b-e7d32fa819bc", null, "Cary.Windler@hotmail.com", false, true, false, null, "SHIRLEY_KUHLMAN26@YAHOO.COM", "ANNABELLE_KESSLER84", "AQAAAAIAAYagAAAAEEqqwNxL9Ht1sBUQQgjfCYVdTUZSTcLe2Df8SRa3h9CxDvOdr/UjnZ0ny2MRI/FpRQ==", null, false, "3086be77-0316-4634-b5fd-81ee7dbaeb75", false, "Carlee97" },
                    { "d6293a71-df80-46b7-923c-3dded9d2af51", 0, "3f925851-40bb-4630-aa89-7ad09e8fb122", null, "Franco_Medhurst73@yahoo.com", false, true, false, null, "ODA66@HOTMAIL.COM", "ORRIN59", "AQAAAAIAAYagAAAAEPAfP4TcF77kJdm79gossjd6W/h2HSYoj0v444MNfGmU2S1mwg/EVRlgY02CFRcpEg==", null, false, "99edce27-b664-4950-8844-7b5b1dcff815", false, "Margarita_Hoppe10" },
                    { "e0cc4272-52fa-4e1f-81b9-2a182b96b73b", 0, "242a824b-9b19-4416-b246-8235c49035ce", null, "Gudrun_Gusikowski23@yahoo.com", false, true, false, null, "OPHELIA37@YAHOO.COM", "MAYE2", "AQAAAAIAAYagAAAAEHmAhEDxzgmLNdLNEXuhG+vPnNWLPqs/jLu4KvNg6/dVR+gYJB8QPtNZyA3panmbKw==", null, false, "efb08692-092a-4cd1-90be-485184e8d3ff", false, "Ayana_Koelpin40" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Terry Mante", "Movies", "Officiis suscipit possimus et omnis. Quod eius quaerat doloremque facilis minus. Occaecati repellendus ut aut ut reprehenderit neque error. Eos voluptatem libero distinctio aperiam officiis distinctio non quo. Assumenda quis repellat exercitationem accusantium rem est sunt non quidem.", "7131174523798", 288, new DateTime(2015, 3, 7, 3, 10, 35, 392, DateTimeKind.Local).AddTicks(6407), "Kihn - Anderson", "Recusandae nulla et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Andre Muller", "Clothing", "Vel pariatur ea dignissimos nisi quis et quia impedit dolor. Optio eum dolor alias et consequatur molestiae dolores dolores. Illum quidem et aut distinctio. Sint doloribus odio delectus esse perferendis aut hic. Quam alias fuga porro aut.", "2043954216071", 561, new DateTime(2009, 6, 10, 2, 36, 14, 309, DateTimeKind.Local).AddTicks(3769), "Shields Inc", "At minus aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Shelly Cole", "Beauty", "Rerum rerum quibusdam debitis a non quo nobis. Temporibus sint repellat et distinctio velit occaecati. Unde pariatur reprehenderit illo quaerat. Perferendis sit blanditiis suscipit quidem. Est corrupti aut odit iure magnam sed autem iusto.", "4161882010627", 820, new DateTime(2019, 2, 1, 21, 3, 47, 306, DateTimeKind.Local).AddTicks(5021), "Hermann - Crona", "Ut sit possimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Toby Schmitt", "Sports", "Atque aut ipsa et autem ullam dicta dolores esse. Autem voluptatibus eligendi aut blanditiis ut. Et et rerum quos ex. Commodi error vel sed earum. Eos voluptatem blanditiis laudantium commodi repellendus quidem dolorem.", "5357199033582", 442, new DateTime(2005, 3, 19, 0, 54, 39, 93, DateTimeKind.Local).AddTicks(538), "Gaylord, Conn and Nikolaus", "Ipsam hic nostrum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Clayton Howe", "Electronics", "Quisquam labore ut. Eius animi aspernatur dolores asperiores aliquam atque numquam aut. Adipisci rerum expedita expedita modi. Quia et ut ea velit harum voluptatem reprehenderit enim.", "0817915866887", 458, new DateTime(2019, 7, 24, 5, 31, 41, 565, DateTimeKind.Local).AddTicks(1965), "VonRueden, Lakin and Macejkovic", "Est voluptas aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ashley Grant", "Health", "Officiis blanditiis qui voluptate reprehenderit consequatur corrupti. Vero dolorem cupiditate temporibus voluptas praesentium ut rerum illum mollitia. Ut ratione id a perspiciatis accusamus sit corporis.", "7720400928324", 901, new DateTime(2017, 1, 10, 6, 4, 46, 742, DateTimeKind.Local).AddTicks(6906), "Rippin, Lynch and Hagenes", "Laudantium dicta et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Irvin Witting", "Outdoors", "Temporibus qui quis nobis vel rem esse voluptatem architecto. Ut ducimus consequatur nam illo dolore magnam quia.", "8555148559061", 579, new DateTime(2022, 3, 20, 19, 37, 33, 969, DateTimeKind.Local).AddTicks(3748), "Runolfsdottir - Zieme", "Et delectus ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ivan Grimes", "Computers", "Totam architecto commodi explicabo possimus recusandae repellendus porro tempora. Est officiis aliquid similique corporis deleniti laboriosam eum illo. Sequi nobis illo magni ut tenetur. Minus reprehenderit iusto et. Commodi quo est adipisci perspiciatis.", "8412313961244", 477, new DateTime(2013, 2, 27, 1, 40, 1, 840, DateTimeKind.Local).AddTicks(8596), "Beahan LLC", "Praesentium ea aliquid." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Gayle Bogan", "Health", "Non doloribus rerum enim sint consequuntur minus quisquam. Et et mollitia harum non nostrum est soluta in odit. Voluptatem saepe molestiae recusandae pariatur nisi unde iste dolores. Maxime sit asperiores reiciendis autem ut exercitationem explicabo saepe. Repellendus aut quasi sunt ipsam debitis.", "0283191529943", 118, new DateTime(2014, 1, 8, 9, 26, 9, 207, DateTimeKind.Local).AddTicks(6055), "Renner - Langosh", "Quos et aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Noel Streich", "Beauty", "Minus facere sed hic eveniet unde in omnis rerum. Quo eum et rem molestiae beatae quaerat vel explicabo magnam. Ut debitis aut a in vel architecto qui.", "7039664908684", 584, new DateTime(2023, 4, 7, 17, 27, 6, 614, DateTimeKind.Local).AddTicks(9910), "Wyman - Predovic", "Sit ex eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Kristina Upton", "Toys", "Omnis ut nisi amet laborum ut. Magni pariatur minus qui consequatur eligendi beatae quidem reiciendis rem.", "2811063871869", 151, new DateTime(2008, 1, 29, 4, 27, 3, 707, DateTimeKind.Local).AddTicks(7339), "Upton Group", "Porro optio dolorem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Fannie Davis", "Beauty", "Enim cumque mollitia doloremque distinctio quaerat fugit. Iusto vel voluptate amet. Provident dolorem quo et deserunt quidem nihil consequatur voluptatem.", "9792077893159", 240, new DateTime(2015, 9, 6, 16, 42, 45, 142, DateTimeKind.Local).AddTicks(7300), "Pacocha, Howell and Harber", "In sequi mollitia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Merle Doyle", "Ut quia sed odit enim quidem quo est non. Ea adipisci repellendus similique et molestiae officia qui magnam. Aut ullam nisi autem nobis.", "9887559422313", 699, new DateTime(2022, 2, 10, 9, 4, 3, 448, DateTimeKind.Local).AddTicks(3121), "Kuhn Inc", "Ea odit vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Susie Balistreri", "Home", "Perspiciatis consectetur dolore consequuntur voluptas et sapiente. Omnis dolor nulla veritatis doloremque. Quidem sed et. Amet nesciunt eligendi quae.", "3915492463974", 343, new DateTime(2018, 1, 13, 7, 52, 8, 766, DateTimeKind.Local).AddTicks(5776), "Waelchi - Lang", "Eum dicta omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Dominick Blanda", "Kids", "Reprehenderit quos repellendus cupiditate. Omnis ex repellendus optio qui. Ea itaque esse alias iure aut.", "9951466904191", 252, new DateTime(2005, 4, 18, 18, 15, 45, 949, DateTimeKind.Local).AddTicks(8779), "Hermiston - Pacocha", "Itaque qui laborum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Angel Funk", "Outdoors", "Omnis minus quaerat reprehenderit molestiae molestiae temporibus. Voluptatibus placeat sunt recusandae cum esse dolor officiis. Sint voluptatem tenetur aliquid et eius magnam. Nam omnis cumque.", "3282233585104", 116, new DateTime(2009, 1, 31, 20, 39, 59, 962, DateTimeKind.Local).AddTicks(8538), "Bode, Spencer and Schmeler", "Omnis explicabo unde." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Carole Larson", "Music", "Dolores excepturi eaque minus ratione maxime omnis blanditiis corporis minima. Sapiente quia omnis non corrupti aspernatur modi. Eius consequatur et ipsum autem pariatur magnam.", "7311897145419", 158, new DateTime(2006, 9, 24, 18, 51, 35, 924, DateTimeKind.Local).AddTicks(2773), "Kreiger, Tromp and Lueilwitz", "Sequi architecto nesciunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Billie Feest", "Shoes", "Blanditiis velit aut quaerat cupiditate enim laudantium molestiae inventore. Sit deleniti enim nam odio maxime magni voluptatem eaque. Ipsum repudiandae dicta et dolorem qui. Temporibus labore molestiae error consequatur.", "1166685284322", 844, new DateTime(2021, 2, 2, 22, 9, 8, 989, DateTimeKind.Local).AddTicks(5838), "Zboncak and Sons", "Voluptatem et deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Theodore Lynch", "Shoes", "Dolores itaque quia officiis id sapiente nisi. Qui sed id doloribus quisquam occaecati in qui. Neque rerum esse earum reiciendis est ipsum omnis deserunt. Aspernatur et quis est maxime qui. Dolores porro repellendus doloribus ut voluptatem voluptates quo quo aut.", "4267418449333", 880, new DateTime(2022, 3, 8, 0, 47, 10, 592, DateTimeKind.Local).AddTicks(9785), "Konopelski Group", "Deleniti a architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Eduardo Hauck", "Grocery", "Autem eos cupiditate odio velit nihil est sed est culpa. Et aut quis debitis eaque enim iure architecto illo id. Soluta beatae sint adipisci illo commodi quo.", "2691758576343", 242, new DateTime(2016, 1, 30, 1, 18, 9, 770, DateTimeKind.Local).AddTicks(6503), "Kovacek and Sons", "Voluptas rerum mollitia." });
        }
    }
}
