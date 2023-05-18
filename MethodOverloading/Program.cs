namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Addmethod(0, 1, true);
        }

        public static int Addmethod(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Addmethod(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Addmethod(int num3,int num4, bool sam)
        {
            if (sam == true && num3 + num4 == 1)
            {
                return $"{num3 + num4} dollar";
            }

            else if (sam == true && num3 + num4 != 1)
            {
                return $"{num3 + num4} dollars";
            }
            else
            {
                return $"{num3 + num4}";
            }
        }
            
            
        
        
        

        

    }

}
