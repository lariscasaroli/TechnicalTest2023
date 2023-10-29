namespace TesteTecnico2023.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class Vehicle
    {
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double WeightSupported { get; set; }
        public double Frete { get; set; }
        public double Autonomy { get; set; }
        public string FuelType { get; set; }

        public abstract string Type();

        public virtual void showInfo()
        {
            Console.WriteLine($"Tipo: {Type()}, Marca: {Brand}, Modelo: {ModelName}, Rodas: {Wheels}, Autonomia: {Autonomy}, Frete {Frete}");
        }

        public Vehicle()
        {
        }
    }
}
