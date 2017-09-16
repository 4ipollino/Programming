using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    bool ok = true;
                    Console.Write("A= ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("OP= ");
                    char op = char.Parse(Console.ReadLine());
                    Console.Write("B= ");
                    double b = double.Parse(Console.ReadLine());
                    double res = 0;

                    ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();

                    switch (op)
                    {
                        case '+': res = client.Add(a, b); break;
                        case '-': res = client.Subtract(a, b); break;
                        case '*': res = client.Multiply(a, b); break;
                        case '/':
                        case ':':
                            if (b != 0)
                            {
                                res = client.Divide(a, b); break;
                            }
                            else goto default;
                        default: ok = false; break;
                    }
                    if (ok) Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
                    else Console.WriteLine("Error!");

                    client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }

            }
            while (true);

        }
    }
}
