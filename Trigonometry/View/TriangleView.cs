using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainTest;

namespace Trigonometry.View
{
    public class TriangleView
    {
        public void ShowTriangle (Triangle t)
        {
            Console.WriteLine(t.ToString());
            Console.WriteLine("Area: " + t.Area().ToString("F2"));
        }
        public void ShowError(string message)
        {
            Console.WriteLine("Error:" + message);
        }
    }
}
