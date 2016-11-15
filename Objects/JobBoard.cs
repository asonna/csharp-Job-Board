using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _title;
    private string _description;
    private string _contactInfo;

    private static List<Job> _jobList = new List<Job> {};

    public Job (string title, string description, string contactInfo)
    {
      _title = title;
      _description = description;
      _contactInfo = contactInfo;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetTitle()
    {
      return _title;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetDescription()
    {
      return _description;
    }

    public void SetContactInfo(string newContactInfo)
    {
      _contactInfo = newContactInfo;
    }
    public string GetContactInfo()
    {
      return _contactInfo;
    }

    

  }
}
