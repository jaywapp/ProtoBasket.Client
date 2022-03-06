using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;

namespace ProtoBasket.Client.Models.Item
{
    public class AllocationItem : ReactiveObject, IAllocation
    {
        #region Internal Field
        private double _win;
        private double _draw;
        private double _lose;
        #endregion

        #region Properties

        /// <inheritdoc />
        public double Win
        {
            get => _win;
            set => this.RaiseAndSetIfChanged(ref _win, value);
        }

        /// <inheritdoc />
        public double Draw
        {
            get => _draw;
            set => this.RaiseAndSetIfChanged(ref _draw, value);
        }

        /// <inheritdoc />
        public double Lose
        {
            get => _lose;
            set => this.RaiseAndSetIfChanged(ref _lose, value);
        }
        #endregion

        #region Constructor
        public AllocationItem()
        {
            // TODO : Data Binding
            // TODO : Event Control
        }

        public AllocationItem(IAllocation allocation) : this()
        {
            Win = allocation.Win;
            Draw = allocation.Draw;
            Lose = allocation.Lose;
        }
        #endregion
    }
}
