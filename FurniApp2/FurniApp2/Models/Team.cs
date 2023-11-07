namespace FurniApp2.Models
{
	public class Team:BaseEntity
	{
		public string FullName { get; set; }
		public string position { get; set; }
        public string Title { get; set; }
		public string description { get; set; }
		public string Url { get; set; }
	}
}
