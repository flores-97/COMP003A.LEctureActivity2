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

            //perfroming calculations
            int futureAge = userAge + 5; //calculate user's age in 5 years
            bool isAdult = userAge >= 18; //determines if use is 18 or older
            bool isAdultStudent = isStudent && isAdult; //determines if use is both a student and an adult

            //display outputs using string interpolation
            Console.WriteLine($"\nHello, {userName}!");//great user with their name
            Console.WriteLine($"You are currently {userAge} years old. In 5 years, you will be {futureAge}.");//display current and future age
            Console.WriteLine($"Are you 18 or older? {isAdultStudent}");//display if user is bith studen and adult
        }
    }
}
