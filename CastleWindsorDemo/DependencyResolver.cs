using Castle.Windsor;

namespace CastleWindsorDemo
{
    /// <summary>Provides functionality to resolve injected dependencies.</summary>
    public static class DependencyResolver
    {
        /// <summary>Reference to an instance of an object that implements the <see cref="T:Castle.Windsor.IWindsorContainer" /> interface.</summary>
        /// <remarks>This object serves as the Dependency Container.</remarks>
        private static IWindsorContainer _container;

        /// <summary>Initializes the IoC container. .</summary>
        public static void Initialize()
        {
            _container = new WindsorContainer();
            _container.Register(new ComponentRegistration());
        }

        /// <summary>Resolves types for the object or interface <typeparamref name="T" />.</summary>
        /// <typeparam name="T">(Required.) Type to resolve dependencies for.</typeparam>
        /// <returns>Reference to an instance of the component of type <typeparamref name="T" />.</returns>
        public static T Resolve<T>() => _container.Resolve<T>();
    }
}