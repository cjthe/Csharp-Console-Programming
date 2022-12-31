


class Cube : Shape, IShape
{


    public Cube(int width, int height, int length)
    {
        Width = width;
        Height = height;
        Length = length;
    }


    public double Width { get; set; }

    public double getArea()
    {
        return Height * Length;
    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}
