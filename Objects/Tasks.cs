using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address1;
    private string _address2;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, string phone, string address1, string address2)
    {
      _name = name;
      _phone = phone;
      _address1 = address1;
      _address2 = address2;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }


    public string GetAddress1()
    {
      return _address1;
    }

    public void SetAddress1(string newAddress1)
    {
      _address1 = newAddress1;
    }

    public string GetAddress2()
    {
      return _address2;
    }

    public void SetAddress2(string newAddress2)
    {
      _address2 = newAddress2;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
