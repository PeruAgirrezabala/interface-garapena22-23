// See https://aka.ms/new-console-template for more information


using Console_Heritance;

try
{
    A objA = new A();
    objA.Prop1 = "Pepe";
    objA.Prop2 = "20";
    objA.Erakutsi();
    B objB = new B();
    objB.Prop1 = "Izaskun";
    objB.Prop2 = "47";
    objB.Prop3 = "Kortabitarte";
    objB.Erakutsi();
    Console.ReadLine();
}catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
