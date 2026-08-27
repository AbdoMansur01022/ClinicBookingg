using ClinicBookingg.Models;

namespace ClinicBookingg.Data
{
    public class DoctorRepository
    {
        private readonly ClinicContext _context;

        public DoctorRepository(ClinicContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetAll() => _context.Doctors.ToList();

        public Doctor? GetById(int id) => _context.Doctors.Find(id);

        public void Add(Doctor doctor) => _context.Doctors.Add(doctor);

        public void Update(Doctor doctor) => _context.Doctors.Update(doctor);

        public void Delete(int id)
        {
            var doctor = GetById(id);
            if (doctor != null) _context.Doctors.Remove(doctor);
        }

        public bool LicenceExists(string licenceNumber, int ignoreDoctorId = 0)
        {
            return _context.Doctors.Any(d => d.LicenceNumber == licenceNumber && d.Id != ignoreDoctorId);
        }

        public void Save() => _context.SaveChanges();
    }
}