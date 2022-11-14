using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace UserMgmtWebForms
{
    //Access modifiers
    //private,public,internal,protected and internal protected
    internal class Employee
    {
        //Has-A
        private static int EmpCounter;

        public static int GetEmployeeCounter()
        {
            return EmpCounter;
        }

        public Employee()
        {
            EmpCounter++;
            this.DOB = DateTime.Now.AddDays(-1);
        }

        public Employee(int eid,string name,DateTime dob) : this()
        {
            EmployeeId = eid;
            Name = name;
            DOB = dob;
            Salary = 10000;
        }


        //public void Set_EmpId(int eid)
        //{
        //    if (eid > 0)
        //        m_intEmployeeId = eid;
        //    else
        //        throw new Exception("Employee id invalid");
        //}
        //public int Get_EmpId()
        //{
        //    return m_intEmployeeId;
        //}
        //property procedure syntax
        private int m_intEmployeeId;
        public int EmployeeId
        {
            set
            {
                if(value >0)
                    m_intEmployeeId = value;
                    else
                        throw new Exception("Employee id invalid");
            }
            get {
                return m_intEmployeeId;
            }
        }

        private string m_strName;

        public string Name
        {
            get { return m_strName; }
            set {
                if (value.Length > 3)
                {
                    m_strName = value;
                }
                else
                    throw new Exception("Name should be atleast 3 chars");
            }
        }

        private DateTime m_dtDOB;

        public DateTime DOB
        {
            get { return m_dtDOB; }
            set {
                DateTime currdate = DateTime.Now;
               if( value.CompareTo(currdate) <0)
                    m_dtDOB = value;
               else
                    throw new Exception("DOB should be less than today");
            }
        }

        private decimal m_decSal;

        public decimal Salary
        {
            get { return m_decSal; }
            set { m_decSal = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        private Address m_tempaddr;

        public Address TempAddress
        {
            get { return m_tempaddr; }
            set { m_tempaddr = value; }
        }

        private Gender gender;

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        StringBuilder sb;

        public string Display()
        {
             sb= new StringBuilder();
            sb.Append("Employee Id : " + EmployeeId + "\n");
            sb.Append("Employee Name : " + Name + "\n");
            sb.Append("Employee DOB : " + DOB.ToLongDateString() + "\n");
            sb.Append("Employee salary : " + Salary + "\n");
            if (Gender == Gender.Male)
                sb.Append("Gender : Male\n");
            else
                sb.Append("Gender : Female\n");
            return sb.ToString();
        }

        public void WriteToFile()
        {
            string path = @"c:\employee";


            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

           path= Path.Combine(path, "employee.txt");

            FileStream fileStream;
            StreamWriter sw;
            BinaryWriter bw;

            if(File.Exists(path))
            {
                //append
                fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                //create and write
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            }
            
            sw = new StreamWriter(fileStream);
            StringBuilder sb = new StringBuilder();
            sb.Append(EmployeeId);
            sb.Append(",");
            sb.Append(Name);
            sb.Append(",");
            sb.Append(DOB.ToShortDateString());
            sb.Append(",");
            sb.Append(Salary);
            sb.Append(",");
            if (gender == Gender.Male)
                sb.Append("M");
            else
                sb.Append("F");

            sw.WriteLine(sb.ToString());

            sw.Flush();
            sw.Close();
            sw.Dispose();
        }
        public void ReadFromFile()
        {
            //path setting is same as write file

            //FileStream fileStream=new FileStream("path");
            

            //using (StreamReader sr =new StreamReader(fileStream))
            //{
            //    //string s = sr.ReadToEnd();
            //    do
            //    {
            //        string s = sr.ReadLine();
            //    } while (sr != null);
            //}

        }

        //Resources
        //critical 
        //DB connection,Pointers,Graphics etc

        //non-critical
        //array,collection, any dot net managed object

        public void Dispose()
        {
            sb = null;
            Console.WriteLine("You can release both managed (non-critical) and un-managed (critical) resources");
        }

        //Finalize
        ~Employee()
        {
            Console.WriteLine("Destructors in .net is in-deterministic");
        }

    }
}
