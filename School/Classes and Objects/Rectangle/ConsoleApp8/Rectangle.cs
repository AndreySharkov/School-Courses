using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Rectangle
    {
        private int width;
        private int hight;
        private string color;

        public int Width 
        {

            get { return this.width; }
            set 
            {
                if(value > 0)
                {
                    this.width = value;
                }
                else
                {
                    this.width = 1;
                }

            } 
        }

        public int Height
        {

            get { return this.hight; }
            set 
            {
                if(value > 0)
                {
                    this.hight = value;
                }
                else
                {
                    this.hight = 1; 
                }
            }
        }

        public string Color
        {

            get { return this.color; }
            set 
            { 
                if(value != string.Empty)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "colorless";
                }
            }
        }

        public Rectangle(int width, int height, string color)
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }

        public int CalcArea()
        {
            return this.Width * this.Height;
        }
    }
}
