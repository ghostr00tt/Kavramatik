using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using SpeechLib;
namespace Kavramatik.cs
{
    class Utils
    {

        public readonly static string BASE_URL = "http://kavramatik.com/api/";

        public static Image byteToImg(string img)
        {
            string base64string = img;
            byte[] blob = Convert.FromBase64String(base64string);
            MemoryStream memory = new MemoryStream(blob);
            memory.Position = 0;
            Image i = Image.FromStream(memory);
            return i;

        }
       
       
    }
}
