using System;
using Patterns_Builder.Builder;
using Patterns_Builder.Factory;

namespace Patterns_Builder {

	class Program {

		static void Main (string[] args) {

			//Standard builder pattern using
			Console.WriteLine ("BMW car builder:");
			var bmwBuilder = new BMWBuilder ();
			bmwBuilder.BuildFrame ();
			bmwBuilder.BuildEngine ();
			bmwBuilder.BuildWheels ();
			bmwBuilder.BuildSafety ();
			Console.WriteLine (bmwBuilder.GetCar ());

			//Builder pattern with fabric pattern
			Console.WriteLine ("\nAUDI regular car builder:");
			var audiRegular = new RegularCar (new AudiBuilder ());
			Console.WriteLine (audiRegular.Construct ());

			Console.WriteLine ("\nBMW luxury car builder:");
			var bmwLuxury = new LuxuryCar (new BMWBuilder ());
			Console.WriteLine (bmwLuxury.Construct ());

			Console.ReadLine ();
		}
	}
}
