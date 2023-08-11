namespace NLayer.Core.Concreate
{
    public class StudentPolling
    {
        public int PollingId { get; set; }
        public Polling Polling { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
