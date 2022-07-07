using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    class TypeMes
    {
        public static string photo { get; } = "photo";
        public static string text { get; } = "text";
        private string _type;
        public string Get() => _type;
        public void Photo() => _type = photo;
        public void Text() => _type = text;
    }
}
