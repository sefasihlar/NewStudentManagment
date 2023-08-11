using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Polling : BaseEntity
    {

        public string? Name { get; set; }
        public DateTime? PollingDate { get; set; }

        public string? Description { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }


        public List<StudentPolling> StudentPollings { get; set; }

    }
}
