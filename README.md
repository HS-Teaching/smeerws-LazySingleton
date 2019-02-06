# smeerws-LazySingleton

A singleton is a design pattern.
The implementation of a singleton design pattern within a class ensures that *only one* instance of the object 
ever exists at any one time. 
There exist several different singleton implementations. 

+ Link to [SimpleSingleton](https://github.com/HS-Teaching/smeerws-SimpleSingleton)
+ Link to [PersistentSingleton](https://github.com/HS-Teaching/smeerws-PersistentSingleton)
+ Link to [ConcreteSingleton](https://github.com/HS-Teaching/smeerws-ConcreteSingleton)

This unity project serves as reference for the implementation of a lazy singleton.
This fixes the persistency problem (across scenes) and in addition the singleton object must not be present in the hierarchy (lazy instantiation).  

The singleton design pattern can be used for saving data between scenes. 
Use singletons for controller classes such as GameManager, GameController, etc. where it is important that an instance 
exists only once. 

Dev-platform: Win 10, Unity Version: 2018.2.14f1, Visual Studio Version: VS Community 2017, 15.3.9;
Scripting Runtime Version: .NET 4.x Equivalent
API Compatibility Level: .NET Standard 2.0

Target platform: Standalone (Reference Resolution: 1024 x 768)