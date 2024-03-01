using System.Collections.Generic;



public class RGB_PixelValues
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public RGB_PixelValues()
    {
        R = 0;
        G = 0;
        B = 0;
    }

    public RGB_PixelValues(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public RGB_PixelValues(int value)
    {
        R = value;
        G = value;
        B = value;
    }
} // !public class RGB_PixelValues

public class RGB_PixelValues_List : List<RGB_PixelValues> { }



public class Grey_PixelValues
{
    public int Value { get; set; }

    public Grey_PixelValues()
    {
        Value = 0;
    }

    public Grey_PixelValues(int value)
    {
        Value = value;
    }
} // !public class Grey_PixelValues

public class Grey_PixelValues_List : List<Grey_PixelValues> { }