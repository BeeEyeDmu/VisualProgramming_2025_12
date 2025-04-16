namespace _027_Student
{
  class Student
  {
    private string name;
    private string major;
    private int age;

    public Student(string name, string major, int age)
    {
      this.name = name;
      this.major = major;
      this.age = age;
    }

    public void DusplayInfo()
    {
      //Console.WriteLine("이름: {0}\n전공: {1}\n나이: {2}\n",
      // name, major, age);
      Console.WriteLine($"이름: {name}\n전공: {major}\n나이: {age}\n");
    }
  }


  internal class Program
  {
    static void Main(string[] args)
    {
      Student s = new Student("홍길동", "의료IT공학", 20);

      s.DusplayInfo();
    }
  }
}
