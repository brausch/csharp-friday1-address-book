using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      }
      Get["/add_contact"] = _ => {
        return View["contact_form.cshtml"];
      }
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml"];
      }
      Post["/contact_created"] = _ => {
        Contact newContact = new Contact(
          Request.Form["new-name"],
          Request.Form["new-phone"],
          Request.Form["new-address1"],
          Request.Form["new-address2"]
        );
        return View["contact_created.cshtml"];
      }


      // Get["/"] = _ => {
      //   return View["index.cshtml"];
      // };
      // Get["/tasks"] = _ => {
      //   List<Task> allTasks = Task.GetAll();
      //   return View["tasks.cshtml", allTasks];
      // };
      // Get["/tasks/new"] = _ => {
      //   return View["task_form.cshtml"];
      // };
      // Post["/tasks"] = _ => {
      //   Task newTask = new Task(Request.Form["new-task"]);
      //   List<Task> allTasks = Task.GetAll();
      //   return View["tasks.cshtml", allTasks];
      // };
      // Post["/tasks_cleared"] = _ => {
      //   Task.ClearAll();
      //   return View["tasks_cleared.cshtml"];
      // };
      // Get["/tasks/{id}"] = parameters => {
      //   Task task = Task.Find(parameters.id);
      //   return View["/task.cshtml", task];
      };
    }
  }
}
