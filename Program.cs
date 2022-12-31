// See https://aka.ms/new-console-template for more information


// Program the program


Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, height, length) ;

var triangle2 = new Triangle() { Length = length, Height = height, Hypotenuse = 10 };
var triangle1 = new Triangle(10);
var triangle = new Triangle();
var triangle3 = new Triangle(10, height, length);


var rectangle = new Rectangle() { Width = width, Length = length, Height = height };


Console.WriteLine("Cube Area is: " + cube.getArea() );
Console.WriteLine("Cube Volume is: " + cube.getVolume());


Console.WriteLine("Triangle Area is: " + triangle.getArea());
Console.WriteLine("Triangle Area is: " + triangle1.getArea());
Console.WriteLine("Triangle Area is: " + triangle2.getArea());
Console.WriteLine("Triangle Area is: " + triangle3.getArea());
Console.WriteLine("Rectangle Area is: " + rectangle.getArea());
