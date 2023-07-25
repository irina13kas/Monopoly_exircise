﻿// <auto-generated />
using System;
using FileStorageContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileStorageContext.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230724170332_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Box", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Depth")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.Property<DateOnly?>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Height")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.Property<long>("PalletId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Weight")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.Property<decimal>("Width")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.HasKey("Id");

                    b.HasIndex("PalletId");

                    b.ToTable("Boxes");

                    b.HasData(
                        new
                        {
                            Id = 2938313391593472728L,
                            Depth = 36.2331492751134m,
                            Height = 140.111670068383m,
                            PalletId = 1L,
                            Weight = 100.379030310501m,
                            Width = 74.9180486208895m
                        },
                        new
                        {
                            Id = 3634502616663969537L,
                            Depth = 159.065458378859m,
                            ExpiryDate = new DateOnly(2022, 8, 2),
                            Height = 94.6960244147471m,
                            PalletId = 1L,
                            Weight = 183.023648717903m,
                            Width = 112.04798669796m
                        },
                        new
                        {
                            Id = 4535330042740534997L,
                            Depth = 126.007234425554m,
                            Height = 116.922143576149m,
                            PalletId = 1L,
                            Weight = 139.861767381567m,
                            Width = 117.492211646636m
                        },
                        new
                        {
                            Id = 4328411709641064369L,
                            Depth = 10.8428463232559m,
                            ExpiryDate = new DateOnly(2021, 9, 21),
                            Height = 76.7473040855942m,
                            PalletId = 1L,
                            Weight = 197.250850907301m,
                            Width = 65.8410865319153m
                        },
                        new
                        {
                            Id = 244625030648311281L,
                            Depth = 189.239780683422m,
                            Height = 45.7034423662078m,
                            PalletId = 1L,
                            Weight = 17.1347501100065m,
                            Width = 109.027403490846m
                        },
                        new
                        {
                            Id = 3557198923959516668L,
                            Depth = 94.1342216817952m,
                            ExpiryDate = new DateOnly(2022, 1, 26),
                            Height = 4.42462760125271m,
                            PalletId = 5L,
                            Weight = 145.373577448912m,
                            Width = 23.072199873939m
                        },
                        new
                        {
                            Id = 3530740864701788827L,
                            Depth = 43.6655460263814m,
                            Height = 146.159207048319m,
                            PalletId = 5L,
                            Weight = 19.4512937204245m,
                            Width = 10.4803244164703m
                        },
                        new
                        {
                            Id = 2994385265398178070L,
                            Depth = 134.920872409496m,
                            ExpiryDate = new DateOnly(2021, 7, 18),
                            Height = 105.577142422517m,
                            PalletId = 5L,
                            Weight = 118.888097230279m,
                            Width = 51.8848020586946m
                        },
                        new
                        {
                            Id = 2438231706896921208L,
                            Depth = 136.721845681855m,
                            Height = 1.99012258160236m,
                            PalletId = 1L,
                            Weight = 18.5018923796922m,
                            Width = 195.568159302747m
                        },
                        new
                        {
                            Id = 7691380536006807160L,
                            Depth = 96.6270435608174m,
                            ExpiryDate = new DateOnly(2020, 10, 25),
                            Height = 115.045878113877m,
                            PalletId = 1L,
                            Weight = 141.697113441709m,
                            Width = 59.4203662538835m
                        },
                        new
                        {
                            Id = 5735595661967413566L,
                            Depth = 76.3199793693793m,
                            Height = 12.7262680824902m,
                            PalletId = 8L,
                            Weight = 110.250887717478m,
                            Width = 135.430180735803m
                        },
                        new
                        {
                            Id = 9042901805405382812L,
                            Depth = 33.741048329932m,
                            ExpiryDate = new DateOnly(2021, 3, 11),
                            Height = 7.67483292136602m,
                            PalletId = 5L,
                            Weight = 141.212986401902m,
                            Width = 113.506420076796m
                        },
                        new
                        {
                            Id = 289744323040849211L,
                            Depth = 188.426753735348m,
                            Height = 126.589116101129m,
                            PalletId = 10L,
                            Weight = 148.28252466272m,
                            Width = 6.14156549345326m
                        },
                        new
                        {
                            Id = 7743746679443464156L,
                            Depth = 168.446794038404m,
                            ExpiryDate = new DateOnly(2021, 4, 1),
                            Height = 10.0607559097112m,
                            PalletId = 13L,
                            Weight = 100.451588908365m,
                            Width = 103.081859435358m
                        },
                        new
                        {
                            Id = 6885682923606628145L,
                            Depth = 25.2802649140155m,
                            Height = 167.508006291967m,
                            PalletId = 8L,
                            Weight = 148.837489575711m,
                            Width = 121.200046550871m
                        },
                        new
                        {
                            Id = 8454404093841409096L,
                            Depth = 110.200517051362m,
                            ExpiryDate = new DateOnly(2021, 2, 3),
                            Height = 33.6687698101182m,
                            PalletId = 5L,
                            Weight = 82.4469370811288m,
                            Width = 100.352826562409m
                        },
                        new
                        {
                            Id = 2995761901336935856L,
                            Depth = 30.1278729811863m,
                            Height = 197.81762600834m,
                            PalletId = 3L,
                            Weight = 184.029257362534m,
                            Width = 126.212052655917m
                        },
                        new
                        {
                            Id = 5277218503390829386L,
                            Depth = 189.894370485579m,
                            ExpiryDate = new DateOnly(2022, 9, 18),
                            Height = 66.3003074431026m,
                            PalletId = 8L,
                            Weight = 87.8195636236082m,
                            Width = 10.6984871154839m
                        },
                        new
                        {
                            Id = 1476884147090716588L,
                            Depth = 196.530407340617m,
                            Height = 164.421674316556m,
                            PalletId = 10L,
                            Weight = 189.677273201933m,
                            Width = 36.6231019960036m
                        },
                        new
                        {
                            Id = 7962579069242573516L,
                            Depth = 44.6600564155904m,
                            ExpiryDate = new DateOnly(2022, 8, 19),
                            Height = 186.554542687034m,
                            PalletId = 13L,
                            Weight = 195.780078254805m,
                            Width = 106.872756817551m
                        });
                });

            modelBuilder.Entity("Pallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Depth")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.Property<DateOnly?>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Height")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Width")
                        .HasPrecision(8, 3)
                        .HasColumnType("NUMERIC(8,3)");

                    b.HasKey("Id");

                    b.ToTable("Pallets");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Depth = 351.612923698066m,
                            Height = 90.6539704868539m,
                            Weight = 0m,
                            Width = 21.485735200253m
                        },
                        new
                        {
                            Id = 2L,
                            Depth = 985.631433562875m,
                            Height = 965.356880623669m,
                            Weight = 0m,
                            Width = 948.101572681445m
                        },
                        new
                        {
                            Id = 3L,
                            Depth = 576.42125925289m,
                            Height = 672.864445041392m,
                            Weight = 0m,
                            Width = 539.233835703063m
                        },
                        new
                        {
                            Id = 4L,
                            Depth = 264.143766867596m,
                            Height = 241.331927962977m,
                            Weight = 0m,
                            Width = 974.553675264162m
                        },
                        new
                        {
                            Id = 5L,
                            Depth = 237.82486414263m,
                            Height = 417.214682774524m,
                            Weight = 0m,
                            Width = 553.337259055699m
                        },
                        new
                        {
                            Id = 6L,
                            Depth = 742.486364828478m,
                            Height = 986.774738796109m,
                            Weight = 0m,
                            Width = 52.4103089899343m
                        },
                        new
                        {
                            Id = 7L,
                            Depth = 73.821904074058m,
                            Height = 78.0348068285992m,
                            Weight = 0m,
                            Width = 202.608817813754m
                        },
                        new
                        {
                            Id = 8L,
                            Depth = 593.14155269341m,
                            Height = 825.859932092275m,
                            Weight = 0m,
                            Width = 356.838825914018m
                        },
                        new
                        {
                            Id = 9L,
                            Depth = 724.738800221329m,
                            Height = 811.650088509318m,
                            Weight = 0m,
                            Width = 545.857854638614m
                        },
                        new
                        {
                            Id = 10L,
                            Depth = 936.043097981386m,
                            Height = 63.2705556717159m,
                            Weight = 0m,
                            Width = 286.062703728049m
                        },
                        new
                        {
                            Id = 11L,
                            Depth = 326.885109284406m,
                            Height = 642.183385917734m,
                            Weight = 0m,
                            Width = 17.3778876037501m
                        },
                        new
                        {
                            Id = 12L,
                            Depth = 920.339355241606m,
                            Height = 321.565372404184m,
                            Weight = 0m,
                            Width = 216.685048428262m
                        },
                        new
                        {
                            Id = 13L,
                            Depth = 640.55583347609m,
                            Height = 212.543314213094m,
                            Weight = 0m,
                            Width = 586.59297240313m
                        },
                        new
                        {
                            Id = 14L,
                            Depth = 533.082364175433m,
                            Height = 479.597742928945m,
                            Weight = 0m,
                            Width = 309.489057639409m
                        },
                        new
                        {
                            Id = 15L,
                            Depth = 541.251327763306m,
                            Height = 312.259538706545m,
                            Weight = 0m,
                            Width = 17.0374809172933m
                        },
                        new
                        {
                            Id = 16L,
                            Depth = 30.1076719701273m,
                            Height = 525.365578111379m,
                            Weight = 0m,
                            Width = 541.382120002671m
                        },
                        new
                        {
                            Id = 17L,
                            Depth = 14.5197804997286m,
                            Height = 117.691439650118m,
                            Weight = 0m,
                            Width = 194.919675448376m
                        },
                        new
                        {
                            Id = 18L,
                            Depth = 782.172717376959m,
                            Height = 30.8594294733693m,
                            Weight = 0m,
                            Width = 327.775495348533m
                        },
                        new
                        {
                            Id = 19L,
                            Depth = 23.1302713922978m,
                            Height = 636.58123840841m,
                            Weight = 0m,
                            Width = 242.250424906118m
                        },
                        new
                        {
                            Id = 20L,
                            Depth = 774.200404305231m,
                            Height = 761.753338267528m,
                            Weight = 0m,
                            Width = 947.116177360841m
                        });
                });

            modelBuilder.Entity("Box", b =>
                {
                    b.HasOne("Pallet", "Pallet")
                        .WithMany("Boxes")
                        .HasForeignKey("PalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pallet");
                });

            modelBuilder.Entity("Pallet", b =>
                {
                    b.Navigation("Boxes");
                });
#pragma warning restore 612, 618
        }
    }
}