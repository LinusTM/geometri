namespace geometri;

class Program {
    static void Main(string[] args) {
        Square square = new Square(12);
        Console.WriteLine($"Circumference of square: {square.Circumference()}\nArea of square: {square.Area()}");

        Rectangle rectangle = new Rectangle(12);
        Console.WriteLine($"Circumference of square: {rectangle.Circumference()}\nArea of square: {rectangle.Area()}");

        Trapezoid trapezoid = new Trapezoid(12);
        Console.WriteLine($"Circumference of square: {trapezoid.Circumference()}\nArea of square: {trapezoid.Area()}");

        Parallelogram parallelogram = new Parallelogram(12);
        Console.WriteLine($"Circumference of square: {parallelogram.Circumference()}\nArea of square: {parallelogram.Area()}");
    }
}

public class Square {
    private double side;
    public double Side {
        get => side;
        set => side = value;
    }

    public Square(double side) {
        this.side = side; 
    }

    public double Circumference() {
        return side * 4;
    }

    public double Area() {
        return side * side;
    }
}

public class Rectangle : Square {
    public Rectangle(double side) : base(side) {}
}

public class Trapezoid : Square {
    private double slope;
    public double Slope {
        get => slope;
        set => slope = value;
    }
    
    private double sideB;
    public double SideB {
        get => sideB;
        set => sideB = value;
    }

    public Trapezoid(double side, double sideB, double slope) : base(side) {}

    override public double Area() {
        return side * sideB * Math.Sin(slope); 
    }
}

public class Parallelogram : Square {
    public Parallelogram(int side) : base(side) {}
}
