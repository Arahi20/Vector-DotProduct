using System.Numerics;

internal class Program
{
    static double[]ReadVector()
    {
        string Userinp = Console.ReadLine();
        string[]Components = Userinp.Split(',');
        double[]vector =new double[Components.Length];
        for(int i = 0;i<Components.Length;i++)
        {
            if(double.TryParse(Components[i],out double Component))
            {
                vector[i] = Component;
            }
            else
            {
                Console.WriteLine("The Input is not valid" + Components[i]);
                Environment.Exit(1);
            }
        }
        return vector;

    }
       static double DotProduct(double[] a, double[] b)
    {
        double result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result += a[i] * b[i];
        }

        return result;
    }




    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the Components of the first vector"); //Refered to Vector A internally
        double[]VectorA = ReadVector();
        Console.WriteLine("Enter the components of the second vector"); //Refered to as Vector B internally 
        double[]VectorB = ReadVector();

        //Dot product only works when they both are the same length
        if(VectorA.Length != VectorB.Length)
        {
            Console.WriteLine("The Vectors have to be the same length");

        }
        else
        {
            double dotproduct= DotProduct(VectorA,VectorB);
            Console.WriteLine("The dot product of the two vectors is: " + dotproduct);
        }
        Console.ReadLine();

    }
}