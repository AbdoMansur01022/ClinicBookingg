using ClinicBookingg.Models;

namespace ClinicBookingg.Data
{
    public static class AppointmentRepository
    {
        private static readonly List<Appointment> _appointments = new List<Appointment>();
        private static int _nextId = 1;

        public static void Add(Appointment appointment)
        {
            appointment.Id = _nextId++;
            _appointments.Add(appointment);
        }

        public static List<Appointment> GetAll() => _appointments;
    }
}