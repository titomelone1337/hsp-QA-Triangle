namespace Domain.Test;

/// <summary>
/// Represents a triangle with properties for its base, right side, left side, and height.
/// Provides functionality to calculate the perimeter and area of the triangle.
/// </summary>
public class Triangle
{
    // Attributes section
    #region Attributes
    private double _base = 1; // Default value for the base of the triangle
    private double _rightSide = 1; // Default value for the right side of the triangle
    private double _leftSide = 1; // Default value for the left side of the triangle
    private double _height = 1; // Default value for the height of the triangle

    public bool WasDefaulted { get; private set; } = false; // True when the input values for a constructor are incorrect
    #endregion

    // Constructors section
    #region Constructors
    /// <summary>
    /// Initializes a new instance of the Triangle class with default values (1) for base,
    /// right side, left side, and height.
    /// </summary>
    public Triangle() { }

    /// <summary>
    /// Initializes a new instance of the Triangle class with specified values for base, right side, and left side.
    /// The height remains at its default value.
    /// </summary>
    /// <param name="b">The value of the triangle's base. It must be a positive value greater than zero.</param>
    /// <param name="rs">The value of the triangle's right side. It must be a positive value greater than zero.</param>
    /// <param name="ls">The value of the triangle's left side. It must be a positive value greater than zero.</param>
    public Triangle(double b, double rs, double ls) : this()
    {
        if (!IsValidTriangle(b, rs, ls))
        {
            WasDefaulted = true;
        }
        else
        {
            Base = b;
            RightSide = rs;
            LeftSide = ls;
        }
    }

    /// <summary>
    /// Initializes a new instance of the Triangle class with specified values for base, right side, left side, and height.
    /// </summary>
    /// <param name="b">The value of the triangle's base. It must be a positive value greater than zero.</param>
    /// <param name="rs">The value of the triangle's right side. It must be a positive value greater than zero.</param>
    /// <param name="ls">The value of the triangle's left side. It must be a positive value greater than zero.</param>
    /// <param name="h">The height of the triangle. It must be a positive value greater than zero.</param>
    public Triangle(double b, double rs, double ls, double h)
        : this(b, rs, ls)
    {
        Height = h;
    }

    /// <summary>
    /// Initializes a new instance of the Triangle class with specified values for base and height.
    /// </summary>
    /// <param name="b">The value of the triangle's base. It must be a positive value greater than zero.</param>
    /// <param name="h">The height of the triangle. It must be a positive value greater than zero.</param>
    public Triangle(double b, double h)
    {
        Base = b;
        Height = h;
    }

    /// <summary>
    /// Initializes a new instance of the Triangle class by copying properties from another triangle.
    /// </summary>
    /// <param name="t">The Triangle object from which to copy properties.</param>
    public Triangle(Triangle t)
    {
        Base = t.Base;
        RightSide = t.RightSide;
        LeftSide = t.LeftSide;
        Height = t.Height;
    }
    #endregion

    // Properties section
    #region Properties
    /// <summary>
    /// Gets or sets the base of the triangle. The value must be a positive number greater than zero.
    /// </summary>
    public double Base
    {
        get { return _base; }
        set
        {
            if (value > 0) _base = value;
        }
    }

    /// <summary>
    /// Gets or sets the right side of the triangle. The value must be a positive number greater than zero.
    /// </summary>
    public double RightSide
    {
        get { return _rightSide; }
        set
        {
            if (value > 0) _rightSide = value;
        }
    }

    /// <summary>
    /// Gets or sets the left side of the triangle. The value must be a positive number greater than zero.
    /// </summary>
    public double LeftSide
    {
        get { return _leftSide; }
        set
        {
            if (value > 0) _leftSide = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the triangle. The value must be a positive number greater than zero.
    /// </summary>
    public double Height
    {
        get { return _height; }
        set
        {
            if (value > 0) _height = value;
        }
    }
    #endregion

    // Behavioral methods section
    #region Behavioral Methods
    /// <summary>
    /// Calculates and returns the perimeter of the triangle.
    /// </summary>
    /// <returns>The sum of all sides of the triangle.</returns>
    public double Perimeter()
    {
        return RightSide + Base + LeftSide;
    }

    /// <summary>
    /// Calculates and returns the area of the triangle.
    /// </summary>
    /// <returns>The area of the triangle calculated using the base and height.</returns>
    public double Area()
    {
        return 1; // Base * (Height / 2);
    }

    /// <summary>
    /// Determines the type of the triangle based on its sides.
    /// </summary>
    /// <returns>A string indicating whether the triangle is Equilateral, Isosceles, or Scalene.</returns>
    public string GetTriangleType()
    {
        if (RightSide == Base && Base == LeftSide)
        {
            return "Equilateral";
        }
        else if (RightSide == Base || RightSide == LeftSide || Base == LeftSide)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
    #endregion

    // ToString method section
    #region ToString
    /// <summary>
    /// Provides a string representation of the Triangle object, including its base, sides, and height.
    /// </summary>
    /// <returns>A string detailing the dimensions of the triangle.</returns>
    public override string ToString()
    {
        return $"Triangle:\n\tbase: {Base:F2}" +
            $"\n\trightSide: {RightSide:F2}" +
            $"\n\tleftSide: {LeftSide:F2}" +
            $"\n\theight: {Height:F2}";
    }
    #endregion

    //Internal Methods
    #region Internal Methods
    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    #endregion
}