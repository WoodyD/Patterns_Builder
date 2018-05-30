using System.Text;

namespace Patterns_Builder {
	public class Car {

		public string Frame { get; set; }
		public string Engine { get; set; }
		public string Wheels { get; set; }
		public string Safety { get; set; }
		public string Audio { get; set; }
		public string Luxury { get; set; }

		public override string ToString () {
			StringBuilder sb = new StringBuilder ();
			sb.AppendFormat ("Frame: {0}\t", Frame);
			sb.AppendFormat ("\nEngine: {0}\t", Engine);
			sb.AppendFormat ("\nWheels: {0}\t", Wheels);
			sb.AppendFormat ("\nSafety: {0}\t", Safety);
			sb.AppendFormat ("\nAudio: {0}\t", Audio);
			sb.AppendFormat ("\nLuxury: {0}\t", Luxury);
			return sb.ToString ();
		}

	}
}
