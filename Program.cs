

public class largest213
{
    public static void Main()
    {
        int num1, num2, num3;
      
        Console.WriteLine("Find the largest of three numbers");
        
        Console.WriteLine("enter 1st number ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter 2nd number ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter 3rd  number ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("1st Number is  largeest among three");
            }
            else
            {
                Console.WriteLine(" 3rd Number is  largest among three");
            }
        }
        else if (num2 > num3)
            Console.WriteLine(" 2nd Number is  largest among three");
        else
            Console.WriteLine(" 3rd Number is  largest among three");
    }
}
