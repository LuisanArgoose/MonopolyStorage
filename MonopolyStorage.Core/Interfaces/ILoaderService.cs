using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Core.Interfaces
{
    public interface ILoaderService
    {
        public List<IGrouping<DateOnly, IPallet>> Group();
        public List<IPallet> VolumeSort();
    }
}
