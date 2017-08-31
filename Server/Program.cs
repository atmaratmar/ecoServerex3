using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class EchoServer
{
    public static void Main()
    {


        TcpListener listener = null;
        try
        {


            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();
            Console.WriteLine("ready...");


            while (true)
            {

                TcpClient client = listener.AcceptTcpClient();

                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;
                String t = DateTime.Now.ToString("HH:mm:ss");
                string d = DateTime.Now.ToString("yy:MM:dd");
                s = reader.ReadLine();
                if (s == "time")

                {

                    writer.WriteLine("From server -> " + t);
                    writer.Flush();
                }
                else if (s == "date")
                {
                    writer.WriteLine("From server -> " + d);
                    writer.Flush();
                }

                else
                {
                    Console.WriteLine("unknown");
                    writer.Flush();
                }
            }
            //reader.Close();
            //writer.Close();
            //client.Close();


        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        finally
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }
}    // end Main()} // end class definition