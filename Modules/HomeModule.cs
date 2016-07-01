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
      };
      Get["/add_contact"] = _ => {
        return View["contact_form.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Post["/contact_created"] = _ => {
        Contact newContact = new Contact(
          Request.Form["new-name"],
          Request.Form["new-phone"],
          Request.Form["new-address1"],
          Request.Form["new-address2"]
        );
        return View["contact_created.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["contact.cshtml", contact];
      };
      Get["/contacts_clear_verify"] = _ => {
        return View["contacts_clear_verify.cshtml"];
      };
      Post["contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
