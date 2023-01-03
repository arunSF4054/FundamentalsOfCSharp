using System.Data;
using System.Runtime.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
     
    public class Operation
    {
         public static CustomList<PatientDetails> patientList=new CustomList<PatientDetails>();
        public static  CustomList<DoctorDetails> doctorList=new  CustomList<DoctorDetails>();
        public static  CustomList<AppoinementDetails> appoinementList=new  CustomList<AppoinementDetails>();
        public static  CustomList<DepartmentDetails> departmentList=new  CustomList<DepartmentDetails>();
        public static PatientDetails CurrentPatient;
         
        public static void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("********ManiMenu***********");
                Console.WriteLine("\t1.UserRegisteration\n\t2.UserLogin\n\t3.Exit");
                Console.WriteLine("Enter your choice=");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("********Registeration Page*************");
                        Registeration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("**************Login Page*************");
                         Login();
                        break;
                    }
                   
                    case 3:
                    {
                        Console.WriteLine("**************Exit From MainMenu***********");
                        break;
                    }
                }
            }while(choice!=3);
        }
        static void SubMenu()
        {
            int choice;
            do
            {
                
                Console.WriteLine("********SubMenu***********");
                Console.WriteLine("\t1.Book Appoinment\n\t2.View My Appoinment\n\t3.Edit My Profile\n\t4.Exit");
                Console.WriteLine("Enter your choice");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("********Book Appoinment*************");
                        BookAppoinment();
                        
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("**************Appoinement History*************");
                        AppoinementHistory();
                         
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("**************Edit My Profile*************");
                        EditMyProfile();
                        
                        break;
                    }
                    
                    case 4:
                    {
                        Console.WriteLine("**************Exit From SubMenu***********");
                        break;
                    }
                }
            }while(choice!=4);

        }
        public static void DefaultData()   //Default values
        {
            PatientDetails patient1=new PatientDetails("Welcome","Arun",21,Gender.Male);
            patientList.Add(patient1);
             PatientDetails patient2=new PatientDetails("Welcome","Sathya",21,Gender.Female);
            patientList.Add(patient2);
            DoctorDetails doctor1=new DoctorDetails("Nancy","Anaesthesiology",1);
            doctorList.Add(doctor1);
             DoctorDetails doctor2=new DoctorDetails("Andrew","Cardiology",0);
            doctorList.Add(doctor2);
             DoctorDetails doctor3=new DoctorDetails("Janet","Diabetology",1);
            doctorList.Add(doctor3);
             DoctorDetails doctor4=new DoctorDetails("Markart","Neonatology",0);
            doctorList.Add(doctor4);
             DoctorDetails doctor5=new DoctorDetails("Steven","Nephrology",1);
            doctorList.Add(doctor5);
            AppoinementDetails appointment=new AppoinementDetails(patient1.PatientID,doctor1.DoctorID,DateTime.Now,"Cancer");
            appoinementList.Add(appointment);
            AppoinementDetails appointment2=new AppoinementDetails(patient2.PatientID,doctor2.DoctorID,DateTime.Now,"Cancer");
            appoinementList.Add(appointment2);
            DepartmentDetails department1=new DepartmentDetails("Anaesthesiology",0);
            DepartmentDetails department2=new DepartmentDetails("Cardiology",0);
            DepartmentDetails department3=new DepartmentDetails("Diabetology",0);
            DepartmentDetails department4=new DepartmentDetails("Neonatology",0);
            DepartmentDetails department5=new DepartmentDetails("Nephrology",0);
            departmentList.Add(department1);
            departmentList.Add(department2);
            departmentList.Add(department3);
            departmentList.Add(department4);
            departmentList.Add(department5);
            
            
            
            
            
        }
        static void Registeration()
        {
            Console.Write("Enter the Password=");
            string password=Console.ReadLine();
            Console.Write("Enter your Name=");
            string name=Console.ReadLine();
            Console.Write("Enter your Age=");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter your Gender(Male/Female)=");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            PatientDetails patient=new PatientDetails(password,name,age,gender);
            patientList.Add(patient);
            Console.WriteLine($"Your Registeration Done Successfully.Your ID is {patient.PatientID}");
        }
        static void Login()
        {
            bool temp=true,temp1=true;
            Console.WriteLine("Enter your Patient ID to Login=");
            string loginID=Console.ReadLine().ToUpper();
            foreach(PatientDetails patientInfo in patientList)
            {
                if(loginID==patientInfo.PatientID)  //check whether user id is exist in Patient Details or not if exist move forward
                {
                    Console.WriteLine("Enter the Password=");
                    string newPassword=Console.ReadLine();
                    if(CurrentPatient.Password==newPassword)  //check the password is valid or not
                    {
                        temp1=false;
                    Console.WriteLine("Login Successfully");
                    temp=false;
                    CurrentPatient=patientInfo;  //store the patient details to the curent patient
                    SubMenu();
                    }

                }
            }
            if(temp1)
            {
                Console.WriteLine("Invalid Password");
            }
            if(temp)  //if the ID not exist so invalid ID
            {
                Console.WriteLine("Invalid ID");
            }

        }
        static void BookAppoinment()
        {
            bool temp=true,check=true;
            foreach(DepartmentDetails department in departmentList) //Display the department Details
            {
                Console.WriteLine($"Department ID={department.DepartmentID} DepartmentName={department.DepartmentName}");
            }
            Console.WriteLine("Enter the Department ID ");  //Ask the department ID from the user
            string newDepartmentID=Console.ReadLine().ToUpper();
             foreach(DepartmentDetails department in departmentList)
            {
                if(newDepartmentID==department.DepartmentID)  //check whether the department ID is valid or not
                {
                    check=false;    //if ID exist change check to false
                }
            }
            if(check==false)
            {

           
                    foreach(DoctorDetails doctor in doctorList) //if departmet id exist show the doctor details
                    {
                        Console.WriteLine($"DoctorID={doctor.DoctorID}  Name={doctor.Name}");
                    }
                    Console.WriteLine("Enter the doctor ID=");   //ask the doctor id from user
                    string newDoctorID=Console.ReadLine().ToUpper();
                    Console.WriteLine("Enter your problem");
                    string problem=Console.ReadLine();
                    foreach(DoctorDetails doctorInfo in doctorList)
                    {
                        if(newDoctorID==doctorInfo.DoctorID)  //check the id is exist or not
                        {
                            if(doctorInfo.Count<=2)  //Check the doctor already has a two appointment or not
                            {
                                temp=false; 
                                                             //if doctor has a less than two appointment show this to the user                            
                                  Console.WriteLine($"Your appointment Booked for {DateTime.Now.ToShortDateString()}");
                                Console.WriteLine("Press Y to Book or Press N to cancel=");  //ask the user to conformation for the booking
                                string option=Console.ReadLine().ToLower();                 //if user enter yes confirm the booking otherwise return to submenu
                                if(option=="y")
                                {
                                    AppoinementDetails appointment=new AppoinementDetails(CurrentPatient.PatientID,doctorInfo.DoctorID,DateTime.Now,problem);
                                    appoinementList.Add(appointment);
                                    Console.WriteLine("Booked SuccessFully");
                                    doctorInfo.Count++;   //increase the doctor appointment 

                                }
                            }
                        }
                    
            }
            } 
            if(check)
            {
                Console.WriteLine("Invalid ID");
            }  
            if(temp)
            {
                Console.WriteLine("Doctor Already has a two Bookings");
            }
            
            

        }
        static void AppoinementHistory()
        {
            foreach(AppoinementDetails appointment in appoinementList)
            {
                 if(CurrentPatient.PatientID==appointment.PatientID)  //check the current user or not if true show the appointment history
                {
                    Console.WriteLine($"AppointmentID={appointment.AppointmentID} DoctorID={appointment.DoctorID} Date={appointment.AppointmentDate.ToShortDateString()} ");
                }

            }
        }
        static void EditMyProfile()
        {
            Console.WriteLine("\t1.Name\n\t2.Password\n\t3.Age\n\t4.Gender");
            Console.WriteLine("Enter your choice you want to edit-"); //ask the user wish to edit
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine("Enter your New Name to update=");
                    string newName=Console.ReadLine();
                    CurrentPatient.PatientName=newName;
                    Console.WriteLine("Updated Successfully");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Enter your new Password= ");
                    string newPassword=Console.ReadLine();
                    CurrentPatient.Password=newPassword;
                     Console.WriteLine("Updated Successfully");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter your new Age=");
                    int newAge=int.Parse(Console.ReadLine());
                     Console.WriteLine("Updated Successfully");
                    CurrentPatient.Age=newAge;
                    break;
                }
                case 4:
                {
                    Console.Write("Enter your new Gender(Male/Female)=");
                    Gender newGender=Enum.Parse<Gender>(Console.ReadLine(),true);
                    CurrentPatient.Gender=newGender;
                     Console.WriteLine("Updated Successfully");
                    break;
                }
            }
        }
    }
}