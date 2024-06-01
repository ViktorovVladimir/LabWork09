using System;

namespace MyClassNameSpace
{
    class Test
    {
        //--.
        static void Main()
        {
            //--.
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука", 823, 2013);
            b2.Show();
            Book.SetPrice(12);
            b2.Show(); 
        }

    }
}