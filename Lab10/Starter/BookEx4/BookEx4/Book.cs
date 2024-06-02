using System;

namespace BookEx4
{
    //--.
    class Book : Item
    {
        //--.
        String author;      //автор
        String title;       //название
        String publisher;   //издательство
        int pages;          //кол-во страниц
        int year;           //год издания
        bool bReturnSrok;        //для учёта возвращения книги

        //--.
        static double price = 9;

        //--.
        public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        //--.
        public Book()           //статический конструктор
        {
            price = 10;
        }

        //--.
        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        //--.
        public override void Show()
        {
            //--.
            Console.WriteLine("\nКнига: \n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}", author, title, year, pages, Book.price);
            //--.
            base.Show();
        }

        //--.
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        //--.
        public void TakeItem()
        {
            if( this.isAvailable() )
            {
                this.Take();
            }
        }

        //--. метод, устанавливающий, что книга сдана в срок
        public void funcReturnSrok()
        {
            bReturnSrok = true;
        }

        public override void Return()
        {
            if (bReturnSrok == true)
            {
                taken = true;
            }
            else
            {
                taken = false;
            }

        }

    }

}