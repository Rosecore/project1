using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Figure//Для создания дополнительных фигур на основе этого класса нужно будет дописать (если необходимо) дополнительную сторону и переопределить метод C
    {
        public double firstSide { get; set; } // базовый класс фигура создается с 3 сторонами, если необходимо больше сторон для расчета площади или других вычислений, предлагаю добавлять эи переменные в соответствующих классах. 
        public double secondSide { get; set; }
        public double thirdSide { get; set; }
        public bool IsSidesOkey()
        {
            if ((firstSide <= 0) || (secondSide <= 0) || (thirdSide <= 0))
            {
                Console.WriteLine("Внимание, введены некорректные стороны, площадь принимается равной 0");
                return false;
            }
            else return true;
        }
        public virtual double  CalcArea()
        {   if (IsSidesOkey())
                return this.firstSide * this.secondSide;
            else return 0;//Насколько я поняла, это и подразумевается под вычислением площади без знания типа фигуры. Т.е. мы создаем базовую фигуру ( в моем случае похожую на квадрат), и считаем ее площадь.
        }
    }
    public class Triangle : Figure
    {
        private double CalcPerim()
        {
            return (firstSide + secondSide + thirdSide)/2;
        }
        public override double CalcArea()
        {   if (IsSidesOkey())
            {
                if (IsRectengular())
                    return (firstSide + secondSide) / 2;
                else
                    return Math.Sqrt(CalcPerim() * (CalcPerim() - firstSide) * (CalcPerim() - secondSide) * (CalcPerim() - thirdSide));
            }
            else return 0;
        }
        public bool IsRectengular()
        {
            if ((Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2))
                || (Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2))
                || (Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(firstSide, 2)))
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
   
}// я понимаю, что, возможно грамотнее, было бы создавать фигуры и передавать стороны в качестве параметров в конструктор. Но мне показалось более "элегантным" (хотя менее "защищенным") задавать стороны и радиус фигур через поля. 
