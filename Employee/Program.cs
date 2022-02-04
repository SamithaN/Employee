using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            string  dname,userName;
            int eid, did,age;
            char c;


            Department[] depid = new Department[20];
            Department.Employee[] Eeid = new Department.Employee[100];
            Console.WriteLine("Do you want to create a Department(y/n)?");

            c = Console.ReadLine()[0];
            for (int i = 0; i < 20; i++)
            {
                
                if (c.Equals('y'))
                {
                    Console.WriteLine("Enter Department Name:");
                    dname = Console.ReadLine();

                    Console.WriteLine("Enter Did:");
                    did = Convert.ToInt32(Console.ReadLine());

                    depid[did] = new Department();

                    depid[did].dname = dname;
                    depid[did].did = did;

                    
                }
                else
                {
                    break;
                }
                Console.WriteLine("Do you want to add a Employee(y/n)?");
                 c = Console.ReadLine()[0];
                if (c.Equals('y'))
                {
                    for (int j = 0; j < 100; j++)
                    {


                        Console.WriteLine("Enter Employee Name:");
                        userName = Console.ReadLine();

                        Console.WriteLine("Enter Eid:");
                        eid = Convert.ToInt32(Console.ReadLine());

                        //Console.WriteLine("Enter Did:");
                        //did = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Enter age:");
                        age = Convert.ToInt32(Console.ReadLine());

                        if (age > 100)
                        {
                            Console.WriteLine("cannot enter more than 100");
                            Console.WriteLine("Enter age:");
                            age = Convert.ToInt32(Console.ReadLine());
                        }

                        
                        Eeid[eid] = new Department.Employee();
                        Eeid[eid].eid = eid;
                        Eeid[eid].ename = userName;
                        Eeid[eid].age = age;

                        Console.WriteLine("Do you want to add another Employee(y/n)?");
                        c = Console.ReadLine()[0];
                        if (c.Equals('y'))
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                                       
                }
                Console.WriteLine("Do you want to create a Department(y/n)?");
                c = Console.ReadLine()[0];
                if (c.Equals('y'))
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("*******************************");
                    break;
                }
                                
            }
            


            Console.WriteLine("Do you want to see employee details(y/n) ?");
            c = Console.ReadLine()[0];
            if (c.Equals('y'))
            {
                Console.WriteLine("Input Employee id :");
                eid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Did:");
                did = Convert.ToInt32(Console.ReadLine());

                depid[did].depDetails(did);
                Eeid[eid].displayDetail();
            }




            Console.WriteLine("Thank you");

        }
    }

    public class Department
    {
        public int did;
        public string dname;

        public Department()
        {

        }
        public class Employee : Department
        {
            public int eid, age;
            public string ename;


            public void displayDetail()
            {

                //Eeid[eid].displayDetail();
                Console.WriteLine("UserID is: " + this.eid);
                Console.WriteLine("Employee name is: " + this.ename);
                //Console.WriteLine("Works on " + dname + " department");
                Console.WriteLine("Employee age is: " + this.age);

            }
        }
        public void depDetails(int did)
        {
            Console.WriteLine(dname + " department");
            Console.WriteLine("Deparment id : "+did);
        }

       
    }
    



}

    

