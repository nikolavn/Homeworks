#Decorator/Декоратор

###1. Description
Този шаблон се използва за да се добави функционалност към вече съществуваш обект. Предимствата на използването му са:

* Заместване на директното наследяване, което може да предизвика създаването на много класове
* Спазване на Open/Close принципа, тъй като оригиналният обект остава непроменен, но с разширена фунционалност

Декораторът се състои от:

- Един основен обект, който няма опции
- Няколко >обвивки по избор
- Един интерфейс, който е общ за всички елементи

Шаблонът може да се използва за добавяне на нова фукционалност в наследени системи, за разширяване на потребителски интерфейс и *sealed* класове.

###2. Diagram
![Diagram][diagramlink]
[diagramlink]:https://sourcemaking.com/files/v2/content/patterns/Decorator__1-2x.png

###3. Sample
```csharp
using System;

  class MainApp
  {
    static void Main()
    {
      ConcreteComponent c = new ConcreteComponent();
      ConcreteDecoratorA d1 = new ConcreteDecoratorA();
      ConcreteDecoratorB d2 = new ConcreteDecoratorB();

      d1.SetComponent(c);
      d2.SetComponent(d1);

      d2.Operation();

      Console.Read();
    }
  }

  abstract class Component
  {
    public abstract void Operation();
  }

  class ConcreteComponent : Component
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteComponent.Operation()");
    }
  }

  abstract class Decorator : Component
  {
    protected Component component;

    public void SetComponent(Component component)
    {
      this.component = component;
    }

    public override void Operation()
    {
      if (component != null)
      {
        component.Operation();
      }
    }
  }

  class ConcreteDecoratorA : Decorator
  {
    private string addedState;

    public override void Operation()
    {
      base.Operation();
      addedState = "New State";
      Console.WriteLine("ConcreteDecoratorA.Operation()");
    }
  }

  class ConcreteDecoratorB : Decorator
  {
    public override void Operation()
    {
      base.Operation();
      AddedBehavior();
      Console.WriteLine("ConcreteDecoratorB.Operation()");
    }

    void AddedBehavior()
    {
    }
  }
```
