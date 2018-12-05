using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace Nursery_Management_System
{
    class ImageOperation
    {
        public  byte[] ImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public  Image BinaryToImage(byte[] byteArray)
        {
            
                MemoryStream ms = new MemoryStream(byteArray, 0, byteArray.Length);
                ms.Write(byteArray, 0, byteArray.Length);
                Image image = Image.FromStream(ms, true);

            int x = 1;
                return image;
           
            
        }



    }
}
