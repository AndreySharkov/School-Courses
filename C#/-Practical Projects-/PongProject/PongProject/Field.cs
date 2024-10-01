using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongProject
{
    public class Field
    {
        private readonly char[,] _field;

        public int GetRows => this._field.GetLength(0);
        public int GetCols => this._field.GetLength(1);

        public char Tile { get; }

        public char Get(int row, int col)
        {
            if (row < 0 || row >= GetRows || col < 0 || col >= GetCols)
                throw new IndexOutOfRangeException("Attempting to access an out of bounds index in the field.");
            return this._field[row, col];
        }

        public void Set(int row, int col, char el)
        {
            if (row < 0 || row >= GetRows || col < 0 || col >= GetCols)
                throw new IndexOutOfRangeException("Attempting to set an out of bounds index in the field.");
            this._field[row, col] = el;
        }

        public Field(int width, int height, char tile = '#')
        {
            this._field = new char[height, width];
            this.Tile = tile;


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    this._field[i, j] = ' ';
                }
            }


            for (int i = 0; i < this.GetCols; i++)
            {
                this.Set(0, i, tile);
                this.Set(this.GetRows - 1, i, tile);
            }
        }
    }
}
