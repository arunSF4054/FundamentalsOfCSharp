using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class DoctorDetails
    {
        private static int s_doctorID=1000;
        public string DoctorID{get;}
        public string Name{get; set;}
        public string Department{get; set;}
        
        public int Count{get; set;}
        public DoctorDetails(string name,string department,int count)
        {
            s_doctorID++;
            DoctorID="DID"+s_doctorID;
            Name=name;
            Department=department;
             Count=count;
        }
        public DoctorDetails(string data)
        {
            string[] values=data.Split(",");
            s_doctorID=int.Parse(values[0].Remove(0,3));
            DoctorID=values[0];
            Name=values[1];
            Department=values[2];
            Count=int.Parse(values[3]);
        }
        
    }
}