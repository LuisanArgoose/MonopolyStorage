using MonopolyStorage.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Models
{
    public class MyBox : Box
    {
        public MyBox(int id, double width, double height, double depth, double weight) : base(id, width, height, depth, weight)
        {
        }
        protected override double GetVolume()
        {
            return base.GetVolume() + 5;
        }
    }
}
