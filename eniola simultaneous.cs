using System;
    public class Eniproject
    {  
       public static void Main(string[] args)  
        {  
        	double A ,B, C, D, E, F; 
           
         
            Console.WriteLine("calc simultaneous eqn");
          
            Console.WriteLine("value of a:");
        A = Convert.ToInt32(Console.ReadLine());
      
      
            Console.WriteLine("value of b:");
        B = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("value of e:");
        E = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("value of c:");
        C = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("value of d:");
        D = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("value of f:");
        F = Convert.ToInt32(Console.ReadLine());
             
               if   (A*D - B*C == 0)
           
           	Console.WriteLine("Equation has no solutuon");
             
          	
          	Console.WriteLine("x=" + (E*D - B*F)/(A*D - B*C) );
            Console.WriteLine("y=" + (A*F - C*E)/(A*D - B*C) );
        
      
        }
    }