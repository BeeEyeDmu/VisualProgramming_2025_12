namespace _008_Console
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // 6장
      int x = 123;
      int y = 345;
      Console.WriteLine("bmi="+21.6);
      Console.WriteLine(x);
      Console.WriteLine(x.ToString());

      // 7장
      Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}",
        2, 3, 5, 7);
      Console.WriteLine("x = {0}, y = {1}", x, y);

      string s = string.Format("x = {0}, y = {1}", x, y);
      Console.WriteLine(s);

      int v1 = 100;
      double v2 = 1.234;

      // Console.WriteLine(v1, v2);
      Console.WriteLine("v1 = " + v1 + ", v2" + v2);
      Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
      Console.WriteLine($"v1 = {v1}, v2 = {v2}");
    }
  }
}
