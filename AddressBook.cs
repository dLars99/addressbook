using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        private Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
        }
        public Contact GetByEmail(string email)
        {
            {
                return Contacts[email];
            }
        }
    }
}