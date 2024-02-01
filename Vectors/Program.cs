using System.Numerics;

internal class Program
{
    static double[]ReadVector()
    {
        //This method is responsable for taking the userinput which is a string than converting it into a vector which we classify as a 'Double' array.
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
        //Calculates the Dot product by timings the first vector with the second and adding that to result


        double result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result += a[i] * b[i];
        }

        return result;
    }

    static double Length_of_Vector(Double[] vector)
    {


        //Using the Length formula
        double sumOfSquares = 0;
        foreach (var component in vector)
        {
            sumOfSquares += component * component;
        }

        return Math.Sqrt(sumOfSquares);
        
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

            //Adding on angle calculations
            double LenA = Length_of_Vector(VectorA);
            double LenB =Length_of_Vector(VectorB);

            //Using the formula 
            double cosTheta = dotproduct/(LenA*LenB);
            
            double radians = Math.Acos(cosTheta);
            double degrees = radians * (180/Math.PI);
            Console.WriteLine("The angle between the two vectors is: " + degrees + " degrees");


        }
        Console.ReadLine();

    }
}