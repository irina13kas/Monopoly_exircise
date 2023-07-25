using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FileStorageContext.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pallets",
                columns: new[] { "Id", "Depth", "ExpiryDate", "Height", "Weight", "Width" },
                values: new object[,]
                {
                    { 1L, 351.612923698066m, null, 90.6539704868539m, 0m, 21.485735200253m },
                    { 2L, 985.631433562875m, null, 965.356880623669m, 0m, 948.101572681445m },
                    { 3L, 576.42125925289m, null, 672.864445041392m, 0m, 539.233835703063m },
                    { 4L, 264.143766867596m, null, 241.331927962977m, 0m, 974.553675264162m },
                    { 5L, 237.82486414263m, null, 417.214682774524m, 0m, 553.337259055699m },
                    { 6L, 742.486364828478m, null, 986.774738796109m, 0m, 52.4103089899343m },
                    { 7L, 73.821904074058m, null, 78.0348068285992m, 0m, 202.608817813754m },
                    { 8L, 593.14155269341m, null, 825.859932092275m, 0m, 356.838825914018m },
                    { 9L, 724.738800221329m, null, 811.650088509318m, 0m, 545.857854638614m },
                    { 10L, 936.043097981386m, null, 63.2705556717159m, 0m, 286.062703728049m },
                    { 11L, 326.885109284406m, null, 642.183385917734m, 0m, 17.3778876037501m },
                    { 12L, 920.339355241606m, null, 321.565372404184m, 0m, 216.685048428262m },
                    { 13L, 640.55583347609m, null, 212.543314213094m, 0m, 586.59297240313m },
                    { 14L, 533.082364175433m, null, 479.597742928945m, 0m, 309.489057639409m },
                    { 15L, 541.251327763306m, null, 312.259538706545m, 0m, 17.0374809172933m },
                    { 16L, 30.1076719701273m, null, 525.365578111379m, 0m, 541.382120002671m },
                    { 17L, 14.5197804997286m, null, 117.691439650118m, 0m, 194.919675448376m },
                    { 18L, 782.172717376959m, null, 30.8594294733693m, 0m, 327.775495348533m },
                    { 19L, 23.1302713922978m, null, 636.58123840841m, 0m, 242.250424906118m },
                    { 20L, 774.200404305231m, null, 761.753338267528m, 0m, 947.116177360841m }
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "Depth", "ExpiryDate", "Height", "PalletId", "Weight", "Width" },
                values: new object[,]
                {
                    { 244625030648311281L, 189.239780683422m, null, 45.7034423662078m, 1L, 17.1347501100065m, 109.027403490846m },
                    { 289744323040849211L, 188.426753735348m, null, 126.589116101129m, 10L, 148.28252466272m, 6.14156549345326m },
                    { 1476884147090716588L, 196.530407340617m, null, 164.421674316556m, 10L, 189.677273201933m, 36.6231019960036m },
                    { 2438231706896921208L, 136.721845681855m, null, 1.99012258160236m, 1L, 18.5018923796922m, 195.568159302747m },
                    { 2938313391593472728L, 36.2331492751134m, null, 140.111670068383m, 1L, 100.379030310501m, 74.9180486208895m },
                    { 2994385265398178070L, 134.920872409496m, new DateOnly(2021, 7, 18), 105.577142422517m, 5L, 118.888097230279m, 51.8848020586946m },
                    { 2995761901336935856L, 30.1278729811863m, null, 197.81762600834m, 3L, 184.029257362534m, 126.212052655917m },
                    { 3530740864701788827L, 43.6655460263814m, null, 146.159207048319m, 5L, 19.4512937204245m, 10.4803244164703m },
                    { 3557198923959516668L, 94.1342216817952m, new DateOnly(2022, 1, 26), 4.42462760125271m, 5L, 145.373577448912m, 23.072199873939m },
                    { 3634502616663969537L, 159.065458378859m, new DateOnly(2022, 8, 2), 94.6960244147471m, 1L, 183.023648717903m, 112.04798669796m },
                    { 4328411709641064369L, 10.8428463232559m, new DateOnly(2021, 9, 21), 76.7473040855942m, 1L, 197.250850907301m, 65.8410865319153m },
                    { 4535330042740534997L, 126.007234425554m, null, 116.922143576149m, 1L, 139.861767381567m, 117.492211646636m },
                    { 5277218503390829386L, 189.894370485579m, new DateOnly(2022, 9, 18), 66.3003074431026m, 8L, 87.8195636236082m, 10.6984871154839m },
                    { 5735595661967413566L, 76.3199793693793m, null, 12.7262680824902m, 8L, 110.250887717478m, 135.430180735803m },
                    { 6885682923606628145L, 25.2802649140155m, null, 167.508006291967m, 8L, 148.837489575711m, 121.200046550871m },
                    { 7691380536006807160L, 96.6270435608174m, new DateOnly(2020, 10, 25), 115.045878113877m, 1L, 141.697113441709m, 59.4203662538835m },
                    { 7743746679443464156L, 168.446794038404m, new DateOnly(2021, 4, 1), 10.0607559097112m, 13L, 100.451588908365m, 103.081859435358m },
                    { 7962579069242573516L, 44.6600564155904m, new DateOnly(2022, 8, 19), 186.554542687034m, 13L, 195.780078254805m, 106.872756817551m },
                    { 8454404093841409096L, 110.200517051362m, new DateOnly(2021, 2, 3), 33.6687698101182m, 5L, 82.4469370811288m, 100.352826562409m },
                    { 9042901805405382812L, 33.741048329932m, new DateOnly(2021, 3, 11), 7.67483292136602m, 5L, 141.212986401902m, 113.506420076796m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 244625030648311281L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 289744323040849211L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 1476884147090716588L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 2438231706896921208L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 2938313391593472728L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 2994385265398178070L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 2995761901336935856L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 3530740864701788827L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 3557198923959516668L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 3634502616663969537L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 4328411709641064369L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 4535330042740534997L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 5277218503390829386L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 5735595661967413566L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 6885682923606628145L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 7691380536006807160L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 7743746679443464156L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 7962579069242573516L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 8454404093841409096L);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 9042901805405382812L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 13L);
        }
    }
}
