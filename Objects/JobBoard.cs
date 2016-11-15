using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _makeModel;
    private int _year;
    private int _price;

    private static List<Car> _carList = new List<Car> {};

    public Car (string makeModel, int year,int price)
    {
      _makeModel = makeModel;
      _year = year;
      _price = price;
    }

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }


    public void AddToCarList()
    {
      _carList.Add(this);
    }
    public static List<Car> ViewCarList()
    {
      return _carList;
    }
    public static void ClearCarList()
    {
      _carList.Clear();
    }
  }
}
