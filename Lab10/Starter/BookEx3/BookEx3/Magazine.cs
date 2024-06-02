using System;

namespace BookEx3
{
    class Magazine : Item
    {
        String volume;      //том
        int number;         //номер
        String title;       //название
        int year;           //год выпуска
        
        //--.
        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        //--.
        public Magazine() 
        { 
        
        }

        //--.
        public override void Show()
        {
            //--.
            Console.WriteLine("\nЖурнал:\n Том: {0}\n Номер: {1}\n Название: {2}\n Год выпуска: {3}", volume, number, title, year);
            
            //--.
            base.Show();
        }

        //--. операция "вернуть"
        public override void Return()
        {
            taken = true;
        }

    }
}
