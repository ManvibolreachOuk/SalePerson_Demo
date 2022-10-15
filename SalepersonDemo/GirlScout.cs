using System;
using System.Collections.Generic;
using System.Text;

namespace SalepersonDemo_Lab8
{
    class GirlScout: Salesperson, ISellable
    {
        int boxesOfCookiesSold = 0;

        public int BoxesOfCookiesSold
        {
            get
            {
                return boxesOfCookiesSold;
            }
            set
            {
                boxesOfCookiesSold = value;
            }
        }

        public GirlScout(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public void SalesSpeech()
        {
            Console.WriteLine("I'm {0}, I sell boxes of cookies", GetFullName());
        }

        public void MakeSale(int boxesSold)
        {
            boxesOfCookiesSold += boxesSold;
        }
    }
}
