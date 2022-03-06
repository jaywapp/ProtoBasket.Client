using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;

namespace ProtoBasket.Client.Models.Item
{
    public class ScoreItem : ReactiveObject, IScorable
    {
        #region Internal Field
        private double _home;
        private double _away;
        #endregion

        #region Properties
        /// <inheritdoc />
        public double HomeScore
        {
            get => _home;
            set => this.RaiseAndSetIfChanged(ref _home, value);
        }

        /// <inheritdoc />
        public double AwayScore
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

        public ScoreItem(IScorable score) : this()
        {
            HomeScore = score.HomeScore;
            AwayScore = score.AwayScore;
        }
        #endregion
    }
}
