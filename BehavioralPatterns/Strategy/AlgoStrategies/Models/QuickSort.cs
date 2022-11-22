namespace AlgoStrategies.Models
{
    public class QuickSort : AbstractStrategy
    {
        public override void AlgorithInterface()
        {
            Console.WriteLine($"Called from {GetType().Name}");
        }
    }
}
