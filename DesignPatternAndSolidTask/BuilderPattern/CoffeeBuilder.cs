using DesignPatternAndSolidTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.BuilderPattern
{
    internal class CoffeeBuilder : ICoffeeBuilder
    {
        private Coffee _coffee { get; set; }
        public ICoffeeBuilder Build(Coffee coffee)
        {
            _coffee = coffee;
            return this;
        }
        public ICoffeeBuilder AddShot()
        {
            _coffee.NumberOfShots++;
            if(_coffee.NumberOfShots == 5)
            {
                throw new ArgumentException("you got the maximum number of shots");
            }
            return this;
        }

        public ICoffeeBuilder WithCream(WhippedCreamType WhippedCream)
        {
            _coffee.WhippedCream = WhippedCream.ToString();
            return this;
        }

        public ICoffeeBuilder WithMilkType(MilkType milkType)
        {
            _coffee.MilkType = milkType.ToString();
            return this;
        }

        public ICoffeeBuilder WithSize(CoffeeSize size)
        {
            _coffee.Size = size.ToString();
            return this;
        }

        public ICoffeeBuilder WithSyrup(string syrupFlavor)
        {
            _coffee.SyrupFlavor = syrupFlavor;
            return this;
        }

        public ICoffeeBuilder WithTemperature(TemperatureType temperature)
        {
            _coffee.Temperature = temperature.ToString();
            return this;
        }
    }
}
