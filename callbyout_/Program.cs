using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyout_
{
    /*
     * call by out is same sa call by reference that is in call by out 
     * also when formal parameters is modified those modifications
     * will be reflected back to actual parameters.
     * while passing the parameter we should use out keyword.
     * In call by out also we will pass the value with  the help
     * address.
     * out parameter is not required to initilaze in case 
     * if we initialize also CLR will ignore that value.
     * when we will go for call by out?
     * whenever we dont want to pass some value to function
     * but we want to get back the modified value then we will
     * go for call by out.
     * 
     */
    class myclas
    {
        internal void payfee(out int totalfee)
        {
            int admfee = 1500;
            int semfee = 1200;
            totalfee=admfee+semfee;
            Console.WriteLine("total fee is" + totalfee);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclas obj = new myclas();
            int x;
            obj.payfee(out x);
            Console.WriteLine("value of x is" + x);

        }
    }
}
