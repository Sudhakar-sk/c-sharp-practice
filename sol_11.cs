// using System;  
// public class ArrangeStringByAsciiValue
// {  
//     public static void Main() 
//     {
//     string str;
//     int l;

//     Console.Write("Enter input string: ");
//     str =Console.ReadLine();//getting input
//     l=str.Length;    //length of input string
//     int[] ar=new int[l];  //array initialization

//     for (int i = 0; i<l; i++)   //this loop for to assign ascii value to the array
//      {
//       int ch = (int)str[i];   //convert char to ascii value
//       ar[i] = ch;             //asign the value to array
//      }

//      Array.Sort(ar);   //sorting array by using ascii value

//     for (int i = 0; i < l; i++)  //
//      {
//        char ch = (char)ar[i];  //convert ascii to char
//        Console.Write("{0} ",ch);  //to display output
//      }
//    }
// }
