﻿using Heroes.ReplayParser;
using HeroesParserData.DataQueries.ReplayData;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HeroesParserData.ViewModels.Match
{
    public class QuickMatchViewModel : MatchContext
    {
        public QuickMatchViewModel()
            :base()
        {

        }

        protected override async Task RefreshExecute()
        {
            await QueryMatchList();
        }

        private async Task QueryMatchList()
        {
            MatchList = new ObservableCollection<Models.DbModels.Replay>(await Query.Replay.ReadGameModeRecordsAsync(GameMode.QuickMatch));
            RowsReturned = MatchList.Count;
        }
    }
}