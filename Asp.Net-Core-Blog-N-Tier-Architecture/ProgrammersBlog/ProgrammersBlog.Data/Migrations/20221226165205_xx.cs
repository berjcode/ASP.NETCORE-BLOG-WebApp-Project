using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class xx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "658f8fe8-5807-4a0d-b8df-b6b2a935e6f8", "AQAAAAEAACcQAAAAEH0WoSkrrjhVNsxZO/8cuBFZnJeOm5wrnh0UfKShQFQOFXymPJ+I+y0pDyXvHYJV2g==", "218bc8f9-5bba-438c-85b0-d0cc2d4f65eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ce8ac6-8ce4-4178-9283-d17492adbeea", "AQAAAAEAACcQAAAAELRMPu48yz0kdd80kWXU68xNJldaWCyWOhWJ7tIlMHIk4qjHIjzy/+W6/0KdgDo+wQ==", "5264ee48-dd8f-4996-8b93-c33da6c3d37b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 512, DateTimeKind.Local).AddTicks(8576), new DateTime(2022, 12, 26, 19, 50, 15, 512, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 12, 26, 19, 50, 15, 512, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1270), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1266), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1282), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1279), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1294), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1292), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1387), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1384), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1399), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1407), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1419), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1417), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1427), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1441), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1439), new DateTime(2022, 12, 26, 19, 50, 15, 513, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2882), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2898), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2906), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2915), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2923), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2931), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2939), new DateTime(2022, 12, 26, 19, 50, 15, 518, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4783), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4866), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4882), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4898), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4912), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4928), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4961), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4976), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 12, 26, 19, 50, 15, 525, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a9833339-7301-4eea-84ed-d37838ba0b9d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3cfbae7c-18c7-49c7-8e03-b07374c26826");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b72b360a-65d6-44ac-8b4a-7c5cdd86e1d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8a25e136-6e6b-48ee-ab4b-23408a5c7882");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "f7c2f6e4-ca64-4537-a75f-97008d617e98");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "75c17cfe-6832-4983-bcd8-816565477c67");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "3a724c9b-4c64-44ed-a043-5325cf4dd76c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "de8cd40d-8c65-4925-a427-aec1fa61eeaf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "52fdad7b-ace2-44dd-9e25-40fe7e9fc3cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "daa5ed4e-acda-43b3-a794-c9bad38c8308");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "aecb25f1-a49a-48c5-ab65-5a49019760a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "44cee414-5766-4b53-adaa-00efe0e7d41c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "eac32f0e-fcf4-4d70-9df5-914a92f9a715");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "7d0cc5c4-09c9-4785-843c-58fcabf2e3df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "b39b0dd5-2313-40ae-af9c-7d0f07ae41a7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "5d624adc-b94c-42e2-8735-ba712b6545eb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "dbd766a5-21e0-4958-b0e5-9ee69c6c5580");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "75afd67f-5109-4fa0-9f65-fc055068dcc1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "a00be4b2-2f53-484c-b942-5b220bd0362f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "483f7e07-0e7c-4dd2-8efe-49368050b468");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "9e2506e3-ecdd-4618-86c7-3e3b63c74fc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "7cd1a7d4-da47-41cd-a089-4a990eae7466");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3695d3c4-be23-4dbb-9be6-0652d8bdde10", "AQAAAAEAACcQAAAAELhH9wPK/22H88CgaptKDl4D3AuFUIMHYGjj9erqFLhfZ+gUEPbMaHnK9DaX3b1Exg==", "c27a73ed-f040-4b85-9ca6-190ea3df563d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ae7d3e0-dbc5-4935-8279-5f57dc58b847", "AQAAAAEAACcQAAAAENG37VR/ZxtpPJ8kzjColC+pQmNLdopFNf/pcJnLTxo05utvV7tK7T/z6nV8sUndKA==", "950bcd8c-e9a7-4810-a1ee-787cbe280349" });
        }
    }
}
