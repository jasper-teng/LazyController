using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LazyController
{
    public class RoutesJson
    {
        public string name { get; set; }
        public string configString { get; set; }
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
        PowerOptions,
        OpenWebsite,
        PanicButton,
        VirtualDesktop
    }
}
