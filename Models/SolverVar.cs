using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubakov_DZ_Spirin.Models
{
    public class SolverVar
    {
        public int xId { get; set; }

        public double Koef { get; set; }

        public double Min { get; set; }

        public double Max { get; set; }

        public double[] ConstraintKoefs { get; set; }
    }
}
