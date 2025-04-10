using System;
using DomainTest;
using Trigonometry.View;

namespace Trigonometry.Controller
{
    /// <summary>
    /// Represents the Controller component in the MVC pattern.
    /// Responsible for handling the logic between the Triangle model and the TriangleView.
    /// </summary>
    public class TriangleController
    {
        /// <summary>
        /// The Triangle model instance used for calculations.
        /// </summary>
        private Triangle triangle;

        /// <summary>
        /// The view used to display triangle data and messages to the user.
        /// </summary>
        private TriangleView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="TriangleController"/> class.
        /// Creates a sample Triangle and its corresponding view.
        /// </summary>
        public TriangleController()
        {
            triangle = new Triangle(1, 2, 3);
            view = new TriangleView();
        }

        /// <summary>
        /// Runs the main logic of the controller.
        /// Validates the triangle and delegates output to the view.
        /// </summary>
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
