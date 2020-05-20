using OnlineTravelDiary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OnlineTravelDiary.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void Place_InstantiatePlace_Place()
    {
      string city = "Seattle";
      Place tempPlace = new Place(city);
      Assert.AreEqual(typeof(Place), tempPlace.GetType());
    }

    [TestMethod]
    public void Place_InstantiatePlaceWithCityString_String()
    {
      string city = "Seattle";
      Place tempPlace = new Place(city);
      Assert.AreEqual(city, tempPlace.CityName);
    }

  }
}