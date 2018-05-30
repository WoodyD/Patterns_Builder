using Patterns_Builder.Builder;

namespace Patterns_Builder.Factory {

	public class RegularCar : CarFactoryBase {

		public RegularCar (CarBuilderBase builder) : base (builder) {
		}

		public override Car Construct () {
			CarBuilder.BuildFrame ();
			CarBuilder.BuildEngine ();
			CarBuilder.BuildWheels ();
			CarBuilder.BuildSafety ();

			return CarBuilder.GetCar ();
		}
	}
}
