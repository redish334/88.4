using System;

abstract class GeographicalObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GeographicalObject(double x, double y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    // Віртуальний метод для отримання інформації про об'єкт
    public virtual string GetInfo()
    {
        return $"Name: {Name}\nDescription: {Description}\nCoordinates: ({X}, {Y})";
    }
}




class River : GeographicalObject
{
    public double FlowSpeed { get; set; } // Швидкість течії у см/с
    public double Length { get; set; } // Довжина у км

    public River(double x, double y, string name, string description, double flowSpeed, double length)
        : base(x, y, name, description)
    {
        FlowSpeed = flowSpeed;
        Length = length;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"\nFlow Speed: {FlowSpeed} cm/s\nLength: {Length} km";
    }
}




class Mountain : GeographicalObject
{
    public double HighestPoint { get; set; } // Найвища точка у метрах

    public Mountain(double x, double y, string name, string description, double highestPoint)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"\nHighest Point: {HighestPoint} m";
    }
}




class Program
{
    static void Main()
    {
        River river = new River(48.45, 34.98, "Dnipro", "The longest river in Ukraine", 80, 2201);
        Console.WriteLine(river.GetInfo());
        Console.WriteLine();

        Mountain mountain = new Mountain(46.38, 10.82, "Hoverla", "The highest mountain in Ukraine", 2061);
        Console.WriteLine(mountain.GetInfo());
    }
}


