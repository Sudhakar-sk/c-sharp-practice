// using System;  
// public class CharOccuringCount  
// {  
//     public static void Main() 
// {
//     string str;
//     int[] charCount = new int[255];
//     int i = 0, max,l;
//     int ascii;
	
//       Console.Write("\n\nFind maximum occurring character in a string :\n");
//       Console.Write("--------------------------------------------------\n"); 	
//       Console.Write("Input the string : ");
//       str = Console.ReadLine();	
//       l=str.Length;

//     for(i=0; i<255; i++)  //Set frequency of all characters to 0
//     {
//         charCount[i] = 0;
//     }
//     /* Read for frequency of each characters */
//     i=0;
//     while(i<l)
//     {
//         ascii = (int)str[i];
//         charCount[ascii] += 1;

//         i++;
//     }
// // Console.Write("{0}  ",(char)65);
//     max = 0;
//     for(i=0; i<255; i++)
//     {
//       if(i!=32)
//         {
//         if(charCount[i] > charCount[max])
//             max = i;
//         }
//     }
//    Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, charCount[max]);
// 	}
// }
