using System.Collections.Generic;

public static class pnm_cs_utility_common
{



    public static int ConvertToGreyscaleValue(int r, int g, int b)
    {
        return (int)((r * 0.299f) + (g * 0.587f) + (b * 0.114f));
    }



    public static int ConvertToGreyscaleValue(RGB_PixelValues rgb_pixelValues)
    {
        return ConvertToGreyscaleValue(rgb_pixelValues.R, rgb_pixelValues.B, rgb_pixelValues.B);
    }



    public static Grey_PixelValues_List ConvertToGreyscaleValueList(RGB_PixelValues_List in_list)
    {
        Grey_PixelValues_List out_list = new Grey_PixelValues_List();

        foreach(RGB_PixelValues pixel in in_list)
        {
            out_list.Add(new Grey_PixelValues(ConvertToGreyscaleValue(pixel)));
        }

        return out_list;
    }



    public static RGB_PixelValues_List GetRGBListFromGreyscaleList(Grey_PixelValues_List in_list)
    {
        RGB_PixelValues_List out_list = new RGB_PixelValues_List();

        foreach(Grey_PixelValues pixel in in_list)
        {
            out_list.Add(new RGB_PixelValues(pixel.Value));
        }

        return out_list;
    }



} // !namespace pnm_cs_lib_utility
