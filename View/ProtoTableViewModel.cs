using ProtoBasket.Client.Models.Item;
using ProtoBasket.Common.Model;
using ProtoBasket.Common.Model.Model.Interface;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Linq;

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
        public ProtoTableViewModel(Proto proto)
        {
            var items = proto.Matches
                .Select(m =>
                {
                    if (m is IHandicapMatch hMatch)
                        return new MatchItem(hMatch);
                    else if (m is IUnderOverMatch uMatch)
                        return new MatchItem(uMatch);

                    return new MatchItem(m);
                });
            MatchItems = new ObservableCollection<MatchItem>(items);
        }
        #endregion

        #region Functions
        #endregion
    }
}
