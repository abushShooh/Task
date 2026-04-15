public class Area
{
    public double Width {get; set;}
    public double Height {get; set;}

    public double GetArea(double Width, double Height)
    {
        this.Width = Width;
        this.Height = Height;
        return Width * Height;
    }
}