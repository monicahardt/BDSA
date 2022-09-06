namespace MyApp;

public class Year
{

    public static void Main (string[]args){
        Console.WriteLine("Type a year");
        var inputYear = Console.ReadLine();
        isInputLeapYear(inputYear);
    }
    
    public static bool isLeapYear(int year)
    {
        if(year%4 == 0){
            if(year%100 == 0 && year%400 != 0){
                    return false;
                } else {
                return true; 
            }
        } else {
            return false;
        }
    }

    public static void isInputLeapYear(string s)  {


        try{
            int inputYearInt = Convert.ToInt32(s);

            if(inputYearInt<1582){
                throw new FormatException("Please enter valid input");
            }
            if(isLeapYear(inputYearInt)){
            Console.WriteLine("yay");
        } else {
            Console.WriteLine("nay");
        }
        } catch (FormatException e) {
            Console.WriteLine("Please enter valid input");
        }
    }
}
