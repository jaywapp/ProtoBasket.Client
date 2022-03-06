using ProtoBasket.Client.Models.Interface;
using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;

namespace ProtoBasket.Client.Models.Item
{
    public class MatchItem : ReactiveObject, IMatch, ICheckable
    {
        #region Internal Field
        private bool _isChecked;

        private int _id;
        private int _year;
        private int _protoNo;
        private int _matchNo;

        private GameItem _game;
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
        public GameItem GameItem
        {
            get => _game;
            set => this.RaiseAndSetIfChanged(ref _game, value);
        }

        /// <inheritdoc />
        public AllocationItem AllocationItem
        {
            get => _allocation;
            set => this.RaiseAndSetIfChanged(ref _allocation, value);


        }
        public IGame Game => GameItem;

        public IAllocation Allocation => AllocationItem;
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
            GameItem = new GameItem(match.Game);
            AllocationItem = new AllocationItem(match.Allocation);
        }
        #endregion
    }
}
