/*AUthor: Victor Flores
 Course: COMP003A
Faculty: Jonathon Cruz
Purpose: A program demonstrating statements, variables, and operators.*/
namespace COMP003A.LEctureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declared ands initialize variables
            string userName; //variable to store user's name
            int userAge; //variable to store user's age
            double productPrice;//used for prodcut price
            bool isStudent;// to stroe if user is a student (true or false)

            //prompt user to enter their name
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine(); //read and assign the user's input to userName

            //prompt user to enter the age
            Console.WriteLine("Enter your age: ");
            userAge = int.Parse(Console.ReadLine()); // read and assign user's age

            //prompt user to enter product price
            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine());//convert and assing the user's input to productPrice

            //prompt user to indicate if they are a student
            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine()); //convert and assign the user's input to isStudent
        }
    }
}
