namespace CsharpDIDenisPanjutaTY;

public interface IToolUser
{
    void SetHammer(Hammer hammer);
    void SetSaw(Saw saw);
}

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

public class Builder : IToolUser
{
    private Hammer _hammer;
    private Saw _saw;

    public void BuildHouse()
    {
        //Builder depends on the hammer and the saw
        // Builder is an IToolUser and must implement
        // setter methods to assing the Hammer and the Saw
        _saw.Use();
        _hammer.Use();
        Console.WriteLine("House Built!");
    }

    public void SetHammer(Hammer hammer)
    {
        _hammer = hammer;
    }

    public void SetSaw(Saw saw)
    {
        _saw = saw;
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
        builder.SetHammer(hammer);//here and
        builder.SetSaw(saw);//here
        builder.BuildHouse();
    }
}
