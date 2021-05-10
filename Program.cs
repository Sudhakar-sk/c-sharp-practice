using System;

namespace Mynamespace{
//     class Student{
//         int id; //data member
//         string name; //field or data member

//         public static void Main(){
//             Student s1=new Student();//creating object of student
//             s1.id=2;
//             s1.name="sk";
//             Console.WriteLine(s1.id);
//             Console.WriteLine(s1.name);



//         }
//     }
// }
/*----------------------------------------------------------------------------------------------------*/
//C# Class Example 2: Having Main() in another class
class student{
    public int id;
    public string name;

}
class TestStudent{
    public static void Main(){
        student s1=new student();
        s1.id=Convert.ToInt32(Console.ReadLine());
        s1.name=Console.ReadLine();

        Console.WriteLine("Hello "+ s1.name +" your id is "+ s1.id);
        // Console.WriteLine(s1.name);

    }
}
}