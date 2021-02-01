using Microsoft.EntityFrameworkCore.Migrations;

namespace AppCordTask.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageLogs_PhoneNumbers_PhoneNumberId",
                table: "MessageLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageLogs",
                table: "MessageLogs");

            migrationBuilder.RenameTable(
                name: "PhoneNumbers",
                newName: "PhoneNumber");

            migrationBuilder.RenameTable(
                name: "MessageLogs",
                newName: "MessageLog");

            migrationBuilder.RenameIndex(
                name: "IX_MessageLogs_PhoneNumberId",
                table: "MessageLog",
                newName: "IX_MessageLog_PhoneNumberId");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "PhoneNumber",
                type: "nvarchar(1024)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "MessageLog",
                type: "nvarchar(1024)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumber",
                table: "PhoneNumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageLog",
                table: "MessageLog",
                column: "Id");

            migrationBuilder.InsertData(
                table: "PhoneNumber",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1, "Phone Number1" },
                    { 73, "Phone Number73" },
                    { 72, "Phone Number72" },
                    { 71, "Phone Number71" },
                    { 70, "Phone Number70" },
                    { 69, "Phone Number69" },
                    { 68, "Phone Number68" },
                    { 67, "Phone Number67" },
                    { 66, "Phone Number66" },
                    { 65, "Phone Number65" },
                    { 64, "Phone Number64" },
                    { 63, "Phone Number63" },
                    { 62, "Phone Number62" },
                    { 61, "Phone Number61" },
                    { 60, "Phone Number60" },
                    { 59, "Phone Number59" },
                    { 58, "Phone Number58" },
                    { 57, "Phone Number57" },
                    { 56, "Phone Number56" },
                    { 55, "Phone Number55" },
                    { 54, "Phone Number54" },
                    { 53, "Phone Number53" },
                    { 74, "Phone Number74" },
                    { 52, "Phone Number52" },
                    { 75, "Phone Number75" },
                    { 77, "Phone Number77" },
                    { 98, "Phone Number98" },
                    { 97, "Phone Number97" },
                    { 96, "Phone Number96" },
                    { 95, "Phone Number95" },
                    { 94, "Phone Number94" },
                    { 93, "Phone Number93" },
                    { 92, "Phone Number92" },
                    { 91, "Phone Number91" },
                    { 90, "Phone Number90" },
                    { 89, "Phone Number89" },
                    { 88, "Phone Number88" },
                    { 87, "Phone Number87" },
                    { 86, "Phone Number86" },
                    { 85, "Phone Number85" },
                    { 84, "Phone Number84" },
                    { 83, "Phone Number83" },
                    { 82, "Phone Number82" },
                    { 81, "Phone Number81" },
                    { 80, "Phone Number80" },
                    { 79, "Phone Number79" },
                    { 78, "Phone Number78" },
                    { 76, "Phone Number76" },
                    { 51, "Phone Number51" },
                    { 50, "Phone Number50" },
                    { 49, "Phone Number49" },
                    { 22, "Phone Number22" },
                    { 21, "Phone Number21" },
                    { 20, "Phone Number20" },
                    { 19, "Phone Number19" },
                    { 18, "Phone Number18" },
                    { 17, "Phone Number17" },
                    { 16, "Phone Number16" },
                    { 15, "Phone Number15" },
                    { 14, "Phone Number14" },
                    { 13, "Phone Number13" },
                    { 12, "Phone Number12" },
                    { 11, "Phone Number11" },
                    { 10, "Phone Number10" },
                    { 9, "Phone Number9" },
                    { 8, "Phone Number8" },
                    { 7, "Phone Number7" },
                    { 6, "Phone Number6" },
                    { 5, "Phone Number5" },
                    { 4, "Phone Number4" },
                    { 3, "Phone Number3" },
                    { 2, "Phone Number2" },
                    { 23, "Phone Number23" },
                    { 24, "Phone Number24" },
                    { 25, "Phone Number25" },
                    { 26, "Phone Number26" },
                    { 48, "Phone Number48" },
                    { 47, "Phone Number47" },
                    { 46, "Phone Number46" },
                    { 45, "Phone Number45" },
                    { 44, "Phone Number44" },
                    { 43, "Phone Number43" },
                    { 42, "Phone Number42" },
                    { 41, "Phone Number41" },
                    { 40, "Phone Number40" },
                    { 39, "Phone Number39" },
                    { 99, "Phone Number99" },
                    { 38, "Phone Number38" },
                    { 36, "Phone Number36" },
                    { 35, "Phone Number35" },
                    { 34, "Phone Number34" },
                    { 33, "Phone Number33" },
                    { 32, "Phone Number32" },
                    { 31, "Phone Number31" },
                    { 30, "Phone Number30" },
                    { 29, "Phone Number29" },
                    { 28, "Phone Number28" },
                    { 27, "Phone Number27" },
                    { 37, "Phone Number37" },
                    { 100, "Phone Number100" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MessageLog_PhoneNumber_PhoneNumberId",
                table: "MessageLog",
                column: "PhoneNumberId",
                principalTable: "PhoneNumber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageLog_PhoneNumber_PhoneNumberId",
                table: "MessageLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumber",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageLog",
                table: "MessageLog");

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PhoneNumber",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                newName: "PhoneNumbers");

            migrationBuilder.RenameTable(
                name: "MessageLog",
                newName: "MessageLogs");

            migrationBuilder.RenameIndex(
                name: "IX_MessageLog_PhoneNumberId",
                table: "MessageLogs",
                newName: "IX_MessageLogs_PhoneNumberId");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "PhoneNumbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "MessageLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageLogs",
                table: "MessageLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageLogs_PhoneNumbers_PhoneNumberId",
                table: "MessageLogs",
                column: "PhoneNumberId",
                principalTable: "PhoneNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
