using System;
using DomainTest;

namespace Trigonometry.View
{
    /// <summary>
    /// Represents the View component in the MVC pattern responsible for displaying
    /// triangle-related data to the user via the console.
    /// </summary>
    public class TriangleView
    {
        /// <summary>
        /// Displays the properties and calculated area of the specified triangle.
        /// </summary>
        /// <param name="t">The <see cref="Triangle"/> object to display.</param>
        public void ShowTriangle(Triangle t)
        {
            Console.WriteLine(t.ToString());
            Console.WriteLine("Area: " + t.Area().ToString("F2"));
        }

        /// <summary>
        /// Displays an error message to the console.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        public void ShowError(string message)
        {
            Console.WriteLine("Error: " + message);
        }
    }
}
