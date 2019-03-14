using System;	
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(IPAddress.Any, 8080);
            Byte[] senddata = Encoding.ASCII.GetBytes("Hello World");
            udpClient.Send(senddata, senddata.Length);
        }
    }
}
