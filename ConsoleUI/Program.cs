using DemoLibrary;

AccessDemo demo = new();

demo.PublicDemo();

BadClassDemo bad = new();
// this is a security risk
var ccn = bad.creditCardNumber;
var ssn = bad.SSN;
var badAge = bad.Age;
// this wont add anything
bad.Age = 150;
// but this will add
bad._age = 150;

static void SayHello()
{
    Console.WriteLine("Hello user");
}