﻿
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-02-12T21:29:36.079Z

// http://www.mingweisamuel.com/riotapi-schema/tool/
// Version e22fa894666bc6e13ce9daac7c0c9272c1ff3aaa

namespace MingweiSamuel.Camille
{
#nullable disable
    public partial class RiotApi
    {
        public readonly ChampionMasteryV4Endpoints ChampionMasteryV4;
        public readonly ChampionV3Endpoints ChampionV3;
        public readonly LeagueExpV4Endpoints LeagueExpV4;
        public readonly LeagueV4Endpoints LeagueV4;
        public readonly LolStatusV3Endpoints LolStatusV3;
        public readonly LorRankedV1Endpoints LorRankedV1;
        public readonly MatchV4Endpoints MatchV4;
        public readonly SpectatorV4Endpoints SpectatorV4;
        public readonly SummonerV4Endpoints SummonerV4;
        public readonly TftLeagueV1Endpoints TftLeagueV1;
        public readonly TftMatchV1Endpoints TftMatchV1;
        public readonly TftSummonerV1Endpoints TftSummonerV1;
        public readonly ThirdPartyCodeV4Endpoints ThirdPartyCodeV4;
        public readonly TournamentStubV4Endpoints TournamentStubV4;
        public readonly TournamentV4Endpoints TournamentV4;

        private RiotApi()
        {
            ChampionMasteryV4 = new ChampionMasteryV4Endpoints(this);
            ChampionV3 = new ChampionV3Endpoints(this);
            LeagueExpV4 = new LeagueExpV4Endpoints(this);
            LeagueV4 = new LeagueV4Endpoints(this);
            LolStatusV3 = new LolStatusV3Endpoints(this);
            LorRankedV1 = new LorRankedV1Endpoints(this);
            MatchV4 = new MatchV4Endpoints(this);
            SpectatorV4 = new SpectatorV4Endpoints(this);
            SummonerV4 = new SummonerV4Endpoints(this);
            TftLeagueV1 = new TftLeagueV1Endpoints(this);
            TftMatchV1 = new TftMatchV1Endpoints(this);
            TftSummonerV1 = new TftSummonerV1Endpoints(this);
            ThirdPartyCodeV4 = new ThirdPartyCodeV4Endpoints(this);
            TournamentStubV4 = new TournamentStubV4Endpoints(this);
            TournamentV4 = new TournamentV4Endpoints(this);
        }
    }
#nullable restore
}