
public class Program
{
    public static void Main()
    {
        var flag = true;
        do
        {
            Console.WriteLine("enter an integer");
            var num = Console.ReadLine();
            int userInput = int.Parse(num);
            //int x =userInput * userInput;
            //int y = userInput * userInput * userInput;
            //Console.WriteLine((x, y));
            Console.WriteLine("number\t\tSquared\t\tCubed\t\t");
            Console.WriteLine("======\t\t======\t\t======");
            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine(i + "\t\t" + i * i + "\t\t" + i * i * i + "\t\t");

            }
            Console.WriteLine("Do you want to continue? Y/N?");
            var Input=Console.ReadLine();
            if (Input =="y")
            {
                flag = true;
            }
            else
            {
                flag = false;   
            }
            
            

               
        } while (flag);
        
    }
}