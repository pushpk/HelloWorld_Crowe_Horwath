Coding Sample is organized in 3 parts

#### HelloWorld_Crowe_Horwath - Console APP

A .NET Core Console project that does following
* Setting Configuration file Path and  Getting Configuration back
* Dependency Registration of Services by registering ITarget
* Calling API to get response of "Hello World"
* Utilizing Factory Method Pattern to Get Target to display Greeting Message
* Factory Method Pattern has currently two implementations `Console` and `Database`, In Future if requirements come to add to text file or something else, we can easily extend current factory to include more sources.

#### HelloWorld_Crowe_Horwath_API_Services -  Service

A .NET Core API project that does following
* Dependency Injection of IGreeting to HelloWorldGreeting
* Controller with one get endpoint that returns "Hello World"

#### HelloWorld_Crowe_Horwath_UnitTest -  Unit Test
 
 MS test Project that has following unit tests
 1. API test - that asserts greeting message returned by controller method
 2. Facotry Creation Test - verifies factories getting created correctly based on parameter