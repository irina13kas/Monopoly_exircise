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
                columns: new[] { "Id", "Depth", "Height", "Width" },
                values: new object[,]
                {
                    { 1, 522.303132645606m, 312.52802176689m, 917.705874338783m },
                    { 2, 225.714844107561m, 771.108011003377m, 581.790752355735m },
                    { 3, 572.91094030983m, 782.602417506904m, 142.142688558135m },
                    { 4, 991.730098039494m, 550.909015072857m, 81.615180480991m },
                    { 5, 68.1711742248592m, 136.67310137252m, 545.341994467166m },
                    { 6, 891.475021078382m, 72.8426054095711m, 998.650455582422m },
                    { 7, 984.163513629121m, 522.739077039483m, 151.487117665714m },
                    { 8, 514.825126120238m, 293.521086538142m, 281.44633746929m },
                    { 9, 553.693954327412m, 273.234295074668m, 853.791080594966m },
                    { 10, 716.421334024955m, 207.010210697893m, 274.318625521338m }
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "Depth", "Height", "PalletId", "Weight", "Width" },
                values: new object[,]
                {
                    { 1, 166.430897502964m, 5.91732504520062m, 10, 85.8901913981985m, 75.8627802133085m },
                    { 2, 58.8892903480893m, 173.769493594898m, 9, 95.8089998806914m, 12.1658635968969m },
                    { 3, 161.922934214724m, 56.7168373103823m, 6, 7.0037391425877m, 165.584964735159m },
                    { 4, 125.44125990079m, 41.0094654346143m, 9, 172.282044564533m, 130.526246430794m },
                    { 5, 57.0998286719885m, 79.7325883577645m, 1, 87.7716811025322m, 149.605982018021m },
                    { 6, 199.603498670317m, 112.917125381123m, 10, 98.379363440691m, 190.901525894673m },
                    { 7, 95.378038032443m, 112.474688318648m, 8, 197.844192679046m, 60.4486598633574m },
                    { 8, 17.443372422391m, 137.434912230963m, 9, 176.820634994626m, 53.8618662644769m },
                    { 9, 106.686712011772m, 155.233851341237m, 2, 87.7846608701882m, 128.301050141038m },
                    { 10, 86.4618694185563m, 107.871463780885m, 2, 25.5813720315532m, 144.664566443718m },
                    { 11, 48.9922042049292m, 57.083478124559m, 5, 195.257756141242m, 8.15250627691386m },
                    { 12, 163.440290503858m, 172.73319319965m, 10, 159.208019108909m, 127.32011539376m },
                    { 13, 45.1078793796886m, 160.571446845798m, 5, 152.244593404888m, 162.765622543585m },
                    { 14, 61.9988581022327m, 73.6582945237802m, 7, 9.97155475242628m, 114.040847077611m },
                    { 15, 98.7675702375655m, 137.67122685493m, 6, 40.6166730339725m, 184.513981831913m },
                    { 16, 8.69069179221646m, 52.8186018314104m, 5, 136.715896209518m, 32.5014513096913m },
                    { 17, 188.737419441437m, 91.246210085493m, 10, 32.7176072759543m, 133.937681482645m },
                    { 18, 92.9108670054124m, 124.747702997976m, 10, 119.743899885217m, 130.092455590292m },
                    { 19, 56.460858049107m, 191.111727362979m, 8, 87.0768164545256m, 43.2095483179541m },
                    { 20, 51.5731148021222m, 44.6733857083772m, 7, 173.31791020658m, 28.8537670109265m },
                    { 21, 84.0460960506281m, 44.4380766687658m, 2, 185.171398332442m, 117.797183538127m },
                    { 22, 187.232075417821m, 71.4957161802554m, 2, 99.1316229899558m, 24.1441483301444m },
                    { 23, 113.280806831709m, 179.965602981649m, 7, 90.2166972342561m, 189.95159432964m },
                    { 24, 115.714950639475m, 197.163357063256m, 3, 105.451179347577m, 180.719732520838m },
                    { 25, 90.4256010218682m, 23.7468626723447m, 2, 100.833369623977m, 118.976212092984m },
                    { 26, 174.680391337939m, 123.690290541911m, 6, 14.0861463640145m, 5.83487681997927m },
                    { 27, 191.78109715581m, 10.5576502858599m, 3, 6.53703009966182m, 13.3119103175726m },
                    { 28, 67.0333670038313m, 103.733822212999m, 3, 167.428411393503m, 51.048583935718m },
                    { 29, 85.3545953167347m, 187.345253630996m, 6, 69.3903889423054m, 35.7735146103087m },
                    { 30, 128.567412536925m, 48.0759669259585m, 1, 167.800241499213m, 113.982806079299m },
                    { 31, 109.323807569625m, 171.240836433748m, 7, 133.388869627244m, 4.10382645196288m },
                    { 32, 51.2684503565438m, 190.59106612497m, 8, 123.909516917138m, 114.715540932067m },
                    { 33, 68.6691421178756m, 120.06640030009m, 10, 4.2890394270749m, 167.46141856551m },
                    { 34, 78.7454396320828m, 152.853207386959m, 5, 16.7099336272121m, 195.715085755601m },
                    { 35, 32.7145629271943m, 53.4502979775414m, 6, 24.9917680280168m, 170.146491209476m },
                    { 36, 72.7335514303575m, 79.1543241046776m, 2, 3.75157308199623m, 61.3508741253846m },
                    { 37, 142.637967183871m, 87.9284967668424m, 7, 185.002487922535m, 146.746391312612m },
                    { 38, 48.4266781240974m, 16.057705867413m, 5, 90.9709217482664m, 84.479806486945m },
                    { 39, 8.57774400840818m, 11.9653551875661m, 2, 109.567266295064m, 60.7371611775401m },
                    { 40, 34.4691509124792m, 66.6488139110834m, 10, 60.4033596648346m, 38.8907938337921m },
                    { 41, 128.523441109866m, 77.7902743236654m, 7, 58.7988954853358m, 3.26892440339577m },
                    { 42, 148.420068509608m, 88.4287494275293m, 9, 90.4416240976837m, 127.059177820142m },
                    { 43, 29.4296293894465m, 141.917184117414m, 7, 36.9780792541609m, 54.9774314638174m },
                    { 44, 156.332160287848m, 133.002623402921m, 4, 59.4716651573274m, 148.580274763469m },
                    { 45, 52.3745075734664m, 134.964410764237m, 1, 187.034044164505m, 195.56991238943m },
                    { 46, 12.2261805996077m, 106.195617038928m, 2, 104.987466388856m, 53.9448226632849m },
                    { 47, 13.6458586084765m, 73.5787524861449m, 4, 189.260317131407m, 75.0521840497359m },
                    { 48, 68.3984108370874m, 116.801637732072m, 5, 19.9967659983462m, 167.162424359317m },
                    { 49, 103.752305805466m, 21.8119535281082m, 8, 138.413411278772m, 134.13704201417m },
                    { 50, 85.7371831317506m, 47.6784290904429m, 2, 129.919802550635m, 153.428451923817m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Boxes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pallets",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
