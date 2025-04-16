namespace _028_calculator
{
  class Calulator
  {
    public static int Add(int x, int y)
    {
      return x + y;
    }
    public static int Subtract(int x, int y)
    {
      return x - y;
    }
    public static int Multiply(int x, int y)
    {
      return x * y;
    }
    public static double Divide(int x, int y)
    {
      if (y == 0)
      {
        Console.WriteLine("0으로는 나눌 수 없습니다");
        return 0;
      }
      else
        return (double)x / y;
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = 20;

      int sum = Calulator.Add(x, y);  // 스태틱 매소드 호출
      int diff = Calulator.Subtract(x, y);
      int prod = Calulator.Multiply(x, y);
      double quot = Calulator.Divide(x, y);

      Console.WriteLine($"덧셈: {sum}\n뺄셈: {diff}\n곱셈: {prod}\n나눗셈: {quot}");
    }
  }
}
