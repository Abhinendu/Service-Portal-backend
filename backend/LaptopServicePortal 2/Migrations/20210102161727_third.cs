using Microsoft.EntityFrameworkCore.Migrations;

namespace LaptopServicePortal_2.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Tickets",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "summary",
                table: "Tickets",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "complaintType",
                table: "Tickets",
                newName: "ComplaintType");

            migrationBuilder.RenameColumn(
                name: "commentId",
                table: "Tickets",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "ticketId",
                table: "Tickets",
                newName: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tickets",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Tickets",
                newName: "summary");

            migrationBuilder.RenameColumn(
                name: "ComplaintType",
                table: "Tickets",
                newName: "complaintType");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Tickets",
                newName: "commentId");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "ticketId");
        }
    }
}
