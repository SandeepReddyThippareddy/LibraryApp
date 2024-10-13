using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameUserToAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fa1ef75-e675-49b3-b6e4-edca6ef451ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29ff7b35-167f-450a-9fa3-315d0c666724");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ed7fe43-3e5e-4124-9f78-357dd5a719da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36335a6c-5104-4aed-8d8e-278d91f6bd8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ac2132a-f25e-46b8-a4b1-fc4e0d01228b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50becd4a-bda0-406b-92d1-e1225dd8090e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5abeb6ac-ef87-4bfa-b19f-52e43d373fb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fdfcc5b-8cf7-44d3-979e-0a99966ab7c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9444d29-60d5-456e-840d-25f5533fb2ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0aa8f2a-1b45-4eb5-a1cb-efe8236d91a0");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Books",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_UserId",
                table: "Books",
                newName: "IX_Books_AppUserId");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
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
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Gwen Dickinson", "Health", "Vel laudantium enim eius quae rem iste. Consequuntur nesciunt voluptas eligendi architecto voluptatem voluptatum.", "7026769209457", 255, new DateTime(2017, 7, 9, 11, 42, 22, 727, DateTimeKind.Local).AddTicks(4828), "Ullrich Group", "Commodi quis itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Johnnie Brekke", "Baby", "Impedit sit dolorem provident ullam. Facilis quaerat non blanditiis rem. Quo velit in. Mollitia tempore quam voluptatem voluptate maiores rerum repudiandae.", "1998857783186", 586, new DateTime(2012, 7, 1, 0, 29, 18, 212, DateTimeKind.Local).AddTicks(3308), "Wuckert - Stroman", "Dolore debitis voluptatem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Shaun Hansen", "Toys", "Provident animi iusto minima libero. Rerum quod inventore occaecati voluptatibus mollitia et. Incidunt aut tenetur animi.", "6164882946550", 264, new DateTime(2017, 12, 28, 16, 15, 55, 728, DateTimeKind.Local).AddTicks(6288), "McGlynn - Lueilwitz", "Deleniti assumenda omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Enrique Anderson", "Grocery", "Est dolorem dolores est possimus. Et eum numquam quia illum. Qui minus quia nisi architecto. Voluptas totam sed et sed rerum.", "9208115121776", 514, new DateTime(2021, 11, 29, 15, 59, 12, 243, DateTimeKind.Local).AddTicks(2263), "Toy - Hammes", "Voluptatibus laudantium laboriosam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Brooke O'Conner", "Movies", "Dolorem maxime non molestiae libero et. Culpa quia ad sequi amet recusandae. Enim magnam voluptate necessitatibus quam quod facilis. Et error dignissimos commodi corporis sit voluptas. Omnis itaque eligendi delectus asperiores explicabo laudantium nobis est pariatur.", "1843574108531", 498, new DateTime(2023, 1, 8, 12, 53, 42, 218, DateTimeKind.Local).AddTicks(3236), "Nikolaus - Little", "Adipisci id sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Jeremy Konopelski", "Books", "Quis illo sed eius alias ducimus doloremque provident. At voluptas eum impedit rerum qui. Porro praesentium laboriosam natus magnam. Omnis repudiandae reiciendis sed perferendis assumenda qui delectus. Nesciunt dolores nam placeat et nesciunt blanditiis aliquid.", "6609429991285", 668, new DateTime(2023, 12, 10, 4, 55, 44, 540, DateTimeKind.Local).AddTicks(742), "Collins - Goldner", "Quis sit nostrum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Woodrow Haley", "Beauty", "Molestias facilis quae. Error asperiores quam et dolores. Deserunt quia nisi consectetur eos quas laborum esse. Alias est eveniet sed rerum necessitatibus.", "5834562294028", 112, new DateTime(2014, 8, 30, 12, 51, 18, 38, DateTimeKind.Local).AddTicks(7448), "Mertz and Sons", "Nam ut eos." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Regina Pagac", "Garden", "Modi dolorem itaque harum beatae quasi dolor accusantium. Impedit consectetur non accusamus molestiae quia deleniti nisi.", "3166215585156", 875, new DateTime(2007, 12, 3, 19, 34, 22, 390, DateTimeKind.Local).AddTicks(4947), "McLaughlin and Sons", "Sit sapiente qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Bryan Rosenbaum", "Baby", "Rerum sapiente laudantium eos sed laborum quo dolores eaque. Dignissimos qui consectetur quibusdam enim.", "2894055962028", 930, new DateTime(2022, 4, 25, 3, 2, 46, 544, DateTimeKind.Local).AddTicks(9786), "Schneider Group", "Porro iure reiciendis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Guillermo Wiegand", "Toys", "Quia et voluptatum occaecati voluptas animi itaque quas. Vero aliquam ut qui quae itaque ab maxime aut rerum. Aperiam et consectetur voluptatum.", "0047032459246", 783, new DateTime(2015, 2, 19, 7, 14, 9, 366, DateTimeKind.Local).AddTicks(4941), "Barrows - Stiedemann", "Sunt maxime ducimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Alfonso Medhurst", "Computers", "Veniam sequi occaecati eligendi et reiciendis enim fugiat praesentium id. Accusantium eum similique quae consectetur quis laudantium rem est cumque.", "3947083267302", 448, new DateTime(2006, 12, 26, 20, 59, 35, 177, DateTimeKind.Local).AddTicks(1947), "Little - Borer", "Ea voluptas facilis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Tasha Dicki", "Beauty", "Enim voluptates est amet sit voluptas est magni. Ipsam quas libero impedit aperiam velit et quia.", "3389216533388", 210, new DateTime(2020, 9, 5, 2, 41, 6, 299, DateTimeKind.Local).AddTicks(7403), "Connelly - Hickle", "Nemo eius ducimus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Philip Funk", "Beauty", "Quis dolorem quis esse consequatur molestiae est nihil quia. Ex et quidem.", "2860105088840", 206, new DateTime(2008, 2, 25, 7, 31, 45, 92, DateTimeKind.Local).AddTicks(9754), "Hodkiewicz - Veum", "Hic aut numquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ricky Stoltenberg", "Sports", "Quidem et impedit at id ex ullam. Eveniet vitae dolore laborum ea temporibus soluta mollitia et.", "9220263550673", 894, new DateTime(2006, 1, 20, 23, 51, 3, 817, DateTimeKind.Local).AddTicks(316), "Pagac - Turcotte", "Error minus alias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Melinda Rau", "Movies", "Molestiae maxime adipisci quis alias dolor molestiae at. Et natus libero non nulla ut totam totam consectetur. Est odit qui deleniti omnis consequatur sed.", "2904198284540", 242, new DateTime(2013, 10, 4, 15, 35, 28, 948, DateTimeKind.Local).AddTicks(2444), "Hauck, Parisian and Ondricka", "Et qui ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Jane Swaniawski", "Kids", "Qui quas aut nostrum dolores minus possimus aut esse. Enim ducimus ut. Quaerat ab dicta delectus molestiae dolore eveniet voluptatem labore dolorem. Consectetur atque enim sapiente.", "8730972957034", 459, new DateTime(2013, 11, 22, 13, 35, 2, 52, DateTimeKind.Local).AddTicks(6918), "O'Keefe - Wyman", "Est deleniti libero." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Irene Spinka", "Sports", "Illo dolores sit iste velit. Magnam adipisci inventore quae minima. Facilis error laborum ea labore ut dolorem earum provident. Autem amet voluptate. Est sed aperiam consectetur.", "8466942766978", 778, new DateTime(2010, 2, 9, 19, 42, 22, 524, DateTimeKind.Local).AddTicks(2928), "Torp LLC", "Voluptatem eaque sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Armando Runolfsson", "Grocery", "Vero alias ad reprehenderit. Magnam aliquam fuga maiores dolorem nemo error est.", "3961147590663", 775, new DateTime(2023, 4, 10, 15, 50, 52, 291, DateTimeKind.Local).AddTicks(3481), "Walker - Hoppe", "Earum et voluptates." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Pedro Kunde", "Home", "Tempora minima totam culpa et. Voluptates quasi vel molestiae eum inventore beatae quibusdam. Voluptas minus ex. Autem aut aspernatur totam facere ut consequatur. Harum voluptatem voluptates vel mollitia quae.", "7188250067011", 848, new DateTime(2008, 10, 30, 20, 45, 53, 598, DateTimeKind.Local).AddTicks(3004), "Rohan, Hane and Wiza", "Vel perspiciatis rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Kerry Ernser", "Automotive", "Commodi earum et iusto voluptas explicabo repudiandae. At laborum consequatur nulla optio illo. Dolores assumenda esse.", "2079369143664", 758, new DateTime(2022, 9, 1, 12, 3, 17, 513, DateTimeKind.Local).AddTicks(6485), "Feeney - Murazik", "Aut animi magnam." });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_AppUserId",
                table: "Books",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_AppUserId",
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
                name: "DisplayName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Books",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AppUserId",
                table: "Books",
                newName: "IX_Books_UserId");

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Tabitha Orn", "Kids", "Voluptate velit quos temporibus qui saepe ullam quas. Qui expedita perferendis aut reiciendis similique atque est minus impedit.", "1820921796795", 770, new DateTime(2024, 4, 2, 13, 47, 39, 653, DateTimeKind.Local).AddTicks(9202), "Rau Group", "Eligendi magni eaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Betty Johnson", "Electronics", "At et enim. Sequi saepe adipisci omnis vitae.", "1116983171909", 552, new DateTime(2011, 9, 22, 17, 34, 19, 970, DateTimeKind.Local).AddTicks(8801), "Rutherford and Sons", "Delectus dolores natus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lionel Mills", "Music", "Minima voluptatibus aut et exercitationem excepturi. Tempora placeat iste. Eos deleniti rerum occaecati dolores ut sapiente animi adipisci. Et accusantium dicta sint.", "7127883603890", 910, new DateTime(2018, 8, 29, 17, 6, 9, 110, DateTimeKind.Local).AddTicks(5396), "Ferry, Davis and Maggio", "Molestiae ullam eligendi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Regina Raynor", "Games", "Ex nostrum eveniet dolor cumque velit repellat. Autem cumque perspiciatis eaque modi consequatur. Ea dicta possimus sit sequi vel ut deleniti eum. Mollitia a ut. Laudantium aliquid earum sed et reiciendis numquam exercitationem hic et.", "8331536789506", 926, new DateTime(2020, 11, 8, 21, 25, 30, 574, DateTimeKind.Local).AddTicks(4152), "Prosacco, Lang and Murray", "Sequi sed et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Rachael Adams", "Shoes", "Recusandae rem reprehenderit itaque porro. Culpa velit et magnam sequi vel reprehenderit consectetur. Voluptatem ut velit repellat ducimus.", "4246945053336", 544, new DateTime(2022, 6, 18, 7, 2, 7, 594, DateTimeKind.Local).AddTicks(4289), "Kuhn, MacGyver and Bernhard", "Quia tempora eligendi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Lora Mraz", "Garden", "Odio eum quia hic nisi. Amet eveniet amet facere laudantium soluta est.", "5320625797662", 672, new DateTime(2022, 10, 15, 20, 54, 16, 22, DateTimeKind.Local).AddTicks(6538), "Russel Group", "Omnis voluptatum in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Eduardo Turcotte", "Electronics", "A rem doloribus quibusdam in. Error quia sit dolorem quam et. Assumenda omnis ut qui. Eos occaecati suscipit ad expedita quod commodi. Sit rerum earum.", "1561194364020", 666, new DateTime(2004, 12, 13, 13, 1, 11, 285, DateTimeKind.Local).AddTicks(3876), "Jacobson LLC", "Sunt optio molestiae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Diane Yundt", "Electronics", "Et iste velit similique in. Dignissimos unde voluptas pariatur omnis et. Deserunt eveniet sed. Nostrum rem earum minus dolorum sed eligendi.", "4007723246421", 588, new DateTime(2023, 7, 16, 18, 32, 12, 848, DateTimeKind.Local).AddTicks(875), "Beatty, Morissette and Zemlak", "Eum inventore voluptates." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Dwight Heaney", "Beauty", "Dolore laborum numquam molestias. Nesciunt et aut unde sint optio animi quibusdam ut rerum.", "7739133736830", 463, new DateTime(2007, 6, 16, 3, 50, 18, 44, DateTimeKind.Local).AddTicks(8329), "Friesen - Kiehn", "Provident repudiandae id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Vera Hettinger", "Outdoors", "Ab porro dolor nulla qui deleniti. Aut nihil non officia impedit suscipit inventore quia. Aut est esse exercitationem doloremque molestiae.", "0188733749400", 710, new DateTime(2022, 4, 15, 10, 28, 40, 353, DateTimeKind.Local).AddTicks(9638), "Stokes, Carter and Casper", "Aut quidem ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Elijah Schaden", "Electronics", "Ea repudiandae explicabo. Sit ut qui minus itaque repellendus ut nulla non nobis. Voluptatibus perferendis provident amet voluptatem. Eos id omnis enim et. Ea a ipsum aspernatur aut.", "1209282832968", 573, new DateTime(2014, 5, 30, 14, 15, 38, 434, DateTimeKind.Local).AddTicks(2851), "Frami, Rice and Bernier", "Ex autem quisquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Andrea Ward", "Grocery", "Ut itaque sit non nihil et enim sit laborum. Velit exercitationem dolor rem est veniam placeat ut tenetur dolor. Debitis quod nostrum aut est. Tenetur et laborum quisquam porro recusandae repudiandae. Quia aut praesentium rerum ipsa.", "2416290053813", 196, new DateTime(2007, 12, 16, 18, 42, 7, 300, DateTimeKind.Local).AddTicks(7977), "Dare Inc", "Et repudiandae consequuntur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Melissa Torphy", "Tools", "Quidem perspiciatis facilis mollitia veniam accusamus natus doloremque. Aut modi saepe. Commodi cupiditate cum molestiae numquam ut quis.", "9902894969481", 451, new DateTime(2019, 4, 5, 18, 2, 8, 855, DateTimeKind.Local).AddTicks(2793), "Cummerata, Schowalter and Lebsack", "Et rerum non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Paulette Cole", "Shoes", "Illo voluptate impedit est. Totam adipisci nemo ipsum soluta. Id ab provident nam rem. Rem ad blanditiis nihil enim sunt labore quidem quae quia.", "7637362041131", 883, new DateTime(2006, 11, 4, 20, 42, 59, 232, DateTimeKind.Local).AddTicks(2589), "Brekke, Olson and Hahn", "Hic ea dolorem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Laverne Beahan", "Computers", "Eum dolorum et dolor est. Ducimus a sint ipsum dolores excepturi iusto. Quaerat reprehenderit tenetur aut. Nisi veritatis eum sit cupiditate exercitationem quia.", "9797949899604", 337, new DateTime(2021, 12, 19, 18, 26, 46, 321, DateTimeKind.Local).AddTicks(7258), "Macejkovic, Leannon and Dach", "Perspiciatis cupiditate quidem." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Emma Bernhard", "Automotive", "Accusamus sunt ex possimus. Ut delectus fugiat nam vel quis architecto aperiam sed. Nesciunt veritatis non vero harum quis laudantium veniam ut ad.", "4183492613036", 943, new DateTime(2010, 2, 26, 3, 26, 41, 94, DateTimeKind.Local).AddTicks(8889), "Kuhlman and Sons", "Excepturi et ullam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Elias Cassin", "Industrial", "Excepturi enim in quas ea. Et odit cupiditate quod iure laboriosam. Et quaerat dolorum soluta. Molestiae odio quia est exercitationem ratione minus maxime sint eveniet.", "7582312106821", 885, new DateTime(2017, 11, 6, 17, 41, 33, 747, DateTimeKind.Local).AddTicks(5461), "Satterfield - Zieme", "Et aut rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Stuart Koss", "Outdoors", "Molestias odit id quia quasi. Voluptatem corporis molestias veritatis blanditiis qui quisquam minima et. Ea unde dolorem voluptas eum corporis maxime porro. Suscipit et est vel nostrum modi repellendus.", "4331245932952", 635, new DateTime(2006, 1, 2, 21, 26, 15, 168, DateTimeKind.Local).AddTicks(59), "Blanda, Swaniawski and Hand", "Tempore quisquam enim." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Ignacio Kuhic", "Kids", "Neque vel aperiam et culpa. Sed magnam et ratione.", "6280350342171", 189, new DateTime(2007, 8, 28, 3, 8, 9, 913, DateTimeKind.Local).AddTicks(9281), "Glover, Gaylord and Leuschke", "Recusandae cum hic." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "Category", "Description", "ISBN", "PageCount", "PublicationDate", "Publisher", "Title" },
                values: new object[] { "Elmer Streich", "Clothing", "Magni necessitatibus magni recusandae. Possimus ut autem corrupti eum. Rerum voluptatem explicabo debitis nihil. Deleniti quisquam in qui beatae inventore atque quae.", "9921113050960", 439, new DateTime(2007, 12, 15, 14, 58, 19, 245, DateTimeKind.Local).AddTicks(5075), "Keebler LLC", "Assumenda deleniti voluptatem." });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_UserId",
                table: "Books",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
