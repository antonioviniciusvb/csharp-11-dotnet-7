using System.Data;
using System.Reflection;

//Declare some unused variables using types
//in additional assemblies
DataSet ds;
HttpClient client; 


Assembly? myApp = Assembly.GetEntryAssembly();

//quit the app
if (myApp == null)
    return;

//loop through the assemblies that my app references
foreach (var assemblyName in myApp.GetReferencedAssemblies())
{
    //Load the assemblies that my app references
    var assembly = Assembly.Load(assemblyName);

    //Declare a variable to count the number of methods
    int methodCount = 0;

    //Loop through all the types in the assembly
    foreach (var definedTypes in assembly.DefinedTypes)
    {
        //Add up the counts of methods
        methodCount += definedTypes.GetMethods().Count();
    }

    //output the count of types and their methods
    Console.WriteLine($"{assembly.DefinedTypes:N0} types with {methodCount:N0} methods in {assemblyName.Name:N0} ");
}

