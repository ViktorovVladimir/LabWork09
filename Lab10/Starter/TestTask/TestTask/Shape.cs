using System;


    abstract class Shape
    {
        //--. название фигуры
        protected String sNameShape;
        //--. значение периметра фигуры 
        protected double rValuePerimetr;
        //--. значение площади фигуры
        protected double rValueSquare;
        
        //--.
        public Shape()
        {
            rValuePerimetr = 0;
            rValueSquare   = 0;
        }
        
        //--. операция "расчёт периметра"
        abstract public void Perimetr();

        //--. операция "расчёт площади"
        abstract public void Square();
        

        //--.
        public virtual void ShowPerimetr()
        {
            Console.WriteLine("{0}: периметр равен : {1} ", sNameShape, rValuePerimetr);
        }
    
        //--.
        public virtual void ShowSquare()
        {
            Console.WriteLine("{0}: площадь равна : {1} ", sNameShape, rValueSquare);
        }


        //--. метод, выводящий на экран информацию о единице хранения
        //public virtual void Show()
        //{
        //    Console.WriteLine(" Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        //}
}
