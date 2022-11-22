namespace AlgoStrategies.Models
{
    public class BogoSort : AbstractStrategy
    {
        public override void AlgorithInterface()
        {
            Console.WriteLine($"Called from {GetType().Name}");
        }
    }
}
