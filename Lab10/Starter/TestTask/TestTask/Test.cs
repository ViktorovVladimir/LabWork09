using System;

    class Test
    {
        //--.
        static void Main()
        {   
            //--. Тестирование полиморфизма
            Shape shapeObj;
            
            //--. 1. Треугольник
            //--. Инициализация
            TTriangle tr = new TTriangle(  new TPoint(0, 0), new TPoint(0, 15), new TPoint(15, 0)  );
            //--. Рассчёт периметра
            tr.Perimetr();
            tr.ShowPerimetr();
            //--. Расчёт площади треугольника
            tr.Square();
            tr.ShowSquare();
            //--. Интерфейс поворота
            tr.IAngle = -30;
            tr .RotationOperations();


            //--. 2. Окружность
            //--. Инициализация
            TCircle okr = new TCircle( 15 );
            //--. Рассчёт периметра
            okr.Perimetr();
            okr.ShowPerimetr();
            //--. Расчёт площади
            okr.Square();
            okr.ShowSquare();

            //--. 3. Квадрат
            //--. Инициализация
            TSquare sqr = new TSquare( 20 );
            //--. Рассчёт периметра
            sqr.Perimetr();
            sqr.ShowPerimetr();
                
            //--. Расчёт площади
            sqr.Square();
            sqr.ShowSquare();
            //--. Интерфейс поворота    
            sqr.IAngle = 45;
            sqr.RotationOperations();

    }

}
