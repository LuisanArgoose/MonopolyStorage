using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Core.Interfaces
{
    public interface IPallet
    {

        public int ID { get; }
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
        public double Weight { get; }
        public double Volume { get; }
        public DateOnly? ExpirationDate { get; }
        public List<IBox> UploadBoxes();
        public IBox UploadBox(int i);
        public List<IBox> GetBoxes();
        public IBox GetBox(int i);
        public bool AddBox(IBox box);
        public bool DeleteBox(IBox box);
        public DateOnly GetLongestExpirationDate();

    }
}
