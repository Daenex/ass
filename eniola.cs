using System;
    public class Eniproject
    {  
       public static void Main(string[] args)  
        {  
            Console.WriteLine("full-time or part-time:"); 
          string degree = Console.ReadLine();
      
       if ( degree == "full-time")
       {
       Console.WriteLine("course of study:");
     
        string course = Console.ReadLine();
        {
        	Console.WriteLine(course +  "is a good course");
 
        }	
        }	
      
      if (degree == "part-time")
      {
      	Console.WriteLine("how many credits:");
      	int credit =Convert.ToInt32(Console.ReadLine());
      	
      	if (credit <=6)
      {
      	Console.WriteLine("proceed");
      }
       else if (credit > 6)
      {
      	Console.WriteLine("Too much unit for a part-time student");
      }	
      }
    }
    }