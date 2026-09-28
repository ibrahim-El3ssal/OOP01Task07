namespace OOP01Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            // Q1: Overloading, Overriding, and Binding

            /*
             * a) What is the difference between Method Overloading and Method Overriding?
             * 
             * - Method Overloading:
             *   - Type: Static Polymorphism (Compile-time Polymorphism).
             *   - Definition: Allows a class to have multiple methods with the same name within the same class, 
             *                 but with different parameter lists 
             * 
             * - Method Overriding:
             *   - Type: Dynamic Polymorphism (Runtime Polymorphism).
             *   - Definition: Allows a derived (child) class to provide a specific implementation for a method 
             *                 that is already defined in its base (parent) class using virtual and override keywords.
             */

            /*
             * b) What is the difference between Static Binding and Dynamic Binding?
             * 
             * - Static Binding (Early Binding):
             *   - Timing: Occurs during Compile-Time.
             *   - Behavior: Method call is resolved based on the Reference Type at compile time.
             *   - Used With: Method Overloading and Method Hiding (using the 'new' keyword).
             * 
             * - Dynamic Binding (Late Binding):
             *   - Timing: Occurs during Runtime.
             *   - Behavior: Method call is resolved based on the actual Object Type in memory at runtime.
             *   - Used With: Method Overriding (using virtual/override) and Abstract Methods.
             */

            #endregion


            Console.ReadLine();
        }
    }
}
