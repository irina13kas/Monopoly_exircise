using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbStorageContext.Migrations
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
                    { 1, 41.3903981343342m, 243.653289777199m, 293.106845025685m },
                    { 2, 127.269367882135m, 95.7605498282308m, 82.6080191495418m },
                    { 3, 256.990592825701m, 35.7287990407294m, 124.118906755619m },
                    { 4, 12.5064807645807m, 274.892702639978m, 129.927474306476m },
                    { 5, 215.005327535618m, 75.1859077981136m, 291.217972037246m },
                    { 6, 299.819667553273m, 207.248462758802m, 275.538921875196m },
                    { 7, 211.271487309242m, 297.977224508646m, 169.07045211343m },
                    { 8, 56.5986732727583m, 197.078530148666m, 165.52234744295m },
                    { 9, 220.973419128597m, 212.531131978806m, 175.209174463318m }
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "DateOfProdaction", "Depth", "ExpiryDate", "Height", "PalletId", "Weight", "Width" },
                values: new object[,]
                {
                    { 1, new DateOnly(2021, 3, 25), 211.14774153125669693111249465m, null, 113.47734842348327051579454223m, 7, 28.145790569931025m, 67.673403894104358267209257294m },
                    { 2, null, 52.377765842763469890549570084m, new DateOnly(2022, 3, 18), 12.901976094915814712943860015m, 8, 14.867701634284475m, 127.01356453069658540245131343m },
                    { 3, new DateOnly(2021, 2, 11), 156.25520573949368647584723380m, null, 74.80120096810071685382981843m, 3, 12.911285963314159m, 25.438457669580783507541218540m },
                    { 4, null, 123.71376562485999043549519276m, new DateOnly(2021, 6, 29), 50.943245068531253674916259238m, 2, 28.984612803599913m, 18.449994257285123731749612875m },
                    { 5, new DateOnly(2021, 9, 1), 254.85234427307747729730147709m, null, 71.136504754468117365848332940m, 6, 24.596989876755029m, 69.69952057226928768698720272m },
                    { 6, null, 103.21205605430211948600331789m, new DateOnly(2021, 8, 25), 25.641872248646284213033864775m, 2, 26.449778578407728m, 75.640454596767904167735426150m },
                    { 7, new DateOnly(2022, 3, 3), 51.234251891278561633078469053m, null, 140.11843308164109169534432074m, 9, 17.448792675671202m, 57.844242303856471729186144774m },
                    { 8, null, 49.860446219368045793131002688m, new DateOnly(2022, 1, 12), 111.94719347046429829813328153m, 5, 29.438133722136657m, 11.118995794089143622859219299m },
                    { 9, new DateOnly(2022, 3, 1), 5.5458213024897550185948795371m, null, 127.58729778810003771321215059m, 4, 18.0729313357971m, 17.653955633288674432271591830m },
                    { 10, null, 101.22153802397773863347783662m, new DateOnly(2021, 1, 6), 240.59726932446513540100702243m, 6, 4.720321563404351m, 27.432564932870196668530248282m },
                    { 11, new DateOnly(2020, 11, 19), 20.428240968380442201358837817m, null, 207.88552774036654448612086702m, 1, 29.529734284767218m, 219.78468888125413045132062200m },
                    { 12, null, 43.329572086634026204469205349m, new DateOnly(2021, 3, 19), 235.81779317965849567771305060m, 6, 5.860225453966047m, 73.321440885000730760334879544m },
                    { 13, new DateOnly(2021, 10, 29), 19.132067910988209726735246370m, null, 33.794824644651700460617731259m, 2, 7.376340298691176m, 93.09030887607131347667363100m },
                    { 14, null, 43.901502448989175570691172442m, new DateOnly(2020, 12, 27), 125.36477926367235529989222155m, 8, 4.036209676250666m, 178.57642317268480866243938369m },
                    { 15, new DateOnly(2021, 3, 17), 26.494645109652585439910302718m, null, 130.45343880598368796429343786m, 5, 29.787548951625974m, 68.328814393561205606729030579m },
                    { 16, null, 38.990251629974019757053729535m, new DateOnly(2021, 11, 14), 46.933411352694901001746265894m, 3, 7.591446017229963m, 8.571115731381446036124404672m },
                    { 17, new DateOnly(2022, 7, 20), 37.801990950706632534085592946m, null, 57.29266937793252891665571785m, 8, 29.435978292366737m, 148.11740691215637787637893798m },
                    { 18, null, 40.670339541012037957683411583m, new DateOnly(2021, 1, 30), 234.99547344129430268881137392m, 1, 10.045168745957482m, 111.13323094897603181035961057m },
                    { 19, new DateOnly(2022, 3, 24), 24.566374916478879672028459518m, null, 43.05686336001452992710835255m, 8, 6.893843267323816m, 11.361644524892494878737266552m },
                    { 20, null, 1.5436513544844162097627261562m, new DateOnly(2020, 12, 6), 18.91958213595250373501229634m, 3, 26.157677984690596m, 16.816124180059098589643520542m },
                    { 21, new DateOnly(2020, 11, 4), 161.73059332708210890875210287m, null, 114.66268992363952752709981710m, 3, 23.841375654154938m, 20.967048914930666733065653893m },
                    { 22, null, 7.1538215661485424642940366672m, new DateOnly(2022, 8, 6), 5.5573263537640587453647936925m, 3, 6.855892459871108m, 21.365151622063038671664449423m },
                    { 23, new DateOnly(2021, 11, 13), 29.965402724015192490592555617m, null, 30.426163528871103500721981376m, 9, 14.215820657520516m, 112.76504568672192246649032079m },
                    { 24, null, 289.96862619761157926620301394m, new DateOnly(2021, 6, 11), 127.38521020365825431898157106m, 6, 28.161589032096756m, 60.588635326971590680567711232m },
                    { 25, new DateOnly(2021, 12, 3), 169.74847073497901718331378344m, null, 110.03420658586361443014899053m, 7, 27.979421601696364m, 264.76840981898689512820542845m },
                    { 26, null, 26.730643114211792298567610150m, new DateOnly(2021, 7, 29), 12.572308836790841897528505665m, 8, 25.665916642564139m, 163.25851459735708848778285897m },
                    { 27, new DateOnly(2021, 1, 13), 193.40635643225875787517556485m, null, 244.59644415736111705090033593m, 5, 9.075887608693165m, 44.607673880029506659923999571m },
                    { 28, null, 119.25207002881773645251760815m, new DateOnly(2022, 7, 8), 97.83244748230851080116006536m, 6, 6.65644253749815m, 88.24093333976793518069197720m },
                    { 29, new DateOnly(2021, 5, 27), 13.446723537131670525114096107m, null, 140.49208251327424981062177896m, 1, 13.958143528004905m, 232.66951869529896467812139351m },
                    { 30, null, 43.848583813427710957072185331m, new DateOnly(2020, 12, 29), 151.16864019185292784127291880m, 8, 2.1851721255178174m, 134.05548565315695027543435898m },
                    { 31, new DateOnly(2021, 5, 13), 90.85463455474892904293629656m, null, 260.51715239974315522998490329m, 5, 19.893801102802337m, 46.305459834585728849414110947m },
                    { 32, null, 208.94569317052997105575326401m, new DateOnly(2021, 1, 4), 125.32704626622279913472789661m, 6, 14.418810328813497m, 169.23480201072854902798652177m },
                    { 33, new DateOnly(2022, 8, 4), 90.44463093613184449073255050m, null, 44.032928791813275122066217464m, 5, 11.494678263263535m, 62.358425959659804137971237878m },
                    { 34, null, 48.753715327655332411844304543m, new DateOnly(2021, 10, 31), 24.17726155328246311257840175m, 8, 4.892111173722962m, 2.5222303003101516532206877665m },
                    { 35, new DateOnly(2021, 3, 21), 135.14018434635142990305630425m, null, 23.4938637148781946396826774m, 7, 25.932151881346331m, 76.074458159393482722809223006m },
                    { 36, null, 12.352445648589465506075571670m, new DateOnly(2022, 1, 21), 56.024813022528639381353678672m, 4, 18.775244904097966m, 259.08557216950013468041728287m },
                    { 37, new DateOnly(2022, 2, 5), 223.29023491711753737214795238m, null, 43.470268530996060361999261045m, 3, 22.908435399061954m, 28.726648761040661123272550357m },
                    { 38, null, 55.013072691565576641576213748m, new DateOnly(2021, 4, 22), 229.42474071808483195724643484m, 6, 13.411555913346306m, 119.45498082513515740276742828m },
                    { 39, new DateOnly(2021, 1, 17), 50.67998192115818505181597465m, null, 22.830429523598109896164607675m, 2, 3.8978384613630454m, 23.143994288242320563672840645m },
                    { 40, null, 156.98106589121036070900030509m, new DateOnly(2022, 4, 16), 16.897777167942630395921617858m, 7, 23.34544028804414m, 64.47919260943902487847599092m },
                    { 41, new DateOnly(2022, 8, 15), 31.185263340156429990945553282m, null, 268.46830398729933799449363986m, 1, 18.73809161328975m, 51.245197600899037796888017294m },
                    { 42, null, 213.54106226858046771911046402m, new DateOnly(2021, 4, 14), 26.640322190991475663256955970m, 6, 23.599992582151764m, 109.24247027166291223534689338m },
                    { 43, new DateOnly(2022, 6, 20), 39.168790201135385964458688926m, null, 67.59560839210949809407993165m, 8, 24.686736322474316m, 82.79583579269432374998928487m },
                    { 44, null, 28.549893476374353735313733296m, new DateOnly(2021, 11, 20), 157.58286894773496305150875714m, 1, 14.06557689263462m, 142.22912437506917133021681847m },
                    { 45, new DateOnly(2021, 3, 27), 48.878131873316599574347650022m, null, 118.44482443163246629648202515m, 6, 4.977519122224331m, 52.157860066589965947657768944m },
                    { 46, null, 113.50902434175615104564310322m, new DateOnly(2020, 12, 13), 87.85336312892119131684424913m, 6, 9.488955941349931m, 113.60447183074877849619975547m },
                    { 47, new DateOnly(2021, 5, 13), 85.06780831902959667542265522m, null, 39.487483871449684738793418831m, 3, 8.664379836802402m, 4.3496460799057600308355509036m },
                    { 48, null, 37.011653901030223213853934967m, new DateOnly(2022, 6, 21), 10.500623852540648567522429845m, 1, 5.806415758553607m, 213.03117000664133176001764508m },
                    { 49, new DateOnly(2021, 10, 7), 31.875000264269103695689479308m, null, 179.48462710280102799157943988m, 1, 17.765025219663586m, 151.27973814656838800453348365m },
                    { 50, null, 187.07877100049879339609447442m, new DateOnly(2021, 9, 20), 47.042950404496615757364775451m, 3, 17.953974889035302m, 14.396175722965636932825545656m }
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
        }
    }
}
