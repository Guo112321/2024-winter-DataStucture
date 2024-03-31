# Assignment 04

Name:Xinfu Guo

ID: n01611988

### Part 1

##### 1. The advantages of utilizing centralized logging for monitoring and debugging mircroservices in a distributed system.

Centralized logging consolidates logs from microservices for unified management and monitoring, simplifying troubleshooting by enabling quick issue identification. It reduces redundant resource use by avoiding individual log handling. As the system expands, it easily adapts to new requirements and changes.



##### 2. How the Singleton design guarantees that there is only one instance of the logging service in the e-commerce platform.

As the constructor is private, no other class can create a new instance of it. The GetInstance method ensures the same instance is always returned. Throughout the lifetime of the application, only one instance of the class exists in memory, ensuring the uniqueness of the logging service.



```C#
public class SingletonLogger
{
    private static SingletonLogger _instance;

    private SingletonLogger() 
    {
    }

    public static SingletonLogger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonLogger();
        }
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {

        SingletonLogger logger = SingletonLogger.GetInstance();
        logger.Log("This is a log message");
    }
}
```

##### 3. Describe the speed and scalability factors to be taken into account while managing log data from several microservices.

The volume of log data can be immense, so efficient data processing mechanisms are needed to ensure rapid collection, storage, and retrieval of logs. As the number of microservices increases, so does the volume of log data. Therefore, the log storage system must be easily scalable to accommodate growing data volumes. 

##### 4. How the flexibility and maintainability of development are improved by utilizing standard logging APIs to integrate the logging service with microservices.

Standard logging APIs offer a unified logging interface for all microservices, simplifying the logging implementation and reducing the specific details developers need to understand. Standardized logging practices lead to clearer code, which is easier to maintain and update.



### Part 2

##### 1. Describe waht is the primary problem you try to solve.

Firstly, I need to access to credit card numbers from the file which contains credit card records.

Characterize this credit card number according to the different types of  cards it belongs to.

Creates an instance of  the appropriate credit card class.

##### 2. Describe what design pattern you use, and use plain text and diagrams to explain.

I can use Factory Pattern.

```C#
public interface ICreditCard
{
    string CardNumber { get; }
}

public class VisaCC : ICreditCard
{
    public string CardNumber { get; private set; }
}

public class MasterCC : ICreditCard
{
    public string CardNumber { get; private set; }
}

public static class CreditCardFactory
{
    public static ICreditCard GetCreditCard(string cardNumber)
    {
    }
}
```

In the creditCardFactory, I can create a method to return a ICreditcard object. And in the method, it could able to analyze which type of credit card it is based on the credit card number.

```C#
public static ICreditCard GetCreditCard(string cardNumber)
{
    if (cardNumber.StartsWith("4"))
    {
        return new VisaCC(cardNumber);
    }
    else if (cardNumber.StartsWith("5"))
    {
        return new MasterCC(cardNumber);
    }
    else if (cardNumber.StartsWith("34") || cardNumber.StartsWith("37"))
    {
        return new AmExCC(cardNumber);
    }
    else
    {
        throw new InvalidOperationException("Unsupported card type");
    }
}
```

![image-20240325190144180](C:\Users\hp\AppData\Roaming\Typora\typora-user-images\image-20240325190144180.png)

##### 3. Describe the consequences of using this pattern.

The Factory Pattern allows for the easy addition of new credit card types without modifying existing code, enhancing system flexibility.

Changes or additions of new credit card types are simpler, as this variation is confined to the factory class.