using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WpfXml
{
public    class ResultadoJSON
    {
        public Parameter[]    appSettings { get; set; }
    }
    public class Parameter
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
