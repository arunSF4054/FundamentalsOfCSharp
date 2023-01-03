using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class DepartmentDetails
    {
        private static int s_departmentID=5000;
        public string DepartmentID{get;}
        public string DepartmentName{get; set;}
        public int Flag{get; set;}
        public DepartmentDetails(string departmentName,int flag)
        {
            s_departmentID++;
            DepartmentID="DEPT"+s_departmentID;
            DepartmentName=departmentName;
            Flag=flag;
        }
        public DepartmentDetails(string data)
        {
            string[] values=data.Split(",");
            s_departmentID=int.Parse(values[0].Remove(0,4));
            DepartmentID=values[0];
            DepartmentName=values[1];
            Flag=int.Parse(values[2]);

        }
        
    }
}