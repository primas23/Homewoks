# Creational Patterns

## Simple Factory/Фабрика

 * Същността на шаблона е много точно отговаряша на значението на дума в реалният свят. Той е фабриката, която връща инстанции на калс според подадени параметри. В примерният код може да се види наличието на един *родителски* калс, който определя основните методи който са необходими за използване на калсовете. Всеки един от класовете го наследява и благодарение на това има възможността да променя това което извръшва методът на родителя си. *__Фабриката__* която се грижи за създаването на инстаницийте определя по дадена логика, коя точно инстаниция трябва да се върне.

## Клас диаграма:

![Factory method](http://dotnet-stuff.com/pics/post/Simple-Factory-Design-Pattern-UML.jpg)

Примерен код:
* Създаване на *parent* калса
```
public class CheckBook
    {
        protected decimal _Amount;
        public decimal getExpense()
        {
            return _Amount;
        }
    }    
```
* Създаване на наследяващите го класове

```
public class Health:CheckBook
    {
        public Health()
        {
            _Amount = 5000;//Could be any logic to calculate health amount
            Console.WriteLine("Your Health Expense: {0}", _Amount.ToString());
        }
    }
public class Travel : CheckBook
    {
        public Travel()
        {
            _Amount = 10000;//Could be any logic to calculate travel amount
            Console.WriteLine("Your Travel Expense: {0}", _Amount.ToString());
        }
    }
 
    public class Personal : CheckBook
    {
        public Personal()
        {
            _Amount = 15000;//Could be any logic to calculate personal amount
            Console.WriteLine("Your Personal Expense: {0}", _Amount.ToString());          
        }
    }
```
* Създаване на фабриката
```
public class CheckFactory
    {
        public CheckFactory() { }
 
        public CheckBook chooseExpense(int o)
        {
            switch (o)
            {
                case 1:
                    return new Personal();
                case 2:
                    return new Travel();
                default:
                    return new Health();
            }
        }
    }
```
* Използване на шаблона
```
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1 for Personal expense:");
            Console.WriteLine("Type 2 for Travel expense:");
            Console.WriteLine("Type any number for Health expense:");
            string input = Console.ReadLine();
            CheckFactory objCheckFactory = new CheckFactory();
            CheckBook currentExpense = objCheckFactory.chooseExpense(int.Parse(input));
            Console.WriteLine("From main class "+currentExpense.getExpense());
            Console.Read();
        }
    }
```
