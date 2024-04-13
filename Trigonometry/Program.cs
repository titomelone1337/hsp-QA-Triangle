using DomainTest;

Triangle t = new Triangle(1,2,3);
double area = t.Area();
Console.WriteLine(t.ToString());
Console.WriteLine("Area: "+ area.ToString("F2"));

Console.ReadKey();