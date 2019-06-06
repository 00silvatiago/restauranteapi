using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Helpers
{
    public class ResponseContent
    {
        public object Object { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public int Skype { get; set; }
        public int Take { get; set; }
    }
}
