// using System;  
// namespace CallByValue  
// {  
//     class Program  
//     {  
//         // User defined function  
//         public void Show(int val)  
//         {  
//             val *= 10; // Manipulating value  
//             Console.WriteLine("Value inside the show function " + val);  
//             // No return statement  
//         }  
//         // Main function, execution entry point of the program  
//         static void Main(string[] args)  
//         {  
//             int val = 50;  
//             Program obj = new Program(); // Creating Object  
//             Console.WriteLine("Value before calling the function "+ val);  
//             obj.Show(val); // Calling Function by passing value            
//             Console.WriteLine("Value after calling the function " + val);  
//         }  
//     }  
// }  
