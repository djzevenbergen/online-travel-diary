using System.Collections.Generic;

namespace OnlineTravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    private static List<Place> _instances;

    public Place(string city)
    {
      CityName = city;
      _instances.Add(this);
    }

    public static List<Place> GetPlaces()
    {
      return _instances;
    }
  }
}