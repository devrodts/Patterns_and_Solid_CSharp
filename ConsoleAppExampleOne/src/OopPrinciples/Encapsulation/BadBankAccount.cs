using System;

namespace ConsoleAppExampleOne.src.OopPrinciples.Encapsulation
{
    //  The above code is an example of a bad implementation of encapsulation. The class has public properties that can be accessed and modified by any class in the application. This is a bad practice because it violates the principle of encapsulation. 
    //  Encapsulation is a fundamental principle of object-oriented programming that allows you to hide the internal state of an object and only expose the necessary information to the outside world. This helps to protect the object's internal state and prevent it from being modified by external classes. 
    public class BadBankAccount
    {
        public decimal balance { get; set; }
        public DateTime AccountCreationDate { get; set; }
        
    }
} 



