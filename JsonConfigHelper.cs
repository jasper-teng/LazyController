using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyController
{
    static public class JsonConfigHelper
    {
        static public RoutesArrayJson ReadJson()
        {
            //we are changing this to Appdata
            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LazyControllerRoutes.json";

            if (!File.Exists(docpath))
            {
                // Create the file
                File.Create(docpath).Close();
            }

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

        public static void WriteJson(RoutesArrayJson json)
        {
            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\LazyControllerRoutes.json";
            string jsonData = JsonConvert.SerializeObject(json, Formatting.Indented);

            File.WriteAllText(docpath, jsonData);

            Console.WriteLine("New JSON file created.");
        }
    }
}
