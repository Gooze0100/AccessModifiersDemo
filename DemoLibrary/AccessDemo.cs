namespace DemoLibrary;

public class AccessDemo
{
    // works the same as for function and events and so on
    private int test;
    private void Demo()
    {
        PrivateDemo();
    }

    // private is only accessible in area it was declared, so just think that it is just accessible just in curly braces of this class
    // so it can be called just with methods in this class
    // nowhere other place it cannot bet accessed
    private void PrivateDemo()
    {

    }

    // It is available in AccessDemo
    // it is not available in other projects just in inherited from this class
    // it is available in inheritance class but not in other projects like ConsoleUI you cannot access it there
    // difference is that in which assembly it is in
    // we can just access it in just same assembly, if it is in same assembly it is protected
    // protects to do not access it outside dll file
    private protected void PrivateProtectedDemo()
    {

    }

    // this is mostly for inheritance, but we do not do that so often
    // you can access it in this AccessDemo class where it is declared or any method inside the class where you derive from this class
    // so protected let us call from other class that inherited
    // this can be very usefult for helper methods in those inherited object, and you don't want to make it accessible to any other class instead for this class or inherited class
    protected void ProtectedDemo()
    {

    }

    // we can access it in same assembly other classes, like calling demo
    // it cannot be accessed in Program.cs
    // also it can be accessed in InheritanceDemo in other assembly where it is inheriting
    // so can access in same assembly and also in where it inherits
    // it is protected inside itself assembly and it is internal inside where it inherits from
    protected internal void ProtectedInternalDemo()
    {

    }

    // this is broader than private, but it is similar in not works outside of the project assembly
    // so for this scope is entire object that where it was created, so it can be accessed in all DemoLibrary, but not outside of it
    // in documentation it is called an assembly scope it just means the project, creating dll it is assembly like console creates executable it is assembly
    // so use internal when you want to get access for that in all your project
    // so it won't be exposed outside your dll
    internal void InternalDemo()
    {

    }

    // public means that it is accesible for everone, it does not matter if you are in same assembly
    // so if you can reference me you can acccess me
    public void PublicDemo()
    {

    }

    // most common public and private
    // private is used for helpers and something small, that would not nessesary to use outside the class it is used.
    // internal should be used more often, it is good especially in library or helpers or where it is used in other classes
    // it is DRY where you can use your code elsewhere and it is very important part of being developer
    // so think of using few times but written once
    // protected it is not used so often if you do not inheritance if you do it then it is used quite often
    // 
}
