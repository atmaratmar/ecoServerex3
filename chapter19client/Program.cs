using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class EchoClient
{
    public static void Main()
    {
        try
        {
            
            
                //TcpClient client = new TcpClient("127.0.0.1", 8080);
                //StreamReader reader = new StreamReader(client.GetStream());  move it from here to make a loop

                //StreamWriter writer = new StreamWriter(client.GetStream());
                //String s = String.Empty;
                while (true)
                {
                TcpClient client = new TcpClient("127.0.0.1", 8080);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;

                s = Console.ReadLine();
                    Console.WriteLine();
                    writer.WriteLine(s);
                    writer.Flush();
                    String server_string = reader.ReadLine();
                    Console.WriteLine(server_string);

                }
            
            //reader.Close();
            //writer.Close();
            //client.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    } // end Main()
} // end class definition