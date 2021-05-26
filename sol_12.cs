  using System;

  public class StringSort{
      public static void Main()
      {
            // string arr;
            // int temp;
            // Console.WriteLine("enter new string");
            // arr=Console.ReadLine();
            // int[] num1 = new int[arr.Length];
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     int ch = (int)arr[i];
            //     Console.WriteLine(ch);
            //     num1[i] = ch;
            // }
           
            //     for (int i = 0; i < num1.Length-1; i++)
            //     {
            //         if (num1[i] > num1[i + 1])
            //         {
            //             temp = num1[i + 1];
            //             num1[i + 1] = num1[i];
            //             num1[i] = temp;
            //         }
            //    }
            //      Console.WriteLine("\n");

            //     for (int i=0;i<num1.Length;i++)
            //     {
            //         Console.WriteLine(num1[i]);
            //         char ch = (char)num1[i];
            //         Console.WriteLine(ch);
            //     }
        string[] arr1;
	    	int n,i;
		
       Console.Write("\n\nSorts the strings of an array using bubble sort :\n");
       Console.Write("-----------------------------------------------------\n");  
       Console.Write("Input number of strings :");
       n= Convert.ToInt32(Console.ReadLine()); //to get integer as a input
       arr1=new string[n];      // to initialilze array
       Console.Write("Input {0} strings below :\n",n);

       for(i=0;i<n;i++)  //loop to get input depends upon n
       {
         arr1[i] = Console.ReadLine();	
       }	
      Array.Sort(arr1);  //to sort a array
      Console.Write("\n\nAfter sorting the array appears like : \n");

       for(i=0;i<n;i++)  //to display output and accessing array element
       {

         Console.WriteLine(arr1[i]);
       }
      

		// for (i = 0; i < l; i++)
		// {
		// 	for (j = 0; j < l-1; j++)
		// 	  {
		// 		if (arr1[j].CompareTo(arr1[j + 1]) > 0)
		// 		  {
        //            temp = arr1[j];
        //            arr1[j] = arr1[j + 1];
        //            arr1[j + 1] = temp;
        //           }
        //       }
        // }
		//  Console.Write("\n\nAfter sorting the array appears like : \n");
        // for (i = 0; i < l; i++)
        //   {
        //     Console.WriteLine(arr1[i] + " ");
        //   }
            
            
             }
          }