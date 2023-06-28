using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyController
{
    static class JsonConfigHelper
    {
        static RoutesArrayJson ReadJson()
        {

            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LazyControllerRoutes.ini";
            string jsonData = File.ReadAllText(docpath);


            if(jsonData == null)
            {
                return new RoutesArrayJson(); //NULL REFERENCE BABEY
            }
            else
            {
                return JsonConvert.DeserializeObject<RoutesArrayJson>(jsonData);
            }

        }

        static void WriteJson(RoutesArrayJson json)
        {
            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LazyControllerRoutes.ini";
            string jsonData = JsonConvert.SerializeObject(json, Formatting.Indented);

            File.WriteAllText(docpath, jsonData);

            Console.WriteLine("New JSON file created.");
        }



/*
        public void initJson()
        {

            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LazyControllerRoutes.ini";

            if (File.Exists(docpath))
            {
                // Read the JSON file
                string jsonData = File.ReadAllText(docpath);

                // Deserialize the JSON data into an object
                var data = JsonConvert.DeserializeObject<RoutesArrayJson>(jsonData);

                // Do something with the data

            }
            else
            {
                //sample text
                var piss = new RoutesArrayJson();

                piss.routes.Add(new RoutesJson() { FunctionType = "asdasdasdsad" });
                piss.routes.Add(new RoutesJson() { FunctionType = "ball" });
                piss.routes[0] = (new RoutesJson() { FunctionType = "shkadjlaskdjlaskdjlasdkljasdkljaskdjl" });

                // Serialize the object into JSON data
                string jsonData = JsonConvert.SerializeObject(piss, Formatting.Indented);

                // Write the JSON data to a file
                File.WriteAllText(docpath, jsonData);

                Console.WriteLine("New JSON file created.");
            }
        }*/

    }
}
