namespace MyApp;

public class Year
{
    public bool isLeapYear(int year)
    {
        if(year%4 == 0){
            if(year%100 == 0 && year%400 == 0){
                    return true;
                } else {
                return true; 
            }
        } else {
            return false;
        }
    }
}
