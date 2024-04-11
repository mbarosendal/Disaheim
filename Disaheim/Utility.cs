using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {              
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0.0;

            switch (amulet.Quality)
            {
                case Level.low:
                    value = 12.5;
                    break;
                case Level.medium:
                    value = 20.0;
                    break;
                case Level.high:
                    value = 27.5;
                    break;
                default:
                    Console.WriteLine("Invalid quality specified for the amulet.");
                    break;
            }

            return value;
        }
    }
}
