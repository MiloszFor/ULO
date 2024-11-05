using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ULO.UI.Migrations
{
    /// <inheritdoc />
    public partial class Init10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "guestsTeamId",
                table: "Match",
                newName: "HostTeamId");

            migrationBuilder.RenameColumn(
                name: "HostsTeamId",
                table: "Match",
                newName: "GuestTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HostTeamId",
                table: "Match",
                newName: "guestsTeamId");

            migrationBuilder.RenameColumn(
                name: "GuestTeamId",
                table: "Match",
                newName: "HostsTeamId");
        }
    }
}
