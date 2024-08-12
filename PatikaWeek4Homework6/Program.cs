
using PatikaWeek4Homework6.Concrete;

Square square = new Square() { Width=5, Height=5};
Console.WriteLine($"Kare alanı {square.Width}*{square.Height}={square.CalculateArea()}");

Rectangle rectangle = new Rectangle() { Width=5, Height=10};
Console.WriteLine($"Dikdörtgen alanı {rectangle.Width}*{rectangle.Height}={rectangle.CalculateArea()}");

RightTriangle triangle = new RightTriangle() { Width=5, Height=10};
Console.WriteLine($"Dik üçgen alanı ({triangle.Width}*{triangle.Height})/2={triangle.CalculateArea()}");


