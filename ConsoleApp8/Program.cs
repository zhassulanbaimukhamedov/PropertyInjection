using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object
            Service1 s1 = new Service1();

            Client client = new Client();
            client.Service = s1; //passing dependency
                                 //TO DO:
            client.ServeMethod();

            Service2 s2 = new Service2();
            client.Service = s2; //passing dependency
                                 //TO DO:
            client.ServeMethod();

            Console.Read();
        }
    }
    public interface IService
    {
        void Serve();
    }
    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }
    }
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }
    public class Client
    {
        private IService _service;
        public IService Service
        {
            set { this._service = value; }
        }
        public void ServeMethod()
        {
            this._service.Serve();
        }
    }
}
