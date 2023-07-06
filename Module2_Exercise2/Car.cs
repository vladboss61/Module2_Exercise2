using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Exercise2;

public sealed class Engine
{
    public string Power { get; set; }
}

public class Car
{
    public Engine Engine { get; set; }

    public Car(Engine engine) // has - a / Aggregation
    {
        Engine = engine;
    }

    public Car() // has - a / Composition
    {
        Engine = new Engine { Power = "V8" };
    }

    public int Speed { get; set; }
}

public class SuperCar : Car // is - a
{
    public string Graphite { get; set; }
}
