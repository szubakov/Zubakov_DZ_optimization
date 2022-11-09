using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubakov_DZ_Spirin.Models
{
    public class SolverConstraint
    {
        public string Name { get; set; }

        // Lower bound
        public double Lb { get; set; }

        // Upper bound
        public double Ub { get; set; }
    }
}
