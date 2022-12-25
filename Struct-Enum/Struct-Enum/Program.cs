
#region Test-Employee



//using Struct_Enum;
//using Struct_Enum.Constants;

////Test test = new Test();
////test.MyProperty = 1;

////Console.WriteLine(test.MyProperty);



//Employee employee = new Employee("Mirze", "Besirzade", 26, "Bulbule");

////Console.WriteLine(employee);


////Console.WriteLine(GetEmployee(employee));


//static Employee GetEmployee(Employee employee)
//{
//    return employee;
//}

////static string GetEmployee(Employee employee)
////{
////    return employee.Name + " " + employee.Surname;
////}


//string email = "ff@gmail.com";

//if(email != "tt@gmail.com")
//{ 

//    Console.WriteLine(Errors.LoginMessage);

//}


#endregion


using Struct_Enum.Enum;


#region Roles


int roleId = 2;

//if(roleId == (int) Roles.SuperadminAdmin)
//{
//    Console.WriteLine("Super admindir");
//}

//switch (roleId)
//{
//    case(int) Roles.SuperadminAdmin:
//        Console.WriteLine("Super admindir");
//        break;
//    case (int)Roles.Admin:
//        Console.WriteLine("Admindir");
//        break;
//    case (int) Roles.Member:
//        Console.WriteLine("Memberdir");
//        break;

//        default:
//        Console.WriteLine("Role tapilmadi");
//        break;

//}




//string[] names = Enum.GetNames(typeof(Roles));

//foreach(var item in names)
//{
//    Console.WriteLine(item);
//}


string[] names = Enum.GetNames(typeof(Roles));
string inputData = "Admin";
foreach (var item in names)
{
    if(inputData == item)
    {
        Console.WriteLine($"User role is - {item}" );
        break;
    }
}


int[] result = (int[])Enum.GetValues(typeof(Roles));
foreach (var item in result)
{
    Console.WriteLine(item);
}

#endregion




//#region WeekDays


//using Struct_Enum.Enum;

//int dayId = 5;

//switch (dayId)
//{

//    case (int)WeekDays.Monday:
//        Console.WriteLine("The day is Monday");
//        break;
//        case(int)WeekDays.Tuesday:
//        Console.WriteLine("The day is Tuesday");
//        break;
//    case (int)WeekDays.Wednesday:
//        Console.WriteLine("The day is Wednesday");
//        break;
//    case(int)WeekDays.Thursday:
//        Console.WriteLine("The day is Thursday");
//             break;
//        case(int)WeekDays.Friday:
//        Console.WriteLine("The day is Friday");
//        break;
//        case(int)WeekDays.Saturday:
//        Console.WriteLine("The day is Saturday");
//        break;  
//        case(int)WeekDays.Sunday:
//        Console.WriteLine("The day is Sunday");
//        break;
//        default:
//        Console.WriteLine("The day is founded");
//        break;






//}

//#endregion


