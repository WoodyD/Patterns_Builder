
namespace Patterns_Builder.Builder {

	public abstract class CarBuilderBase {

		protected Car Car;

		protected CarBuilderBase () {
			Car = new Car ();
		}

		public Car GetCar () {
			return Car;
		}

		public abstract void BuildFrame ();
		public abstract void BuildEngine ();
		public abstract void BuildWheels ();
		public abstract void BuildSafety ();
		public abstract void BuildAudio ();
		public abstract void BuildLuxury ();
	}
}
