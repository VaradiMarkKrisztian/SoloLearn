using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_application__polymorfsm_
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();
            Console.ReadKey();
        }
        /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */
//startdraw este folosit de IDraw care e in Draw. Deci pt a da override la instruc pt celelalte clase
//trebuie sa scriu path ul pana la interface 
//EX:  class Brush : Draw,IDraw (clasa care o foloseste, interfata folosita de acea clasa)
        public interface IDraw  
        {
            void StartDraw();
        }

        class Draw : IDraw
        {
            public virtual void StartDraw()
            {
                Console.WriteLine("Using pencil");
            }
        }

        //inherit this class from the class Draw
        class Brush : Draw,IDraw
        {
            //implement the StartDraw() method
            public override void StartDraw()
            {
                Console.WriteLine("Using brush");
            }
        }
    
        //inherit this class from the class Draw
        class Spray : Draw,IDraw
        {
            //implement the StartDraw() method
            public override void StartDraw()
            {
                Console.WriteLine("Using spray");
            }
        }
    }
}
