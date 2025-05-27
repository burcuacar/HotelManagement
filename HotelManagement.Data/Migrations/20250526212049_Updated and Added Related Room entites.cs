using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedandAddedRelatedRoomentites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Street",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "RoomTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "RoomTypes",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoomTypes",
                newName: "RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Addresses",
                newName: "AddressLine1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PetFriendly",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeStatusId",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SmokeFriendly",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "RoomStatusId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZIP",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RoomStatus",
                columns: table => new
                {
                    RoomStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStatus", x => x.RoomStatusId);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypeStatus",
                columns: table => new
                {
                    RoomTypeStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypeStatus", x => x.RoomTypeStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypes_RoomTypeStatusId",
                table: "RoomTypes",
                column: "RoomTypeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomStatusId",
                table: "Rooms",
                column: "RoomStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomStatus_RoomStatusId",
                table: "Rooms",
                column: "RoomStatusId",
                principalTable: "RoomStatus",
                principalColumn: "RoomStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTypes_RoomTypeStatus_RoomTypeStatusId",
                table: "RoomTypes",
                column: "RoomTypeStatusId",
                principalTable: "RoomTypeStatus",
                principalColumn: "RoomTypeStatusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomStatus_RoomStatusId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomTypes_RoomTypeStatus_RoomTypeStatusId",
                table: "RoomTypes");

            migrationBuilder.DropTable(
                name: "RoomStatus");

            migrationBuilder.DropTable(
                name: "RoomTypeStatus");

            migrationBuilder.DropIndex(
                name: "IX_RoomTypes_RoomTypeStatusId",
                table: "RoomTypes");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomStatusId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "PetFriendly",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "RoomTypeStatusId",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "SmokeFriendly",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "RoomStatusId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ZIP",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RoomTypes",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "RoomTypes",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "RoomTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "Addresses",
                newName: "ZipCode");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
