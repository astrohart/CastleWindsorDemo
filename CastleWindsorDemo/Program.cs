using System;

namespace CastleWindsorDemo
{
    /// <summary>Provides functionality for the program entry point.</summary>
    /// <remarks>This program was created by me in order to learn more about the Castle.Windsor dependency-injection (DI) framework.  In this project, we are developing it while following along with the Aspect Oriented Programming (AOP) in C# using Castle DynamicProxy article on The Code Project, at: https://www.codeproject.com/Articles/1083684/Aspect-Oriented-Programming-AOP-in-Csharp-using-Ca.</remarks>
    public static class Program
    {
        /// <summary>Initializes static data or performs actions that need to be performed once only for the <see cref="T:CastleWindsorDemo.Program" /> class.</summary>
        /// <remarks>This constructor is called automatically prior to the first instance being created or before any static members are referenced.</remarks>
        static Program() =>
            // Initialize the DependencyResolver
            DependencyResolver.Initialize();

        /// <summary>Entry point of the application.</summary>
        /// <param name="args">(Optional.) Array of strings, one per value passed on the command line of this application.</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine(typeof(Program).FullName);

            // resolve the type Rocket
            var rocket = DependencyResolver.Resolve<IRocket>();

            // try to launch the rocket
            try
            {
                rocket.Launch(5);
            }
            catch
            {
                // Ignored.
            }

            Console.ReadKey();
        }
    }
}