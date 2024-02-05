using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static WindowsFormsApp4.MainForm;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace WindowsFormsApp4
{
    internal class SupportFile
    {
        public CustomerForm dd = new CustomerForm();
        public static student[] StudentList = new student[1];





        /// <summary>
        /// Creates Customer structure as well as a nested structure which contains phonebill information
        /// </summary>
        public struct student
        {

            //These are properties of the student - each property has a different 
            //name and data type

            public int ID;
            public string Surname;
            public String Address;
            public String TelNo;
            public String Phoneplan;
            public CostByMonth[] month;

            public struct CostByMonth
            {
                public int numberOfMinutes;
                public int numberOfText;
                public int numberOfData;
            }

        }


        // Main Method

        const string filename = "Example.txt";

        /// <summary>
        /// Loads data, and populates the combobox
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="StudentList"></param>
        public static void PopulateCustomers(ref System.Windows.Forms.ComboBox cmb, ref student[] StudentList)
        {
            
            SupportFile.loaddata(ref SupportFile.StudentList);
            cmb.Items.Clear();

            
            foreach (student cus in StudentList)
            {
                cmb.Items.Add(cus.Surname);
            }

        }
        
        /// <summary>
        /// shows customers after a selection
        /// </summary>
        /// <param name="index"></param>
        public static void ShowCustomer(int index)
        {
            if (index > -1)
            {
                CustomerForm.CName = StudentList[index].Surname;
                CustomerForm.CPhone = StudentList[index].TelNo;
                CustomerForm.CAddress = StudentList[index].Address;
                CustomerForm.CPlan = StudentList[index].Phoneplan;
            }
        }
        
        /// <summary>
        /// Shows customer bill
        ///
        /// </summary>
        /// <param name="indexOfCustomer"></param>
        /// <param name="indexOfMonth"></param>
        public static void ShowCustomerbill(int indexOfCustomer, int indexOfMonth)
        {




            StatementForm.CNbOfMinutes = 200;
            if (indexOfCustomer > -1 && indexOfMonth > -1)
            {
                StatementForm.CNbOfMinutes = StudentList[indexOfCustomer].month[indexOfMonth].numberOfMinutes;
                StatementForm.CNbofText = StudentList[indexOfCustomer].month[indexOfMonth].numberOfText;
                StatementForm.CNbofData = StudentList[indexOfCustomer].month[indexOfMonth].numberOfData;

            }
        }


        public static void TakeData(ref student[] W, int indexOfWorker, int CorrespondingMonth)
        {
            W[indexOfWorker].month[CorrespondingMonth].numberOfMinutes = StatementForm.CNbOfMinutes;
            W[indexOfWorker].month[CorrespondingMonth].numberOfText = StatementForm.CNbofText;
            W[indexOfWorker].month[CorrespondingMonth].numberOfData = StatementForm.CNbofData;

        }



        /// <summary>
        /// Creates textfile with customer data(if doesnt exist), and fills it with user input
        /// </summary>
        /// <param name="StudentList"></param>
        public static void loaddata(ref student[] StudentList)
        {

            if (!File.Exists(filename))
            {
                StreamWriter Writer = new StreamWriter(filename);
                Writer.WriteLine(0);
                Writer.Close();
            }

            StreamReader reader = new StreamReader(filename);
            int size = Convert.ToInt32(reader.ReadLine());
            StudentList = new student[size];

            for (int Index = 0; Index < StudentList.Length; Index++)
            {
                StudentList[Index] = new student();
                StudentList[Index].month = new student.CostByMonth[12];

                StudentList[Index].ID = Convert.ToInt32(reader.ReadLine());
                StudentList[Index].Surname = reader.ReadLine();
                StudentList[Index].Address = reader.ReadLine();
                StudentList[Index].TelNo = reader.ReadLine();
                StudentList[Index].Phoneplan = reader.ReadLine();
                for (int i = 0; i < 12; i++)
                {
                    StudentList[Index].month[i].numberOfMinutes = Convert.ToInt32(reader.ReadLine());
                    StudentList[Index].month[i].numberOfText = Convert.ToInt32(reader.ReadLine());
                    StudentList[Index].month[i].numberOfData = Convert.ToInt32(reader.ReadLine());

                }

            }

            reader.Close();
        }


        /// <summary>
        /// Function to add customer
        /// </summary>
        /// <param name="StudentList"></param>
        public static void addStudent(ref student[] StudentList)
        {

            StreamWriter Writer = new StreamWriter(filename);
            Writer.WriteLine(StudentList.Length + 1);

            //create a new temp student structure
            student temp = new student();
            temp.month = new student.CostByMonth[12];

            // collect data from the user

            temp.ID = GetHighestID(StudentList) + 1;
            temp.Surname = CustomerForm.CName;
            temp.Address = CustomerForm.CAddress;
            temp.TelNo = CustomerForm.CPhone;
            temp.Phoneplan = CustomerForm.CPlan;

            // Write the new data to the text file

            Writer.WriteLine(temp.ID);
            Writer.WriteLine(temp.Surname);
            Writer.WriteLine(temp.Address);
            Writer.WriteLine(temp.TelNo);
            Writer.WriteLine(temp.Phoneplan);

            for (int i = 0; i < 36; i++)
            {

                Writer.WriteLine(0);
            }

            //put old records of students back to text file

            for (int index = 0; index < StudentList.Length; index++)
            {
                Writer.WriteLine(StudentList[index].ID);
                Writer.WriteLine(StudentList[index].Surname);
                Writer.WriteLine(StudentList[index].Address);
                Writer.WriteLine(StudentList[index].TelNo);
                Writer.WriteLine(StudentList[index].Phoneplan);

                for (int i = 0; i < 12; i++)
                {
                    Writer.WriteLine(StudentList[index].month[i].numberOfMinutes);
                    Writer.WriteLine(StudentList[index].month[i].numberOfText);
                    Writer.WriteLine(StudentList[index].month[i].numberOfData);

                }

            }
            //close the file
            Writer.Close();

            //Update our array
            // loaddata(ref StudentList);

        }

        /// <summary>
        /// Function to save data into the textfile
        /// </summary>
        /// <param name="StudentList"></param>
        public static void saveData(student[] StudentList)
        {
            StreamWriter Writer = new StreamWriter(filename);
            Writer.WriteLine(StudentList.Length);
            for (int index = 0; index < StudentList.Length; index++)
            {
                Writer.WriteLine(StudentList[index].ID);
                Writer.WriteLine(StudentList[index].Surname);
                Writer.WriteLine(StudentList[index].Address);
                Writer.WriteLine(StudentList[index].TelNo);
                Writer.WriteLine(StudentList[index].Phoneplan);

                for (int i = 0; i < 12; i++)
                {
                    Writer.WriteLine(StudentList[index].month[i].numberOfMinutes);
                    Writer.WriteLine(StudentList[index].month[i].numberOfText);
                    Writer.WriteLine(StudentList[index].month[i].numberOfData);

                }

            }

            //Close the file
            Writer.Close();

        }


        static int GetHighestID(student[] StudentList)
        {
            PutInOrder(StudentList);

            if (StudentList.Length == 0)

            {
                return 0;
            }


            return StudentList[StudentList.Length - 1].ID;


        }

        static void PutInOrder(student[] StudentList)

        {
            for (int Index = 0; Index < (StudentList.Length); Index++)

            {
                Console.Write(StudentList[Index].ID);
            }
            bool swapped;

            do
            {
                swapped = false;
                for (int n = 0; n < StudentList.Length - 1; n++)

                {
                    if (StudentList[n].ID > StudentList[n + 1].ID)
                    {
                        student stud = StudentList[n];
                        StudentList[n] = StudentList[n + 1];
                        StudentList[n + 1] = stud;
                        swapped = true;

                    }
                }
            } while (swapped);

            for (int Index = 0; Index < (StudentList.Length); Index++)

            {
                Console.WriteLine();
                Console.Write(StudentList[Index].ID);
            }
            Console.ReadLine();

        }



    }
}
