using LazyController.Properties;
using System.Drawing;
using System;
using System.Net;
using System.IO;
using System.Text;
using System.Security.Policy;
using Newtonsoft.Json;
using System.Xml.Linq;
using LazyController;

namespace ControllerServer
{
    public class HttpServer
    {
        public int Port = 6969;

        private HttpListener _listener;

        public void Start()
        {
            //start 
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://*:" + Port.ToString() + "/");
            _listener.Start();
            Receive();
            initJson();
        }

        public void Stop()
        {
            _listener.Stop();
        }

        private void Receive()
        {
            _listener.BeginGetContext(new AsyncCallback(ListenerCallback), _listener);
        }


        private void ListenerCallback(IAsyncResult result)
        {
            if (_listener.IsListening)
            {
                var context = _listener.EndGetContext(result);
                var request = context.Request;

                // do something with the request
                Console.WriteLine($"{request.Url}");

                if(request != null )
                {

                    string responseString = ";";
                    if (request.Url.AbsolutePath == "/balls")
                    {
                        responseString = "<html><body><h1>Hello, World!</h1></body></html>";
                    }
                    else
                    {
                        responseString = "<html><body><h1>Hello, ligma!</h1></body></html>";
                    }
                    //better idea, get json / list of items, map to the url then execute functions
                    //TODO: that

                    byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                    // Set the response headers
                    context.Response.ContentLength64 = buffer.Length;
                    context.Response.ContentType = "text/html";

                    // Write the response
                    context.Response.OutputStream.Write(buffer, 0, buffer.Length);

                    // Close the response
                    context.Response.OutputStream.Close();

                }

                Receive();
            }
        }

/*        private void HandleRequest(HttpListenerRequest request)
        {
            string url = request.Url.AbsolutePath;
        }*/

    }
}