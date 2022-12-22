    //1. Написать иерархию классов «Фигуры».
    //Фигура -> Треугольник -> Прямоугольник -> Круг.
    //Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет периметра.
    //Создать массив из 5 фигур. Вывести на экран сумму периметра всех фигур в массиве.

    abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract string figureName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {figureName()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}");
            Console.WriteLine();
        }
    }

    class Triangle : Figure
    {
        double sideA, sideB, sideC; 

         public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            SideA = triangleSideA;
            SideB = triangleSideB;
            SideC = triangleSideC;
        }

    public double SideA
    {
        get { return sideA; }
        set { sideA = value; }
    }

    public double SideB
    {
        get { return sideB; }
        set { sideB = value; }
    }

    public double SideC
    {
        get { return sideC; }
        set { sideC = value; }
    }

    public override double Area()
    {
        double semPer = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC));
    }

        
    public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

    public override string figureName()
        {
            return "Треугольник";
        }
    }
    class Rectangle : Figure
    {
        double width;   
        double height;   

        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public override double Area()
        {
            return width * height;
        }
        public override double Perimeter()
        {
            return width * 2 + height * 2;
        }
        public override string figureName()
        {
            return "Прямоугольник";
        }
    }

class Circle : Figure
{
    double radius;
    public Circle(double circleRadius)
    {
        Radius = circleRadius;
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
   
    public override double Area()
    {
        return radius * radius * Math.PI;
    }
    public override double Perimeter()
    {
        return radius * 2 * Math.PI;
    }
    public override string figureName()
    {
        return "Круг";
    }
}

internal class Program
{
        static void Main()
        {
            double sumPerimetr = 0;
            var ArrayFigures = new Figure[] { new Triangle(2, 5, 6), new Rectangle(5, 6), new Circle(5), new Circle(7), new Rectangle(3, 8), new Triangle(4, 9, 9) };
            foreach (var figures in ArrayFigures)

            {
                figures.ShowInfo();
                sumPerimetr = sumPerimetr + (double)figures.Perimeter();
            
            }
            Console.WriteLine("Summ perimetrs of figures: " + sumPerimetr);
    }
  
}