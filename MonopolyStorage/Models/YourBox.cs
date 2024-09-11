using MonopolyStorage.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyStorage.Models
{
    public class YourBox : Box
    {
        public YourBox(int id, double width, double height, double depth, double weight) : base(id, width, height, depth, weight)
        {
        }
    }
}
