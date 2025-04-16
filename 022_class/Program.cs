
  class Date
  {
    private int year, month, day;

    public void SetYear(int year)
    {
      this.year = year;
    }
    public int GetYear()
    {
      return this.year;
    }
    public void PrintDate()
    {
      Console.WriteLine("{0}년 {1}월 {2}일",
        this.year, this.month, this.day); ;
    }

    // 생성자
    public Date()
    {
      year = 2025;
      month = 1;
      day = 1;
    }

    // 생성자 2
    public Date(int y, int m, int d)
    {
      year = y;
      month = m;
      day = d;
    }
  }
  class Program
  {
    
    static void Main(string[] args)
    {
      // Date 클래스의 객체 a를 만든다
      Date a = new Date();
      Date b = new Date(2030, 12, 25);

      //a.SetYear(2025);
      //Console.WriteLine(a.GetYear());
      a.PrintDate();
      b.PrintDate();
    }

  }

