namespace _025_Rectangle
{
  class Rectangle
  {
    private int width;
    private int height;

    public Rectangle()
    {
      width = height = 0;
    }

    public Rectangle(int w, int h)
    {
      width = w;
      height = h;
    }

    public int GetArea()
    {
      return width * height;
    }

    public int GetPerimeter()
    {
      return 2 * width + 2 * height;
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle(5, 3);
      int area = r.GetArea();
      int perimeter = r.GetPerimeter();

      Console.WriteLine("넓이 : {0}", area);
      Console.WriteLine("둘레 : {0}", perimeter);

    }
  }
}
