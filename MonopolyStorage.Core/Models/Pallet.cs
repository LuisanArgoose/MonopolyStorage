using MonopolyStorage.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Core.Models
{
    public abstract class Pallet : IPallet
    {
        protected readonly List<IBox> _boxes = new List<IBox>();
        public int ID { get; }
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
        public double Weight { get => GetWeight(); }
        protected virtual double GetWeight()
        {
            var palletWeight = 30;
            var boxesWeight = _boxes.Select(x => x.Weight).Sum();
            return palletWeight + boxesWeight;
        }
        public double Volume { get => GetVolume(); }
        protected virtual double GetVolume()
        {
            var palletVolume = Width * Height * Depth;
            var boxesVolume = _boxes.Select(x => x.Volume).Sum();
            return palletVolume + boxesVolume;
        }
        public DateOnly? ExpirationDate { get => GetExpirationDate(); }

        protected virtual DateOnly? GetExpirationDate()
        {
            if(_boxes.Count == 0)
                return null;
            var expirationDate = _boxes.Select(x => x.ExpirationDate).Min();
            return expirationDate;
        }
        public virtual List<IBox> UploadBoxes()
        {
            throw new NotImplementedException();
        }
        public virtual IBox UploadBox(int i)
        {
            throw new NotImplementedException();
        }
        public virtual List<IBox> GetBoxes()
        {
            throw new NotImplementedException();
        }
        public virtual IBox GetBox(int i)
        {
            throw new NotImplementedException();
        }
        public virtual bool AddBox(IBox box)
        {
            if(box.Width > Width || box.Depth > Depth)
                return false;
            _boxes.Add(box);
            return true;
        }
        public virtual bool DeleteBox(IBox box)
        {
            return _boxes.Remove(box);  
        }
        public virtual DateOnly GetLongestExpirationDate()
        {
            throw new NotImplementedException();
        }
    }
}
