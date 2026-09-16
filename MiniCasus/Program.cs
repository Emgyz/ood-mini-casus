using System.Data;

class Campus
{
    public string name {get; set;}
    private List<Building> buildings { get; set; }
    
    Campus(string name)
    {
        this.name = name;
        this.buildings = new List<Building>();
    }
}

class Building
{
    public string name {get; set;}
    private List<Zone> zones { get; set; }
    
    Building(string name)
    {
        this.name = name;
        this.zones = new List<Zone>();
    }
}

class Zone
{
    public string name {get; set;}
    private List<Rule> rules { get; set; }
    private List<MotorComponent> motors { get; set; }
    private List<SensorComponent> sensors { get; set; }
    
    Zone(string name)
    {
        this.name = name;
        this.rules = new List<Rule>();
        this.motors = new List<MotorComponent>();
        this.sensors = new List<SensorComponent>();
    }
}

class  Rule
{
    public string name { get; set; }
    private string messageOnOffence { get; set; }

    public void notifyOnOffence()
    {
        Console.WriteLine(this.messageOnOffence);
    }
    
    Rule(string name, string messageOnOffence)
    {
        this.name = name;
        this.messageOnOffence = messageOnOffence;
    }
}

class HardwareComponent
{
    void logEvent()
    {
        
    }


}

class MotorComponent : HardwareComponent
{
    MotorComponent()
    {
        
    }
}

class SensorComponent : HardwareComponent
{
    
}