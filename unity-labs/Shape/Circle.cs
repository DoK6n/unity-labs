namespace unity_labs.Shape;

public class Circle : Shape
{
    public float Radius { get; set; }
    public override float CalculateArea()
    {
        return Radius * Radius * MathF.PI;
    }
}