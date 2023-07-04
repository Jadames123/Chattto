using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Chattto.WebSocketServices
{
    public class WebSocket
    {
        public WebSocket()
        {
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8000);

            server.Start();

            Console.WriteLine(server.ToString(), Environment.NewLine);
            Console.WriteLine("mierda sapoperros");


            //I also can i try

            TcpClient client = server.AcceptTcpClient();

            client.Close();

            Console.WriteLine("This client is connected");
        }
    }
}
