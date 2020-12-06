using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public double Add(double a, double b){
            return a+b;
        }

        public string PrimeFactor(int number){
            int i=2;
            bool factorFound= false;
            while(i<=(number/2)){
                if(number%i==0){factorFound = true;break;}
                i++;
            }
            if(!factorFound){
                return number.ToString();
            }else{
                return PrimeFactor(number/i)+"x"+i.ToString();
            }
        }

    }
}
