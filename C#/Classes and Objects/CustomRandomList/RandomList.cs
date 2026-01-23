using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    internal class RandomList : List<string>
    {
        private Random r;
        public RandomList(string element)
        {
            r = new Random();
        }
        public string RandomString()
        {
            int index = r.Next(0, this.Count);
            string element = this[index];
            RemoveAt(index);
            return element;

        }
    }
}
