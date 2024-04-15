<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csdm.Models
=======
﻿namespace csdm.Models
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
{
    public class Player
    {
        public string steamId { get; set; }
        public int assistCount { get; set; }
        public double averageDamagePerRound { get; set; }
        public double averageDeathPerRound { get; set; }
        public double averageKillPerRound { get; set; }
        public double utilityDamagePerRound { get; set; }
        public int bombDefusedCount { get; set; }
        public int bombPlantedCount { get; set; }
        public int hostageRescuedCount { get; set; }
        public int damageArmor { get; set; }
        public int damageHealth { get; set; }
        public int deathCount { get; set; }
        public int firstDeathCount { get; set; }
        public int firstKillCount { get; set; }
        public int firstTradeDeathCount { get; set; }
        public int firstTradeKillCount { get; set; }
        public int fiveKillCount { get; set; }
        public int fourKillCount { get; set; }
        public int mvpCount { get; set; }
        public int headshotCount { get; set; }
        public int headshotPercentage { get; set; }
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
        public string id { get; set; }
        public double kast { get; set; }
        public int killCount { get; set; }
        public double killDeathRatio { get; set; }
        public string matchChecksum { get; set; }
        public int rankType { get; set; }
        public int oldRank { get; set; }
        public int rank { get; set; }
        public int winsCount { get; set; }
        public string name { get; set; }
        public int oneKillCount { get; set; }
        public int score { get; set; }
        public string teamName { get; set; }
        public int threeKillCount { get; set; }
        public int tradeDeathCount { get; set; }
        public int tradeKillCount { get; set; }
        public int twoKillCount { get; set; }
        public int utilityDamage { get; set; }
        public int vsOneCount { get; set; }
        public int vsOneWonCount { get; set; }
        public int vsOneLostCount { get; set; }
        public int vsTwoCount { get; set; }
        public int vsTwoWonCount { get; set; }
        public int vsTwoLostCount { get; set; }
        public int vsThreeCount { get; set; }
        public int vsThreeWonCount { get; set; }
        public int vsThreeLostCount { get; set; }
        public int vsFourCount { get; set; }
        public int vsFourWonCount { get; set; }
        public int vsFourLostCount { get; set; }
        public int vsFiveCount { get; set; }
        public int vsFiveWonCount { get; set; }
        public int vsFiveLostCount { get; set; }
        public string avatar { get; set; }
        public double hltvRating { get; set; }
        public double hltvRating2 { get; set; }
<<<<<<< HEAD
        public string? lastBanDate { get; set; }
=======
        public object lastBanDate { get; set; }
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
        public string crosshairShareCode { get; set; }
        public int collateralKillCount { get; set; }
        public int wallbangKillCount { get; set; }
        public int color { get; set; }
    }

    public class Root
    {
<<<<<<< HEAD
        [Key]
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
        public string checksum { get; set; }
        public string demoFilePath { get; set; }
        public string game { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public string type { get; set; }
        public string mapName { get; set; }
        public string clientName { get; set; }
        public string serverName { get; set; }
        public int tickCount { get; set; }
        public string date { get; set; }
        public int killCount { get; set; }
        public int assistCount { get; set; }
        public int deathCount { get; set; }
        public int collateralKillCount { get; set; }
        public double duration { get; set; }
        public string analyzeDate { get; set; }
        public int shotCount { get; set; }
        public string winnerName { get; set; }
        public int winnerSide { get; set; }
        public double frameRate { get; set; }
        public int tickrate { get; set; }
        public string gameMode { get; set; }
        public bool isRanked { get; set; }
        public int maxRounds { get; set; }
        public string shareCode { get; set; }
        public bool hasVacLiveBan { get; set; }
        public TeamA teamA { get; set; }
        public TeamB teamB { get; set; }
        public List<Player> players { get; set; }
        public List<Round> rounds { get; set; }
        public string comment { get; set; }
<<<<<<< HEAD
        //public List<object> tagIds { get; set; }
=======
        public List<object> tagIds { get; set; }
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
    }

    public class Round
    {
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
        public int id { get; set; }
        public int number { get; set; }
        public int startTick { get; set; }
        public int endTick { get; set; }
        public int endOfficiallyTick { get; set; }
        public int startFrame { get; set; }
        public int endFrame { get; set; }
        public int endOfficiallyFrame { get; set; }
        public int freezetimeEndFrame { get; set; }
        public int endReason { get; set; }
        public int duration { get; set; }
        public int freezetimeEndTick { get; set; }
        public string matchChecksum { get; set; }
        public int teamAScore { get; set; }
        public int teamBScore { get; set; }
        public int teamASide { get; set; }
        public int teamBSide { get; set; }
        public int winnerSide { get; set; }
        public string winnerTeamName { get; set; }
        public int teamAStartMoney { get; set; }
        public int teamBStartMoney { get; set; }
        public int teamAMoneySpent { get; set; }
        public int teamBMoneySpent { get; set; }
        public int teamAEquipmentValue { get; set; }
        public int teamBEquipmentValue { get; set; }
        public string teamAEconomyType { get; set; }
        public string teamBEconomyType { get; set; }
    }

    public class TeamA
    {
        public int currentSide { get; set; }
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
        public int id { get; set; }
        public string letter { get; set; }
        public string matchChecksum { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public int scoreFirstHalf { get; set; }
        public int scoreSecondHalf { get; set; }
    }

    public class TeamB
    {
        public int currentSide { get; set; }
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
=======
>>>>>>> 67c149afad9ee6d6098bf3aa8807f134344ac229
        public int id { get; set; }
        public string letter { get; set; }
        public string matchChecksum { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public int scoreFirstHalf { get; set; }
        public int scoreSecondHalf { get; set; }
    }
}
