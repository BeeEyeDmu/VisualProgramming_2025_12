namespace _023_InstanceNStatic
{
  class Date
  {
    public int year, month, day;  // 멤버변수(필드)

    // 생성자 만들기
    public Date()
    {
      year = 1; month = 1; day = 1;
    }
    public Date(int y, int m, int d)
    {
      year = y; month = m; day = d;
    }
    public static bool IsLeapYear(int year)
    {
      return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

    static int[] days = 
      { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

    public int DayOfYear()
    {
      return days[month-1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
    }

  }
  internal class Program
  {
    static void Main(string[] args)
    {
      //Date xmas = new Date();
      //xmas.year = 2025;
      //xmas.month = 12;
      //xmas.day = 25;
      Date xmas = new Date(2024, 12, 25);

      Console.WriteLine(xmas.DayOfYear());  // 객체 메소드

      if (Date.IsLeapYear(2024) == true)    // 클래스(스태틱) 메소드
        Console.WriteLine("윤년");
      else
        Console.WriteLine("평년");
    }
  }
}
