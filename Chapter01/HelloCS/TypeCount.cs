
#nullable enable
using System;
using System.Linq;
using System.Reflection;
public class TypeCount {
    public int? Id { get; set; }
    public string Name { get; set; }
    public static void ShowAllType(){
        foreach(var refAssembly in Assembly.GetEntryAssembly().GetReferencedAssemblies()){
            var a = Assembly.Load(new AssemblyName(refAssembly.FullName));
            int methodCount = 0;
            foreach(var definedType in a.DefinedTypes){
                methodCount+=definedType.GetMethods().Count();
            }
            Console.WriteLine($"{a.DefinedTypes.Count()} types with {methodCount} methods in {refAssembly.Name} assembly.");
        }
    }
}