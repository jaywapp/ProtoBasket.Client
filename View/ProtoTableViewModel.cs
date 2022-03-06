using ProtoBasket.Client.Models.Item;
using ReactiveUI;
using System.Collections.ObjectModel;

namespace ProtoBasket.Client.View
{
    public class ProtoTableViewModel : ReactiveObject
    {
        #region Internal Field
        private ObservableCollection<MatchItem> _matchItems = new ObservableCollection<MatchItem>();
        private ObservableAsPropertyHelper<ObservableCollection<MatchItem>> _selectedItems;
        #endregion

        #region Properties
        public ObservableCollection<MatchItem> MatchItems
        {
            get => _matchItems;
            set => this.RaiseAndSetIfChanged(ref _matchItems, value);
        }

        public ObservableCollection<MatchItem> SelectedItems => _selectedItems.Value;
        #endregion

        #region Constructor
        public ProtoTableViewModel()
        {
        }
        #endregion

        #region Functions
        #endregion
    }
}
