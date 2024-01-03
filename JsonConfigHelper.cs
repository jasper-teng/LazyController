using ArisakaController;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LazyController
{
    static public class JsonConfigHelper
    {
        static public RoutesArrayJson ReadJson()
        {
            //we are changing this to the folder its in
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

        public static bool DuplicateRoutes(RoutesArrayJson json)
        {
            return json.routes.GroupBy(x => x.Route).All(g => g.Count() != 1);
        }

        //check for a valid route using a string
        public static bool VerifyRoutes(string route)
        {
            RoutesArrayJson json = ReadJson();

            if(json == null)
            {
                return false;
            }

            return json.routes.Any(x => x.name == route);

        }

        public static string ConvertToParameters() //used for passing into the website with parameters
        {
            var param = "";
            RoutesArrayJson routes = ReadJson();
            foreach(var (value, i) in routes.routes.Select((value, i) => (value, i)))
            {
                //get the route and the name
                param += $"nrpname{i}={value.name}&nrproute{i}={value.Route}&";
            }
            return param;
        }
    }
}
