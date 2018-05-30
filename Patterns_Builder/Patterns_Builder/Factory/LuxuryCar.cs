using Patterns_Builder.Builder;

namespace Patterns_Builder.Factory {

	public class LuxuryCar : CarFactoryBase {

		public LuxuryCar (CarBuilderBase builder) : base (builder) {
		}

		public override Car Construct () {
			CarBuilder.BuildFrame ();
			CarBuilder.BuildEngine ();
			CarBuilder.BuildWheels ();
			CarBuilder.BuildSafety ();
			CarBuilder.BuildAudio ();
			CarBuilder.BuildLuxury ();

			return CarBuilder.GetCar ();
		}
	}
}
