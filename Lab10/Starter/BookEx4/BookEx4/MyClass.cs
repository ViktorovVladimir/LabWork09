using System;

namespace BookEx4
{
    class Test
    {
        //--.
        static void Main()
        {
            //--. Тестирование полиморфизма
            Item it;
            
            //--. 1
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            it = b2;
            it.TakeItem();
            it.Show();


            //--. 2
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();

            it = mag1;
            it.TakeItem();
            it.Show();

            //--.
            Console.WriteLine();

            mag1.IfSubs = true;
            mag1.Subs();
        }

    }
}