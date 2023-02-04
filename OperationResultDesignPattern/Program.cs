using Newtonsoft.Json;
using OperationResultDesignPattern;


Executor executor = new Executor();
var obj=executor.Operation();

var json= JsonConvert.SerializeObject(obj, Formatting.Indented);


Console.WriteLine(json);

Console.WriteLine("Bitti!");
Console.ReadKey();