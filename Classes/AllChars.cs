using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Kavramatik.cs
{
    class AllChars
    {
        public List<Chars> CharList = new List<Chars>();

        public List<Number> NumList = new List<Number>();


        string[] nums = { "0", "1", "2 ", "3 ", "4 ", "5 ", "6 ", "7", "8", "9" };
        string[] chars = { "A", "B", "C","Ç","D","E","F","G","Ğ","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T",
              "U","Ü","V","Y","Z"};

        public AllChars()
        {
            //set Alphabets
            for (int i = 0; i < 29; i++)
            {   
                int j = i + 1;
                Image a = Image.FromFile("C:\\Users\\asus k555l\\source\\repos\\OzelOgrenciDemo\\Resources\\Alphabet\\A" + j + ".jpg");

                //resize image
              

                SoundPlayer s = new SoundPlayer("C:\\Users\\asus k555l\\source\\repos\\OzelOgrenciDemo\\Resources\\Alphabet\\Alfabe\\A" + j + ".wav");
                Chars c = new Chars(chars[i], s, a);
                CharList.Add(c);
            }
            

            //set for Number
            for (int i = 0; i <= 9; i++)
            {
                int j = i;
                Image a = Image.FromFile("C:\\Users\\asus k555l\\source\\repos\\OzelOgrenciDemo\\Resources\\Digits\\A" + j + ".jpg");
                

                SoundPlayer s = new SoundPlayer(@"C:\\Users\\asus k555l\\source\\repos\\OzelOgrenciDemo\\Resources\\Digits\\Rakamlar\\A" + j + ".wav");
                Number n = new Number(nums[i], s, a);
                NumList.Add(n);
            }

        }

    }
}
