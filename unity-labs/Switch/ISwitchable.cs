namespace unity_labs.Switch;

public interface ISwitchable
{
    public bool IsActive { get; }
    public void Activate();
    public void Deactivate();
}