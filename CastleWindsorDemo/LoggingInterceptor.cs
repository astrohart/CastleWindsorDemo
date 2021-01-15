using System;
using Castle.DynamicProxy;

namespace CastleWindsorDemo
{
    /// <summary>Intercepts method entry, exit, and exception occurrence to log messages to the console.</summary>
    public class LoggingInterceptor : IInterceptor
    {
        /// <summary>Called when intercepted DynamicProxy calls are made to program class' methods.</summary>
        /// <param name="invocation">Reference to an instance of an object that implements the <see cref="T:Castle.DynamicProxy.IInvocation" /> interface.</param>
        /// <remarks>This method can be used to intercept the entry, exit, and exception-thrown scenarios of a method call.</remarks>
        public void Intercept(IInvocation invocation)
        {
            var methodClassFqn =
                $"{invocation.InvocationTarget.GetType().Name}.{invocation.Method.Name}";

            try
            {
                Console.WriteLine($"In {methodClassFqn}");
                invocation.Proceed();
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    $"{methodClassFqn}: {e.Message}\n\t{FormatExceptionStackTrace(e.StackTrace)}"
                );
                throw;
            }
            finally
            {
                Console.WriteLine($"{methodClassFqn}: Done.");
            }
        }

        private static string FormatExceptionStackTrace(string stackTrace) =>
            string.IsNullOrWhiteSpace(stackTrace)
                ? stackTrace
                : stackTrace.Replace("\n", "\n\t").Replace(" in ", "\n\tin ")
                    .Replace(".cs:line", ".cs:\n\t\tline");
    }
}