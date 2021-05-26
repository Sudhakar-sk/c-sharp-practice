// using System;
// public class Substring
// {
// 	public static void Main()
// 	{
//     string str;
//     int c=0;
    
//                Console.Write("\n\nExtract a substring from a given string:\n");
//                Console.Write("--------------------------------------------\n");  
//                Console.Write("Input the string : ");
//                str = Console.ReadLine();   //to get input string	
//                int len=str.Length;
//                char[] arr=str.ToCharArray(0,len); //to convert string to char array  

//                Console.Write("Input the position to start extraction :");
//                int startPos= Convert.ToInt32(Console.ReadLine());   // input here as integer

//                Console.Write("Input the length of substring :");
//                int lenSubstring= Convert.ToInt32(Console.ReadLine()); //input of substring

//                Console.Write("The substring retrieve from the string is : ");
//                   while (c < lenSubstring) 
//                   {
//                    Console.Write(arr[startPos+c]);
//                    c++;
//                    }

//     }
// }