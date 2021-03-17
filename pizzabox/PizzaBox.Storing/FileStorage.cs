using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Storing
{
  public class FileStorage
  {
    private readonly string _path = @"store.xml";

    public void WriteToXml<T>(List<T> data) where T : class
    {
      using (var writer = new StreamWriter(_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }

    public IEnumerable<T> ReadFromXml<T>() where T : class
    {
      using (var reader = new StreamReader(_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
    private readonly string pizza_path = @"pizza.xml";
     public void WritePizzaToXml<T>(List<T> data) where T : class
    {
      using (var writer = new StreamWriter(pizza_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }
      public IEnumerable<T> ReadPizzaFromXml<T>() where T : class
    {
      using (var reader = new StreamReader(pizza_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
  }
}
