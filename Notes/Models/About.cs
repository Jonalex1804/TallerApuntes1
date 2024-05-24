using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;

        public string Nombre => "Jonathan Granja";
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://github.com/Jonalex1804";
        public string Message => "Hola mi nombre es Jonathan pero todos me dicen Jonalex, me gustan los videojuegos, leer y tambien practicar en mis tiempos libres";
    }
}
