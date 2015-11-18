namespace System; //We need this for not typing the System. after every command.

namespace ACSL1 //Namespace definition. That is easier way to travel through namespaces.
{
    class A1 //Our class for writing "Hello World!"
    {
        public static void main() // Our On-Launch function.
        { //Every function have these block parantheses. This is actually like Pascal's Begin.
            Console.WriteLine("Hello World!"); //The function that writes into console
            Console.ReadKey();//Making window not close immediately after finish, by waiting user to type key.
        } //Every function have these block parantheses. This is actually like Pascal's End.
    } //Every class have these block parantheses. This is actually like Pascal's End.
} //Every namespace have these block parantheses. This is actually like Pascal's End.
//This is program for writing Hello World string into console.
//Unlike other languages, .Net and C# have not exact Ending function.
// C++ have return 0;
// VB have End();
// Pascal have END.
// And else.
// But this language have not any ending function, it finishes when there is no function to execute.
// This is first lesson in every tutorial for C#.
