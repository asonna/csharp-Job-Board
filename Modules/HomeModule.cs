using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["addNewJob.cshtml"];
      };

      Post["/JobAdded"] = _ => {
        string title = Request.Form["titleName"];
        string description = Request.Form["descriptionName"];
        string contactInfo = Request.Form["contactInfoName"];

        Job newJob = new Job (title, description, contactInfo);
        newJob.AddToJobList();

        return View["JobAdded.cshtml", newJob];
      };

      Get["/JobInventory"] = _ => {
        return View["JobInventory.cshtml",  Job.JobInventory()];
      };
    }
  }
}
