using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DomainTest;
using Trigonometry.View;

namespace Trigonometry.Controller
{
   public class TriangleController
    {
        private Triangle triangle;
        private TriangleView view;
        
        public TriangleController()
        {
            triangle = new Triangle(1,2,3);
            view = new TriangleView();
        }

        public void Run()
        {
            if (triangle.WasDefaulted)
            {
                view.ShowError("Invalid triangle values. Using default triangle");
            }

            view.ShowTriangle(triangle);
        }
       
    }
}
