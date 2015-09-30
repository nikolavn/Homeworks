#Шаблонен метод/Template Method

###1. Description
Този модел се използва за да се избегне полагането на допълнително усилие за промяна,  когато два различни компонента имат значителни прилики, но не преизползват общ интерфейс или имплементация.

Шаблонният метод дефинира основата на алгоритъм, в метод, оставяйки имплементацията на неговите наследници. Като им позволява да предефинират някои части от алгоритъма, но не и неговата структура.

*Template Method* разчита на наследяване, като обикновено се променят виртуални или абстрактни методи. *Framework*-ът е виден пример за използването на шаблонен метод. Всеки framework имплементира частите от архитектурата, които не се променят и оставя места, където клиентът може да прави промени.

###2. Diagram
![Diagram][diagramlink]
[diagramlink]:https://sourcemaking.com/files/v2/content/patterns/Template_Method_-2x.png

###3. Sample Code
```csharp
using System;

  class MainApp
  {
    static void Main()
    {
      AbstractClass c;

      c = new ConcreteClassA();
      c.TemplateMethod();

      c = new ConcreteClassB();
      c.TemplateMethod();

      Console.Read();
    }
  }

  abstract class AbstractClass
  {
    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();

    public void TemplateMethod()
    {
      PrimitiveOperation1();
      PrimitiveOperation2();
      Console.WriteLine("");
    }
  }

  class ConcreteClassA : AbstractClass
  {
    public override void PrimitiveOperation1()
    {
      Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
    }
    public override void PrimitiveOperation2()
    {
      Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
    }
  }

  class ConcreteClassB : AbstractClass
  {
    public override void PrimitiveOperation1()
    {
      Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
    }
    public override void PrimitiveOperation2()
    {
      Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
    }
  }
```
