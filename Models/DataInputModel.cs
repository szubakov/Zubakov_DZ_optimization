using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zubakov_DZ_Spirin.Models
{
    public class DataInputModel
    {      
        /*
         * Целевая функция:
            2X1 - 3X2 + 4X3 -> min

            Прямые ограничения на X:
            0 <= X1  <=  10
            0 <= X2  <=  100
            0 <= X3  <=  20

            Ограничения-неравенства:
            X1 + 2X2 + 3X3 <= 900
            2X1 + 10X2 - 5X3 <= 950

            Для нахождения максимального значения необходимо поменять 
            знак коэффициентов целевой функции.         
         * */

        #region --- Переменные

        private double _X1;    // закрытая переменная класса 
        /// <summary>
        /// Величина X1
        /// </summary> 
        public double X1
        {
            get { return _X1; }
            set { _X1 = value; }
        }

        private double _X2;    // закрытая переменная класса 
        /// <summary>
        /// Величина X2
        /// </summary> 
        public double X2
        {
            get { return _X2; }
            set { _X2 = value; }
        }

        private double _X3;    // закрытая переменная класса 
        /// <summary>
        /// Величина X3
        /// </summary> 
        public double X3
        {
            get { return _X3; }
            set { _X3 = value; }
        }

        #endregion --- Переменные

       

      

        #region --- Коэффициенты целевой функции

        private double _Koeff_Z_1;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента целевой функции при X1
        /// </summary> 
        public double Koeff_Z_1
        {
            get { return _Koeff_Z_1; }
            set { _Koeff_Z_1 = value; }
        }

        private double _Koeff_Z_2;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента целевой функции при X2
        /// </summary> 
        public double Koeff_Z_2
        {
            get { return _Koeff_Z_2; }
            set { _Koeff_Z_2 = value; }
        }

        private double _Koeff_Z_3;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента целевой функции при X3
        /// </summary> 
        public double Koeff_Z_3
        {
            get { return _Koeff_Z_3; }
            set { _Koeff_Z_3 = value; }
        }

        private double _Koeff_Z_4;
        public double Koeff_Z_4
        {
            get { return _Koeff_Z_4; }
            set { _Koeff_Z_4 = value; }
        }

        private double _Koeff_Z_5;
        public double Koeff_Z_5
        {
            get { return _Koeff_Z_5; }
            set { _Koeff_Z_5 = value; }
        }

        private double _Koeff_Z_6;
        public double Koeff_Z_6
        {
            get { return _Koeff_Z_6; }
            set { _Koeff_Z_6 = value; }
        }
        private double _Square_Z_1;
        public double Square_Z_1
        {
            get { return _Square_Z_1; }
            set { _Square_Z_1 = value; }
        }

        private double _Square_Z_2;
        public double Square_Z_2
        {
            get { return _Square_Z_2; }
            set { _Square_Z_2 = value; }
        }
        private double _Square_Z_3;
        public double Square_Z_3
        {
            get { return _Square_Z_3; }
            set { _Square_Z_3 = value; }
        }
        /// <summary>
        /// Количество заготовок на 1 изделие 1 строка
        /// </summary> 
        private double _Number_Blanks_1;
        public double Number_Blanks_1
        {
            get { return _Number_Blanks_1; }
            set { _Number_Blanks_1 = value; }
        }
        /// <summary>
        /// Количество заготовок на 1 изделие 2 строка
        /// </summary> 
        private double _Number_Blanks_2;
        public double Number_Blanks_2
        {
            get { return _Number_Blanks_2; }
            set { _Number_Blanks_2 = value; }
        }
        /// <summary>
        /// Количество заготовок на 1 изделие 3 строка
        /// </summary> 
        private double _Number_Blanks_3;
        public double Number_Blanks_3
        {
            get { return _Number_Blanks_3; }
            set { _Number_Blanks_3 = value; }
        }
        #endregion --- Коэффициенты целевой функции

        #region --- Коэффициенты в уравнениях ограничений

        private double _ConstraintKoeff_1_X1;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента в 1-м уравнении ограничений при X1
        /// </summary> 
        public double ConstraintKoeff_1_X1
        {
            get { return _ConstraintKoeff_1_X1; }
            set { _ConstraintKoeff_1_X1 = value; }
        }

        private double _ConstraintKoeff_1_X2;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента в 1-м уравнении ограничений при X2
        /// </summary> 
        public double ConstraintKoeff_1_X2
        {
            get { return _ConstraintKoeff_1_X2; }
            set { _ConstraintKoeff_1_X2 = value; }
        }

        private double _ConstraintKoeff_1_X3;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента в 1-м уравнении ограничений при X3
        /// </summary> 
        public double ConstraintKoeff_1_X3
        {
            get { return _ConstraintKoeff_1_X3; }
            set { _ConstraintKoeff_1_X3 = value; }
        }
        private double _ConstraintKoeff_1_X4;
        public double ConstraintKoeff_1_X4
        {
            get { return _ConstraintKoeff_1_X4; }
            set { _ConstraintKoeff_1_X4 = value; }
        }
        private double _ConstraintKoeff_1_X5;
        public double ConstraintKoeff_1_X5
        {
            get { return _ConstraintKoeff_1_X5; }
            set { _ConstraintKoeff_1_X5 = value; }
        }
        private double _ConstraintKoeff_1_X6;
        public double ConstraintKoeff_1_X6
        {
            get { return _ConstraintKoeff_1_X6; }
            set { _ConstraintKoeff_1_X6 = value; }
        }


        private double _ConstraintKoeff_2_X1;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента во 2-м уравнении ограничений при X1
        /// </summary> 
        public double ConstraintKoeff_2_X1
        {
            get { return _ConstraintKoeff_2_X1; }
            set { _ConstraintKoeff_2_X1 = value; }
        }

        private double _ConstraintKoeff_2_X2;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента во 2-м уравнении ограничений при X2
        /// </summary> 
        public double ConstraintKoeff_2_X2
        {
            get { return _ConstraintKoeff_2_X2; }
            set { _ConstraintKoeff_2_X2 = value; }
        }

        private double _ConstraintKoeff_2_X3;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента во 2-м уравнении ограничений при X3
        /// </summary> 
        public double ConstraintKoeff_2_X3
        {
            get { return _ConstraintKoeff_2_X3; }
            set { _ConstraintKoeff_2_X3 = value; }
        }

        private double _ConstraintKoeff_2_X4;
        public double ConstraintKoeff_2_X4
        {
            get { return _ConstraintKoeff_2_X4; }
            set { _ConstraintKoeff_2_X4 = value; }
        }

        private double _ConstraintKoeff_2_X5;
        public double ConstraintKoeff_2_X5
        {
            get { return _ConstraintKoeff_2_X5; }
            set { _ConstraintKoeff_2_X5 = value; }
        }

        private double _ConstraintKoeff_2_X6;
        public double ConstraintKoeff_2_X6
        {
            get { return _ConstraintKoeff_2_X6; }
            set { _ConstraintKoeff_2_X6 = value; }
        }

        #endregion --- Коэффициенты в уравнениях ограничений

        #region --- Столбцы свободных членов в уравнениях ограничений типа неравенств

        private double _Length_prokata;    // закрытая переменная класса 
        /// <summary>
        /// Необходимая длина полосы проката
        /// </summary> 
        public double Length_prokata
        {
            get { return _Length_prokata; }
            set { _Length_prokata = value; }
        }

        private double _Necc_amount;    // закрытая переменная класса 
        /// <summary>
        /// Необходимо количество заготовок
        /// </summary> 
        public double Necc_amount
        {
            get { return _Necc_amount; }
            set { _Necc_amount = value; }
        }

        private double _Constraint_1_Lb;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента свободного члена в 1-м уравнении ограничений (нижний предел)
        /// </summary> 
        public double Constraint_1_Lb
        {
            get { return _Constraint_1_Lb; }
            set { _Constraint_1_Lb = value; }
        }

        private double _Constraint_2_Lb;    // закрытая переменная класса 
        /// <summary>
        /// Величина коэффициента свободного члена во 2-м уравнении ограничений (нижний пределе)
        /// </summary> 
        public double Constraint_2_Lb
        {
            get { return _Constraint_2_Lb; }
            set { _Constraint_2_Lb = value; }
        }

        #endregion --- Столбцы свободных членов в уравнениях ограничений типа неравенств
    }
}
