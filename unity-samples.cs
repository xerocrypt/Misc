public static class UnityConfig
{
    //static IUnityContainer container = new UnityContainer();
    private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
    {
        var container = new UnityContainer();
        RegisterTypes(container);
        return container;
    });

    // Gets the configured Unity container.
    public static IUnityContainer GetConfiguredContainer()
    {
        return container.Value;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
        container.RegisterType<IUnitOfWork, UnitOfWork>();
        container.RegisterType<IEntities, ManagementdbEntities>();
        container.Resolve<IUnitOfWork>();
    }
}




// Integrates Unity when the application starts
public static void Start()
{
    var container = UnityConfig.GetConfiguredContainer();

    FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
    FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(container));

    DependencyResolver.SetResolver(new UnityDependencyResolver(container));

    // TODO: Uncomment if you want to use PerRequestLifetimeManager
    // Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
}




//Provides the bootstrapping for integrating Unity with ASP.NET MVC.
public static class UnityWebActivator
{
    // <summary>Integrates Unity when the application starts.</summary>
    public static void Start()
    {
        var container = UnityConfig.GetConfiguredContainer();

        FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
        FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(container));

        DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        // TODO: Uncomment if you want to use PerRequestLifetimeManager
        // Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
    }

    // <summary>Disposes the Unity container when the application is shut down.</summary>
    public static void Shutdown()
    {
        var container = UnityConfig.GetConfiguredContainer();
        container.Dispose();
    }
}




#region Assembly Microsoft.Practices.Unity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=6d32ff45e0ccc69f
// C:\TFS2015\WRDS\packages\Unity.4.0.1\lib\net45\Microsoft.Practices.Unity.dll
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Practices.Unity
{
    //     A simple, extensible dependency injection container.
    public class UnityContainer : IUnityContainer, IDisposable
    {
        public UnityContainer();
        public IUnityContainer Parent { get; }
        public IEnumerable<ContainerRegistration> Registrations { get; }

        [SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods", Justification = "Validation done by Guard class")]
        public IUnityContainer AddExtension(UnityContainerExtension extension);

        [SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods", Justification = "Guard class is doing validation")]
        public object BuildUp(Type t, object existing, string name, params ResolverOverride[] resolverOverrides);

        public object Configure(Type configurationInterface);

        [SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope", Justification = "Factory method that creates disposable object but does not own its lifetime.")]
        public IUnityContainer CreateChildContainer();

        public void Dispose();

        public IUnityContainer RegisterInstance(Type t, string name, object instance, LifetimeManager lifetime);

        public IUnityContainer RegisterType(Type from, Type to, string name, LifetimeManager lifetimeManager, InjectionMember[] injectionMembers);

        public IUnityContainer RemoveAllExtensions();

        public object Resolve(Type t, string name, params ResolverOverride[] resolverOverrides);

        public IEnumerable<object> ResolveAll(Type t, params ResolverOverride[] resolverOverrides);

        [SuppressMessage("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods", Justification = "Validation done by Guard class")]
        public void Teardown(object o);

        protected virtual void Dispose(bool disposing);
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MyApplication.Web.Data;

namespace MyApplication.Web.Interfaces
{
    public interface IRepository<T> : IEnumerable<T>,IRepository where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Get(int id);
        T Get(params object[] keyValues);
        T Put(T entity);
        T Add(T entity);
        T Update(T entity);
        List<dynamic> SqlQuery(string sql);
        void Delete(T entity);
    }
    public interface IRepository
    {
    }
}
