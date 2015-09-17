#Bridge

###1. Description
Този шаблон се използва за да се отдели абстракцията от имплементацията (двете по начало са свързани). По таози начин всяка от тях може да се разширява независимо от другата. Така се решават проблеми, които иначе биха били решени чрез наследяване.

Bridge заменя връзката Абстракция -> Имплементация с Абстракция -> Абстракция -> Имплементация. Като едната абстракция използва другата и двете са взаимозаменяеми. Използването на Bridge шаблонът предотвратява бързото разрастването на йерархията породено от допълнителното наследяване, което ще е необходимо при разширяване на функционалността.

Този шаблон е подобен на *Proxy*, *Decorator* и *Adaptor* шаблоните с тази разлика, че не се използва за да се пригоди външен или наследствен код. Използващият Bridge:

* Дефинира и абстрактният интерфейс и основната имплементация
* Проектира кода така, че различните имплементации да могат да се подменят

###2. Diagram
![Diagram][diagramlink]
[diagramlink]:https://sourcemaking.com/files/v2/content/patterns/Bridge___-2x.png

###3. Sample
```csharp
using System;

  class MainApp
  {
    static void Main()
    {
      Abstraction ab = new RefinedAbstraction();

      ab.Implementor = new ConcreteImplementorA();
      ab.Operation();

      ab.Implementor = new ConcreteImplementorB();
      ab.Operation();

      Console.Read();
    }
  }

  class Abstraction
  {
    protected Implementor implementor;

    public Implementor Implementor
    {
      set{ implementor = value; }
    }

    public virtual void Operation()
    {
      implementor.Operation();
    }
  }

  abstract class Implementor
  {
    public abstract void Operation();
  }

  class RefinedAbstraction : Abstraction
  {
    public override void Operation()
    {
      implementor.Operation();
    }
  }

  class ConcreteImplementorA : Implementor
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteImplementorA Operation");
    }
  }

  class ConcreteImplementorB : Implementor
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteImplementorB Operation");
    }
  }
```
