namespace _2_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////// Rate calculation software \\\\\\\\\\\\\\\\\\\\\\\\\\\


            //// Currency 


            float usd = 1.7f;
            float euro = 1.8036f;
            float rub = 0.0225f;


            Console.Write("enter the amount (azn): ");
            float aznsum = float.Parse(Console.ReadLine());

            Console.Write("\ntotal (azn): " + aznsum);
            Console.Write("\nusd " + usd * aznsum);
            Console.Write("\neuro: " + euro * aznsum);
            Console.Write("\nrub: " + rub * aznsum);
        }
    }
}