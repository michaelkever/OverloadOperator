using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadOperator
{
    class Employee
    {
        public struct EmployeeId
        {
            public int employee01;
            public int employee02;

            public employeeId(int employee01, int employee02)
            {
                this.employee01 = employee01;
                this.employee02 = employee02;
            }
            public static bool operator == (EmployeeId employeeId)
            {
                if (employeeId.employee01 == employeeId.employee02)
                {
                    return true;
                }
                return false;
            }

            public static bool operator != (EmployeeId employeeId)
            {
                return !(employeeId.employee01 == employeeId.employee02);
            }

            public override bool Equals(object emp)
            {
                if (!(emp is EmployeeId))
                {
                    return false;
                }
                return this == (EmployeeId)emp;
            }
        }
    }
}

       
        


        
    
