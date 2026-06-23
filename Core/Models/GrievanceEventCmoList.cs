namespace Core.Models
{
    public class GrievanceEventCmoList
    {
        public List<grievanceEventCmo> grievanceEventCmo { get; set; }
    }

    public class grievanceEventCmo
    {
        public int officerId { get; set; }
        public int userNumber { get; set; }
        public int levelId { get; set; }
        public string officerName { get; set; }

    }


}
