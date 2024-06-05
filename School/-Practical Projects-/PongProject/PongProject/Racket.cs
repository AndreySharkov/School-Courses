using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongProject
{
    public class Racket
    {
        private readonly int _y;
        private readonly int _length;
        private readonly int _initialX;

        private int _x;

        public Racket(int x, int y, int length = 5, char tile = '|')
        {
            this._x = this._initialX = x;
            this._y = y;
            this._length = length;
            this.Tile = tile;
        }

        public char Tile { get; set; }

        public void Draw(Field field)
        {
            for (int i = 0; i < this._length; i++)
            {
                if (i + this._x >= 0 && i + this._x < field.GetRows)
                    field.Set(i + this._x, this._y, this.Tile);
            }
        }

        public void MoveUp(Field field)
        {
            if (this._x <= 1) return;

            field.Set(this._x + (this._length - 1), this._y, ' ');
            this._x--;
            this.Draw(field);
        }

        public void MoveDown(Field field)
        {
            if (this._x + this._length >= field.GetRows - 1) return;

            field.Set(this._x, this._y, ' ');
            this._x++;
            this.Draw(field);
        }

        public void Reset(Field field)
        {
            for (int i = 0; i < this._length; i++)
            {
                if (i + this._x >= 0 && i + this._x < field.GetRows)
                    field.Set(i + this._x, this._y, ' ');
            }

            this._x = this._initialX;
            this.Draw(field);
        }
    }
}
