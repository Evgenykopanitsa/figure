using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Square : Figure
    {
        public override void Draw()
        {

            Console.Write(
                " ____________\n" +
                "|            |\n" +
                "|            |\n" +
                "|            |\n" +
                "|            |\n" +
                "|            |\n" +
                "|____________|\n");
        }

    }
}