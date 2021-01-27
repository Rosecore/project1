using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Figure
    {
        public int hight { get; set; }
        public int widht { get; set; }
        public virtual double  CalcArea()
        {
            return this.hight * this.widht; //Насколько я поняла, это и подразумевается под вычислением площади без знания типа фигуры. Т.е. мы создаем базовую фигуру ( в моем случае похожую на квадрат), и считаем ее площадь.
        }
    }
    public class Triange : Figure
    {
        public int firstSide { get; set; }
        public int secondSide { get; set; }
        public int thirdSide { get; set; }
        private double CalcPerim()
        {
            return (this.firstSide + this.secondSide + this.thirdSide)/2;
        }
        public override double CalcArea()
        {

            return Math.Sqrt(CalcPerim() * (CalcPerim() - this.firstSide) * (CalcPerim() - this.secondSide) * (CalcPerim() - this.thirdSide));
        }
        public bool IsRectengular()
        {
            if ((Math.Pow(this.firstSide, 2) == Math.Pow(this.secondSide, 2) + Math.Pow(this.thirdSide, 2))
                || (Math.Pow(this.secondSide, 2) == Math.Pow(this.firstSide, 2) + Math.Pow(this.thirdSide, 2))
                || (Math.Pow(this.thirdSide, 2) == Math.Pow(this.secondSide, 2) + Math.Pow(this.firstSide, 2)))
                return true;
            else return false;
        }
    }
    public class Circle : Figure
    {
        public int radius { get; set; }
        public override double CalcArea()
        {
            return Math.Pow(this.radius, 2) * Math.PI;
        }

    }
   
}
