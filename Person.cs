namespace CsharpPart1
{
    public class Person
    {
        public string FisrtName;

        public Person(string lastName)
        {
            LastName = lastName;
        }

        public string LastName { get; private set; }
    }
    // Comment single line, don't use multi live with /*   */

    // Static Modifier, like static void Main() only 1 instance where you can access the method

    // Classes are only created at the namespace level
}