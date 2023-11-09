using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine($"{ this.Model}:");
            output.AppendLine($"    {Engine.Model}:");
            output.AppendLine($"        Power: {Engine.Power}");
            if (Engine.Displacement != 0)
            {
                output.AppendLine($"        Displacement: {Engine.Displacement}");
            }
            else if (Engine.Displacement == 0)
            {
                output.AppendLine($"        Displacement: n/a");
            }
            if (Engine.Efficiency != null)
            {
                output.AppendLine($"        Efficiency: {Engine.Efficiency}");
            }
            else if (Engine.Efficiency == null)
            {
                output.AppendLine($"        Efficiency: n/a");
            }
            if (Weight == 0)
            {
                output.AppendLine($"    Weight: n/a");
            }
            else if (Weight != 0)
            {
                output.AppendLine($"    Weight: {Weight}");
            }
            if (Color == null)
            {
                output.AppendLine($"    Color: n/a");
            }
            else if (Color != null)
            {
                output.AppendLine($"    Color: {Color}");
            }
            return output.ToString().Trim();
        }
    }


}

