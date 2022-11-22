namespace AlgoStrategies.Models
{
    public class MergeSort : AbstractStrategy
    {
        public override void AlgorithInterface()
        {
            Console.WriteLine($"Called from {GetType().Name}");
        }
    }
}
