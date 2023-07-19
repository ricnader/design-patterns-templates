using DesignPatternsTemplates;


var singletonObject1 = SingletonTemplate.instance;
var singletonObject2 = SingletonTemplate.instance;

//singletonObject.setValue1("Teste");

Console.WriteLine(singletonObject1 == singletonObject2);
Console.ReadLine();