using Microsoft.Practices.Unity;
using Prism.Mvvm;
using ProtoBasket.Client.View;
using ProtoBasket.Server.Crawler.Service;
using System;

namespace ProtoBasket.Client
{
    public class MainWindowModel
    {
        #region Internal Field
        private readonly IUnityContainer _container;
        #endregion

        #region Constructor
        public MainWindowModel(IUnityContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));

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

            var protoRepository = CrawlingManager.Crawl(2022, 19);
            _container.RegisterInstance(protoRepository, new ContainerControlledLifetimeManager());
        }

        private void RegisterViews()
        {
            // #Template
            // ViewModelLocationProvider.Register<TView, TViewModel>();
            ViewModelLocationProvider.Register<ProtoTableView, ProtoTableViewModel>();
        }
        #endregion
    }
}
