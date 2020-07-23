using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Format
  {
    private static List<Format> _instances = new List<Format> {};
    public string Type { get; set; }
    public int Id { get; }
    public List<Record> Records { get; set; }
    public Format(string FormatType)
    {
      Type = FormatType;
      _instances.Add(this);
      Id = _instances.Count;
      Records = new List<Record>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Format> GetAll()
    {
      return _instances;
    }
    public static Format Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddRecord(Record record)
    {
      Records.Add(record);
    }
  }
}