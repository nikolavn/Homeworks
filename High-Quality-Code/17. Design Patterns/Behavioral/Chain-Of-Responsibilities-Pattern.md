#Верига на отговорността/Chain of Responsibility

###1. Description
Този шаблон се използва в случаи, когато има променлив брой обработващи елементи или възли и постоянен поток от заявки, които трябва да се обработят. Той помага да се избегне свързването на определена заявка с определен обработващ елемент и логическото взаимосвързване между обработващите елементи.

Шаблонът свързва във верига всички елементи получатели , и след това предава дадена заявка (съобщение) от елемент на елемент докато достигне такъв, който може да я обработи. Броят на получаващите елементи не се знае предварително а може да се конфигурира в последствие.  
Веригата на отговорността опростява връзката между изпращият и получаващият елемент. Вместо те да поддържат референции към всички кандидат-получатели, всеки изпращащ елемент поддържа референция към началото на веригата а всеки получаващ елемент поддържа единствена референция към своят пряк нселдник във веригата.

При употребата на този шаблон трябва да се подсигури съществуването на предпазна мрежа, която да хване всички необработени заявки.

###2. Diagram
![Diagram][diagramlink]
[diagramlink]:https://sourcemaking.com/files/v2/content/patterns/Chain_of_responsibility1-2x.png

###3. Sample Code
```csharp
using System;

  class MainApp
  {
    static void Main()
    {
      Handler h1 = new ConcreteHandler1();
      Handler h2 = new ConcreteHandler2();
      Handler h3 = new ConcreteHandler3();
      h1.SetSuccessor(h2);
      h2.SetSuccessor(h3);

      int[] requests = {2, 5, 14, 22, 18, 3, 27, 20};

      foreach (int request in requests)
      {
        h1.HandleRequest(request);
      }

      Console.Read();
    }
  }

  abstract class Handler
  {
    protected Handler successor;

    public void SetSuccessor(Handler successor)
    {
      this.successor = successor;
    }

    public abstract void HandleRequest(int request);
  }

  class ConcreteHandler1 : Handler
  {
    public override void HandleRequest(int request)
    {
      if (request >= 0 && request < 10)
      {
        Console.WriteLine("{0} handled request {1}",
          this.GetType().Name, request);
      }
      else if (successor != null)
      {
        successor.HandleRequest(request);
      }
    }
  }

  class ConcreteHandler2 : Handler
  {
    public override void HandleRequest(int request)
    {
      if (request >= 10 && request < 20)
      {
        Console.WriteLine("{0} handled request {1}",
          this.GetType().Name, request);
      }
      else if (successor != null)
      {
        successor.HandleRequest(request);
      }
    }
  }

  class ConcreteHandler3 : Handler
  {
    public override void HandleRequest(int request)
    {
      if (request >= 20 && request < 30)
      {
        Console.WriteLine("{0} handled request {1}",
          this.GetType().Name, request);
      }
      else if (successor != null)
      {
        successor.HandleRequest(request);
      }
    }
  }
```
