using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBorrowerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_AppUserId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_AppUserId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136a7a21-9774-4bba-8287-601af382879b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ce3a1a6-070a-48e1-ac31-e624c9cce708");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "884609cc-0d1d-4cfd-9aef-073a25a2a7cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95ffd13d-2f17-4988-ac68-bca469936740");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c94f7f74-4064-45d1-a712-d127c3b69ffd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc7acf01-de50-4766-9eef-b2c8c321addd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcedffdf-a7ff-4f84-96e2-b1291c88fce3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f697fe75-c521-410d-bb21-1547b16cff21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f913b48d-196d-404c-912f-1ccfb47df40d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9ec9f05-7670-4ded-90db-db0380a7accb");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "IsBorrowed",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BookBorrowers",
                columns: table => new
                {
                    BorrowedBooksId = table.Column<int>(type: "int", nullable: false),
                    BorrowersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBorrowers", x => new { x.BorrowedBooksId, x.BorrowersId });
                    table.ForeignKey(
                        name: "FK_BookBorrowers_AspNetUsers_BorrowersId",
                        column: x => x.BorrowersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBorrowers_Books_BorrowedBooksId",
                        column: x => x.BorrowedBooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Terry Mante", "Movies", "Officiis suscipit possimus et omnis. Quod eius quaerat doloremque facilis minus. Occaecati repellendus ut aut ut reprehenderit neque error. Eos voluptatem libero distinctio aperiam officiis distinctio non quo. Assumenda quis repellat exercitationem accusantium rem est sunt non quidem.", "7131174523798", false, 288, new DateTime(2015, 3, 7, 3, 10, 35, 392, DateTimeKind.Local).AddTicks(6407), "Kihn - Anderson", "Recusandae nulla et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Andre Muller", "Clothing", "Vel pariatur ea dignissimos nisi quis et quia impedit dolor. Optio eum dolor alias et consequatur molestiae dolores dolores. Illum quidem et aut distinctio. Sint doloribus odio delectus esse perferendis aut hic. Quam alias fuga porro aut.", "2043954216071", false, 561, new DateTime(2009, 6, 10, 2, 36, 14, 309, DateTimeKind.Local).AddTicks(3769), "Shields Inc", "At minus aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Shelly Cole", "Beauty", "Rerum rerum quibusdam debitis a non quo nobis. Temporibus sint repellat et distinctio velit occaecati. Unde pariatur reprehenderit illo quaerat. Perferendis sit blanditiis suscipit quidem. Est corrupti aut odit iure magnam sed autem iusto.", "4161882010627", false, 820, new DateTime(2019, 2, 1, 21, 3, 47, 306, DateTimeKind.Local).AddTicks(5021), "Hermann - Crona", "Ut sit possimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Toby Schmitt", "Sports", "Atque aut ipsa et autem ullam dicta dolores esse. Autem voluptatibus eligendi aut blanditiis ut. Et et rerum quos ex. Commodi error vel sed earum. Eos voluptatem blanditiis laudantium commodi repellendus quidem dolorem.", "5357199033582", false, 442, new DateTime(2005, 3, 19, 0, 54, 39, 93, DateTimeKind.Local).AddTicks(538), "Gaylord, Conn and Nikolaus", "Ipsam hic nostrum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Clayton Howe", "Electronics", "Quisquam labore ut. Eius animi aspernatur dolores asperiores aliquam atque numquam aut. Adipisci rerum expedita expedita modi. Quia et ut ea velit harum voluptatem reprehenderit enim.", "0817915866887", false, 458, new DateTime(2019, 7, 24, 5, 31, 41, 565, DateTimeKind.Local).AddTicks(1965), "VonRueden, Lakin and Macejkovic", "Est voluptas aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ashley Grant", "Health", "Officiis blanditiis qui voluptate reprehenderit consequatur corrupti. Vero dolorem cupiditate temporibus voluptas praesentium ut rerum illum mollitia. Ut ratione id a perspiciatis accusamus sit corporis.", "7720400928324", false, 901, new DateTime(2017, 1, 10, 6, 4, 46, 742, DateTimeKind.Local).AddTicks(6906), "Rippin, Lynch and Hagenes", "Laudantium dicta et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Irvin Witting", "Outdoors", "Temporibus qui quis nobis vel rem esse voluptatem architecto. Ut ducimus consequatur nam illo dolore magnam quia.", "8555148559061", false, 579, new DateTime(2022, 3, 20, 19, 37, 33, 969, DateTimeKind.Local).AddTicks(3748), "Runolfsdottir - Zieme", "Et delectus ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ivan Grimes", "Computers", "Totam architecto commodi explicabo possimus recusandae repellendus porro tempora. Est officiis aliquid similique corporis deleniti laboriosam eum illo. Sequi nobis illo magni ut tenetur. Minus reprehenderit iusto et. Commodi quo est adipisci perspiciatis.", "8412313961244", false, 477, new DateTime(2013, 2, 27, 1, 40, 1, 840, DateTimeKind.Local).AddTicks(8596), "Beahan LLC", "Praesentium ea aliquid." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Gayle Bogan", "Health", "Non doloribus rerum enim sint consequuntur minus quisquam. Et et mollitia harum non nostrum est soluta in odit. Voluptatem saepe molestiae recusandae pariatur nisi unde iste dolores. Maxime sit asperiores reiciendis autem ut exercitationem explicabo saepe. Repellendus aut quasi sunt ipsam debitis.", "0283191529943", false, 118, new DateTime(2014, 1, 8, 9, 26, 9, 207, DateTimeKind.Local).AddTicks(6055), "Renner - Langosh", "Quos et aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Noel Streich", "Beauty", "Minus facere sed hic eveniet unde in omnis rerum. Quo eum et rem molestiae beatae quaerat vel explicabo magnam. Ut debitis aut a in vel architecto qui.", "7039664908684", false, 584, new DateTime(2023, 4, 7, 17, 27, 6, 614, DateTimeKind.Local).AddTicks(9910), "Wyman - Predovic", "Sit ex eum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Kristina Upton", "Toys", "Omnis ut nisi amet laborum ut. Magni pariatur minus qui consequatur eligendi beatae quidem reiciendis rem.", "2811063871869", false, 151, new DateTime(2008, 1, 29, 4, 27, 3, 707, DateTimeKind.Local).AddTicks(7339), "Upton Group", "Porro optio dolorem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Fannie Davis", "Enim cumque mollitia doloremque distinctio quaerat fugit. Iusto vel voluptate amet. Provident dolorem quo et deserunt quidem nihil consequatur voluptatem.", "9792077893159", false, 240, new DateTime(2015, 9, 6, 16, 42, 45, 142, DateTimeKind.Local).AddTicks(7300), "Pacocha, Howell and Harber", "In sequi mollitia." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Merle Doyle", "Tools", "Ut quia sed odit enim quidem quo est non. Ea adipisci repellendus similique et molestiae officia qui magnam. Aut ullam nisi autem nobis.", "9887559422313", false, 699, new DateTime(2022, 2, 10, 9, 4, 3, 448, DateTimeKind.Local).AddTicks(3121), "Kuhn Inc", "Ea odit vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Susie Balistreri", "Home", "Perspiciatis consectetur dolore consequuntur voluptas et sapiente. Omnis dolor nulla veritatis doloremque. Quidem sed et. Amet nesciunt eligendi quae.", "3915492463974", false, 343, new DateTime(2018, 1, 13, 7, 52, 8, 766, DateTimeKind.Local).AddTicks(5776), "Waelchi - Lang", "Eum dicta omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Dominick Blanda", "Kids", "Reprehenderit quos repellendus cupiditate. Omnis ex repellendus optio qui. Ea itaque esse alias iure aut.", "9951466904191", false, 252, new DateTime(2005, 4, 18, 18, 15, 45, 949, DateTimeKind.Local).AddTicks(8779), "Hermiston - Pacocha", "Itaque qui laborum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Angel Funk", "Outdoors", "Omnis minus quaerat reprehenderit molestiae molestiae temporibus. Voluptatibus placeat sunt recusandae cum esse dolor officiis. Sint voluptatem tenetur aliquid et eius magnam. Nam omnis cumque.", "3282233585104", false, 116, new DateTime(2009, 1, 31, 20, 39, 59, 962, DateTimeKind.Local).AddTicks(8538), "Bode, Spencer and Schmeler", "Omnis explicabo unde." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Carole Larson", "Music", "Dolores excepturi eaque minus ratione maxime omnis blanditiis corporis minima. Sapiente quia omnis non corrupti aspernatur modi. Eius consequatur et ipsum autem pariatur magnam.", "7311897145419", false, 158, new DateTime(2006, 9, 24, 18, 51, 35, 924, DateTimeKind.Local).AddTicks(2773), "Kreiger, Tromp and Lueilwitz", "Sequi architecto nesciunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Billie Feest", "Shoes", "Blanditiis velit aut quaerat cupiditate enim laudantium molestiae inventore. Sit deleniti enim nam odio maxime magni voluptatem eaque. Ipsum repudiandae dicta et dolorem qui. Temporibus labore molestiae error consequatur.", "1166685284322", false, 844, new DateTime(2021, 2, 2, 22, 9, 8, 989, DateTimeKind.Local).AddTicks(5838), "Zboncak and Sons", "Voluptatem et deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Theodore Lynch", "Shoes", "Dolores itaque quia officiis id sapiente nisi. Qui sed id doloribus quisquam occaecati in qui. Neque rerum esse earum reiciendis est ipsum omnis deserunt. Aspernatur et quis est maxime qui. Dolores porro repellendus doloribus ut voluptatem voluptates quo quo aut.", "4267418449333", false, 880, new DateTime(2022, 3, 8, 0, 47, 10, 592, DateTimeKind.Local).AddTicks(9785), "Konopelski Group", "Deleniti a architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Category", "Description", "ISBN", "IsBorrowed", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Eduardo Hauck", "Grocery", "Autem eos cupiditate odio velit nihil est sed est culpa. Et aut quis debitis eaque enim iure architecto illo id. Soluta beatae sint adipisci illo commodi quo.", "2691758576343", false, 242, new DateTime(2016, 1, 30, 1, 18, 9, 770, DateTimeKind.Local).AddTicks(6503), "Kovacek and Sons", "Voluptas rerum mollitia." });

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrowers_BorrowersId",
                table: "BookBorrowers",
                column: "BorrowersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBorrowers");

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

            migrationBuilder.DropColumn(
                name: "IsBorrowed",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "IsLibrarian", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "136a7a21-9774-4bba-8287-601af382879b", 0, "7a46c0ae-38b7-4bf4-9f2a-353e6c6c8e5e", null, "Paolo71@gmail.com", false, true, false, null, "DOMENICK33@HOTMAIL.COM", "IRVING.LAKIN", "AQAAAAIAAYagAAAAENOzPTx1ORNG7ikBj+VBRmv3ZsDNrBsCYJ7oWYrAwSiMfUSJJmOJGpAgtnuvD7Zs+g==", null, false, "947ce4e9-ce68-4606-a0c8-4741665ca48c", false, "Ewald_Ortiz" },
                    { "2ce3a1a6-070a-48e1-ac31-e624c9cce708", 0, "e374ace4-fed8-45ff-a034-8405c4b18e89", null, "Davon73@gmail.com", false, false, false, null, "MARISOL_JACOBSON36@GMAIL.COM", "TYLER98", "AQAAAAIAAYagAAAAEHwxblrVk5X+lCp2KVm4nSQ9SHZeSizdPR8XNNymUCLhdn2HFdH7/xMp+TN+sUXJ3Q==", null, false, "f8f67078-f83c-4d30-b68d-20cfb0223b83", false, "Adolfo.Jakubowski" },
                    { "884609cc-0d1d-4cfd-9aef-073a25a2a7cc", 0, "d777ac8a-1726-48d2-b0df-fd5f34ae9b60", null, "Ursula_Cartwright@yahoo.com", false, true, false, null, "KARLEY_SCHUMM74@YAHOO.COM", "HOWELL39", "AQAAAAIAAYagAAAAEGQ/W6VAMhqnNI9J6q5Tzp1f4c3v9tqWk8Ppux1592TZQR/KCEhgRe+67zmFmI6OkA==", null, false, "4653215e-f89e-49e9-9df7-a474ac9ff9ee", false, "Karen_Hammes" },
                    { "95ffd13d-2f17-4988-ac68-bca469936740", 0, "e75fa30f-5b84-4767-b376-41fd0dd14331", null, "Nora.Kuhic79@hotmail.com", false, true, false, null, "SALVATORE67@YAHOO.COM", "RUSTY.ANKUNDING27", "AQAAAAIAAYagAAAAEPyoIiChS/HhkmqPWpepnmSZN0ChjEIulLYVLHRowdqUxh1N6+SBSk+jsz8javTNVw==", null, false, "07914df5-b71c-497f-a5e0-36068399f4f3", false, "Ena.Nicolas72" },
                    { "c94f7f74-4064-45d1-a712-d127c3b69ffd", 0, "d7ddd5d9-9057-4052-81e0-5d42d1a62c1a", null, "Maegan14@yahoo.com", false, true, false, null, "MEKHI_RUNOLFSSON@GMAIL.COM", "TYREL_FLATLEY18", "AQAAAAIAAYagAAAAECBWb6eX1jB6+p3o/F5698fFMtm9X7O2ed/TR2/SGjHbrZgXc8/LDTDPNUxX6Iz90Q==", null, false, "5f2a4528-d3cb-42d0-995d-6bc1d68a24ec", false, "Howard_Waelchi" },
                    { "dc7acf01-de50-4766-9eef-b2c8c321addd", 0, "d3d55cda-308e-4949-87f5-25ab94082617", null, "Myra_Kassulke53@yahoo.com", false, true, false, null, "MELYNA.RENNER65@YAHOO.COM", "BRYON.RAYNOR", "AQAAAAIAAYagAAAAEOiR50/ruEbRLJAbazsiToHxSDFSQus9QhRRFMjy7ioMlIE8cyX/wrxJOtE9ERSr4w==", null, false, "1c56ae9a-27c9-4850-96e7-a502fb2afd3d", false, "Tressa_Turner" },
                    { "dcedffdf-a7ff-4f84-96e2-b1291c88fce3", 0, "fd612ada-0442-456a-a391-5719ec7370cb", null, "Scotty5@yahoo.com", false, false, false, null, "VANCE_WELCH@HOTMAIL.COM", "DEVYN_DAUGHERTY82", "AQAAAAIAAYagAAAAECbWPyWUEGjjQBPf6damtQA/LXIY39/IWPOF40AZTlQ9mITAjE101+f3VL12asp2zw==", null, false, "2e6b9cc4-2624-4de3-bc68-8684a1a15270", false, "Howell8" },
                    { "f697fe75-c521-410d-bb21-1547b16cff21", 0, "b3a8df08-c2cb-40eb-9036-95c017110ae5", null, "Dino_Hilpert@hotmail.com", false, true, false, null, "BRENDEN33@HOTMAIL.COM", "AHMAD69", "AQAAAAIAAYagAAAAEHrmG0K6VHiJeqWSyoAOp3p8GNBJDoQ4GpeIvSQ2Y6sK7Vjd8vim9BAI3+4IdPWPsg==", null, false, "062cbe00-b0eb-4c40-9d9b-6674a93b672d", false, "Stacy28" },
                    { "f913b48d-196d-404c-912f-1ccfb47df40d", 0, "f13e5721-6f9f-4157-addb-8ec1892b24a6", null, "Elliott.Macejkovic42@yahoo.com", false, false, false, null, "ABBIGAIL.LAKIN88@HOTMAIL.COM", "MARCELLUS.EFFERTZ70", "AQAAAAIAAYagAAAAEKGegp9uqnviazM/GYBiYDr1hMR09/8MUq4l6y8/fwxni73oZL12c9Ku/EVgCVyWyQ==", null, false, "fc9a95f5-ec68-40fe-9bcc-0193687e6ab2", false, "Madonna.Predovic" },
                    { "f9ec9f05-7670-4ded-90db-db0380a7accb", 0, "f6f186cd-7d36-4831-b1ea-f01a0fe16988", null, "Aisha.Huel@yahoo.com", false, false, false, null, "FLO74@GMAIL.COM", "HOLLIE_JACOBSON", "AQAAAAIAAYagAAAAEHgJZ1pdv82lB3YuiFUX3cdD/+WCFO4V+ngfScwPTXtZhSYnMyWU7SQgZZ2NNIHifA==", null, false, "85e85f0c-55f3-4781-8c72-892ad12e9205", false, "Jalon_Goyette" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Gwen Dickinson", "Health", "Vel laudantium enim eius quae rem iste. Consequuntur nesciunt voluptas eligendi architecto voluptatem voluptatum.", "7026769209457", 255, new DateTime(2017, 7, 9, 11, 42, 22, 727, DateTimeKind.Local).AddTicks(4828), "Ullrich Group", "Commodi quis itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Johnnie Brekke", "Baby", "Impedit sit dolorem provident ullam. Facilis quaerat non blanditiis rem. Quo velit in. Mollitia tempore quam voluptatem voluptate maiores rerum repudiandae.", "1998857783186", 586, new DateTime(2012, 7, 1, 0, 29, 18, 212, DateTimeKind.Local).AddTicks(3308), "Wuckert - Stroman", "Dolore debitis voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Shaun Hansen", "Toys", "Provident animi iusto minima libero. Rerum quod inventore occaecati voluptatibus mollitia et. Incidunt aut tenetur animi.", "6164882946550", 264, new DateTime(2017, 12, 28, 16, 15, 55, 728, DateTimeKind.Local).AddTicks(6288), "McGlynn - Lueilwitz", "Deleniti assumenda omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Enrique Anderson", "Grocery", "Est dolorem dolores est possimus. Et eum numquam quia illum. Qui minus quia nisi architecto. Voluptas totam sed et sed rerum.", "9208115121776", 514, new DateTime(2021, 11, 29, 15, 59, 12, 243, DateTimeKind.Local).AddTicks(2263), "Toy - Hammes", "Voluptatibus laudantium laboriosam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Brooke O'Conner", "Movies", "Dolorem maxime non molestiae libero et. Culpa quia ad sequi amet recusandae. Enim magnam voluptate necessitatibus quam quod facilis. Et error dignissimos commodi corporis sit voluptas. Omnis itaque eligendi delectus asperiores explicabo laudantium nobis est pariatur.", "1843574108531", 498, new DateTime(2023, 1, 8, 12, 53, 42, 218, DateTimeKind.Local).AddTicks(3236), "Nikolaus - Little", "Adipisci id sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Jeremy Konopelski", "Books", "Quis illo sed eius alias ducimus doloremque provident. At voluptas eum impedit rerum qui. Porro praesentium laboriosam natus magnam. Omnis repudiandae reiciendis sed perferendis assumenda qui delectus. Nesciunt dolores nam placeat et nesciunt blanditiis aliquid.", "6609429991285", 668, new DateTime(2023, 12, 10, 4, 55, 44, 540, DateTimeKind.Local).AddTicks(742), "Collins - Goldner", "Quis sit nostrum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Woodrow Haley", "Beauty", "Molestias facilis quae. Error asperiores quam et dolores. Deserunt quia nisi consectetur eos quas laborum esse. Alias est eveniet sed rerum necessitatibus.", "5834562294028", 112, new DateTime(2014, 8, 30, 12, 51, 18, 38, DateTimeKind.Local).AddTicks(7448), "Mertz and Sons", "Nam ut eos." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Regina Pagac", "Garden", "Modi dolorem itaque harum beatae quasi dolor accusantium. Impedit consectetur non accusamus molestiae quia deleniti nisi.", "3166215585156", 875, new DateTime(2007, 12, 3, 19, 34, 22, 390, DateTimeKind.Local).AddTicks(4947), "McLaughlin and Sons", "Sit sapiente qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Bryan Rosenbaum", "Baby", "Rerum sapiente laudantium eos sed laborum quo dolores eaque. Dignissimos qui consectetur quibusdam enim.", "2894055962028", 930, new DateTime(2022, 4, 25, 3, 2, 46, 544, DateTimeKind.Local).AddTicks(9786), "Schneider Group", "Porro iure reiciendis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Guillermo Wiegand", "Toys", "Quia et voluptatum occaecati voluptas animi itaque quas. Vero aliquam ut qui quae itaque ab maxime aut rerum. Aperiam et consectetur voluptatum.", "0047032459246", 783, new DateTime(2015, 2, 19, 7, 14, 9, 366, DateTimeKind.Local).AddTicks(4941), "Barrows - Stiedemann", "Sunt maxime ducimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Alfonso Medhurst", "Computers", "Veniam sequi occaecati eligendi et reiciendis enim fugiat praesentium id. Accusantium eum similique quae consectetur quis laudantium rem est cumque.", "3947083267302", 448, new DateTime(2006, 12, 26, 20, 59, 35, 177, DateTimeKind.Local).AddTicks(1947), "Little - Borer", "Ea voluptas facilis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppUserId", "Author", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Tasha Dicki", "Enim voluptates est amet sit voluptas est magni. Ipsam quas libero impedit aperiam velit et quia.", "3389216533388", 210, new DateTime(2020, 9, 5, 2, 41, 6, 299, DateTimeKind.Local).AddTicks(7403), "Connelly - Hickle", "Nemo eius ducimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Philip Funk", "Beauty", "Quis dolorem quis esse consequatur molestiae est nihil quia. Ex et quidem.", "2860105088840", 206, new DateTime(2008, 2, 25, 7, 31, 45, 92, DateTimeKind.Local).AddTicks(9754), "Hodkiewicz - Veum", "Hic aut numquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Ricky Stoltenberg", "Sports", "Quidem et impedit at id ex ullam. Eveniet vitae dolore laborum ea temporibus soluta mollitia et.", "9220263550673", 894, new DateTime(2006, 1, 20, 23, 51, 3, 817, DateTimeKind.Local).AddTicks(316), "Pagac - Turcotte", "Error minus alias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Melinda Rau", "Movies", "Molestiae maxime adipisci quis alias dolor molestiae at. Et natus libero non nulla ut totam totam consectetur. Est odit qui deleniti omnis consequatur sed.", "2904198284540", 242, new DateTime(2013, 10, 4, 15, 35, 28, 948, DateTimeKind.Local).AddTicks(2444), "Hauck, Parisian and Ondricka", "Et qui ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Jane Swaniawski", "Kids", "Qui quas aut nostrum dolores minus possimus aut esse. Enim ducimus ut. Quaerat ab dicta delectus molestiae dolore eveniet voluptatem labore dolorem. Consectetur atque enim sapiente.", "8730972957034", 459, new DateTime(2013, 11, 22, 13, 35, 2, 52, DateTimeKind.Local).AddTicks(6918), "O'Keefe - Wyman", "Est deleniti libero." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Irene Spinka", "Sports", "Illo dolores sit iste velit. Magnam adipisci inventore quae minima. Facilis error laborum ea labore ut dolorem earum provident. Autem amet voluptate. Est sed aperiam consectetur.", "8466942766978", 778, new DateTime(2010, 2, 9, 19, 42, 22, 524, DateTimeKind.Local).AddTicks(2928), "Torp LLC", "Voluptatem eaque sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Armando Runolfsson", "Grocery", "Vero alias ad reprehenderit. Magnam aliquam fuga maiores dolorem nemo error est.", "3961147590663", 775, new DateTime(2023, 4, 10, 15, 50, 52, 291, DateTimeKind.Local).AddTicks(3481), "Walker - Hoppe", "Earum et voluptates." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Pedro Kunde", "Home", "Tempora minima totam culpa et. Voluptates quasi vel molestiae eum inventore beatae quibusdam. Voluptas minus ex. Autem aut aspernatur totam facere ut consequatur. Harum voluptatem voluptates vel mollitia quae.", "7188250067011", 848, new DateTime(2008, 10, 30, 20, 45, 53, 598, DateTimeKind.Local).AddTicks(3004), "Rohan, Hane and Wiza", "Vel perspiciatis rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppUserId", "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { null, "Kerry Ernser", "Automotive", "Commodi earum et iusto voluptas explicabo repudiandae. At laborum consequatur nulla optio illo. Dolores assumenda esse.", "2079369143664", 758, new DateTime(2022, 9, 1, 12, 3, 17, 513, DateTimeKind.Local).AddTicks(6485), "Feeney - Murazik", "Aut animi magnam." });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AppUserId",
                table: "Books",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_AppUserId",
                table: "Books",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
