﻿
using Program.Model.modl;
using PROGRAM.DOMINE.domine;
namespace PROGRAM.UI.ui
{


 public class UI
{
   public void Viewing(){

        Console.Write("\n PROLIFICS PROJECT MANAGEMENT\n");
        Console.Write(" \n [Enter 1 : Add Project] \t" + "[Enter 2 : View all Projects ] \t" +"[Enter 3 : Add Employee] \t "   
                 + "\n \n [Enter 4 : View all Employees] \t" + "[Enter 5 : Add Role] \t " +  "[Enter 6 : View all Roles] \t "
                +"\n \n  [Enter 7 : Search Project] \t"+ "[Enter 8 : Search Project via Id] \t" +"[Enter 9  : Add employee to Project] \t" 
            + "\n \n  [Enter 10 : View  Project details ] \t "+"[ Enter 11 : Delete Employee from  Project] \t "+"[Enter x  :  Exit Application] "); 

        Console.WriteLine("\n \n[Select Operation] ");


        ProjectData obj = new ProjectData();
        Employee employee = new Employee();
        Project project = new Project();
        EmployeeManagement obj1 = new EmployeeManagement();
        RoleManagement obj2 = new RoleManagement();
        obj2.RoleList.Add(new Role(1,"Manager"));
        obj2.RoleList.Add(new Role(2,"Asst.Manger"));
        obj2.RoleList.Add(new Role(3,"Software Engineer" ));
        obj2.RoleList.Add(new Role(4,"Associate Software Engineer" ));
        obj2.RoleList.Add(new Role(5,"Trainee Software Engineer" ));


        Console.WriteLine("");
        Boolean error = false;
        var read = Console.ReadLine();
        while (true)
        {
            switch (read)
            {
                case "1":
                    Console.WriteLine("");
                    do
                    {
                    try
                     { 
                        ProjectId:
                        Console.WriteLine("Enter Project Id");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i< obj.Prolifics.Count;i++)
                        {
                        if(obj.Prolifics[i].id == Id)
                        {
                            Console.WriteLine("The Id already Exists \t");
                            Console.WriteLine("\n Enter any key to try again");
                            Console.WriteLine("\n Press x to get  Main Menu");

                            var tryId = Console.ReadLine();
                            if(tryId == "x")
                            {
                               goto breakage;
                            }
                            else
                            {
                                goto ProjectId;
                            }
                            }
                        }
                        
                        Console.WriteLine("Enter Project Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Project Start Date");
                        string start = Console.ReadLine();
                        Console.WriteLine("Enter Project End Date");
                        string end = Console.ReadLine();
                        Project project1 = new Project(name, start, end, Id);
                        project = project1;
                        obj.Addproject(project);
                        Console.WriteLine(" \n Project Added Successfully! \t ");
                        Console.WriteLine(" \n Enter any key to get back to Main Menu \t ");
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("\nError : Use Numbers for Id like 123....");

                    }
                }
                while(error);
                    breakage:
                    break;
                case "2":
                    obj.ViewAllProjects();
                     Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;

                case "3":
                     ProjectempId:
                    Console.WriteLine("Enter the Id of employee");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i< obj1.employeeList.Count;i++){
                        if(obj1.employeeList[i].employeeId == empId){
                            Console.WriteLine(" \n \n The id already exists \t ");
                            Console.WriteLine("\n Enter any key to try again \t");
                            Console.WriteLine(" \n Press x to get to main menu \t ");
                            var tryId = Console.ReadLine();
                            if(tryId == "x"){
                               goto breakage;
                            }
                            else{
                                goto ProjectempId;
                            }
                            }
                        }
                        
                    Console.WriteLine("Enter employee First Name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter employee Last Name");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter employee Email Id");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter employee Mobile Number");
                    string MobileNumber = Console.ReadLine();
                    Console.WriteLine("Enter Employee Address");
                    string Address = Console.ReadLine();
                    Console.WriteLine("Select 1 : Add Role Id to Employe");
                    Console.WriteLine("Select 2 : New Role to  Employee");
                    int select = Convert.ToInt32(Console.ReadLine());
                    if (select == 1)
                    {
                        try
                        {
                           obj2.DisplayRole();
                            Console.WriteLine("Select Role Id from above list to assign role to employee");
                            int r1 = Convert.ToInt32(Console.ReadLine());
                            string? rN1 = null;
                            switch (r1)
                            {
                                case 1:
                                    rN1 = "Manager";
                                    break;
                                case 2:
                                    rN1 = " Asst.Manager";
                                    break;
                                case 3:
                                    rN1 = " Software Engineer";
                                    break;
                                case 4:
                                    rN1 = " Associate Software Engineer";
                                    break;
                                case 5:
                                    rN1 = "Trainee Software Engineer";
                                    break;
                                default:
                                    Console.WriteLine("\n Invalid Entry");
                                    break;
                            }
                            Employee eadd = new Employee(empId, FirstName, LastName, Email, MobileNumber, Address, r1, rN1);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine(" \n \n Added Successfully");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n \n Emp ID in formate eg: 1234 ");
                        }
                    }
                    else if (select == 2)
                    {
                        try
                        {
                            Console.WriteLine("Enter  Role Id");
                            int roleID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter  name of the  Role");
                            string roleName = Console.ReadLine();
                            Console.WriteLine(roleName);
                            Role newRole = new Role(roleID, roleName);
                            obj2.RoleAdd(newRole);
                            Employee eadd = new Employee(empId, FirstName, LastName, Email, MobileNumber,Address, roleID, roleName);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine("\n \n ...Added Successfully...\t");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n \n Role Id should be Numbers ");
                        }
                    }
                            Console.WriteLine("");
                            Console.WriteLine("Enter any key to get back to Main Menu");
                            Console.ReadLine();
                            break;
                case "4":
                    obj1.ShowEmployees();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine(" \n \n Enter  Role Id \t ");
                        int roleID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of the  Role");
                        string roleName = Console.ReadLine();
                        Console.WriteLine(roleName);
                        Role newRole = new Role(roleID, roleName);
                        obj2.RoleAdd(newRole);
                        Console.WriteLine("\n \n ...Added Successfully...\t");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Role Id should only be in number formate ");
                    }
                    Console.WriteLine("\n \n Enter any key to get  back to main menu \t ");
                    Console.ReadLine();
                    break;

                case "6":
                    obj2.DisplayRole();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine("search for project");
                    read = Console.ReadLine();
                    obj.SearchProject(read);
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "8":
                    try
                    {
                        Console.WriteLine("Search via project id");
                        Console.WriteLine("Enter  id of project");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        obj.ShowProject(eid);
                        Console.WriteLine();
                        Console.WriteLine("Enter any key to get back to main menu");
                    }
                    catch (Exception ) 
                    {
                         Console.WriteLine("Id should be in numbers formate"); 
                    }
                    break;
                case "9":
                     Console.WriteLine("");
                    Console.WriteLine("Available projects");
                    obj.ViewAllProjects();
                    Console.WriteLine();
                    Console.WriteLine(" Available employees");
                    obj1.ShowEmployees();
                    Console.WriteLine("Enter  Project ID ");
                    int PROJId = Convert.ToInt32(Console.ReadLine());
                    if(obj.exist(PROJId))
                    {
                         Console.WriteLine("Enter the  employee ID ");
                        int EmpId = Convert.ToInt32(Console.ReadLine());
                        if( obj1.exist(EmpId)){
                            employee = obj1.eDetails(EmpId);
                            obj.EmployeeToProject(PROJId,employee);
                            //AddingEmptoProject addition = new AddingEmptoProject();
                            //addition.addingemp();
                            Console.WriteLine(" Project Added Successfully");
                             Console.WriteLine("Enter any key to get to main menu");
                            Console.ReadLine();
                        }
                        else{
                             Console.WriteLine("Employee does not exist");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Project does not exist");
                    }
                    //  }
                    var Read = Console.ReadLine();
                    break;

                case "10":
                    Console.WriteLine("Enter Project Id");
                         int pid = Convert.ToInt32(Console.ReadLine());
                    obj.Display();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "11":  try{
                    obj.ViewAllProjects();
                    Console.WriteLine("Enter Project ID");
                    int PROJId1 = Convert.ToInt32(Console.ReadLine());
                    if(obj.exist(PROJId1)){
                        Console.WriteLine("Enter Employee ID ");
                        int EmpId1 = Convert.ToInt32(Console.ReadLine());
                        employee = obj1.eDetails(EmpId1);
                        obj.EmployeeFromProject(PROJId1,employee);
                        Console.WriteLine("\n Employee Deleted Successfully");
                        
                    }
                    else{
                        Console.WriteLine("The project do not exist");
                    }
                }
                catch(FormatException e){
                    Console.WriteLine("Id can only be integer");
                }
                Console.WriteLine("Enter any key to get to main menu");
                        Console.ReadLine();
                break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
        
   
        
        Console.Write("\n LIST OF OPERATIONS ");
        Console.Write(" \n [Enter 1 for add project] \t" + "[Enter 2 to view all projects ] \t" +"[Enter 3 for addEmployee] \t "   
                 + "\n \n [Enter 4 for view all Employees] \t" + "[Enter 5 for add Role] \t " +  "[Enter 6 for view all Roles] \t "
                +"\n \n  [Enter 7 for search project] \t"+ "[Enter 8 for search project through id] \t" +"[Enter 9 to add employee to project] \t" 
            + "\n \n  [Enter 10 view  project details ] \t "+"[Enter 11 to remove employee from  project] \t "+"[Enter x exit application] "); 
         Console.WriteLine("\n \n [Select operation]");
        read = Console.ReadLine();
        }
    }
   }
}
