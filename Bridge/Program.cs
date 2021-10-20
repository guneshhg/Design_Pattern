using System;

namespace Bridge
{

    public interface ILogWriter
    {
        void LogWrite();
    }

    public class CustomerLog : ILogWriter
    {
        public void LogWrite()
        {
            throw new NotImplementedException();
        }
    }

    public class FirmLog : ILogWriter
    {
        public void LogWrite()
        {
            throw new NotImplementedException();
        }
    }
    

    public class Log
    {
        public ILogWriter _logWriter;
        public Log(ILogWriter logWriter)
        {
            _logWriter = logWriter;
        }
        public virtual void LogWrite()
        {
            _logWriter.LogWrite();
        }
    }


    public class Customer:Log
    {
        public Customer(ILogWriter writer):base(writer)
        {

        }
        public override void LogWrite()
        {
            Console.WriteLine("Customer Added");
            base.LogWrite();
        }
    }


    public class Firm : Log
    {
        public Firm(ILogWriter writer)
        :base(writer)
        {

        }
        public override void LogWrite()
        {
            Console.WriteLine("Firm Added");
            base.LogWrite();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Log logCustomer = new Customer(new CustomerLog());
            logCustomer.LogWrite();

            Log logFirm = new Firm(new FirmLog());
            logFirm.LogWrite();

        }
    }
}
