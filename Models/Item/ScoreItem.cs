using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;

namespace ProtoBasket.Client.Models.Item
{
    public class ScoreItem : ReactiveObject, IScore
    {
        #region Internal Field
        private double _home;
        private double _away;
        #endregion

        #region Properties
        /// <inheritdoc />
        public double Home
        {
            get => _home;
            set => this.RaiseAndSetIfChanged(ref _home, value);
        }

        /// <inheritdoc />
        public double Away
        {
            get => _away;
            set => this.RaiseAndSetIfChanged(ref _away, value);
        }
        #endregion

        #region Constructor
        public ScoreItem()
        {
            // TODO : Data Binding
            // TODO : Event Control
        }

        public ScoreItem(IScore score) : this()
        {
            Home = score.Home;
            Away = score.Away;
        }
        #endregion
    }
}
