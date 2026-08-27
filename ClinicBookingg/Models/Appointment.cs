namespace ClinicBookingg.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string PatientPhone { get; set; } = string.Empty;
        public DateTime SlotTime { get; set; }
        public string? Notes { get; set; }
    }
}