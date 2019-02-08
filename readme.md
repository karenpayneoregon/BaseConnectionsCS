# Base connection library (CS)

This repository is for base classes used for connecting to both SQL-Server and MS-Access databases using several classes for both easily creating connections along with a generalized method to detect runtime exceptions.

> This code may not suit every developer's need and also may seem like overkill to the novice developer. The intent is to have a base class that can be used in any project in one or more Visual Studio solutions. Although the code is C#, the base library can be used with VB.NET also.

## Getting started
- Add the class project [KarenBase](https://github.com/karenpayneoregon/BaseConnectionsCS/tree/master/KarenBase) to your Visual Studio solution, rename the project if so desired.
- Add a reference to KarenBase to your Windows forms project.
- ***Set*** `DatabaseServer` to your server e.g. KARENS-PC or for SQL-Server Express .\SQLEXPRESS
- ***Set*** `DefaultCatalog` to the targeted database in the server above.
- Follow the example in the project SampleSqlConnection for SQL-Server. MS-Access example to follow.

### Requires
- Microsoft Visual Studio 2015 or higher.

### Tips
- [IsSuccessFul](https://github.com/karenpayneoregon/BaseConnectionsCS/blob/master/KarenBase/Classes/BaseExceptionProperties.cs) from the base exception class allow a type to be returned from a function such as a [List(Of T)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2) or [DataTable](https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable?view=netframework-4.7.2) without the need to be concerned with if there had been a runtime exception as after the method calls and before using the return item check IsSuccessFul.

```csharp
using System;
using SampleSqlConnection.Classes;

namespace SampleSqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DataOperations ops = new DataOperations();

            ops.TestSqlConnection();
            if (ops.IsSuccessFul)
            {
                Console.WriteLine("Successfully connected!!!");
                Console.ForegroundColor = foregroundColorColor;
            }
            else
            {
                Console.WriteLine("Unsuccessful");
                Console.WriteLine(ops.LastExceptionMessage);
            }
            Console.ReadLine();
        }
    }
}

```

For VB.NET version of this library, see [the following repository](https://github.com/karenpayneoregon/BaseConnectionsVisualBasicNet).


