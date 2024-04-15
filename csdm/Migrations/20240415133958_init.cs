using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csdm.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    checksum = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    demoFilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    game = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mapName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    serverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tickCount = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    killCount = table.Column<int>(type: "int", nullable: false),
                    assistCount = table.Column<int>(type: "int", nullable: false),
                    deathCount = table.Column<int>(type: "int", nullable: false),
                    collateralKillCount = table.Column<int>(type: "int", nullable: false),
                    duration = table.Column<double>(type: "float", nullable: false),
                    analyzeDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shotCount = table.Column<int>(type: "int", nullable: false),
                    winnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    winnerSide = table.Column<int>(type: "int", nullable: false),
                    frameRate = table.Column<double>(type: "float", nullable: false),
                    tickrate = table.Column<int>(type: "int", nullable: false),
                    gameMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isRanked = table.Column<bool>(type: "bit", nullable: false),
                    maxRounds = table.Column<int>(type: "int", nullable: false),
                    shareCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasVacLiveBan = table.Column<bool>(type: "bit", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.checksum);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    steamId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assistCount = table.Column<int>(type: "int", nullable: false),
                    averageDamagePerRound = table.Column<double>(type: "float", nullable: false),
                    averageDeathPerRound = table.Column<double>(type: "float", nullable: false),
                    averageKillPerRound = table.Column<double>(type: "float", nullable: false),
                    utilityDamagePerRound = table.Column<double>(type: "float", nullable: false),
                    bombDefusedCount = table.Column<int>(type: "int", nullable: false),
                    bombPlantedCount = table.Column<int>(type: "int", nullable: false),
                    hostageRescuedCount = table.Column<int>(type: "int", nullable: false),
                    damageArmor = table.Column<int>(type: "int", nullable: false),
                    damageHealth = table.Column<int>(type: "int", nullable: false),
                    deathCount = table.Column<int>(type: "int", nullable: false),
                    firstDeathCount = table.Column<int>(type: "int", nullable: false),
                    firstKillCount = table.Column<int>(type: "int", nullable: false),
                    firstTradeDeathCount = table.Column<int>(type: "int", nullable: false),
                    firstTradeKillCount = table.Column<int>(type: "int", nullable: false),
                    fiveKillCount = table.Column<int>(type: "int", nullable: false),
                    fourKillCount = table.Column<int>(type: "int", nullable: false),
                    mvpCount = table.Column<int>(type: "int", nullable: false),
                    headshotCount = table.Column<int>(type: "int", nullable: false),
                    headshotPercentage = table.Column<int>(type: "int", nullable: false),
                    kast = table.Column<double>(type: "float", nullable: false),
                    killCount = table.Column<int>(type: "int", nullable: false),
                    killDeathRatio = table.Column<double>(type: "float", nullable: false),
                    matchChecksum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rankType = table.Column<int>(type: "int", nullable: false),
                    oldRank = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    winsCount = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oneKillCount = table.Column<int>(type: "int", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    teamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    threeKillCount = table.Column<int>(type: "int", nullable: false),
                    tradeDeathCount = table.Column<int>(type: "int", nullable: false),
                    tradeKillCount = table.Column<int>(type: "int", nullable: false),
                    twoKillCount = table.Column<int>(type: "int", nullable: false),
                    utilityDamage = table.Column<int>(type: "int", nullable: false),
                    vsOneCount = table.Column<int>(type: "int", nullable: false),
                    vsOneWonCount = table.Column<int>(type: "int", nullable: false),
                    vsOneLostCount = table.Column<int>(type: "int", nullable: false),
                    vsTwoCount = table.Column<int>(type: "int", nullable: false),
                    vsTwoWonCount = table.Column<int>(type: "int", nullable: false),
                    vsTwoLostCount = table.Column<int>(type: "int", nullable: false),
                    vsThreeCount = table.Column<int>(type: "int", nullable: false),
                    vsThreeWonCount = table.Column<int>(type: "int", nullable: false),
                    vsThreeLostCount = table.Column<int>(type: "int", nullable: false),
                    vsFourCount = table.Column<int>(type: "int", nullable: false),
                    vsFourWonCount = table.Column<int>(type: "int", nullable: false),
                    vsFourLostCount = table.Column<int>(type: "int", nullable: false),
                    vsFiveCount = table.Column<int>(type: "int", nullable: false),
                    vsFiveWonCount = table.Column<int>(type: "int", nullable: false),
                    vsFiveLostCount = table.Column<int>(type: "int", nullable: false),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hltvRating = table.Column<double>(type: "float", nullable: false),
                    hltvRating2 = table.Column<double>(type: "float", nullable: false),
                    lastBanDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    crosshairShareCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collateralKillCount = table.Column<int>(type: "int", nullable: false),
                    wallbangKillCount = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<int>(type: "int", nullable: false),
                    Rootchecksum = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.id);
                    table.ForeignKey(
                        name: "FK_Player_Root_Rootchecksum",
                        column: x => x.Rootchecksum,
                        principalTable: "Root",
                        principalColumn: "checksum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Round",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    startTick = table.Column<int>(type: "int", nullable: false),
                    endTick = table.Column<int>(type: "int", nullable: false),
                    endOfficiallyTick = table.Column<int>(type: "int", nullable: false),
                    startFrame = table.Column<int>(type: "int", nullable: false),
                    endFrame = table.Column<int>(type: "int", nullable: false),
                    endOfficiallyFrame = table.Column<int>(type: "int", nullable: false),
                    freezetimeEndFrame = table.Column<int>(type: "int", nullable: false),
                    endReason = table.Column<int>(type: "int", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    freezetimeEndTick = table.Column<int>(type: "int", nullable: false),
                    matchChecksum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamAScore = table.Column<int>(type: "int", nullable: false),
                    teamBScore = table.Column<int>(type: "int", nullable: false),
                    teamASide = table.Column<int>(type: "int", nullable: false),
                    teamBSide = table.Column<int>(type: "int", nullable: false),
                    winnerSide = table.Column<int>(type: "int", nullable: false),
                    winnerTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamAStartMoney = table.Column<int>(type: "int", nullable: false),
                    teamBStartMoney = table.Column<int>(type: "int", nullable: false),
                    teamAMoneySpent = table.Column<int>(type: "int", nullable: false),
                    teamBMoneySpent = table.Column<int>(type: "int", nullable: false),
                    teamAEquipmentValue = table.Column<int>(type: "int", nullable: false),
                    teamBEquipmentValue = table.Column<int>(type: "int", nullable: false),
                    teamAEconomyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamBEconomyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rootchecksum = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Round", x => x.id);
                    table.ForeignKey(
                        name: "FK_Round_Root_Rootchecksum",
                        column: x => x.Rootchecksum,
                        principalTable: "Root",
                        principalColumn: "checksum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    currentSide = table.Column<int>(type: "int", nullable: false),
                    letter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matchChecksum = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    scoreFirstHalf = table.Column<int>(type: "int", nullable: false),
                    scoreSecondHalf = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamA", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeamA_Root_matchChecksum",
                        column: x => x.matchChecksum,
                        principalTable: "Root",
                        principalColumn: "checksum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamB",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    currentSide = table.Column<int>(type: "int", nullable: false),
                    letter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matchChecksum = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    scoreFirstHalf = table.Column<int>(type: "int", nullable: false),
                    scoreSecondHalf = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamB", x => x.id);
                    table.ForeignKey(
                        name: "FK_TeamB_Root_matchChecksum",
                        column: x => x.matchChecksum,
                        principalTable: "Root",
                        principalColumn: "checksum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_Rootchecksum",
                table: "Player",
                column: "Rootchecksum");

            migrationBuilder.CreateIndex(
                name: "IX_Round_Rootchecksum",
                table: "Round",
                column: "Rootchecksum");

            migrationBuilder.CreateIndex(
                name: "IX_TeamA_matchChecksum",
                table: "TeamA",
                column: "matchChecksum",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamB_matchChecksum",
                table: "TeamB",
                column: "matchChecksum",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Round");

            migrationBuilder.DropTable(
                name: "TeamA");

            migrationBuilder.DropTable(
                name: "TeamB");

            migrationBuilder.DropTable(
                name: "Root");
        }
    }
}
