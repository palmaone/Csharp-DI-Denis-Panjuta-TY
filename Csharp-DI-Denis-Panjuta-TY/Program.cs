namespace Csharp_DI_Denis_Panjuta_TY;

public class Hammer
{
    public void Use() 
    {
        Console.WriteLine("Hammering Nails!");
    }
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing Wood!");
    }
}

public class Builder
{
    public Hammer Hammer { get; set; }
    public Saw Saw { get; set; }

    public void BuildHouse()
    {
        //Builder depends on the hammer and the saw
        // the client program or process is responsible for setting
        // the required dependencies trhoug the builder setter methods
        Saw.Use();
        Hammer.Use();
        Console.WriteLine("House Built!");   
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // the client program or process is responsible for setting
        // the required dependencies trhoug the builder setter methods
        Hammer hammer = new Hammer();
        Saw saw = new Saw();    
        Builder builder = new Builder();
        // We are injecting the dependencies via setters
        builder.Hammer = hammer;//here and
        builder.Saw = saw;//here
        builder.BuildHouse();
    }
}

