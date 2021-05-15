using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef2
{
    class EmpSearch
    {
        static void Main()
        {
            sqlpracticeEntities entites = new sqlpracticeEntities();
            int empno;
            Console.WriteLine("Enter Employ No   ");
            empno = Convert.ToInt32(Console.ReadLine());
            EMp result = entites.EMps.Where(x => x.Empno == empno).FirstOrDefault<EMp>();
            Console.WriteLine(result.Empno);
            Console.WriteLine(result.nam);
            Console.WriteLine(result.dept);
        }
    }
}
