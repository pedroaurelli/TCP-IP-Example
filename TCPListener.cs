using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP_IP_Example;

public class TCPListener
{
    private TcpListener? _tcpListener;

    public TCPListener()
    {
        StartServer();
    }

    private void StartServer()
    {
        var port = 13000;
        var hostAdress = IPAddress.Parse("127.0.0.1");

        _tcpListener = new TcpListener(hostAdress, port);
        _tcpListener.Start();

        var buffer = new byte[256];
        var receivedMessage = string.Empty;

        using TcpClient client = _tcpListener.AcceptTcpClient();

        var tcpStream = client.GetStream();

        var incomingMessage = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

        int readTotal;

        while ((readTotal = tcpStream.Read(buffer, 0, buffer.Length)) != 0)
        {
            receivedMessage = Encoding.UTF8.GetString(buffer, 0, readTotal);
            var successfull 

            tcpStream.Write(buffer, 0, readTotal);
        }
    }
}
