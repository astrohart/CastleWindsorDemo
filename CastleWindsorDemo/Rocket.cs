using System;
using System.Threading;

namespace CastleWindsorDemo
{
    /// <summary>Concrete implementation of a rocket.</summary>
    public class Rocket : IRocket
    {
        /// <summary>Gets or sets a string containing the model of the rocket.</summary>
        public string Model { get; set; }

        /// <summary>Gets or sets a string containing the name of the rocket.</summary>
        public string Name { get; set; }

        /// <summary>Launches the rocket after a countdown specified by the <paramref name="delaySeconds" /> parameter.</summary>
        /// <param name="delaySeconds">(Required.) Number of seconds to count down before launching the rocket.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if <paramref name="delaySeconds" /> is zero or negative.</exception>
        public void Launch(int delaySeconds)
        {
            if (delaySeconds <= 0)
                throw new ArgumentOutOfRangeException(nameof(delaySeconds));

            Console.WriteLine("Launching rocket in {0} seconds", delaySeconds);
            for (var i = delaySeconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            // uncomment this line to test invocator exception handling
            // throw new InvalidOperationException("UH OH!  Rocket blew up!");

            Console.WriteLine("** BLAST OFF!!! **");
            Thread.Sleep(1000);
        }
    }
}