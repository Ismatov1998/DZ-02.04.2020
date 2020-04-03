using System;

namespace MyfirstClass
{
    class Program
    {
        static void Main()
        {
          double a,b;
          Console.WriteLine("Введите значения a и b");
          a=Convert.ToInt32(Console.ReadLine());
          b=Convert.ToInt32(Console.ReadLine());
          Rectangle Aziz =new Rectangle(a,b);
          Aziz.AreaCalculator();
          Aziz.PerimetrCalculator();
          
        }
    }
    class Rectangle
    {
      public double side1,side2;
      public double  area { get; set; }
      public double perimetr { get; set; }
      public Rectangle(double side1,double side2)
      {
        this.side1=side1;
        this.side2=side2;
      }
      public void AreaCalculator()
      {
        this.area=this.side1*this.side2;
       Console.WriteLine($"Периметр = {this.side1*this.side2}");
      }
       public void PerimetrCalculator()
      {
        this.perimetr=2*(this.side1+this.side2);
        Console.WriteLine($"Площадь = {2*(this.side1+this.side2)}");
      }
      
    }
}

 
