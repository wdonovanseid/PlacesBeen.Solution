using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get;}
    public int DaysStayed { get; set; }
    public string JournalEntry { get; set; }
    private static List<Place> Diary = new List<Place> {};

    public Place(string cityName, string daysStayed, string journalEntry)
    {
      CityName = cityName;
      DaysStayed = int.Parse(daysStayed);
      JournalEntry = journalEntry;
      
      Diary.Add(this);
      Id = Diary.Count;
    }

    public static List<Place> GetAll()
    {
      return Diary;
    }

    public static void ClearAll()
    {
      Diary.Clear();
    }

    public static Place Find(int searchId)
    {
      return Diary[searchId-1];
    }
  }
}