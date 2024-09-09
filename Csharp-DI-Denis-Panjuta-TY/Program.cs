namespace Csharp_DI_Denis_Panjuta_TY
{

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

        public Builder()
        {
            _hammer = new Hammer();
            _saw = new Saw();
        }

        public void BuildHouse()
        {
            //Builder depends on the hammer and the saw
            // builder is responsible for creating it's tools, namely
            //  its hammer and its saw
            _saw.Use();
            _hammer.Use();
            Console.WriteLine("House Built!");   
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            builder.BuildHouse();
        }
    }
}
