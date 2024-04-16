using my_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftheejae
{
    class giftboxmanager
    {
        public void setlnit()
        {
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000, ItemGrade.normal);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000, ItemGrade.rare);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000, ItemGrade.Unique);

            Console.WriteLine($"addressC : letter : {addressC.Letter} item : {addressC.Grade}");
        }

        private static GiftBox GiftBoxMaker(string Letter, int Money, ItemGrade itemGrade)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = Letter,
                Money = Money,
                Grade = itemGrade
            };
            return addressA;
        }
    }
}
