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
    private Hammer _hammer;
    private Saw _saw;

    public Builder(Hammer hammer, Saw saw)
    {
        _hammer = hammer;
        _saw = saw;
    }

    public void BuildHouse()
    {
        //Builder depends on the hammer and the saw
        // the client program or process is responsible for passing in
        // the required dependencies trhoug the constructor
        _saw.Use();
        _hammer.Use();
        Console.WriteLine("House Built!");   
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // the user program or process is responsible for passing in
        // the required dependencies trhoug the constructor
        Hammer hammer = new Hammer();
        Saw saw = new Saw();    
        Builder builder = new Builder(hammer, saw);
        builder.BuildHouse();
    }
}

