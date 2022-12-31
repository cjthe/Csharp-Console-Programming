using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle : Shape, IShape
{

    public Triangle()
    {

    }

    public Triangle(int hyp)
    {
        Hypotenuse = hyp;
    }

    public Triangle(int hyp, int height, int length)
    {
        Hypotenuse= hyp;
        Height = height;
        Length = length;
    }
    public double Hypotenuse { get; set; }

    public double getArea()
    {
        return .5 * Length * Height;
    }
}