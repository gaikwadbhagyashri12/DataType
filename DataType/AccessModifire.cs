using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    public class person
    {
        protected int EmpId;
        protected string EmpName;
        protected string EmpAdd;
    }
    public class employee : person
    {
        public employee(int EmpId, string EmpName, string empAdd);
        {
        this.EmpId=EmpId;


         }
    }

    internal class AccessModifire
    {
        
        public static void Main()
        {
          

        }
    }
}
