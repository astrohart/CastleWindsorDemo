using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;

namespace CastleWindsorDemo
{
    /// <summary>Implements the <see cref="T:Castle.MicroKernel.Registration.IRegistration" /> interface.</summary>
    /// <remarks>This class does the connection between interceptors and the objects they work on.</remarks>
    public class ComponentRegistration : IRegistration
    {
        /// <summary>Associates project classes with interceptors.</summary>
        /// <param name="kernel">(Required.) Reference to an instance of an object that implements the <see cref="T:Castle.MicroKernel.IKernelInternal" /> interface.  This object provides access to the Castle.Windsor library functionality.</param>
        public void Register(IKernelInternal kernel)
        {
            kernel.Register(
                Component.For<LoggingInterceptor>()
                    .ImplementedBy<LoggingInterceptor>()
            );

            kernel.Register(
                Component.For<IRocket>().ImplementedBy<Rocket>().Interceptors(
                    InterceptorReference.ForType<LoggingInterceptor>()
                ).Anywhere
            );
        }
    }
}