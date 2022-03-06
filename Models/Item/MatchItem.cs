using Betman.Client.Models.Interface;
using ProtoBasket.Common.Model;
using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;
using System;

namespace Betman.Client.Models.Item
{
    public class MatchItem : ReactiveObject, IMatch, ICheckable
    {
        #region Internal Field
        private bool _isChecked;

        private int _id;
        private int _year;
        private int _protoNo;
        private int _matchNo;
        private DateTime _startTime;
        private string _contest;
        private eMatchCategory _category;
        private string _homeTeam;
        private string _awayTeam;
        private ScoreItem _score;
        private AllocationItem _allocation;
        #endregion

        #region Properties
        /// <inheritdoc />
        public bool IsChecked
        {
            get => _isChecked;
            set => this.RaiseAndSetIfChanged(ref _isChecked, value);
        }

        /// <inheritdoc />
        public int Id
        {
            get => _id;
            set => this.RaiseAndSetIfChanged(ref _id, value);
        }

        /// <inheritdoc />
        public int Year
        {
            get => _year;
            set => this.RaiseAndSetIfChanged(ref _year, value);
        }

        /// <inheritdoc />
        public int ProtoNo
        {
            get => _protoNo;
            set => this.RaiseAndSetIfChanged(ref _protoNo, value);
        }

        /// <inheritdoc />
        public int MatchNo
        {
            get => _matchNo;
            set => this.RaiseAndSetIfChanged(ref _matchNo, value);
        }

        /// <inheritdoc />
        public DateTime StartTime
        {
            get => _startTime;
            set => this.RaiseAndSetIfChanged(ref _startTime, value);
        }

        /// <inheritdoc />
        public string Contest
        {
            get => _contest;
            set => this.RaiseAndSetIfChanged(ref _contest, value);
        }

        /// <inheritdoc />
        public eMatchCategory Category
        {
            get => _category;
            set => this.RaiseAndSetIfChanged(ref _category, value);
        }

        /// <inheritdoc />
        public string HomeTeam
        {
            get => _homeTeam;
            set => this.RaiseAndSetIfChanged(ref _homeTeam, value);
        }

        /// <inheritdoc />
        public string AwayTeam
        {
            get => _awayTeam;
            set => this.RaiseAndSetIfChanged(ref _awayTeam, value);
        }

        /// <inheritdoc />
        public ScoreItem Score
        {
            get => _score;
            set => this.RaiseAndSetIfChanged(ref _score, value);
        }

        /// <inheritdoc />
        public AllocationItem Allocation
        {
            get => _allocation;
            set => this.RaiseAndSetIfChanged(ref _allocation, value);
        }
        #endregion

        #region Constructor
        public MatchItem()
        {
            // TODO : Data Binding
            // TODO : Event Control
        }

        public MatchItem(IMatch match) : this()
        {
            Id = match.Id;
            Year = match.Year;
            ProtoNo = match.ProtoNo;
            MatchNo = match.MatchNo;
            StartTime = match.StartTime;
            Contest = match.Contest;
            Category = match.Category;
            HomeTeam = match.HomeTeam;
            AwayTeam = match.AwayTeam;
        }
        #endregion
    }
}
