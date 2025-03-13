using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MessageDelegate(string name);
class Program
{
    public void Greeting(string name)
    { 
        Console.WriteLine("Welcome to " + name);
    }
    public void Course(string name)
    {
        Console.WriteLine("Registered for "+ name + "course");
    }
    public void EndNote(string name)
    {
        Console.WriteLine("Thanks for joining " + name);
    }

    static void Main()
    {
        Program p=new Program();
        MessageDelegate greet = new MessageDelegate(p.Greeting);
        MessageDelegate course =new MessageDelegate(p.Course);
        MessageDelegate endNote=new MessageDelegate(p.EndNote);

        greet("C#");
        course(".NET");
        endNote("Wipro");
    }
}

