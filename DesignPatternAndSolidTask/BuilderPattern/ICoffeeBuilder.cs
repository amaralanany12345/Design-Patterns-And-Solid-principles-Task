using DesignPatternAndSolidTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.BuilderPattern
{
    internal interface ICoffeeBuilder
    {
        ICoffeeBuilder WithSize(CoffeeSize size);
        ICoffeeBuilder AddShot();
        ICoffeeBuilder WithSyrup(string syrupFlavor);
        ICoffeeBuilder WithTemperature(TemperatureType temperature);
        ICoffeeBuilder WithCream(WhippedCreamType WhippedCream);
        ICoffeeBuilder WithMilkType(MilkType milkType);
        ICoffeeBuilder Build(Coffee coffee);
    }
}
