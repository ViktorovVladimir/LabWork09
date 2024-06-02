using System;


namespace BookEx2
{
    class Item
    {
        // инвентарный номер - целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;
        
        //--.
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        //--.
        public Item()
        {
            this.taken = true;
        }

        //--.

        //--. истина, если этот предмет имеется в библиотеке
        public bool isAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        //--. инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }

        //--. операция "взять"
        public void Take()
        {
            taken = false;
        }

        //--. операция "вернуть"
        public void Return()
        {
            taken = true;
        }

        //--. метод, выводящий на экран информацию о единице хранения
        public void Show()
        {
            Console.WriteLine(" Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }
    }
}
