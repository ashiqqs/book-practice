
using System.Text.RegularExpressions;
namespace PeopleApp
{
    /*
    Using 'static' before class and 'this' before param type 
    tell the compiler that this is a extend method of string type.
    */
    public static class StringExtention
    {
        public static bool IsValidEmail(this string email){
            return Regex.IsMatch(email,@"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
        public static bool IsNumber(this string text){
            return int.TryParse(text,out int n);
        }
    }
}