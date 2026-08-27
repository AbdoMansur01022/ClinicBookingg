using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicBookingg.Migrations
{
    /// <inheritdoc />
    public partial class FixUsersAndModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENNmfY+q2gHgChayZ3UCILVDym57loMTX6HgXpTNQTCT3JxdWRtVcO2rqz7V36VFOw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDFALzt0tnelzv5POsk4q1KzO/ZGftxurBpdyYvjhyxLrj37xzD4gFgIF5KU89JhjA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC/eWPyIZAAHTtBBAqaVuB9xlh5cri++IlOvkiXw3q0XnEAatval8GCylTsIRT/yjw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB8fXLwi2V8f520vOZ1fCRmcP2Mza48twn1jNRtqSRwLFYDmXEuDFGPM/2yBAJ9MZw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENck7nzAEoAPlJ8ztx4bT0IFwBtgqQwZ7Q57Mysm3edzno1AZAQM3JBDtzy87EOAQg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL3NrHPfp0EeodzmfsI6D+zruV4fg2qe0jMeN1XNdeOMbaUWT5AJHVK3ez8RwERcRg==");
        }
    }
}
