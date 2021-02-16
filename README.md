# MyTestLib

Simple C# library


## Getting Started

Build the library. Debug or release depends on your intent.

```BASH
dotnet build
```

Using the library is simple. Include the path to the dll in your csproj file.

```XML
<ItemGroup>
  <Reference Include="MyTestLib">
    <HintPath>path/to/MyTestLib.dll</HintPath>
  </Reference>
</ItemGroup>
```

Add the using declarative

```C#
using System;
using System.Collections.Generic;
...

using MyTestLib;

...


public void SomeFunction()
{
    var myList = new List<double>()
    {
        1, 1, 2, 3, 5, 8, 13
    };

    var someLib = new MyTestLib();
    // All the values of myList are summed and stored in the sum variable
    var sum = someLib.SumListValues(myList);
}
```