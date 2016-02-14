 ## .csproj order affects Autofac resolution
 
 This sample contains two projects `AthenB` and `BthenA`. Both projects contain an interface `IThing` and two concrete implementations, imaginatively named `A` and `B`. These projects are identical except in `AthenB.csproj`, `A.cs` is listed before `B.cs`. In `BthenA.csproj` the order is reversed. This ordering appears to affect the order in IL and thus the order of registration in Autofac when using
 
 ```csharp
 builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
 ```
 
 which may result in unexpected behavior.