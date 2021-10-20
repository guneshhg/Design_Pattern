using System;

namespace Adapter
{
    


    //The Adapter acts as a wrapper between two objects. It catches calls for one object and transforms them to format and interface recognizable by the second object.

    
    public interface ITarget
    {
        string GetRequest();
    }

    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.GetRequest());


        }
    }
}
