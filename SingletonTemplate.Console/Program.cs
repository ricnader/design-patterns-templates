using DesignPatternsTemplates;


var singletonObject1 = UserSingleton.getInstance();
var singletonObject2 = UserSingleton.getInstance();


Console.WriteLine(singletonObject1 == singletonObject2);
Console.WriteLine(singletonObject1.GetHashCode());
Console.WriteLine(singletonObject2.GetHashCode());
singletonObject1.PrintUsers();
//Console.WriteLine();
Console.ReadLine();