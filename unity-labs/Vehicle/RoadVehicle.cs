namespace unity_labs.Vehicle;

public class RoadVehicle : IMovable, ITurnable
{
    public float speed = 100f;
    public float turnSpeed = 5f;

    public virtual void GoForward()
    {
        Console.WriteLine("Forward");
    }

    public virtual void Reverse()
    {
        Console.WriteLine("Reverse");
    }

    public virtual void TurnLeft()
    {
        Console.WriteLine("TurnLeft");
    }

    public virtual void TurnRight()
    {
        Console.WriteLine("TurnRight");
    }
}