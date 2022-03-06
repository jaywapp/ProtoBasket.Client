using ProtoBasket.Common.Model;
using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;
using System;

namespace ProtoBasket.Client.Models.Item
{
    public class GameItem : ReactiveObject, IGame
    {
        #region Internal Field
        private DateTime _time;
        private string _contest;
        private eMatchCategory _category;
        private string _homeTeam;
        private string _awayTeam;
        private double _homeScore;
        private double _awayScore;
        #endregion

        #region Properties
        public DateTime Time
        {
            get => _time;
            set => this.RaiseAndSetIfChanged(ref _time, value);
        }

        public string Contest
        {
            get => _contest;
            set => this.RaiseAndSetIfChanged(ref _contest, value);
        }

        public eMatchCategory Category
        {
            get => _category;
            set => this.RaiseAndSetIfChanged(ref _category, value);
        }

        public string HomeTeam
        {
            get => _homeTeam;
            set => this.RaiseAndSetIfChanged(ref _homeTeam, value);
        }

        public string AwayTeam
        {
            get => _awayTeam;
            set => this.RaiseAndSetIfChanged(ref _awayTeam, value);
        }

        public double HomeScore
        {
            get => _homeScore;
            set => this.RaiseAndSetIfChanged(ref _homeScore, value);
        }

        public double AwayScore
        {
            get => _awayScore;
            set => this.RaiseAndSetIfChanged(ref _awayScore, value);
        }
        #endregion

        #region Constructor
        public GameItem(IGame game)
        {
            Time = game.Time;
            Contest = game.Contest;
            Category = game.Category;
            HomeTeam = game.HomeTeam;
            HomeScore = game.HomeScore;
            AwayTeam = game.AwayTeam;
            AwayScore = game.AwayScore;
        }
        #endregion
    }
}
