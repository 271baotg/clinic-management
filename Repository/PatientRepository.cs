using ClinicBackend.Data;
using ClinicBackend.Models;
using ClinicBackend.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ClinicBackend.Repository
{
    public class PatientRepository : IPatient
    {
        private readonly DBContext _dbContext;

        public PatientRepository( DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool createPatient(Patient patient)
        {
            _dbContext.Patients.Add(patient);
            return Save();
        }

        public ICollection<Patient> getAll()
        {
            return _dbContext.Patients.OrderBy(p => p.PatientId)
                .Include(p => p.Addresses)
                .Include(p => p.Contacts)
                .ToList();
        }

        public Patient getById(int id)
        {
            return _dbContext.Patients.FirstOrDefault(p => p.PatientId ==  id);
        }


        public bool isExist(int id)
        {
            return _dbContext.Patients.Any(p => p.PatientId == id);
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool updatePatient(Patient patient)
        {
            _dbContext.Update(patient);
            return Save();
        }
    }
}
