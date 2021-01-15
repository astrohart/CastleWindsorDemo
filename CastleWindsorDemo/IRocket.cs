namespace CastleWindsorDemo
{
    /// <summary>Describes the public interface of a rocket object.</summary>
    public interface IRocket
    {
        /// <summary>Launches the rocket after a countdown specified by the <paramref name="delaySeconds" /> parameter.</summary>
        /// <param name="delaySeconds">(Required.) Number of seconds to count down before launching the rocket.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if <paramref name="delaySeconds" /> is zero or negative.</exception>
        void Launch(int delaySeconds);
    }
}