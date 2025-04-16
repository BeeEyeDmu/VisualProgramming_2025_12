namespace _004_bmiCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w, h;

            Console.Write("키를 입력(cm) : ");
            h = double.Parse(Console.ReadLine());

            Console.Write("체중을 입력(kg) : ");
            w = double.Parse(Console.ReadLine());

            h /= 100;

            double bmi = w / (h * h);
            //Console.WriteLine("bmi = {0:F4}", bmi);
            Console.WriteLine("bmi = " + bmi);
        }
    }
}
