namespace unity_labs.Vehicle;

public class RailVehicle : IMovable
{
    public float speed = 100;
    public virtual void GoForward()
    {
        Console.WriteLine("Rail vehicle going forward");
    }

    public virtual void Reverse()
    {
        Console.WriteLine("Rail vehicle reverse");
    }
}