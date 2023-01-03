using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public class Files
    {
        public static void create()
        {
            if(!Directory.Exists("FinalAssignment"))
            {
                Directory.CreateDirectory("FinalAssignment");
                Console.WriteLine("created");
            }
            else
            {
                Console.WriteLine("Folder Exists");
            }
            if(!File.Exists("FinalAssignment/PatientDetails.csv"))
            {
                File.Create("FinalAssignment/PatientDetails.csv");
                Console.WriteLine("Folder created");
            }
            else
            {
                Console.WriteLine("Folder Exist");
            }
            if(!File.Exists("FinalAssignment/DoctorDetails.csv"))
            {
                File.Create("FinalAssignment/DoctorDetails.csv");
                Console.WriteLine("Folder created");
            }
            else
            {
                Console.WriteLine("Folder Exist");
            }
            if(!File.Exists("FinalAssignment/DepartmentDetails.csv"))
            {
                File.Create("FinalAssignment/DepartmentDetails.csv");
                Console.WriteLine("Folder created");
            }
            else
            {
                Console.WriteLine("Folder Exist");
            }
            if(!File.Exists("FinalAssignment/AppoinementDetails.csv"))
            {
                File.Create("FinalAssignment/AppoinementDetails.csv");
                Console.WriteLine("Folder created");
            }
            else
            {
                Console.WriteLine("Folder Exist");
            }
            
        }
        public static void ReadToCSV()
        {
            string[] PatientDetails=File.ReadAllLines("FinalAssignment/PatientDetails.csv");
            foreach(string data in PatientDetails)
            {
                PatientDetails patient=new PatientDetails(data);
                Operation.patientList.Add(patient);
            }
            
            string[] DoctorDetails=File.ReadAllLines("FinalAssignment/DoctorDetails.csv");
            foreach(string data in DoctorDetails)
            {
                DoctorDetails doctor=new DoctorDetails(data);
                Operation.doctorList.Add(doctor);
            }

            string[] AppoinementDetails=File.ReadAllLines("FinalAssignment/AppoinementDetails.csv");
            foreach(string data in AppoinementDetails)
            {
                AppoinementDetails appointment=new AppoinementDetails(data);
                Operation.appoinementList.Add(appointment);
            }
            string[] DepartmentDetails=File.ReadAllLines("FinalAssignment/DepartmentDetails.csv");
            foreach(string data in DepartmentDetails)
            {
                DepartmentDetails department=new DepartmentDetails(data);
                Operation.departmentList.Add(department);
            }
        }
        public static void WriteToCSV()
        {
            string[] PatientDetails= new string [Operation.patientList.Count];
            for(int i=0;i<Operation.patientList.Count;i++)
            {
                PatientDetails[i]=Operation.patientList[i].PatientID+","+Operation.patientList[i].Password+","+Operation.patientList[i].PatientName+","+Operation.patientList[i].Age+","+Operation.patientList[i].Gender;

            }
            File.WriteAllLines("FinalAssignment/PatientDetails.csv",PatientDetails);
            
            string[] travleDetails=new string[Operation.doctorList.Count];
            for(int i=0;i<Operation.doctorList.Count;i++)
            {
                travleDetails[i]=Operation.doctorList[i].DoctorID+","+Operation.doctorList[i].Name+","+Operation.doctorList[i].Department+","+Operation.doctorList[i].Count;
            }
            File.WriteAllLines("FinalAssignment/DoctorDetails.csv",travleDetails);
            string[] AppoinementDetails=new string[Operation.appoinementList.Count];
            for(int i=0;i<Operation.appoinementList.Count;i++)
            {
                AppoinementDetails[i]=Operation.appoinementList[i].AppointmentID+","+Operation.appoinementList[i].PatientID+","+Operation.appoinementList[i].DoctorID+","+Operation.appoinementList[i].AppointmentDate.ToString("dd/MM/yyyy")+","+Operation.appoinementList[i].Problem;
            }
            File.WriteAllLines("FinalAssignment/AppoinementDetails.csv",AppoinementDetails);
             string[] DepartmentDetails=new string[Operation.departmentList.Count];
            for(int i=0;i<Operation.departmentList.Count;i++)
            {
                DepartmentDetails[i]=Operation.departmentList[i].DepartmentID+","+Operation.departmentList[i].DepartmentName+","+Operation.departmentList[i].Flag;
            }
            File.WriteAllLines("FinalAssignment/DepartmentDetails.csv",DepartmentDetails);
        }
        
    }
}