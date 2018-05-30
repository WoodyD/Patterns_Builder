
namespace Patterns_Builder.Builder {

	public class BMWBuilder : CarBuilderBase {

		public override void BuildFrame () {
			Car.Frame = "BMW 5 frame";
		}

		public override void BuildEngine () {
			Car.Engine = "BMW 2.0 engine";
		}

		public override void BuildWheels () {
			Car.Wheels = "BMW 17\" wheels";
		}

		public override void BuildSafety () {
			Car.Safety = "BMW safety packet";
		}

		public override void BuildAudio () {
			Car.Audio = "BMW audio system";
		}

		public override void BuildLuxury () {
			Car.Luxury = "BMW M5 upgrade";
		}

	}
}
