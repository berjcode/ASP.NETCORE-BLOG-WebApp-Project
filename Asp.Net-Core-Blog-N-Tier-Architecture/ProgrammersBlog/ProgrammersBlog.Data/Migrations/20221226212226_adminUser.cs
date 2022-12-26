using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class adminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 144, DateTimeKind.Local).AddTicks(8059), new DateTime(2022, 12, 27, 0, 22, 25, 144, DateTimeKind.Local).AddTicks(5537), new DateTime(2022, 12, 27, 0, 22, 25, 144, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2333), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2346), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2343), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2357), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2355), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2367), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2365), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2378), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2376), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2388), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2386), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2399), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2397), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2408), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2418), new DateTime(2022, 12, 27, 0, 22, 25, 145, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(4998), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5063), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5071), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5079), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5088), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5096), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5104), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5112), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 12, 27, 0, 22, 25, 153, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4167), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4238), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4249), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4258), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4267), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4277), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4286), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4295), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4305), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4315), new DateTime(2022, 12, 27, 0, 22, 25, 158, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e0b1a287-bbb3-43de-9ecd-c75878a22297");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c573e3d0-63ac-4688-a310-383ce667bf8c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "718eb2a9-44c2-41e5-ad80-a491721e064e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a3c69a12-10c1-480d-b937-204c8c2d8c19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "14abf07d-9ae3-40bc-bbe8-5a38fed426f1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "ea3cdbcb-41aa-4cba-93cd-c99bf0544e7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "52571a75-ea01-4ea7-8e75-3023df7a5348");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "859dfc4f-a00a-4a71-8225-764e3269c9d6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "c565c487-b0b0-4833-a5c3-77cf65d6559b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "d6125e0e-03b6-4ef4-afa5-f07ee7464277");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "6a334bdf-f095-4c64-9077-4bb709448f52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "7ff4ccaa-d5aa-4218-9287-835ff1dbc212");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "eba8cf6c-fc60-42a3-bc1b-5b2e802ae24b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "a1005277-5217-4cb7-ae95-4ca21fc272f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "6b02c807-9a48-46de-9763-eddaa856c50e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "76dfa1aa-0ca3-4224-8c78-71365702fd39");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "44493d93-b1c6-4f4d-bf6c-5347259eee04");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "a9ca38cb-59a2-4357-b008-76de82799876");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "3932e22c-0b40-4e9d-99f3-8f561ab3f4bd");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "d5b92477-0ece-4a4c-91d5-57e556b73ac8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "a4ba4d57-6f2a-4aaa-8b39-6f859fc1c829");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "dab70141-f88f-4deb-976b-a4bb19ded262");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "GitHubLink", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Admin  Bilişim Sözlüğü", "e1ff5320-be3b-4d7d-9eb7-193420d695ef", "abdullah@gmail.com", "https://github.com/berjcode", "ABDULLAH@GMAIL.COM", "abdullah", "AQAAAAEAACcQAAAAEH81KudSAnvqDyb9zzYiwbbihzs+mBFIyE3QEr7THxbiemb7da/IxZNoWBtADXAg0w==", "3072c889-82b6-4127-91b2-6ff3bc32fdfb", "abdullah" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfbd0bbd-c67d-4ea3-be85-8783c734fe32", "AQAAAAEAACcQAAAAENzJfqQozdHzJLVnRCyDLA1lEMn+ih7RFgyeYeQkKJ2shMaS58O0NfS9OdyAWa4+/w==", "b6a55db2-4460-4149-a04d-664da71cf02b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(2609), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(928), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5581), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5579), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5594), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5592), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5605), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5603), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5613), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5628), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5626), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5637), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5649), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5647), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5658), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 12, 26, 19, 52, 4, 297, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8287), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8328), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8339), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8347), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8355), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8363), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8371), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8379), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8387), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8395), new DateTime(2022, 12, 26, 19, 52, 4, 302, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9281), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9323), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9341), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9349), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9357), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9365), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9373), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9381), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9389), new DateTime(2022, 12, 26, 19, 52, 4, 306, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a2420987-f9d3-4cb5-9e2c-fe20cdcf5c1a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "26f0d2f5-1255-4dcc-8252-cd17994807af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2343891e-fd73-487e-95ea-658f0e043937");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "b7eb623e-d751-4322-ab20-c7eeee0e4caf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8b84dc57-6255-4d5c-9728-582d8c47855f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "cd7fac71-e7fc-4292-95bf-5426ab7070ba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "72eaa789-65da-4b53-8547-a9787a081d5a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "a01f5db7-e66c-4ff1-b891-44573099b970");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "9f91d9d2-8aff-4cb5-8a4b-6a8c7915ead6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "a890e78e-264a-4d35-8831-24705a3f76c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "f263f03a-d4fb-48e3-82fc-1763a89499d4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "312c0a98-d5b7-472e-a3a6-8daec06b0f56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "55c8e604-0b11-4260-844c-383e2ac52bd5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "720b99a2-956b-44b2-b764-b4b381cd02e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "d6613818-3d41-431a-8382-ef64e9c0844a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "8acb1640-ace1-4537-8110-44cd31c67d2d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "ffb974d8-aa0a-4ef5-ae55-3eb62e9b5146");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "cd55eb11-79b0-45c3-a2b5-a2ef39cc5807");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "d8883b19-3f8c-472b-b109-a608921cbd78");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "92222f8c-a9ca-430e-8f5b-f09bedc2e90b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "1159f527-1913-4efb-a31b-5313d324484f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "011d63c5-6cc7-46ca-80df-2fad96e8d535");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "ConcurrencyStamp", "Email", "GitHubLink", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "Admin of Bilişim Sözlüğü", "658f8fe8-5807-4a0d-b8df-b6b2a935e6f8", "admin@gmail.com", "https://github.com/adminuser", "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEH0WoSkrrjhVNsxZO/8cuBFZnJeOm5wrnh0UfKShQFQOFXymPJ+I+y0pDyXvHYJV2g==", "218bc8f9-5bba-438c-85b0-d0cc2d4f65eb", "admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ce8ac6-8ce4-4178-9283-d17492adbeea", "AQAAAAEAACcQAAAAELRMPu48yz0kdd80kWXU68xNJldaWCyWOhWJ7tIlMHIk4qjHIjzy/+W6/0KdgDo+wQ==", "5264ee48-dd8f-4996-8b93-c33da6c3d37b" });
        }
    }
}
