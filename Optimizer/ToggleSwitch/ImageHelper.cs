using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    public static class ImageHelper
    {
        private static float[][] _colorMatrixElements = 
        {
            new float[] {(float)0.299, (float)0.299, (float)0.299, 0, 0},
            new float[] {(float)0.587, (float)0.587, (float)0.587, 0, 0},
            new float[] {(float)0.114, (float)0.114, (float)0.114, 0, 0},
            new float[] {0,  0,  0,  1, 0},
            new float[] {0, 0, 0, 0, 1}
        };

        private static ColorMatrix _grayscaleColorMatrix = new ColorMatrix(_colorMatrixElements);

        public static ImageAttributes GetGrayscaleAttributes()
        {
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(_grayscaleColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            return attr;
        }

        public static Size RescaleImageToFit(Size imageSize, Size canvasSize)
        {
            // Code "borrowed" from http://stackoverflow.com/questions/1940581/c-sharp-image-resizing-to-different-size-while-preserving-aspect-ratio
            // and the Math.Min improvement from http://stackoverflow.com/questions/6501797/resize-image-proportionally-with-maxheight-and-maxwidth-constraints

            // Figure out the ratio
            double ratioX = (double)canvasSize.Width / (double)imageSize.Width;
            double ratioY = (double)canvasSize.Height / (double)imageSize.Height;

            // use whichever multiplier is smaller
            double ratio = Math.Min(ratioX, ratioY);

            // now we can get the new height and width
            int newHeight = Convert.ToInt32(imageSize.Height * ratio);
            int newWidth = Convert.ToInt32(imageSize.Width * ratio);

            Size resizedSize = new Size(newWidth, newHeight);

            if (resizedSize.Width > canvasSize.Width || resizedSize.Height > canvasSize.Height)
            {
                throw new Exception("ImageHelper.RescaleImageToFit - Resize failed!");
            }

            return resizedSize;
        }
    }
}
