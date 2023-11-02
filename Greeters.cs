namespace DoSomethingLib;

public interface IGreeter
{
    string Greet(string name);
}

public class HelloGreeter : IGreeter
{
    public string Greet(string name)
    {
        return $"Hello {name}.";
    }
}

public class AhoyGreeter : IGreeter
{
    public string Greet(string name)
    {
        return $"Ahoy there, {name}.";
    }
}