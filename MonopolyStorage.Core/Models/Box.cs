using MonopolyStorage.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Core.Models
{
    public class Box : IBox
    {
        public Box(int id, double width, double height, double depth, double weight)
        {
            ID = id;
            Width = width;
            Height = height;
            Depth = depth;
            Weight = weight;
        }
        public int ID { get; }
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
        public double Weight { get; }
        public double Volume { get => GetVolume(); }

        protected virtual double GetVolume()
        {
            return Width * Height * Depth;
        }

        private DateOnly _expirationDate;
        public DateOnly ExpirationDate
        {
            get => GetExpirationDate();
            private set => _expirationDate = value;
        }
        protected virtual DateOnly GetExpirationDate()
        {
            if (ProductionDate.HasValue)
            {
                return ProductionDate.Value.AddDays(100);
            }
            return _expirationDate;
        }
        public void SetExpirationDate(DateOnly expirationDate)
        {
            ExpirationDate = expirationDate;
        }
        public DateOnly? ProductionDate { get; private set; }
        public void SetProductionDate(DateOnly productionDate)
        {
            ProductionDate = productionDate;
        }
    }
}
