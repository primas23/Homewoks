# Creational Patterns

## Factory Method/Метод Фабрика

 * Същността на шаблона е да дефинира структура на обект, който може да бъде създаден и наследяван, но да оставя на наследниците му да решават, какъв ще резултата от методът му. Това се осъществява с абстрактен калс, който има в себе си абстрактен метод. Така логиката може да се променя от наследниците, а в основният код да се бъде вика един и същи метод.

## Клас диаграма:

![Factory method](http://www.dofactory.com/images/diagrams/net/factory.gif)

Примерен код:
* Създаване на *parent* калса
```
abstract class Product
{
}   
```
* Създаване на наследяващите го класове
```
class ConcreteProductA : Product
{
}

class ConcreteProductB : Product
{
}
```
* Създаване на *структура за основният създаващ клас*, който ще инициализира наследниците
```
abstract class Creator
{
    public abstract Product FactoryMethod();
}
```
* Създаване на калсове който ще наследяват *създаващият клас*
```
class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod()
    {
      return new ConcreteProductA();
    }
}

class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod()
    {
      return new ConcreteProductB();
    }
}
```
* Използване на шаблона
```
class MainApp
{
    static void Main()
    {
      // An array of creators
      Creator[] creators = new Creator[2];
 
      creators[0] = new ConcreteCreatorA();
      creators[1] = new ConcreteCreatorB();
 
      // Iterate over creators and create products
      foreach (Creator creator in creators)
      {
        Product product = creator.FactoryMethod();
        Console.WriteLine("Created {0}",
          product.GetType().Name);
      }
 
      // Wait for user
      Console.ReadKey();
    }
}
```