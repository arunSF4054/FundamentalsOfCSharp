using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class AppoinementDetails
    {
        private static int s_appointmentID=300;
        public string AppointmentID{get;}
        public string PatientID{get; set;}
        public string DoctorID{get; set;}
        public DateTime AppointmentDate{get; set;}
        public string Problem{get; set;}
       
       
        public AppoinementDetails(string patientID,string doctorID,DateTime appointmentDate,string problem)
        {
            s_appointmentID++;
            AppointmentID="AID"+s_appointmentID;
            PatientID=patientID;
            DoctorID=doctorID;
            AppointmentDate=appointmentDate;
            Problem=problem;
            
           
        }
        public AppoinementDetails(string data)
        {
            string[] values=data.Split(",");
            s_appointmentID=int.Parse(values[0].Remove(0,3));
            AppointmentID=values[0];
            PatientID=values[1];
            DoctorID=values[2];
            AppointmentDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Problem=values[4];
        }

    }
}