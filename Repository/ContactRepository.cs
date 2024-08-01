using ClinicBackend.Data;
using ClinicBackend.Models;
using ClinicBackend.Service;
using Microsoft.EntityFrameworkCore;

namespace ClinicBackend.Repository
{
    public class ContactRepository : IContact
    {
        private readonly DBContext _dbContext;

        public ContactRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool createContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            return Save();
        }

        public ICollection<Contact> getAll(int id)
        {
            return _dbContext.Contacts.Where(p => p.PatientId == id).ToList();
        }



        public bool updateContact(Contact contact)
        {
            _dbContext.Update(contact);
            return Save();
        }

        public bool Save()
        {
            var save = _dbContext.SaveChanges();
            return save > 0 ? true : false;
        }
    }
}
