using Microsoft.Practices.Unity;
using ProtoBasket.Client.Models.Item;
using ProtoBasket.Common.Model.Repository;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace ProtoBasket.Client.View
{
    public class ProtoTableViewModel : ReactiveObject
    {
        #region Internal Field
        private readonly IUnityContainer _container;

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
        public ProtoTableViewModel(IUnityContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
            var repo = _container.Resolve<ProtoRepository>();
        }
        #endregion

        #region Functions
        #endregion
    }
}
