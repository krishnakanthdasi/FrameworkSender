using NetMQ.Sockets;
using NetMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = new ResponseSocket("@tcp://localhost:5500");

            string message = socket.ReceiveFrameString();
            Console.WriteLine("Message : " + message);

            Console.ReadLine();
        }
    }
}
