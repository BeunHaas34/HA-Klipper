namespace AppModel;

[NetDaemonApp]
public class KlipperApp : IInitializable
{
    // This will be populated from the yaml with same name
    public string? Klipper_ip { get; set; }

    private readonly IHaContext _ha;
    public KlipperApp(IHaContext ha) => _ha = ha;

    public void Initialize()
    {
        // The properties is not populated in constructor so it needs to be in the
        // Initialize function.
        _ha.CallService("notify", "persistent_notification", data: new { message = HelloMessage, title = "Klipper app!" });
    }
}