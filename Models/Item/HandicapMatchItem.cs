using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;

namespace Betman.Client.Models.Item
{
    public class HandicapMatchItem : MatchItem, IHandicapMatch
    {
        #region Internal Field
        private double? _handicap;
        #endregion

        #region Properties
        public double? Handicap
        {
            get => _handicap;
            set => this.RaiseAndSetIfChanged(ref _handicap, value);
        }
        #endregion

        #region Constructor
        public HandicapMatchItem(IHandicapMatch match) : base(match)
        {
            Handicap = match.Handicap;
        }
        #endregion
    }
}
