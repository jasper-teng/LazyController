using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyController
{
    public class RoutesJson
    {
        public string filePath { get; set; }
        public string Route { get; set; }
        public FunctionType FunctionType { get; set; }
    }

    public class RoutesArrayJson
    {
        public List<RoutesJson> routes = new List<RoutesJson>();
    }

    public enum FunctionType
    {
        LaunchProgram,
        ToggleVolume,
        SetPcToHibernate,
        SetPcToStandby
    }
}
