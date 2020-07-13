
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-07-13T03:11:46.281Z

using System;
using System.ComponentModel.DataAnnotations;

namespace Camille.Enums
{
    /// <summary>
    /// Queues enum based on queues.json.
    /// </summary>
#if USE_SYSTEXTJSON
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
#endif
    public enum Queue
    {
        [Display(Name = "Custom games", Description = "")]
        CUSTOM_GAMES = 0,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 430")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Blind Pick games")]
        SUMMONERS_RIFT_5V5_BLIND_PICK_GAMES_DEPRECATED_2 = 2,

        [Obsolete("Deprecated in favor of queueId 420")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Solo games")]
        SUMMONERS_RIFT_5V5_RANKED_SOLO_GAMES_DEPRECATED_4 = 4,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Premade games")]
        SUMMONERS_RIFT_5V5_RANKED_PREMADE_GAMES_DEPRECATED_6 = 6,

        [Obsolete("Deprecated in favor of queueId 32 and 33")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_GAMES_DEPRECATED_7 = 7,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 460")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Normal games")]
        TWISTED_TREELINE_3V3_NORMAL_GAMES_DEPRECATED_8 = 8,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 470")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Ranked Flex games")]
        TWISTED_TREELINE_3V3_RANKED_FLEX_GAMES_DEPRECATED_9 = 9,

        [Obsolete("Deprecated in favor of queueId 400")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Draft Pick games")]
        SUMMONERS_RIFT_5V5_DRAFT_PICK_GAMES_DEPRECATED_14 = 14,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Crystal Scar", Description = "5v5 Dominion Blind Pick games")]
        CRYSTAL_SCAR_5V5_DOMINION_BLIND_PICK_GAMES_DEPRECATED_16 = 16,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Crystal Scar", Description = "5v5 Dominion Draft Pick games")]
        CRYSTAL_SCAR_5V5_DOMINION_DRAFT_PICK_GAMES_DEPRECATED_17 = 17,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Crystal Scar", Description = "Dominion Co-op vs AI games")]
        CRYSTAL_SCAR_DOMINION_COOP_VS_AI_GAMES_DEPRECATED_25 = 25,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 830")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Intro Bot games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTRO_BOT_GAMES_DEPRECATED_31 = 31,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 840")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Beginner Bot games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_BEGINNER_BOT_GAMES_DEPRECATED_32 = 32,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 850")]
        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Intermediate Bot games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTERMEDIATE_BOT_GAMES_DEPRECATED_33 = 33,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Ranked Team games")]
        TWISTED_TREELINE_3V3_RANKED_TEAM_GAMES_DEPRECATED_41 = 41,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Team games")]
        SUMMONERS_RIFT_5V5_RANKED_TEAM_GAMES_DEPRECATED_42 = 42,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 800")]
        [Display(Name = "Twisted Treeline", Description = "Co-op vs AI games")]
        TWISTED_TREELINE_COOP_VS_AI_GAMES_DEPRECATED_52 = 52,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Team Builder games")]
        SUMMONERS_RIFT_5V5_TEAM_BUILDER_GAMES_DEPRECATED_61 = 61,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 450")]
        [Display(Name = "Howling Abyss", Description = "5v5 ARAM games")]
        HOWLING_ABYSS_5V5_ARAM_GAMES_DEPRECATED_65 = 65,

        [Obsolete("Game mode deprecated")]
        [Display(Name = "Howling Abyss", Description = "ARAM Co-op vs AI games")]
        HOWLING_ABYSS_ARAM_COOP_VS_AI_GAMES_DEPRECATED_67 = 67,

        [Obsolete("Deprecated in patch 8.6 in favor of queueId 1020")]
        [Display(Name = "Summoner's Rift", Description = "One for All games")]
        SUMMONERS_RIFT_ONE_FOR_ALL_GAMES_DEPRECATED_70 = 70,

        [Display(Name = "Howling Abyss", Description = "1v1 Snowdown Showdown games")]
        HOWLING_ABYSS_1V1_SNOWDOWN_SHOWDOWN_GAMES = 72,

        [Display(Name = "Howling Abyss", Description = "2v2 Snowdown Showdown games")]
        HOWLING_ABYSS_2V2_SNOWDOWN_SHOWDOWN_GAMES = 73,

        [Display(Name = "Summoner's Rift", Description = "6v6 Hexakill games")]
        SUMMONERS_RIFT_6V6_HEXAKILL_GAMES = 75,

        [Display(Name = "Summoner's Rift", Description = "Ultra Rapid Fire games")]
        SUMMONERS_RIFT_ULTRA_RAPID_FIRE_GAMES = 76,

        [Display(Name = "Howling Abyss", Description = "One For All: Mirror Mode games")]
        HOWLING_ABYSS_ONE_FOR_ALL_MIRROR_MODE_GAMES = 78,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs AI Ultra Rapid Fire games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_ULTRA_RAPID_FIRE_GAMES = 83,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 950")]
        [Display(Name = "Summoner's Rift", Description = "Doom Bots Rank 1 games")]
        SUMMONERS_RIFT_DOOM_BOTS_RANK_1_GAMES_DEPRECATED_91 = 91,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 950")]
        [Display(Name = "Summoner's Rift", Description = "Doom Bots Rank 2 games")]
        SUMMONERS_RIFT_DOOM_BOTS_RANK_2_GAMES_DEPRECATED_92 = 92,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 950")]
        [Display(Name = "Summoner's Rift", Description = "Doom Bots Rank 5 games")]
        SUMMONERS_RIFT_DOOM_BOTS_RANK_5_GAMES_DEPRECATED_93 = 93,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 910")]
        [Display(Name = "Crystal Scar", Description = "Ascension games")]
        CRYSTAL_SCAR_ASCENSION_GAMES_DEPRECATED_96 = 96,

        [Display(Name = "Twisted Treeline", Description = "6v6 Hexakill games")]
        TWISTED_TREELINE_6V6_HEXAKILL_GAMES = 98,

        [Display(Name = "Butcher's Bridge", Description = "5v5 ARAM games")]
        BUTCHERS_BRIDGE_5V5_ARAM_GAMES = 100,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 920")]
        [Display(Name = "Howling Abyss", Description = "Legend of the Poro King games")]
        HOWLING_ABYSS_LEGEND_OF_THE_PORO_KING_GAMES_DEPRECATED_300 = 300,

        [Display(Name = "Summoner's Rift", Description = "Nemesis games")]
        SUMMONERS_RIFT_NEMESIS_GAMES = 310,

        [Display(Name = "Summoner's Rift", Description = "Black Market Brawlers games")]
        SUMMONERS_RIFT_BLACK_MARKET_BRAWLERS_GAMES = 313,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 940")]
        [Display(Name = "Summoner's Rift", Description = "Nexus Siege games")]
        SUMMONERS_RIFT_NEXUS_SIEGE_GAMES_DEPRECATED_315 = 315,

        [Display(Name = "Crystal Scar", Description = "Definitely Not Dominion games")]
        CRYSTAL_SCAR_DEFINITELY_NOT_DOMINION_GAMES = 317,

        [Obsolete("Deprecated in patch 7.19 in favor of queueId 900")]
        [Display(Name = "Summoner's Rift", Description = "ARURF games")]
        SUMMONERS_RIFT_ARURF_GAMES_DEPRECATED_318 = 318,

        [Display(Name = "Summoner's Rift", Description = "All Random games")]
        SUMMONERS_RIFT_ALL_RANDOM_GAMES = 325,

        [Display(Name = "Summoner's Rift", Description = "5v5 Draft Pick games")]
        SUMMONERS_RIFT_5V5_DRAFT_PICK_GAMES = 400,

        [Obsolete("Game mode deprecated in patch 6.22")]
        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Dynamic games")]
        SUMMONERS_RIFT_5V5_RANKED_DYNAMIC_GAMES_DEPRECATED_410 = 410,

        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Solo games")]
        SUMMONERS_RIFT_5V5_RANKED_SOLO_GAMES = 420,

        [Display(Name = "Summoner's Rift", Description = "5v5 Blind Pick games")]
        SUMMONERS_RIFT_5V5_BLIND_PICK_GAMES = 430,

        [Display(Name = "Summoner's Rift", Description = "5v5 Ranked Flex games")]
        SUMMONERS_RIFT_5V5_RANKED_FLEX_GAMES = 440,

        [Display(Name = "Howling Abyss", Description = "5v5 ARAM games")]
        HOWLING_ABYSS_5V5_ARAM_GAMES = 450,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Blind Pick games")]
        TWISTED_TREELINE_3V3_BLIND_PICK_GAMES_DEPRECATED_460 = 460,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "3v3 Ranked Flex games")]
        TWISTED_TREELINE_3V3_RANKED_FLEX_GAMES_DEPRECATED_470 = 470,

        [Display(Name = "Summoner's Rift", Description = "Blood Hunt Assassin games")]
        SUMMONERS_RIFT_BLOOD_HUNT_ASSASSIN_GAMES = 600,

        [Display(Name = "Cosmic Ruins", Description = "Dark Star: Singularity games")]
        COSMIC_RUINS_DARK_STAR_SINGULARITY_GAMES = 610,

        [Display(Name = "Summoner's Rift", Description = "Clash games")]
        SUMMONERS_RIFT_CLASH_GAMES = 700,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "Co-op vs. AI Intermediate Bot games")]
        TWISTED_TREELINE_COOP_VS_AI_INTERMEDIATE_BOT_GAMES_DEPRECATED_800 = 800,

        [Obsolete("Deprecated in patch 9.23")]
        [Display(Name = "Twisted Treeline", Description = "Co-op vs. AI Intro Bot games")]
        TWISTED_TREELINE_COOP_VS_AI_INTRO_BOT_GAMES_DEPRECATED_810 = 810,

        [Display(Name = "Twisted Treeline", Description = "Co-op vs. AI Beginner Bot games")]
        TWISTED_TREELINE_COOP_VS_AI_BEGINNER_BOT_GAMES = 820,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs. AI Intro Bot games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTRO_BOT_GAMES = 830,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs. AI Beginner Bot games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_BEGINNER_BOT_GAMES = 840,

        [Display(Name = "Summoner's Rift", Description = "Co-op vs. AI Intermediate Bot games")]
        SUMMONERS_RIFT_CO_OP_VS_AI_INTERMEDIATE_BOT_GAMES = 850,

        [Display(Name = "Summoner's Rift", Description = "URF games")]
        SUMMONERS_RIFT_URF_GAMES = 900,

        [Display(Name = "Crystal Scar", Description = "Ascension games")]
        CRYSTAL_SCAR_ASCENSION_GAMES = 910,

        [Display(Name = "Howling Abyss", Description = "Legend of the Poro King games")]
        HOWLING_ABYSS_LEGEND_OF_THE_PORO_KING_GAMES = 920,

        [Display(Name = "Summoner's Rift", Description = "Nexus Siege games")]
        SUMMONERS_RIFT_NEXUS_SIEGE_GAMES = 940,

        [Display(Name = "Summoner's Rift", Description = "Doom Bots Voting games")]
        SUMMONERS_RIFT_DOOM_BOTS_VOTING_GAMES = 950,

        [Display(Name = "Summoner's Rift", Description = "Doom Bots Standard games")]
        SUMMONERS_RIFT_DOOM_BOTS_STANDARD_GAMES = 960,

        [Display(Name = "Valoran City Park", Description = "Star Guardian Invasion: Normal games")]
        VALORAN_CITY_PARK_STAR_GUARDIAN_INVASION_NORMAL_GAMES = 980,

        [Display(Name = "Valoran City Park", Description = "Star Guardian Invasion: Onslaught games")]
        VALORAN_CITY_PARK_STAR_GUARDIAN_INVASION_ONSLAUGHT_GAMES = 990,

        [Display(Name = "Overcharge", Description = "PROJECT: Hunters games")]
        OVERCHARGE_PROJECT_HUNTERS_GAMES = 1000,

        [Display(Name = "Summoner's Rift", Description = "Snow ARURF games")]
        SUMMONERS_RIFT_SNOW_ARURF_GAMES = 1010,

        [Display(Name = "Summoner's Rift", Description = "One for All games")]
        SUMMONERS_RIFT_ONE_FOR_ALL_GAMES = 1020,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Intro games")]
        CRASH_SITE_ODYSSEY_EXTRACTION_INTRO_GAMES = 1030,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Cadet games")]
        CRASH_SITE_ODYSSEY_EXTRACTION_CADET_GAMES = 1040,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Crewmember games")]
        CRASH_SITE_ODYSSEY_EXTRACTION_CREWMEMBER_GAMES = 1050,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Captain games")]
        CRASH_SITE_ODYSSEY_EXTRACTION_CAPTAIN_GAMES = 1060,

        [Display(Name = "Crash Site", Description = "Odyssey Extraction: Onslaught games")]
        CRASH_SITE_ODYSSEY_EXTRACTION_ONSLAUGHT_GAMES = 1070,

        [Display(Name = "Convergence", Description = "Teamfight Tactics games")]
        CONVERGENCE_TEAMFIGHT_TACTICS_GAMES = 1090,

        [Display(Name = "Convergence", Description = "Ranked Teamfight Tactics games")]
        CONVERGENCE_RANKED_TEAMFIGHT_TACTICS_GAMES = 1100,

        [Display(Name = "Convergence", Description = "Teamfight Tactics Tutorial games")]
        CONVERGENCE_TEAMFIGHT_TACTICS_TUTORIAL_GAMES = 1110,

        [Obsolete("Deprecated in patch 9.2")]
        [Display(Name = "Nexus Blitz", Description = "Nexus Blitz games")]
        NEXUS_BLITZ_NEXUS_BLITZ_GAMES_DEPRECATED_1200 = 1200,

        [Display(Name = "Summoner's Rift", Description = "Tutorial 1")]
        SUMMONERS_RIFT_TUTORIAL_1 = 2000,

        [Display(Name = "Summoner's Rift", Description = "Tutorial 2")]
        SUMMONERS_RIFT_TUTORIAL_2 = 2010,

        [Display(Name = "Summoner's Rift", Description = "Tutorial 3")]
        SUMMONERS_RIFT_TUTORIAL_3 = 2020,

    }
}
