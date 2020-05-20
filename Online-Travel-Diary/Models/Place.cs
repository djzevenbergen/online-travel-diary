using System.Collections.Generic;

namespace OnlineTravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    private static List<Place> _instances = new List<Place> { };
    public static int IdCount { get; set; }
    public int Id { get; set; }

    public Place(string city)
    {
      CityName = city;
      _instances.Add(this);
      if (_instances.Count == 1)
      {
        IdCount = 1;
      }
      else
      {
        IdCount++;
      }
      Id = IdCount;
    }

    public static List<Place> GetPlaces()
    {
      return _instances;
    }

    public static Place Find(int searchId)
    {
      foreach (Place place in _instances)
      {
        if (place.Id == searchId)
        {
          return place;
        }
      }
      return null;
    }

  }
}