#Стратегия/Strategy

###1. Description
Този шаблон се използва за енкапсулиране на семейство от свързани алгоритми. Това им позволява да се развиват отделно от класът който ги използва. Така класът име единствено предназначение. По този начин се спазва *Open-Close* принципът в ООП.

*Strategy* капсулира всички алгоритми в отделни класове, като в същото време ги прави взаимозаменяеми.  Всеки от алгоритмите може да работи с едни и същи данни,  клиентът може да работи с всеки един алгоритъм.

Някои следствия от използването на стратегии са:
- Стратегиите не могат да използват членове на обгръщащите класове
- По-лесно е да се пишат тестове за индивидуални конкретни стратегии
- Стратегиите могат да се имитират, когато се тества контекстният клас
- Добавянето на нови стратегии не променя нищо

###2. Diagram
![Diagram][diagramlink]
[diagramlink]:https://sourcemaking.com/files/v2/content/patterns/Strategy_-2x.png

###3. Sample Code
```csharp
using System;

  class MainApp
  {
    static void Main()
    {
      Context context;

      context = new Context(new ConcreteStrategyA());
      context.ContextInterface();

      context = new Context(new ConcreteStrategyB());
      context.ContextInterface();

      context = new Context(new ConcreteStrategyC());
      context.ContextInterface();

      Console.Read();
    }
  }

  abstract class Strategy
  {
    public abstract void AlgorithmInterface();
  }

  class ConcreteStrategyA : Strategy
  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyA.AlgorithmInterface()");
    }
  }

  class ConcreteStrategyB : Strategy
  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyB.AlgorithmInterface()");
    }
  }

  class ConcreteStrategyC : Strategy
  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyC.AlgorithmInterface()");
    }
  }

  class Context
  {
    Strategy strategy;

    public Context(Strategy strategy)
    {
      this.strategy = strategy;
    }

    public void ContextInterface()
    {
      strategy.AlgorithmInterface();
    }
  }
```
