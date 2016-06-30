using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCard_062916
{
    class CardCount
    {
        public int Count { get; set; }
        //public int Card  { get; set; }
        public int CC(int card)
        {
            // Assign a -1, 0, or 1 to "count" based on "card" value
            if (card == 7 | card == 8 | card == 9)
            {
                /* do nothing */
            }
            else if (card == 2 | card == 3 | card == 4 | card == 5 | card == 6)
            {
                this.Count++;
            }
            else {
                this.Count--;
            }

            // Return "count" total and action to take
            if (this.Count > 0)
            {
                return this.Count;
            }
            else {
                return this.Count;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cardCount1 = new CardCount{};


            cardCount1.CC(2);
            cardCount1.CC(3);
            cardCount1.CC(4);
            cardCount1.CC(5);
            Console.WriteLine(cardCount1.CC(6));

            cardCount1.CC(2);
            cardCount1.CC(3);
            cardCount1.CC(4);
            cardCount1.CC(5);
            Console.WriteLine(cardCount1.CC(6));


            Console.ReadLine();

           
        }
    }
}
