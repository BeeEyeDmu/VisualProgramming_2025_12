namespace _021_loop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] a = new int[20];
      Random r  = new Random();

      // 20개의 정수를 배열에 저장
      for (int i = 0; i < 20; i++)
        a[i] = r.Next(101);

      // 배열에 저장된 값을 출력
      foreach(var i in a)
        Console.Write(i + " ");
      Console.WriteLine();

      // 최소값, 최대값, 평균값
      int min = a[0];
      int max = a[0];
      int sum = 0;
      double avg = 0;

      foreach(var i in a)
      {
        if (i < min)
          min = i;
        if (i > max)
          max = i;
        sum += i;
      }
      Console.WriteLine("min={0}, max={1}, avg={2}",
        min, max, sum/20.0);
    }
  }
}
