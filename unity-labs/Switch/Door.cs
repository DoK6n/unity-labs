namespace unity_labs.Switch;

public class Door: ISwitchable
{
    private bool _isActive;
    public bool IsActive => _isActive;

    public void Activate()
    {
        _isActive = true;
        Console.WriteLine("the door is open.");
    }

    public void Deactivate()
    {
        _isActive = false;
        Console.WriteLine("the door is closed.");
    }
}