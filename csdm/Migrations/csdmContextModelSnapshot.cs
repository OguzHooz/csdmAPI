﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csdm.Data;

#nullable disable

namespace csdm.Migrations
{
    [DbContext(typeof(csdmContext))]
    partial class csdmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("csdm.Models.Player", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Rootchecksum")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("assistCount")
                        .HasColumnType("int");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("averageDamagePerRound")
                        .HasColumnType("float");

                    b.Property<double>("averageDeathPerRound")
                        .HasColumnType("float");

                    b.Property<double>("averageKillPerRound")
                        .HasColumnType("float");

                    b.Property<int>("bombDefusedCount")
                        .HasColumnType("int");

                    b.Property<int>("bombPlantedCount")
                        .HasColumnType("int");

                    b.Property<int>("collateralKillCount")
                        .HasColumnType("int");

                    b.Property<int>("color")
                        .HasColumnType("int");

                    b.Property<string>("crosshairShareCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("damageArmor")
                        .HasColumnType("int");

                    b.Property<int>("damageHealth")
                        .HasColumnType("int");

                    b.Property<int>("deathCount")
                        .HasColumnType("int");

                    b.Property<int>("firstDeathCount")
                        .HasColumnType("int");

                    b.Property<int>("firstKillCount")
                        .HasColumnType("int");

                    b.Property<int>("firstTradeDeathCount")
                        .HasColumnType("int");

                    b.Property<int>("firstTradeKillCount")
                        .HasColumnType("int");

                    b.Property<int>("fiveKillCount")
                        .HasColumnType("int");

                    b.Property<int>("fourKillCount")
                        .HasColumnType("int");

                    b.Property<int>("headshotCount")
                        .HasColumnType("int");

                    b.Property<int>("headshotPercentage")
                        .HasColumnType("int");

                    b.Property<double>("hltvRating")
                        .HasColumnType("float");

                    b.Property<double>("hltvRating2")
                        .HasColumnType("float");

                    b.Property<int>("hostageRescuedCount")
                        .HasColumnType("int");

                    b.Property<double>("kast")
                        .HasColumnType("float");

                    b.Property<int>("killCount")
                        .HasColumnType("int");

                    b.Property<double>("killDeathRatio")
                        .HasColumnType("float");

                    b.Property<string>("lastBanDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matchChecksum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mvpCount")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("oldRank")
                        .HasColumnType("int");

                    b.Property<int>("oneKillCount")
                        .HasColumnType("int");

                    b.Property<int>("rank")
                        .HasColumnType("int");

                    b.Property<int>("rankType")
                        .HasColumnType("int");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.Property<string>("steamId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("threeKillCount")
                        .HasColumnType("int");

                    b.Property<int>("tradeDeathCount")
                        .HasColumnType("int");

                    b.Property<int>("tradeKillCount")
                        .HasColumnType("int");

                    b.Property<int>("twoKillCount")
                        .HasColumnType("int");

                    b.Property<int>("utilityDamage")
                        .HasColumnType("int");

                    b.Property<double>("utilityDamagePerRound")
                        .HasColumnType("float");

                    b.Property<int>("vsFiveCount")
                        .HasColumnType("int");

                    b.Property<int>("vsFiveLostCount")
                        .HasColumnType("int");

                    b.Property<int>("vsFiveWonCount")
                        .HasColumnType("int");

                    b.Property<int>("vsFourCount")
                        .HasColumnType("int");

                    b.Property<int>("vsFourLostCount")
                        .HasColumnType("int");

                    b.Property<int>("vsFourWonCount")
                        .HasColumnType("int");

                    b.Property<int>("vsOneCount")
                        .HasColumnType("int");

                    b.Property<int>("vsOneLostCount")
                        .HasColumnType("int");

                    b.Property<int>("vsOneWonCount")
                        .HasColumnType("int");

                    b.Property<int>("vsThreeCount")
                        .HasColumnType("int");

                    b.Property<int>("vsThreeLostCount")
                        .HasColumnType("int");

                    b.Property<int>("vsThreeWonCount")
                        .HasColumnType("int");

                    b.Property<int>("vsTwoCount")
                        .HasColumnType("int");

                    b.Property<int>("vsTwoLostCount")
                        .HasColumnType("int");

                    b.Property<int>("vsTwoWonCount")
                        .HasColumnType("int");

                    b.Property<int>("wallbangKillCount")
                        .HasColumnType("int");

                    b.Property<int>("winsCount")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Rootchecksum");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("csdm.Models.Root", b =>
                {
                    b.Property<string>("checksum")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("analyzeDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assistCount")
                        .HasColumnType("int");

                    b.Property<string>("clientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("collateralKillCount")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("deathCount")
                        .HasColumnType("int");

                    b.Property<string>("demoFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("duration")
                        .HasColumnType("float");

                    b.Property<double>("frameRate")
                        .HasColumnType("float");

                    b.Property<string>("game")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gameMode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hasVacLiveBan")
                        .HasColumnType("bit");

                    b.Property<bool>("isRanked")
                        .HasColumnType("bit");

                    b.Property<int>("killCount")
                        .HasColumnType("int");

                    b.Property<string>("mapName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maxRounds")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shareCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("shotCount")
                        .HasColumnType("int");

                    b.Property<string>("source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tickCount")
                        .HasColumnType("int");

                    b.Property<int>("tickrate")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("winnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("winnerSide")
                        .HasColumnType("int");

                    b.HasKey("checksum");

                    b.ToTable("Root");
                });

            modelBuilder.Entity("csdm.Models.Round", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("Rootchecksum")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<int>("endFrame")
                        .HasColumnType("int");

                    b.Property<int>("endOfficiallyFrame")
                        .HasColumnType("int");

                    b.Property<int>("endOfficiallyTick")
                        .HasColumnType("int");

                    b.Property<int>("endReason")
                        .HasColumnType("int");

                    b.Property<int>("endTick")
                        .HasColumnType("int");

                    b.Property<int>("freezetimeEndFrame")
                        .HasColumnType("int");

                    b.Property<int>("freezetimeEndTick")
                        .HasColumnType("int");

                    b.Property<string>("matchChecksum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("startFrame")
                        .HasColumnType("int");

                    b.Property<int>("startTick")
                        .HasColumnType("int");

                    b.Property<string>("teamAEconomyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("teamAEquipmentValue")
                        .HasColumnType("int");

                    b.Property<int>("teamAMoneySpent")
                        .HasColumnType("int");

                    b.Property<int>("teamAScore")
                        .HasColumnType("int");

                    b.Property<int>("teamASide")
                        .HasColumnType("int");

                    b.Property<int>("teamAStartMoney")
                        .HasColumnType("int");

                    b.Property<string>("teamBEconomyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("teamBEquipmentValue")
                        .HasColumnType("int");

                    b.Property<int>("teamBMoneySpent")
                        .HasColumnType("int");

                    b.Property<int>("teamBScore")
                        .HasColumnType("int");

                    b.Property<int>("teamBSide")
                        .HasColumnType("int");

                    b.Property<int>("teamBStartMoney")
                        .HasColumnType("int");

                    b.Property<int>("winnerSide")
                        .HasColumnType("int");

                    b.Property<string>("winnerTeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Rootchecksum");

                    b.ToTable("Round");
                });

            modelBuilder.Entity("csdm.Models.TeamA", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("currentSide")
                        .HasColumnType("int");

                    b.Property<string>("letter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matchChecksum")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.Property<int>("scoreFirstHalf")
                        .HasColumnType("int");

                    b.Property<int>("scoreSecondHalf")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("matchChecksum")
                        .IsUnique();

                    b.ToTable("TeamA");
                });

            modelBuilder.Entity("csdm.Models.TeamB", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("currentSide")
                        .HasColumnType("int");

                    b.Property<string>("letter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matchChecksum")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.Property<int>("scoreFirstHalf")
                        .HasColumnType("int");

                    b.Property<int>("scoreSecondHalf")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("matchChecksum")
                        .IsUnique();

                    b.ToTable("TeamB");
                });

            modelBuilder.Entity("csdm.Models.Player", b =>
                {
                    b.HasOne("csdm.Models.Root", null)
                        .WithMany("players")
                        .HasForeignKey("Rootchecksum")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("csdm.Models.Round", b =>
                {
                    b.HasOne("csdm.Models.Root", null)
                        .WithMany("rounds")
                        .HasForeignKey("Rootchecksum")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("csdm.Models.TeamA", b =>
                {
                    b.HasOne("csdm.Models.Root", null)
                        .WithOne("teamA")
                        .HasForeignKey("csdm.Models.TeamA", "matchChecksum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csdm.Models.TeamB", b =>
                {
                    b.HasOne("csdm.Models.Root", null)
                        .WithOne("teamB")
                        .HasForeignKey("csdm.Models.TeamB", "matchChecksum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("csdm.Models.Root", b =>
                {
                    b.Navigation("players");

                    b.Navigation("rounds");

                    b.Navigation("teamA")
                        .IsRequired();

                    b.Navigation("teamB")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}