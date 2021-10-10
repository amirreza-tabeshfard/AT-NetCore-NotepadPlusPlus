namespace AT_Notepad.WFA.NetCore.Common.Extensions
{
    public static class ImageExtensions
    {
        /// <summary>
        /// Scales a Image to make it fit inside of a Height/Width
        /// Example:
        /// Image test = someImg.ScaleImage(591, 1096);
        /// </summary>
        /// <param name="img"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static System.Drawing.Image ScaleImage(this System.Drawing.Image img, int height, int width)
        {
            if (img == null || height <= 0 || width <= 0)
                return null;

            int newWidth = img.Width * height / img.Height;
            int newHeight = img.Height * width / img.Width;
            int x;
            int y;

            var bmp = new System.Drawing.Bitmap(width, height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

            // use this when debugging.
            //g.FillRectangle(Brushes.Aqua, 0, 0, bmp.Width - 1, bmp.Height - 1);

            if (newWidth > width)
            {
                // use new height
                x = (bmp.Width - width) / 2;
                y = (bmp.Height - newHeight) / 2;
                g.DrawImage(img, x, y, width, newHeight);
            }
            else
            {
                // use new width
                x = bmp.Width / 2 - newWidth / 2;
                y = bmp.Height / 2 - height / 2;
                g.DrawImage(img, x, y, newWidth, height);
            }

            // use this when debugging.
            //g.DrawRectangle(new Pen(Color.Red, 1), 0, 0, bmp.Width - 1, bmp.Height - 1);

            return bmp;
        }

        /// <summary>
        /// This method resizes a System.Drawing.Image and tries to fit it in the destination Size. 
        /// The source image size may be smaller or bigger then the target size. 
        /// Source and target layout orientation can be different. ResizeAndFit tries to fit it the best it can.
        /// Example:
        /// Image image = Image.FromStream(context.Request.InputStream).ResizeAndFit(new Size( 125, 100));
        /// </summary>
        /// <param name="image"></param>
        /// <param name="newSize"></param>
        /// <returns></returns>
        public static System.Drawing.Image ResizeAndFit(this System.Drawing.Image image, System.Drawing.Size newSize)
        {
            var sourceIsLandscape = image.Width > image.Height;
            var targetIsLandscape = newSize.Width > newSize.Height;

            var ratioWidth = newSize.Width / (double)image.Width;
            var ratioHeight = newSize.Height / (double)image.Height;

            double ratio;

            if (ratioWidth > ratioHeight && sourceIsLandscape == targetIsLandscape)
                ratio = ratioWidth;
            else
                ratio = ratioHeight;

            var targetWidth = (int)(image.Width * ratio);
            var targetHeight = (int)(image.Height * ratio);

            var bitmap = new System.Drawing.Bitmap(newSize.Width, newSize.Height);
            var graphics = System.Drawing.Graphics.FromImage(bitmap);

            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            var offsetX = (double)(newSize.Width - targetWidth) / 2;
            var offsetY = (double)(newSize.Height - targetHeight) / 2;

            graphics.DrawImage(image, (int)offsetX, (int)offsetY, targetWidth, targetHeight);
            graphics.Dispose();

            return bitmap;
        }

        /// <summary>
        /// Create a new Image from a byte array
        /// Example:
        /// byte[] imageBytes = GetImageBytesFromDB();
        /// Image myImage = imageBytes.ToImage();
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static System.Drawing.Image ToImage(this byte[] bytes)
        {
            if (bytes == null)
                throw new System.ArgumentNullException(nameof(bytes));

            return System.Drawing.Image.FromStream(new System.IO.MemoryStream(bytes));
        }

        /// <summary>
        /// Convert image to byte array
        /// Example:
        /// Image image = ...;
        /// byte[] imageBytes = image.ToBytes(ImageFormat.Png);
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this System.Drawing.Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if (image == null)
                throw new System.ArgumentNullException(nameof(image));

            if (format == null)
                throw new System.ArgumentNullException(nameof(format));

            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, format);
                return stream.ToArray();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static byte[] IconToBytes(this System.Drawing.Icon icon)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                icon.Save(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static System.Drawing.Icon BytesToIcon(this byte[] bytes)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
            {
                return new System.Drawing.Icon(ms);
            }
        }

        public static byte[] ImageToByteArray(this System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}