using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class Shaverma
    {
        public List<string> Ingredients { get; set; }

        public int Price { get; set; } 

        public Shaverma()
        {
            Ingredients = new List<string>();
        }

        public override string ToString()
        {
            string str = "";
            foreach(string s in Ingredients)
            {
                str += s;
            }
            str += "Price ";
            str += Price.ToString();
            str += " Bravo Sheff!";
            return str;
        }
    }
}
