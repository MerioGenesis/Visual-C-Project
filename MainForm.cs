using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    
    
    
    
    public partial class MainForm : Form
    {
        CustomerForm dd = new CustomerForm();
        //public static student[] StudentList = new student[1];
        public MainForm()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            //loaddata(ref StudentList);

            //// allocating memory for the arrays in CostByMonth---Very important
            //for (int i = 0; i < StudentList.Length; i++)
            //    StudentList[i].month = new student.CostByMonth[12];
            //addStudent(ref StudentList);



        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm dd = new CustomerForm();
            dd.Show();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            StatementForm SForm = new StatementForm();
            SForm.Show();
        }
        //public struct student
        //{

        //    //These are properties of the student - each property has a different 
        //    //name and data type

        //    public int ID;
        //    public string FirstName;
        //    public string Surname;
        //    public DateTime DoB;
        //    public String Address;
        //    public String TelNo;
        //    public char Gender;
        //    public CostByMonth[] month;

        //    public struct CostByMonth
        //    {

        //        public int priceByMonth;
        //        public int numberOfHoursByCourse;
        //        public int numberOfCourses;
        //        public int monthNumber;
        //    }

        //}


        //// Main Method

        //const string filename = "Example.txt";
        ////static void Main(string[] args)
        ////{



        ////    int choice;
        ////    //menu
        ////    do
        ////    {
        ////        Console.Clear();
        ////        Console.WriteLine("1. Display Students");
        ////        Console.WriteLine("2. Add a student");
        ////        Console.WriteLine("3. find the Monthly bill");
        ////        Console.WriteLine("4. Display monthly bill");
        ////        Console.WriteLine("5. Edit a student");
        ////        Console.WriteLine("6. Exit");
        ////        Console.Write("Make a choice 1-6: ");
        ////        bool success = int.TryParse(Console.ReadLine(), out choice);
        ////        if (success = false)
        ////        {
        ////            Console.WriteLine("Input a valid choice");
        ////            Console.ReadKey();
        ////        }


        ////        switch (choice)
        ////        {
        ////            case 1:
        ////                displayStudents(StudentList);
        ////                Console.ReadLine();
        ////                break;

        ////            case 2:
        ////                addStudent(ref StudentList);
        ////                break;

        ////            case 3:
        ////                Monthpay(StudentList);

        ////                Console.ReadLine();
        ////                break;
        ////            case 4:
        ////                int indexMonth = Monthchosen(StudentList);

        ////                Displaymonthlybill(StudentList[SelectStudent(StudentList)], indexMonth);

        ////                break;
        ////            case 5:
        ////                editStudent(ref StudentList, SelectStudent(StudentList));

        ////                break;

        ////            default:
        ////                break;


        ////        }

        ////    } while (choice != 6);
        ////}


        ////static void TakeData(ref student[] W, int indexOfWorker, int CorrespondingMonth)
        ////{

        ////    Console.Write("How many hours: ");
        ////    W[indexOfWorker].month[CorrespondingMonth].numberOfHoursByCourse = Convert.ToInt32(Console.ReadLine());
        ////    Console.Write("How many courses: ");
        ////    W[indexOfWorker].month[CorrespondingMonth].numberOfCourses = Convert.ToInt32(Console.ReadLine());

        ////}


        ////static int Monthchosen(student[] StudentList)
        ////{

        ////    int monthChoice;

        ////    do
        ////    {
        ////        Console.Clear();
        ////        Console.WriteLine("Please choose a Month, select 1 to 12\n 1-Jan, 2-Feb, 3-Mar, 4-Apr, 5-May, 6-Jun, 7-Jul, 8-Aug, 9-Sep, 10-Oct, 11-Nov, 12-Dec\nPress 13 To Quit  ");

        ////        monthChoice = Convert.ToInt32(Console.ReadLine());

        ////        switch (monthChoice)
        ////        {

        ////            case 1:
        ////                return 0;
        ////                break;

        ////            case 2:
        ////                return 1;
        ////                break;

        ////            case 3:
        ////                return 2;
        ////                break;

        ////            case 4:
        ////                return 3;
        ////                break;
        ////            case 5:
        ////                return 4;
        ////                break;
        ////            case 6:
        ////                return 5;
        ////                break;
        ////            case 7:
        ////                return 6;
        ////                break;
        ////            case 8:
        ////                return 7;
        ////                break;
        ////            case 9:
        ////                return 8;
        ////                break;
        ////            case 10:
        ////                return 9;
        ////                break;
        ////            case 11:
        ////                return 10;
        ////                break;
        ////            case 12:
        ////                return 11;
        ////                break;
        ////            case 13:
        ////                Console.Write("enter a key to exit ");
        ////                return -1;
        ////                break;
        ////            default:
        ////                Console.Write(" Please a number between 1 and 12, press enter to continue ");
        ////                Console.ReadLine();
        ////                return -1;

        ////                break;

        ////        }

        ////    } while (monthChoice != 13);




        ////}
        ////static void Monthpay(student[] StudentList)

        ////{

        ////    //int indexofStudent = SelectStudent(StudentList);
        ////    int monthChoice;

        ////    do
        ////    {
        ////        Console.Clear();
        ////        Console.WriteLine("Please choose a Month, select 1 to 12\n 1-Jan, 2-Feb, 3-Mar, 4-Apr, 5-May, 6-Jun, 7-Jul, 8-Aug, 9-Sep, 10-Oct, 11-Nov, 12-Dec\n13- Quit  ");

        ////        monthChoice = Convert.ToInt32(Console.ReadLine());

        ////        switch (monthChoice)
        ////        {

        ////            case 1:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 0);

        ////                break;

        ////            case 2:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 1);


        ////                break;
        ////            case 3:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 2);

        ////                break;
        ////            case 4:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 3);
        ////                break;
        ////            case 5:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 4);
        ////                break;
        ////            case 6:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 5);
        ////                break;
        ////            case 7:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 6);
        ////                break;
        ////            case 8:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 7);
        ////                break;
        ////            case 9:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 8);
        ////                break;
        ////            case 10:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 9);
        ////                break;
        ////            case 11:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 10);
        ////                break;
        ////            case 12:
        ////                TakeData(ref StudentList, SelectStudent(StudentList), 11);
        ////                break;
        ////            case 13:
        ////                Console.Write("no more entries, Press any key ");

        ////                break;
        ////            default:
        ////                Console.Write(" Please a number between 1 and 12, press enter to continue ");
        ////                Console.ReadLine();

        ////                break;

        ////        }

        ////    } while (monthChoice != 13);
        ////}




        ////static void Displaymonthlybill(student studentTodispaly, int chosenMonth)
        ////{
        ////    Console.WriteLine(studentTodispaly.ID);
        ////    Console.WriteLine(studentTodispaly.FirstName);
        ////    Console.WriteLine(studentTodispaly.Surname);
        ////    Console.WriteLine(studentTodispaly.month[chosenMonth].monthNumber);
        ////    Console.WriteLine(studentTodispaly.month[chosenMonth].numberOfCourses);
        ////    Console.WriteLine(studentTodispaly.month[chosenMonth].numberOfHoursByCourse);
        ////    Console.WriteLine(studentTodispaly.month[chosenMonth].numberOfCourses * studentTodispaly.month[chosenMonth].numberOfHoursByCourse);

        ////    Console.WriteLine("--------------------");
        ////    Console.ReadKey();
        ////}
        //public static void loaddata(ref student[] StudentList)
        //{

        //    if (!File.Exists(filename))
        //    {
        //        StreamWriter Writer = new StreamWriter(filename);
        //        Writer.WriteLine(0);
        //        Writer.Close();
        //    }

        //    StreamReader reader = new StreamReader(filename);
        //    int size = Convert.ToInt32(reader.ReadLine());
        //    StudentList = new student[size];

        //    for (int Index = 0; Index < StudentList.Length; Index++)
        //    {
        //        StudentList[Index] = new student();
        //        StudentList[Index].ID = Convert.ToInt32(reader.ReadLine());
        //        StudentList[Index].FirstName = reader.ReadLine();
        //        StudentList[Index].Surname = reader.ReadLine();
        //      //  StudentList[Index].DoB = Convert.ToDateTime(reader.ReadLine());
        //        StudentList[Index].Address = reader.ReadLine();
        //        StudentList[Index].TelNo = reader.ReadLine();
        //      //  StudentList[Index].Gender = Convert.ToChar(reader.ReadLine());


        //    }
        //    reader.Close();
        //    // allocating memory for the arrays in CostByMonth---Very important
        //    for (int i = 0; i < StudentList.Length; i++)
        //        StudentList[i].month = new student.CostByMonth[12];

        //}

        //static int SelectStudent(student[] StudentList)
        //{
        //    int studentID;
        //    Console.Clear();
        //    for (int i = 0; i < StudentList.Length; i++)
        //    {
        //        Console.WriteLine("Student ID: {0}-Student Surname: {1}", StudentList[i].ID, StudentList[i].Surname);
        //    }
        //    Console.Write("\nPlease enter student ID: ");
        //    bool success = int.TryParse(Console.ReadLine(), out studentID);
        //    if (success = false)
        //    {
        //        Console.WriteLine("Input a valid choice");
        //        Console.ReadKey();
        //    }


        //    for (int i = 0; i < StudentList.Length; i++)
        //    {
        //        if (StudentList[i].ID == studentID)
        //        {
        //            Console.WriteLine("Student ID: {0}-Student Surname: {1}", StudentList[i].ID, StudentList[i].Surname);
        //            return i;
        //        }

        //    }
        //    return -1;
        //}
        //public static void addStudent(ref student[] StudentList)
        //{

        //    StreamWriter Writer = new StreamWriter(filename);
        //    Writer.WriteLine(StudentList.Length + 1);

        //    //create a new temp student structure
        //    student temp = new student();

        //    // collect data from the user

        //    temp.ID = GetHighestID(StudentList) + 1;


        //    temp.FirstName = "Salim"; 


        //    temp.Surname = "Karakou";

        //    //Console.Write("Enter Student Date of Birth: ");
        //    //temp.DoB = Convert.ToDateTime(Console.ReadLine());


        //    temp.Address = "London";

        //    //Console.Write("Enter Student Tel number: ");
        //    temp.TelNo = "ghjghjh";

        //    //Console.Write("Enter Student Gender: ");
        //    //temp.Gender = Convert.ToChar(Console.ReadLine());



        //    // Write the new data to the text file

        //    Writer.WriteLine(temp.ID);
        //    Writer.WriteLine(temp.FirstName);
        //    Writer.WriteLine(temp.Surname);
        //   // Writer.WriteLine(temp.DoB);
        //    Writer.WriteLine(temp.Address);
        //    Writer.WriteLine(temp.TelNo);
        // //   Writer.WriteLine(temp.Gender);


        //    //put old records of students back to text file

        //    for (int index = 0; index < StudentList.Length; index++)
        //    {
        //        Writer.WriteLine(StudentList[index].ID);
        //        Writer.WriteLine(StudentList[index].FirstName);
        //        Writer.WriteLine(StudentList[index].Surname);
        //      //  Writer.WriteLine(StudentList[index].DoB);
        //        Writer.WriteLine(StudentList[index].Address);
        //        Writer.WriteLine(StudentList[index].TelNo);
        //      //  Writer.WriteLine(StudentList[index].Gender);

        //    }
        //    //close the file
        //    Writer.Close();

        //    //Update our array

        //    loaddata(ref StudentList);

        //}
        //static void deleteStudent()
        //{

        //}
        //static void displayStudents(student[] StudentList)
        //{
        //    for (int Index = 0; Index < StudentList.Length; Index++)
        //    {
        //        displayInformation90(StudentList[Index]);
        //    }
        //}
        //static void editStudent(ref student[] StudentList, int studentToEdit)
        //{
        //    bool isPresent = false;



        //    for (int index = 0; index < StudentList.Length; index++)
        //    {
        //        if (StudentList[index].ID == StudentList[studentToEdit].ID)
        //        {
        //            //  create a new temp student structure

        //            student temp = new student();

        //            //   collect data from the user


        //            Console.Write("Enter new Student First Name: ");
        //            StudentList[index].FirstName = Console.ReadLine();

        //            Console.Write("Enter new Student Surname: ");
        //            StudentList[index].Surname = Console.ReadLine();

        //            Console.Write("Enter new Student Date of Birth: ");
        //            StudentList[index].DoB = Convert.ToDateTime(Console.ReadLine());

        //            Console.Write("Enter  new Student Address: ");
        //            StudentList[index].Address = Console.ReadLine();

        //            Console.Write("Enter new Student Tel number: ");
        //            StudentList[index].TelNo = Console.ReadLine();

        //            Console.Write("Enter Student Gender: ");
        //            StudentList[index].Gender = Convert.ToChar(Console.ReadLine());

        //            displayInformation90(StudentList[index]);
        //            isPresent = true;
        //            break;
        //        }

        //    }
        //    if (isPresent == false)
        //        Console.WriteLine("item not found");
        //    else
        //    {
        //        StreamWriter Writer = new StreamWriter(filename);
        //        Writer.WriteLine(StudentList.Length);
        //        for (int index = 0; index < StudentList.Length; index++)
        //        {
        //            Writer.WriteLine(StudentList[index].ID);
        //            Writer.WriteLine(StudentList[index].FirstName);
        //            Writer.WriteLine(StudentList[index].Surname);
        //            Writer.WriteLine(StudentList[index].DoB);
        //            Writer.WriteLine(StudentList[index].Address);
        //            Writer.WriteLine(StudentList[index].TelNo);
        //            Writer.WriteLine(StudentList[index].Gender);

        //        }
        //        //close the file
        //        Writer.Close();
        //        loaddata(ref StudentList);
        //    }

        //}
        //static void displayInformation90(student s)
        //{
        //    Console.WriteLine(s.ID);
        //    Console.WriteLine(s.FirstName);
        //    Console.WriteLine(s.Surname);
        //    Console.WriteLine(s.DoB);
        //    Console.WriteLine(s.Address);
        //    Console.WriteLine(s.TelNo);
        //    Console.WriteLine(s.Gender);
        //    Console.WriteLine("--------------------");
        //}

        //static int GetHighestID(student[] StudentList)
        //{
        //    PutInOrder(StudentList);

        //    if (StudentList.Length == 0)

        //    {
        //        return 0;
        //    }


        //    return StudentList[StudentList.Length - 1].ID;


        //}
        //static void PutInOrder(student[] StudentList)

        //{
        //    for (int Index = 0; Index < (StudentList.Length); Index++)

        //    {
        //        Console.Write(StudentList[Index].ID);
        //    }
        //    bool swapped;

        //    do
        //    {
        //        swapped = false;
        //        for (int n = 0; n < StudentList.Length - 1; n++)

        //        {
        //            if (StudentList[n].ID > StudentList[n + 1].ID)
        //            {
        //                student stud = StudentList[n];
        //                StudentList[n] = StudentList[n + 1];
        //                StudentList[n + 1] = stud;
        //                swapped = true;

        //            }
        //        }
        //    } while (swapped);

        //    for (int Index = 0; Index < (StudentList.Length); Index++)

        //    {
        //        Console.WriteLine();
        //        Console.Write(StudentList[Index].ID);
        //    }
        //    Console.ReadLine();

        //}


    }
}
