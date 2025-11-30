using System;

namespace MyConsoleApp.RectangleApplication;

public class Rectangle
 {
     private double _length;
     private double _width;

     public Rectangle()
     {
         _length = 1;
         _width = 1;
     }

     public Rectangle(double length, double width)
     {
         _length = length;
         _width = width;
     }
 
     public double Length { get; set; }
     public double Width { get; set; }

     public double GetArea() => _length * _width;

     public void Display()
     {
         Console.WriteLine($"Length: {_length}");
         Console.WriteLine($"Width: {_width}");
         Console.WriteLine($"Area: {GetArea()}");
     }
 }
 
 
 public class ExecuteRectangle
 {
     public static void Run()
     {
         Console.WriteLine("无参");
         Rectangle r1 = new Rectangle();
         r1.Display();
         
         Console.WriteLine("\n有参");
         Rectangle r2 = new Rectangle(5, 5);
         r2.Display();
         
     }
 }