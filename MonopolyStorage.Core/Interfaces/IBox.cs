using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Core.Interfaces
{
    public interface IBox
    {
        public int ID { get; }
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
        public double Weight { get; }
        public double Volume { get; }

        public DateOnly ExpirationDate { get; }
        public void SetExpirationDate(DateOnly expirationDate);
        public DateOnly? ProductionDate { get; }
        public void SetProductionDate(DateOnly productionDate);



    }
}
