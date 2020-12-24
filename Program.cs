using System;
using System.Linq;

namespace ReturningThis
{
  class Program
  {
    static void Main(string[] args)
    {
      var box = new Box();

      box
        .AddThing("Chocolate")
        .AddThing("Mouse")
        .AddThing("Coin")
        .AddThing("Telephone")
        .AddThing("My annoying sister")
        .AddThing("Book")
        .AddThing("Paper that says I was joking about my sister")
        .AddThing("Lamp")
        .TurnEverythingToUppercase();

      ListThings(box);
    }

    private static void ListThings(Box box) => Console.Write(
      string.Join("", box.Things.Select(thing => $"{thing}\n"))
    );
  }
}
