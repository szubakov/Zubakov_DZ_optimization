using Google.OrTools.LinearSolver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Zubakov_DZ_Spirin.Models
{
    public class DataOutputModel
    {        
        private DataInputModel _DataInput = new DataInputModel();

        public DataOutputModel() { }

        public DataOutputModel(DataInputModel DataInput)
        {
            _DataInput = DataInput;              

            var s = new Stopwatch();
            s.Start();

            for (int i = 0; i < 1; i++)
            {
                SolveProblem();
            }
            s.Stop();           
        }

        private double _Get_opt_X1;
        /// <summary>
        /// X1 оптимальное
        /// </summary>          
        public double Get_opt_X1
        {
            get { return _Get_opt_X1; }
        }

        private double _Get_opt_X2;
        /// <summary>
        /// X2 оптимальное
        /// </summary>          
        public double Get_opt_X2
        {
            get { return _Get_opt_X2; }
        }

        private double _Get_opt_X3;
        /// <summary>
        /// X3 оптимальное
        /// </summary>          
        public double Get_opt_X3
        {
            get { return _Get_opt_X3; }
        }

        private double _Get_objective;
        /// <summary>
        /// Величина целевой функции
        /// </summary>          
        public double Get_objective
        {
            get { return _Get_objective; }
        }
        private double _Value_X1;
        /// <summary>
        /// X1 значение итоговое
        /// </summary>          
        public double Value1_X1
        {
            get { return _Value_X1; }
        }
        private double _Value_X2;
        /// <summary>
        /// X2 значение итоговое
        /// </summary>          
        public double Value1_X2
        {
            get { return _Value_X2; }
        }
        private double _Value_X3;
        /// <summary>
        /// X3 значение итоговое
        /// </summary>          
        public double Value1_X3
        {
            get { return _Value_X3; }
        }
        private double _Value_X4;
        /// <summary>
        /// X4 значение итоговое
        /// </summary>          
        public double Value1_X4
        {
            get { return _Value_X4; }
        }
        private double _Value_X5;
        /// <summary>
        /// X5 значение итоговое
        /// </summary>          
        public double Value1_X5
        {
            get { return _Value_X5; }
        }
        private double _Value_X6;
        /// <summary>
        /// X6 значение итоговое
        /// </summary>          
        public double Value1_X6
        {
            get { return _Value_X6; }
        }

        private double _Vaste_X1;
        /// <summary>
        /// Отходы 1
        /// </summary>          
        public double Vaste_X1
        {
            get { return _Vaste_X1; }
        }
        private double _Vaste_X2;
        /// <summary>
        /// Отходы 2
        /// </summary>          
        public double Vaste_X2
        {
            get { return _Vaste_X2; }
        }
        private double _Vaste_X3;
        /// <summary>
        /// Отходы 3
        /// </summary>          
        public double Vaste_X3
        {
            get { return _Vaste_X3; }
        }
        private double _Vaste_X4;
        /// <summary>
        /// Отходы 4
        /// </summary>          
        public double Vaste_X4
        {
            get { return _Vaste_X4; }
        }
        private double _Vaste_X5;
        /// <summary>
        /// Отходы 5
        /// </summary>          
        public double Vaste_X5
        {
            get { return _Vaste_X5; }
        }
        private double _Vaste_X6;
        /// <summary>
        /// Отходы 6
        /// </summary>          
        public double Vaste_X6
        {
            get { return _Vaste_X6; }
        }

        private void SolveProblem()
        {
            var rawData = new List<SolverVar>();

            // Исходные данные задачи
            //rawData.Add(new SolverVar { xId = 1, Koef = 2, Min = 0, Max = 10, ConstraintKoefs = new double[] { 1, 2 } });
            //rawData.Add(new SolverVar { xId = 2, Koef = -3, Min = 0, Max = 100, ConstraintKoefs = new double[] { 2, 10 } });
            //rawData.Add(new SolverVar { xId = 3, Koef = 4, Min = 0, Max = 20, ConstraintKoefs = new double[] { 3, -5 } });

            

            //var rawConstraints = new List<SolverConstraint>()
            //{
            //    new SolverConstraint { Name = "Constraint 1", Lb = double.NegativeInfinity, Ub = 900 },
            //    new SolverConstraint { Name = "Constraint 2", Lb = double.NegativeInfinity, Ub = 950 }
            //};

            var rawConstraints = new List<SolverConstraint>()
            {
                new SolverConstraint { Name = "Constraint 1", Lb = double.NegativeInfinity, Ub = _DataInput.Length_prokata },
                new SolverConstraint { Name = "Constraint 2", Lb = double.NegativeInfinity, Ub = _DataInput.Necc_amount }
            };

            // Create linear solver
            Solver solver = Solver.CreateSolver("GLOP");

            if (solver is null)
            {
                //return;
            }

            // Create Variables. Set Min & Max value
            var vars = new List<Variable>();

            for (int i = 0; i < rawData.Count; ++i)
            {
                vars.Add(solver.MakeNumVar(rawData[i].Min, rawData[i].Max, rawData[i].xId.ToString()));
            }

            // Add Constraints
            //  lowerBound ≤ Sum(a(i) x(i)) ≤ upperBound
            var constraints = new List<Constraint>();

            for (int i = 0; i < rawConstraints.Count; ++i)
            {
                var constraint = solver.MakeConstraint(rawConstraints[i].Lb, rawConstraints[i].Ub, rawConstraints[i].Name);

                for (int j = 0; j < vars.Count; ++j)
                {
                    constraint.SetCoefficient(vars[j], rawData[j].ConstraintKoefs[i]);
                }

                constraints.Add(constraint);
            }

            var objective = solver.Objective();

            for (int i = 0; i < vars.Count; ++i)
            {
                objective.SetCoefficient(vars[i], rawData[i].Koef);
            }

            objective.SetMinimization();

            Solver.ResultStatus resultStatus = solver.Solve();

            // Check that the problem has an optimal solution.
            if (resultStatus != Solver.ResultStatus.OPTIMAL)
            {
                //toolStripStatusLabel.Text = "Optimal solution not found. ";

                if (resultStatus == Solver.ResultStatus.FEASIBLE)
                {
                    //toolStripStatusLabel.Text += "Suboptimal solution was found.";
                }
                else
                {
                    //toolStripStatusLabel.Text += "Could not solve the problem.";
                    //return;
                }
            }

            //var reportStr = $"Problem solved in {solver.Iterations()} iterations for {solver.WallTime()} milliseconds.\n" +
            //    $"Objective function value: {objective.Value()}\n\n";
            //
            //for (int i = 0; i < rawData.Count; i++)
            //{
            //    reportStr += $"Optimal value of var {rawData[i].xId} - {vars[i].SolutionValue()}\n";
            //}

            _Get_opt_X1 = vars[0].SolutionValue();
            _Get_opt_X2 = vars[1].SolutionValue();
            _Get_opt_X3 = vars[2].SolutionValue();
            _Get_objective = objective.Value();            
        }     
    }
}
