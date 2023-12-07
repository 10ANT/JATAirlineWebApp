namespace JATAirlineWebApp.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public string ?passengerFirstName { get; set; }
		public string ?passengerLastName { get; set;}
		public string ?destination { get; set; }
		public DateTime ?FlightDate { get; set; }
		public string ?seatingpreference { get; set; }	
		public int seatingnumber { get; set; }

		public Reservation() { }

	}
}
