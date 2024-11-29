using System;

interface GeographicalObject1
{
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    string GetInfo();
}




class River : GeographicalObject1
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }
    public double Length { get; set; }

    public River(double x, double y, string name, string description, double flowSpeed, double length)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
        FlowSpeed = flowSpeed;
        Length = length;
    }

    public string GetInfo()
    {
        return $"Name: {Name}\nDescription: {Description}\nCoordinates: ({X}, {Y})\nFlow Speed: {FlowSpeed} cm/s\nLength: {Length} km";
    }
}



class Mountain : GeographicalObject1
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public Mountain(double x, double y, string name, string description, double highestPoint)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
        HighestPoint = highestPoint;
    }

    public string GetInfo()
    {
        return $"Name: {Name}\nDescription: {Description}\nCoordinates: ({X}, {Y})\nHighest Point: {HighestPoint} m";
    }
}




class Program
{
    static void Main()
    {
        GeographicalObject1 river = new River(48.45, 34.98, "Dnipro", "The largest river in Ukraine", 80, 2201);
        Console.WriteLine(river.GetInfo());
        Console.WriteLine();

        GeographicalObject1 mountain = new Mountain(46.38, 10.82, "Hoverla", "The highest mountain in Ukraine", 2061);
        Console.WriteLine(mountain.GetInfo());
    }
}
