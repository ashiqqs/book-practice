using System;
using PackLibrary;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate,Event
            //This is local funtion
            void Ashiq_Shout(object sender, EventArgs e){
                Person ashiq = (Person)sender;
                WriteLine($"{ashiq.Name} is angry. Anger Level: {ashiq.AngerLevel}");
            }
            Person p = new Person("Ashiqur Rahman");
            p.Shout = Ashiq_Shout; //asigning Ashiq_Shout() into EventHandler delegate;
            p.Poke();
            p.Poke();
            p.Poke();
            p.Poke();
            #endregion

            #region Differentiating between instance and static method
            var nayok = new Person("Nayok");
            var villen = new Person("Villen");
            var nayeeka = new Person("Nayeeka");

            var baby1 = Person.Procreate(nayok,nayeeka);
            var baby2 = nayeeka.ProcreateWith(villen);

            var baby = nayok*nayeeka; //using overloaded * operator;

            WriteLine($"{nayeeka.Name} has {nayeeka.Children.Count} Children."); //Nayeeka has 1 Children.
            WriteLine($"{nayeeka.Name}'s first children is named {nayeeka.Children[0].Name}.");
            //Nayeeka's first children is named Baby of Nayok & Nayeeka.


            WriteLine($"{nayok.Name} has {nayok.Children.Count} Children.");
            WriteLine($"{villen.Name} has {villen.Children.Count} Children.");
            WriteLine($"{nayeeka.Name} has {nayeeka.Children.Count} Children.");

            WriteLine($"{nayeeka.Name}'s first children is named {nayeeka.Children[0].Name}.");
            #endregion

            #region Delegate
            var d = new MyDelegate(StrLen);

            WriteLine(d("Ashiq"));
            #endregion

            #region Extending method
            string email1 = "ashiq.mail.net@gmail.com";
            string email2 = "10";

            WriteLine($"{email1} is valid {email1.IsValidEmail()}");
            WriteLine($"{email2} is valid {email2.IsValidEmail()}");

            WriteLine($"{email1} is number {email1.IsNumber()}");
            WriteLine($"{email2} is number {email2.IsNumber()}");
            #endregion
        }

        public static int StrLen(string str){
            return str.Length;
        }
    }
    
    delegate int MyDelegate(string str);
}
