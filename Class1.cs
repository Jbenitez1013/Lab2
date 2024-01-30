using System.Reflection.Metadata.Ecma335;

namespace Lab2Class
{
    public class Class1



    {
        // Juan Benitez | Tech4982-01 | Lab #2

        double number1, number2;

        public static double Min( double number1,  double number2)
        {
            double min;


            if (number1>number2)
            {

                min = number2;
            }

            min = number1;


            return min;

        }

        public static double Min(double number1, double number2, double number3)
        {
            double min, min2;

            if (number1 > number2)
            {

                min = number2; 

            }
                min = number1;
            
            if (min>number3)
            {

                min2 = number3;
                return min2;

            }

            return min;


        }

    }

}

