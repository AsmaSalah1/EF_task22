using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task22.Model
{
    internal class product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }

    }
}
