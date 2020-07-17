using System;

namespace SubtractionProject
{
    public class SubtractClass
    {
        public static int Subtract(int a, int b){
            int result;
            checked
            {
                result = a - b;
            }
            
            return result;
        }
    }
}
