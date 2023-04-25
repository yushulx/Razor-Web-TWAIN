using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorWebTWAIN
{
    // https://www.dynamsoft.com/web-twain/docs/info/api/Dynamsoft_Enum.html
    public enum PixelType
    {
        TWPT_BW,
        TWPT_GRAY,
        TWPT_RGB,
        TWPT_PALLETE,
        TWPT_CMY,
        TWPT_CMYK,
        TWPT_YUV,
        TWPT_YUVK,
        TWPT_CIEXYZ,
        TWPT_LAB,
        TWPT_SRGB,
        TWPT_SCRGB,
        TWPT_INFRARED
    }

    public enum ImageType
    {
        JPEG,
        TIFF,
        PDF
    }
}
