using ClinicBackend.Models;

namespace ClinicBackend.Service
{
    public interface IPatient
    {
        public ICollection<Patient> getAll();
        public Patient getById(int id);
        public bool updatePatient(Patient patient);
        public bool createPatient(Patient patient);
        public bool isExist(int id);
        public bool Save();
    }
}
