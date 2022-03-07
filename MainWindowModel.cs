using Microsoft.Practices.Unity;
using Prism.Mvvm;
using ProtoBasket.Client.View;
using ProtoBasket.Common.Model;
using ProtoBasket.Server.Crawler.Service;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProtoBasket.Client
{
    public class MainWindowModel : ReactiveObject
    {
        #region Internal Field
        private readonly IUnityContainer _container;
        #endregion

        #region Properties
        public List<Proto> Protos { get; }

        public ProtoTableViewModel ProtoTableViewModel { get; }

        public Dictionary<Proto, ProtoTableViewModel> ProtoTableViewModelDic { get; }
        #endregion

        #region Constructor
        public MainWindowModel(IUnityContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));

            var nos = CrawlingManager.CrawlProtoNos();

            Protos = new List<Proto>()
            {
                CrawlingManager.Crawl(2022, nos.Max()),
            };

            ProtoTableViewModelDic = Protos.ToDictionary(p => p, p => new ProtoTableViewModel(p));

            var target = Protos.OrderBy(p => p.No).LastOrDefault();
            ProtoTableViewModel = ProtoTableViewModelDic[target];

            RegisterModules();
            RegisterViews();
        }
        #endregion

        #region Functions
        private void RegisterModules()
        {
            // #Template
            // _container.RegisterType<TModule>();
            // _container.RegisterInstance((TModule) obj);
            // Singleton
            // _container.RegisterType<TModule>(new ContainerControlledLifetimeManager());
        }

        private void RegisterViews()
        {
            // #Template
            // ViewModelLocationProvider.Register<TView, TViewModel>();
        }
        #endregion
    }
}
