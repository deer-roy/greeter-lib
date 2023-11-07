using Newtonsoft.Json;

namespace DoSomethingLib.Greeters;

public interface IGreeter
{
    string Greet(string name);
    string SerializedMessage(string name);
}

public abstract class AbstractGreeter: IGreeter {
    
    public abstract string Greet(string name);
    public string SerializedMessage(string name) {
        var message = new {
            Message = Greet(name),
        };
        
        return JsonConvert.SerializeObject(message);
    }
}

public class HelloGreeter : AbstractGreeter
{
    public override string Greet(string name)
    {
        return $"Hello {name}.";
    }
}

public class AhoyGreeter : AbstractGreeter
{
    public override string Greet(string name)
    {
        return $"Ahoy there, {name}.";
    }
}

public class HeyGreeter : AbstractGreeter
{
    public override string Greet(string name)
    {
        return $"Well hey there, {name}.";
    }
}

public class HiGreeter : AbstractGreeter
{
    public override string Greet(string name)
    {
        return $"Hi, {name}.";
    }
}
