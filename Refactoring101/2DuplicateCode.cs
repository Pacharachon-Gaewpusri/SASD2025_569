using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101;

// 2
public class DuplicateCode
{
    public void Run()
    {
        string name = "Jimmy";
        Console.WriteLine("Owner : " + name);
        Console.WriteLine("...");
        Console.WriteLine("Signed : " + name);
    }
}

