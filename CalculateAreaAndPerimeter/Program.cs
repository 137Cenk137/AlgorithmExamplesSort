using System;

namespace GeometricShapes
{
    // Base class for shapes
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract double CalculateVolume();
    }

    class Circle : Shape
    {
        private readonly  double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override double CalculateVolume()
        {
            return 0;
        }
    }

    class Square : Shape
    {
        private  readonly double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override double CalculateArea()
        {
            return _side * _side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * _side;
        }

        public override double CalculateVolume()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        private readonly double _width ;
        private readonly double _height ;
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (_width + _height);
        }

        public override double CalculateVolume()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometrik şekil seçiniz (Daire, Kare, Dikdörtgen): ");
            string shapeType = Console.ReadLine();

            Shape shape = null;

            switch (shapeType.ToLower())
            {
                case "daire":
                    Console.Write("Yarıçapı giriniz: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;
                case "kare":
                    Console.Write("Kenar uzunluğunu giriniz: ");
                    double side = double.Parse(Console.ReadLine());
                    shape = new Square(side);
                    break;
                case "dikdörtgen":
                    Console.Write("Genişliği giriniz: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Yüksekliği giriniz: ");
                    double height = double.Parse(Console.ReadLine());
                    shape = new Rectangle(width, height);
                    break;
                default:
                    Console.WriteLine("Geçersiz şekil.");
                    return;
            }

            Console.WriteLine("Hangi hesaplamayı yapmak istersiniz? (Çevre, Alan): ");
            string calculationType = Console.ReadLine();

            double result = 0;

            switch (calculationType.ToLower())
            {
                case "çevre":
                    result = shape.CalculatePerimeter();
                    break;
                case "alan":
                    result = shape.CalculateArea();
                    break;
                default:
                    Console.WriteLine("Geçersiz hesaplama türü.");
                    return;
            }

            Console.WriteLine($"Sonuç: {result}");
        }
    }
}

