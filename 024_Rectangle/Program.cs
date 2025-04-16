using System.Drawing;

namespace _024_Rectangle
{
  class Rectangle
  {
    private double width;
    private double height;

    public void SetWidth(double width)  // 셋터
    {
      if(width >= 0)
        this.width = width;
      else
        Console.WriteLine("width는 0보다 크거나 같아야 합니다.");
    }

    public double GetWidth() // 겟터
    {
      return width;
    }

    public void SetHeight(double height)
    {
      this.height = height;
    }

    public double GetHeight()
    {
      return height;
    }
  }

  class RectWithProp  // 속성을 갖는 사각형 클래스
  {
    public double Width { get; set; }
    public double Height { get; set; }
  }

  class RectWithPropFull
  {
    //public double Width { get; set; }
    //public double Height { get; set; }
    private double width;

    public double Width
    {
      get { return width; }
      set { if(value >= 0 ) width = value; }
    }

    private double height;

    public double Height
    {
      get { return height; }
      set { if(value >= 0) height = value; }
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle();

      // r.Width = 10;
      r.SetWidth(10);
      Console.WriteLine("사각형 r의 폭 : {0}", r.GetWidth());

      RectWithProp rp = new RectWithProp();
      rp.Width = 10;
      rp.Height = 10;
      Console.WriteLine("면적 = {0}", rp.Width*rp.Height);

      RectWithPropFull r2 = new RectWithPropFull();
      r2.Width = 10;
      r2.Height = 10;
      Console.WriteLine("r2의 면적은 {0}", r2.Width * r2.Height);

      RectWithPropFull r3 = new RectWithPropFull();
      r3.Width = 10;
      r3.Height = -10;
      Console.WriteLine("r3의 면적은 {0}", r3.Width*r3.Height);
    }
  }
}
