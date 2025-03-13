using AspDotNetCoreDependencyInjection.Models;

namespace AspDotNetCoreDependencyInjection.Models
{
    public interface IGreetingService
    {
        string Greeting(string name);

    }
    public class GreetingService : IGreetingService
    {
        public string Greeting(string name)
        {
            return $"Hello,{name}";

        }
    }
}
