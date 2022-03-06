using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;

namespace ProtoBasket.Client.Models.Item
{
    public class UnderOverMatchItem : MatchItem, IUnderOverMatch
    {
        #region Internal Field
        private double? _underOver;
        #endregion

        #region Properties
        public double? UnderOver
        {
            get => _underOver;
            set => this.RaiseAndSetIfChanged(ref _underOver, value);
        }
        #endregion

        #region Constructor
        public UnderOverMatchItem(IUnderOverMatch match) : base(match)
        {
            UnderOver = match.UnderOver;
        }
        #endregion
    }
}
