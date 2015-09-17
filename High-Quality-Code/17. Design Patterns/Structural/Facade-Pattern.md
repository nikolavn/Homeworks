#Facade/Фасада

###1. Description
Фасадата представлява обединен интерфейс, който предоставя достъп до част от функционалността на по сложна система. Целта на този шаблон за дизайн е да:

* Улесни използването, разбирането и четимостта на софтуерните библиотеки
* Намали зависимостта от външен код следвайки принципа на най-малкото знание
* Обвие лошо конструиран програмен интерфейс с по-добър,

Чрез използването на фасада се намалява времето необходимо за придобиване знанията нужни за използването на дадена система. Също така се съдейства за откачането на системата от многото и потенциялни клиенти. От друга страна, фасадата може да ограничи достъпа до някои разширени функционалности, което да засегне ползващите ги потребители.

Примери за шаблонът фасада са [XmlSerializer](https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer(v=vs.110).aspx) в .NET и [JSON Serializer](http://www.newtonsoft.com/json/help/html/SerializingJSON.htm) в JSON.NET.

###2. Diagram
![Diagram][diagramlink]
[diagramlink]:http://core0.staticworld.net/images/idge/imported/article/jvw/2003/05/jw-0530-designpatterns1-100156719-orig.jpg

###3. Sample
```csharp
using System;

  class MainApp
  {
    public static void Main()
    {
      Facade facade = new Facade();

      facade.MethodA();
      facade.MethodB();

      Console.Read();
    }
  }

  class SubSystemOne
  {
    public void MethodOne()
    {
      Console.WriteLine(" SubSystemOne Method");
    }
  }

  class SubSystemTwo
  {
    public void MethodTwo()
    {
      Console.WriteLine(" SubSystemTwo Method");
    }
  }

  class SubSystemThree
  {
    public void MethodThree()
    {
      Console.WriteLine(" SubSystemThree Method");
    }
  }

  class SubSystemFour
  {
    public void MethodFour()
    {
      Console.WriteLine(" SubSystemFour Method");
    }
  }

  class Facade
  {
    SubSystemOne one;
    SubSystemTwo two;
    SubSystemThree three;
    SubSystemFour four;

    public Facade()
    {
      one = new SubSystemOne();
      two = new SubSystemTwo();
      three = new SubSystemThree();
      four = new SubSystemFour();
    }

    public void MethodA()
    {
      Console.WriteLine("\nMethodA() ---- ");
      one.MethodOne();
      two.MethodTwo();
      four.MethodFour();
    }

    public void MethodB()
    {
      Console.WriteLine("\nMethodB() ---- ");
      two.MethodTwo();
      three.MethodThree();
    }
  }
```
