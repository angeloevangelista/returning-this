using System.Collections.Generic;
using System.Linq;

namespace ReturningThis
{
  public class Box
  {
    // Encapsulating the list of things 
    private IList<string> _things;
    public IReadOnlyCollection<string> Things { get => _things.ToArray(); }

    public Box()
    {
      this._things = new List<string>();
    }

    /// <summary>
    /// Add something to the box 
    /// </summary>
    public Box AddThing(string something)
    {
      _things.Add(something);

      return this;
    }

    /// <summary>
    /// It turns everything in the box to Uppercase writing  
    /// </summary>
    public Box TurnEverythingToUppercase()
    {
      _things = _things.Select(thing => thing.ToUpper()).ToList();

      return this;
    }

    /// <summary>
    /// It turns everything in the box to Lowercase writing  
    /// </summary>
    public Box TurnEverythingToLowercase()
    {
      _things = _things.Select(thing => thing.ToLower()).ToList();

      return this;
    }
  }
}