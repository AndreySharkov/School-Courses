using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DefiningSimpleClses
{
    internal class DateCounter
    {
        public int CalculateDifference(string firstDate, string secondDate)
        {
            System.DateTime dateFirstToDateTime = new System.DateTime((firstDate.Split("/").Select(int.Parse).ToArray())[0],
                (firstDate.Split("/").Select(int.Parse).ToArray())[1],
                (firstDate.Split("/").Select(int.Parse).ToArray())[2]);
            System.DateTime dateSecondToDateTime = new System.DateTime((secondDate.Split("/").Select(int.Parse).ToArray())[0],
                (secondDate.Split("/").Select(int.Parse).ToArray())[1],
                (secondDate.Split("/").Select(int.Parse).ToArray())[2]);
            return Math.Abs((dateSecondToDateTime - dateFirstToDateTime).Days);
        }

    }
}
