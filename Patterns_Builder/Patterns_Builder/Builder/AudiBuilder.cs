
namespace Patterns_Builder.Builder {

	public class AudiBuilder : CarBuilderBase {

		public override void BuildFrame () {
			Car.Frame = "Audi 4 frame";
		}

		public override void BuildEngine () {
			Car.Engine = "Audi 1.8 engine";
		}

		public override void BuildWheels () {
			Car.Wheels = "Audi 17\" wheels";
		}

		public override void BuildSafety () {
			Car.Safety = "Audi safety packet";
		}

		public override void BuildAudio () {
			Car.Audio = "Audi audio system";
		}

		public override void BuildLuxury () {
			Car.Luxury = "Audi S4 upgrade";
		}

	}
}
