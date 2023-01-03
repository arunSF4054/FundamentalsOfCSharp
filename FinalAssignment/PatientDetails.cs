using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public enum Gender{Male,Female}
    public class PatientDetails
    {
        private static int s_patientID=100;
        public string PatientID{get;}
        public string Password{get; set;}
        public string PatientName{get; set;}
        public int Age{get; set;}
        public Gender Gender{get; set;}
        public PatientDetails(string password,string patientName,int age,Gender gender)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Password=password;
            PatientName=patientName;
            Age=age;
            Gender=gender;
        }
        public PatientDetails(string data)
        {
            string[] values=data.Split(",");
            s_patientID=int.Parse(values[0].Remove(0,3));
            PatientID=values[0];
            Password=values[1];
            PatientName=values[2];
            Age=int.Parse(values[3]);
            Gender=Enum.Parse<Gender>(values[4]);
        }


        
    }
}