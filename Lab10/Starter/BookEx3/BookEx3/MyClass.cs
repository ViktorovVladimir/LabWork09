using BookEx2;
using System;

namespace BookEx2NameSpace
{
    class Test
    {
        //--.
        static void Main()
        {
            //--.1
            Item item1= new Item();
            item1.Show();

            //--.2
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            //--.3
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();

        }

    }
}