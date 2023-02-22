using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ6
{
    internal class Knigs
    {
        public Random random = new Random();
        private int God
        {
            get => random.Next(1700, 1994);
        }
        private int Pages
        {
            get => random.Next(200, 400);
        }
        internal List<Year> Years { get; private set; }
        public void Initialize()
        {
            Years = new List<Year>
            {
                new Year(God, Pages, new book("Regnorum")),
                new Year(God, Pages, new book("Initive")),
                new Year(God, Pages, new book("Gertrude")),
                new Year(God, Pages, new book("Calamity")),
                new Year(God, Pages, new book("Redemtion")),
                new Year(God, Pages, new book("StarsAbove")),
                new Year(God, Pages, new book("Digital")),
                new Year(God, Pages, new book("Blazblue")),
                new Year(God, Pages, new book("Arknights")),
            };
        }
    }
}
