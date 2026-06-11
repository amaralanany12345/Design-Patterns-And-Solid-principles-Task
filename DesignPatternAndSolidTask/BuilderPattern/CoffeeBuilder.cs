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
        private readonly Coffee _coffee;

        public CoffeeBuilder()
        {
            _coffee = new Coffee();
        }

        public ICoffeeBuilder AddShot()
        {
            _coffee.NumberOfShots++;
            if(_coffee.NumberOfShots == 0)
            {
                throw new ArgumentException("please add shot to coffee");
            }
            return this;
        }

        public Coffee Build()
        {
            return _coffee;
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
