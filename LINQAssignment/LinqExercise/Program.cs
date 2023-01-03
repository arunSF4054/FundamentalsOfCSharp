using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.WriteLine("Enter Menu Number");
            int option = Convert.ToInt32(Console.ReadLine());
            TraineeDetails obj = new TraineeDetails();
            TraineeData ob1 = new TraineeData();
            List<TraineeDetails> b = ob1.GetTraineeDetails();
            

            switch(option)
            {
                case 1:
                    {
                        IEnumerable<string> query = from trainee in b select trainee.TraineeId;
                               foreach(string id in query)
                               {
                                Console.WriteLine(id);
                               }
                        break;
                    }
                case 2:
                    {
                         IEnumerable<string> query = (from trainee in b select trainee.TraineeId).Take(3);
                         foreach(string id in query)
                               {
                                Console.WriteLine(id);
                               }
                        
                        break;
                    }
                    case 3:
                    {
                       IEnumerable<string> query = (from trainee in b select trainee.TraineeId).Skip(3);
                         foreach(string id in query)
                               {
                                Console.WriteLine(id);
                               }
                        
                        
                        break;
                    }
                    case 4:
                    {
                        IEnumerable<string> query =from trainee in b select trainee.TraineeId;
                        Console.WriteLine(query.Count());

                        
                        break;
                    }
                    case 5:
                    {
                         IEnumerable<string> query =from trainee in b where trainee.YearPassedOut>=2019 select trainee.TraineeName;
                         foreach(string year in query)
                         {
                            Console.WriteLine(year);
                         }
                         break;
                    }
                    case 6:
                    {

                       IEnumerable<TraineeDetails> query =  b.OrderBy(c => c.TraineeName);
                       foreach(TraineeDetails trainer in query)
                       {
                        Console.WriteLine($"{trainer.TraineeId} {trainer.TraineeName}");
                       }

                        
                        break;
                    }
                    case 7:
                    {
                        
                        break;
                    }
                    case 8:
                    {
                        IEnumerable<int> query=(from trainee in b select trainee.YearPassedOut).Distinct();
                        foreach(int year in query)
                        {
                            Console.WriteLine(year);
                        }
                        
                        break;
                    }
                    case 9:
                    {
                        Console.WriteLine("Enter the trainee ID=");
                        string newID=Console.ReadLine().ToUpper();
                        IEnumerable<int> query=from trainee in b where trainee.TraineeId==newID select trainee.TotalScore;
                        if(query.Count()==0)
                        {
                            Console.WriteLine("Invalid ID");

                        }
                        else
                        {
                            foreach(int mark in query)
                            {
                                Console.WriteLine(mark);
                            }
                        }
                        
                        break;
                    }
                    case 10:
                    {
                        TraineeDetails trainee=b.First();
                        Console.WriteLine(trainee.TraineeId+":"+trainee.TraineeName);
                        
                        break;
                    }
                    case 11:
                    {
                         TraineeDetails trainee=b.Last();
                        Console.WriteLine(trainee.TraineeId+":"+trainee.TraineeName);
                        
                        break;
                    }
                    case 12:
                    {
                        IEnumerable<TraineeDetails> query=from trainee in b select trainee;
                        foreach(TraineeDetails trainee in query)
                        {
                            Console.WriteLine(trainee.TotalScore);
                        }
                        
                        break;
                    }
                    case 13:
                    {
                        int maxScore=(from trainee in b select trainee.TotalScore).Max();
                        Console.WriteLine(maxScore);
                        
                        break;
                    }
                    case 14:
                    {
                        int minScore=(from trainee in b select trainee.TotalScore).Min();
                        Console.WriteLine(minScore);
                        
                        break;
                    }
                    case 15:
                    {
                        double average=(from trainee in b select trainee.TotalScore).Average();
                        Console.WriteLine(average);
                        
                        break;
                    }
                    case 16:
                    {
                        bool answer=(from trainee in b select trainee).Any(trainee => trainee.TotalScore>40);
                        Console.WriteLine(answer);
                        
                        break;
                    }
                    case 17:
                    {
                        bool answer=(from trainee in b select trainee).All(trainee => trainee.TotalScore>20);
                        Console.WriteLine(answer);
                        
                        break;
                    }
                    case 18:
                    {
                        IEnumerable<TraineeDetails> answer=(from trainee in b select trainee).OrderBy(trainee => trainee.TraineeName).OrderBy(trainee=>trainee.TraineeId);
                        foreach(TraineeDetails trainee in answer)
                        {
                            Console.WriteLine($"ID={trainee.TraineeId} | Name={trainee.TraineeName} | ");
                        }
                        
                        break;
                    }
             
            }
           
        }
    }
}
