using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongProject
{
    public class Ball
    {
        private readonly char _tile;
        private readonly int _initialX;
        private readonly int _initialY;

        private int _x;
        private int _y;
        private bool _isGoingDown;
        private bool _isGoingRight;

        public Ball(int x, int y, char tile = '0')
        {
            this._x = this._initialX = x;
            this._y = this._initialY = y;
            this._tile = tile;
            this._isGoingDown = true;
            this._isGoingRight = true;
        }

        public int Y => this._y;

        public void Draw(Field field)
        {
            if (_x >= 0 && _x < field.GetRows && _y >= 0 && _y < field.GetCols)
                field.Set(this._x, this._y, this._tile);
        }

        public void CalculateTrajectory(Field field, char leftRacketTile, char rightRacketTile)
        {


            if (_x >= 0 && _x < field.GetRows && _y >= 0 && _y < field.GetCols && field.Get(_x, _y) != '#')
                field.Set(this._x, this._y, ' ');

            if (_x - 1 < 0 || field.Get(_x - 1, _y) == '#')
            {
                this._isGoingDown = true;
            }
            else if (_x + 1 >= field.GetRows || field.Get(_x + 1, _y) == '#')
            {
                this._isGoingDown = false;
            }
            if (_y + 1 < field.GetCols && field.Get(_x, _y + 1) == rightRacketTile)
            {
                this._isGoingRight = false;
            }
            else if (_y - 1 >= 0 && field.Get(_x, _y - 1) == leftRacketTile)
            {
                this._isGoingRight = true;
            }

            this._x = this._isGoingDown ? this._x + 1 : this._x - 1;
            this._y = this._isGoingRight ? this._y + 1 : this._y - 1;
            Draw(field);
        }

        public void Reset(Field field)
        {
            if (_x >= 0 && _x < field.GetRows && _y >= 0 && _y < field.GetCols && field.Get(_x, _y) != '#')
                field.Set(this._x, this._y, ' ');

            this._x = this._initialX;
            this._y = this._initialY;
            this.Draw(field);
        }
    }
}
