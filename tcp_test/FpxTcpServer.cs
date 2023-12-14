using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace tcp_test
{
    public class FpxTcpServer
    {
        private int port { get; set; }
        private TcpListener listener;
        private Socket client;
        private volatile bool shutdownReq = false;
        public FpxTcpServer(int _port)
        {
            port = _port;
        }
        
        public void StartServer()
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Thread thr = new Thread(() =>
            {
                while (!shutdownReq)
                {
                    while (listener.Pending())
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        Thread clientThread = new Thread(() =>
                        {
                            var stream  = client.GetStream();
                            byte[] buffer = new byte[1024];
                            int i = 0;
                            string data = null;
                            while (client.Connected)
                            {
                                if((i= stream.Read(buffer,0, buffer.Length))>0)
                                {
                                    data = System.Text.Encoding.ASCII.GetString(buffer, 0, i);

                                }
                                Thread.Sleep(10);
                            }
                        });
                        clientThread.Start();
                    }
                }
            });
            thr.Start();
        }


    }
}
