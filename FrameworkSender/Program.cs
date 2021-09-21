using NetMQ.Sockets;
using NetMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkSender
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = new RequestSocket(">tcp://localhost:5500");
            Console.WriteLine("Message : ");
            string message = Console.ReadLine();
            socket.SendFrame(message);

            Console.ReadLine();
        }
    }
}
