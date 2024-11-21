namespace challenge_assignmentweek_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numberpair = false;
            Console.WriteLine("enter your array");

            int[] inputarray = new int[5];

            for (int i = 0; i < inputarray.Length; i++)
            {
                Console.WriteLine($"enter your values {i+1}");
                inputarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("these are your numbers");

            Console.Write("[");
            for (int i = 0;i < inputarray.Length; i++)
            {

                Console.Write(inputarray[i] +",");
                }
            Console.WriteLine("]");

            Console.WriteLine("enter the target number");
            int targetnum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < inputarray.Length; i++)
            {
                for (int j = i +2 ; j < inputarray.Length; j++)
                {
                    if (inputarray[i] + inputarray[j] == targetnum)
                    {
                        Console.WriteLine($"Target number {targetnum}: is the sum of elements {i},{j}");
                        numberpair = true;
                    }
                    
                }
            }
            if (!numberpair)
            {
                Console.WriteLine($"No numbers in the array add up to {targetnum}");
            }
                
            
            
        }
    }
}
