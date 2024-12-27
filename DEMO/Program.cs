namespace DEMO
{
    //enum Status
    //{
    //    Pending,
    //    Approved,
    //    Rejected
    //}
    //enum DaysOfWeek
    //{
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday
    //}

    internal class Program
    {
        //public string PublicProperty { get; set; } = "Public";
        //private string PrivateProperty { get; set; } = "Private";
        //protected string ProtectedProperty { get; set; } = "Protected";
        //internal string InternalProperty { get; set; } = "Internal";
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //int value = 123;
            //object boxedValue = value; 
            //Console.WriteLine($"Boxed value: {boxedValue}");


            //object obj = 456;
            //int unboxedValue = (int)obj; 
            //Console.WriteLine($"Unboxed value: {unboxedValue}");
            #endregion


            #region Nullable Value Types
            //int? nullableInt = null;

            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine($"Value: {nullableInt.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Value is null");
            //}

            //nullableInt = 42;
            //Console.WriteLine($"New Value: {nullableInt ?? 0}");
            #endregion


            #region Nullable Reference Types
            ////string? name = null;

            ////if (name != null)
            ////{
            ////    Console.WriteLine($"Hello, {name}");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Name is null");
            ////}

            ////name = "John";
            ////Console.WriteLine($"Hello, {name}");
            #endregion


            #region Null-Propagation Operator
            //string? str = null;
            //Console.WriteLine($"String Length: {str?.Length ?? 0}");

            //str = "Hello, World!";
            //Console.WriteLine($"String Length: {str?.Length ?? 0}");
            #endregion


            #region Exception Handling and Protective Code
            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]); // IndexOutOfRangeException
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Execution completed.");
            //}
            #endregion


            #region Access Modifiers
            //Program program = new Program();
            //Console.WriteLine(program.PublicProperty);
            //// Console.WriteLine(program.PrivateProperty); // Not accessible
            //// Console.WriteLine(program.ProtectedProperty); // Not accessible
            //Console.WriteLine(program.InternalProperty);
            #endregion

            #region  Enum Example 1
            //DaysOfWeek today = DaysOfWeek.Monday;
            //Console.WriteLine($"Today is: {today}");
            #endregion


            #region Enum Example 2
            //Status orderStatus = Status.Approved;

            //switch (orderStatus)
            //{
            //    case Status.Pending:
            //        Console.WriteLine("Order is pending.");
            //        break;
            //    case Status.Approved:
            //        Console.WriteLine("Order is approved.");
            //        break;
            //    case Status.Rejected:
            //        Console.WriteLine("Order is rejected.");
            //        break;
            //}
            #endregion

        }
    }
}
