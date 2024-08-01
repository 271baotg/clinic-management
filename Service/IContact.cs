using ClinicBackend.Models;

namespace ClinicBackend.Service
{
    public interface IContact
    {
        public ICollection<Contact> getAll(int id);
        public bool updateContact(Contact contact);
        public bool createContact(Contact contact);

        public bool Save();
    }
}
