namespace Assignment_5
{
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    //[Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}

    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}


            #endregion


            #region Q4
            //Console.WriteLine("Enter a color name (e.g., Red, Green, Blue): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}
            #endregion

            #region Q3
            //Permissions userPermissions = Permissions.None;


            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //Console.WriteLine($"Permissions after adding: {userPermissions}");


            //bool hasReadPermission = (userPermissions & Permissions.Read) == Permissions.Read;
            //Console.WriteLine($"Has Read Permission: {hasReadPermission}");


            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");


            //bool hasExecutePermission = (userPermissions & Permissions.Execute) == Permissions.Execute;
            //Console.WriteLine($"Has Execute Permission: {hasExecutePermission}");
        }
        #endregion

 
  
    }

    }


