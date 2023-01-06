using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNinja5.Fundamentals
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong>{content}</strong>";
        }
    }
}