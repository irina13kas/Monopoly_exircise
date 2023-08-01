using System;
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
                    { 1, 133.141520683688m, 26.1517678001185m, 192.765850379962m },
                    { 2, 236.32781821884m, 25.6023881492576m, 257.453619143826m },
                    { 3, 57.037847578729m, 135.994854891218m, 295.374079750009m },
                    { 4, 111.923778192009m, 94.1080346272008m, 262.037973434761m },
                    { 5, 209.94116221914m, 104.211238491624m, 104.607466385818m },
                    { 6, 141.82395733659m, 177.350900741942m, 189.609354226645m },
                    { 7, 138.062942292987m, 256.451186371418m, 221.078226430589m },
                    { 8, 74.0326760460022m, 250.055445868852m, 193.304702669959m },
                    { 9, 58.9465469143748m, 132.071155990003m, 285.10769725711m }
                });

            migrationBuilder.InsertData(
                table: "Boxes",
                columns: new[] { "Id", "DateOfProduction", "Depth", "ExpiryDate", "Height", "PalletId", "Weight", "Width" },
                values: new object[,]
                {
                    { 1, new DateOnly(2021, 3, 24), 181.34128153535667557240736764m, null, 240.57074500938730770782863679m, 2, 21.71951123854576m, 17.231275473921307408574813408m },
                    { 2, null, 103.610664257584474177316658m, new DateOnly(2022, 6, 2), 91.16492404430009400852163609m, 6, 23.135048520643632m, 99.44406030259055903270846196m },
                    { 3, new DateOnly(2021, 12, 10), 207.47001298042166947145021750m, null, 64.648812990161437948830667390m, 5, 14.190824021514752m, 35.522187771186422613268247296m },
                    { 4, null, 47.966146296593170797428226276m, new DateOnly(2022, 6, 23), 152.94972225638981152609076984m, 8, 2.5485321124437534m, 175.17351140823689556517843221m },
                    { 5, new DateOnly(2020, 12, 24), 59.792537382159934280458248272m, null, 132.19249274406126053294373387m, 1, 9.443836773836706m, 3.8407218977510767981697448130m },
                    { 6, null, 42.44765398450773207949019173m, new DateOnly(2020, 11, 30), 217.48621479965181406859454228m, 4, 23.770051796855298m, 32.701305095891767214893891193m },
                    { 7, new DateOnly(2021, 3, 3), 89.17877233533332498654402204m, null, 81.95813492229180082114333341m, 7, 23.574693872709226m, 111.04662141894756011768833307m },
                    { 8, null, 47.69436043217744258640619406m, new DateOnly(2020, 12, 22), 139.09859444664398075526692978m, 6, 29.474631628399553m, 108.68559513344956865858008206m },
                    { 9, new DateOnly(2021, 8, 16), 177.41590952122092811778702728m, null, 66.773437106956969577971998184m, 5, 10.419445076821868m, 11.639366847420133179583477536m },
                    { 10, null, 65.617756333822800640262572168m, new DateOnly(2021, 11, 28), 162.96967863652731207991176184m, 1, 16.625839773790046m, 25.615404193761383334060109836m },
                    { 11, new DateOnly(2022, 3, 21), 26.352708489220838318616399118m, null, 284.09117859099425769094773450m, 3, 13.802430249854086m, 43.855931325986190001209807348m },
                    { 12, null, 49.675264615403299294694477802m, new DateOnly(2021, 10, 10), 176.55576502181494937925048259m, 9, 9.386568980976794m, 64.210262963662571728355824033m },
                    { 13, new DateOnly(2021, 3, 31), 78.166682715773280284832320016m, null, 95.56672419190715475321981674m, 1, 25.859989135566474m, 16.173587206736936264664980880m },
                    { 14, null, 32.383931520492236835170645092m, new DateOnly(2020, 12, 8), 215.75162186866466517327836902m, 9, 13.479597196993266m, 19.343687553120254813923817278m },
                    { 15, new DateOnly(2021, 10, 31), 101.63687830537417771092983739m, null, 157.11061673178005989977873103m, 6, 7.043259713672967m, 50.321488925755124400723269224m },
                    { 16, null, 208.04562483963443168622875102m, new DateOnly(2021, 12, 16), 78.675312828747510913911904378m, 5, 7.351626507022006m, 11.791498120776324276500692520m },
                    { 17, new DateOnly(2021, 1, 15), 25.820909938609490902090277733m, null, 24.009067032572650601224052389m, 8, 11.830977635200271m, 46.041090999186011280571513612m },
                    { 18, null, 36.047848532607979443415114033m, new DateOnly(2020, 11, 1), 12.389990262045240015901210091m, 4, 17.947324731120981m, 72.127019293201807309586867811m },
                    { 19, new DateOnly(2021, 9, 5), 76.11123963216072200841519996m, null, 16.227392715695253958269458201m, 2, 3.6113275132190362m, 15.849879417608544851463483971m },
                    { 20, null, 101.32933191869997658693211814m, new DateOnly(2021, 9, 14), 118.69487073652884618252683949m, 1, 2.4902831150615298m, 11.388454463768826407425038937m },
                    { 21, new DateOnly(2022, 1, 18), 33.280097452437440922706531438m, null, 233.99409391086719022957049306m, 9, 2.6882480546245343m, 40.314111378689515615552940923m },
                    { 22, null, 68.47108054236740841636566524m, new DateOnly(2022, 4, 29), 100.04370846703309029718991154m, 4, 29.287853622583724m, 86.85917493291288650374903917m },
                    { 23, new DateOnly(2021, 2, 22), 2.4282120873538890615997481693m, null, 173.11086322448290434599333605m, 9, 17.145641091106187m, 72.962870290468033005772872544m },
                    { 24, null, 166.37233728314609591260131048m, new DateOnly(2021, 7, 9), 87.4507224649283966746724854m, 5, 16.36271785671813m, 24.24950710887020877692269448m },
                    { 25, new DateOnly(2021, 11, 26), 107.02930485421291752568931475m, null, 205.93004555225991050532909096m, 7, 22.138625692502923m, 175.95288619478910808262571483m },
                    { 26, null, 101.63634086119612128011352885m, new DateOnly(2021, 2, 7), 94.85274103157769808029760978m, 1, 11.504258584246549m, 15.610026203851667096088458210m },
                    { 27, new DateOnly(2022, 3, 30), 129.27404095494488850510948174m, null, 207.0674242024623023991735774m, 7, 26.664625194223694m, 50.661123363244966035421547046m },
                    { 28, null, 69.710154861596061431975776890m, new DateOnly(2022, 2, 23), 13.004760626020415979639528383m, 8, 23.474582104375624m, 197.25419399135302898253448514m },
                    { 29, new DateOnly(2022, 5, 31), 3.3070839989588679521085255458m, null, 155.21590219565062954579568152m, 9, 29.190766993455035m, 27.047823199868203467248931319m },
                    { 30, null, 42.164075748477532541158237792m, new DateOnly(2021, 5, 11), 8.886559595583627027363611527m, 3, 3.1490118103160832m, 58.17393628449706883286648202m },
                    { 31, new DateOnly(2021, 2, 2), 49.554332898597996500515784543m, null, 260.63589881367521526121995382m, 9, 1.8099200963150562m, 97.69118299457013368781537750m },
                    { 32, null, 47.810923121940927070047980931m, new DateOnly(2021, 12, 1), 225.13196018653770475386785614m, 9, 4.430369033687312m, 45.792099834009959641625921287m },
                    { 33, new DateOnly(2021, 2, 10), 99.7213845794202784785345517m, null, 107.72082886499975972869590923m, 7, 15.008511324669997m, 76.690497409842130714988353008m },
                    { 34, null, 194.95298523580733694693936612m, new DateOnly(2021, 5, 6), 50.032022041360529822731763602m, 5, 7.96310795376869m, 85.33326209904626118180048901m },
                    { 35, new DateOnly(2021, 11, 3), 105.78102724197601318114581318m, null, 63.821661243010498072434063508m, 5, 9.831973803303646m, 76.605178513929959174189265792m },
                    { 36, null, 36.337076607186683579871995101m, new DateOnly(2022, 1, 2), 169.58174135299380717885101137m, 9, 8.07645546083052m, 63.011171795619842958303126784m },
                    { 37, new DateOnly(2021, 11, 4), 66.370063517971439130113877188m, null, 74.927582834325573497014709909m, 7, 25.786254083401348m, 82.00049941956366429266567328m },
                    { 38, null, 11.634882676063880939118896856m, new DateOnly(2021, 6, 20), 16.267352585416731795160134673m, 6, 12.874246566613871m, 141.13242575084291620215466298m },
                    { 39, new DateOnly(2021, 4, 4), 74.586180699701392391751177934m, null, 160.88555528734554777176477425m, 4, 5.319955421341714m, 85.44879799837261039489261491m },
                    { 40, null, 89.34485730248142896302614773m, new DateOnly(2021, 11, 23), 56.809549223150646271887203344m, 1, 1.8766967454647595m, 25.672342144118248057794156175m },
                    { 41, new DateOnly(2022, 3, 27), 46.54777479490908409262262168m, null, 61.575971173624448601095371060m, 6, 19.644629127408271m, 130.00105652720525627117205651m },
                    { 42, null, 111.23755382625396147583332984m, new DateOnly(2021, 6, 4), 108.89698315545244799065213912m, 7, 27.354480168981518m, 203.31832462322889980752548353m },
                    { 43, new DateOnly(2021, 10, 8), 46.981868258545314971549357728m, null, 5.081514085461858753679465555m, 9, 23.166382782401034m, 5.1439046383206617926079831563m },
                    { 44, null, 24.642790102017907601788474234m, new DateOnly(2022, 6, 4), 231.7959191724886253048518303m, 3, 22.222666377950149m, 48.656876847243443059026924114m },
                    { 45, new DateOnly(2021, 9, 10), 18.806178822222387818803115921m, null, 27.249693772259347070302397314m, 8, 29.970936734420004m, 152.80010325735432121713069398m },
                    { 46, null, 97.38016852854670030065248702m, new DateOnly(2020, 10, 2), 70.08343440897646443820685386m, 1, 12.045739479174107m, 23.071644147021514192637156314m },
                    { 47, new DateOnly(2021, 5, 20), 43.092779213350010392667782311m, null, 18.958383361872532203518294365m, 8, 18.232292134951025m, 234.95615816492149472327572740m },
                    { 48, null, 112.68473328102014520537148818m, new DateOnly(2022, 4, 19), 57.255241214067474581432158336m, 5, 11.036065603404487m, 26.425547699604540184010491928m },
                    { 49, new DateOnly(2021, 1, 9), 35.94405102338634771771198858m, null, 158.47909920176844757740666708m, 6, 10.795691118588103m, 82.51899852471631032479140145m },
                    { 50, null, 156.13271722932376728971692540m, new DateOnly(2021, 11, 14), 189.75015780309177061786212925m, 2, 11.110531712694517m, 4.7661532872176193467238637600m }
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
