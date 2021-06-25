using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace Kavramatik.cs
{
    public class Number
    {

        public string Character { set; get; }
        public SoundPlayer sound { set; get; }
        public Image image { set; get; }

        public Number(string a, SoundPlayer s, Image i)
        {
            this.Character = a;
            this.sound = s;
            this.image = i;
        }
    }

}
