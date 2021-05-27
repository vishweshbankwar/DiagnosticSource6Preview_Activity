using System;
using System.Diagnostics;

namespace DiagnosticSource6Preview
{
    class Program
    {
        static void Main(string[] args)
        {
            var listener = new ActivityListener
            {
                ShouldListenTo = _ => true,
                Sample = (ref ActivityCreationOptions<ActivityContext> options) => ActivitySamplingResult.AllData,
            };

            ActivitySource.AddActivityListener(listener);

            ActivitySource activitySource = new ActivitySource("TestActivitySource");
            
            Activity.ForceDefaultIdFormat = true;
            using (var act = activitySource.StartActivity("TestActivity1", ActivityKind.Client, "InvalidW3CIdParent"))
            {
                // act will not be null.
                Console.WriteLine($"Is Activity created with ForceDefaultIdFormat set to True: {act!=null}");
            }

            Activity.ForceDefaultIdFormat = false;
            using (var act = activitySource.StartActivity("TestActivity2", ActivityKind.Client, "InvalidW3CIdParent"))
            {
                // act will be null
                Console.WriteLine($"Is Activity created with ForceDefaultIdFormat set to False: {act!=null}");
            }
        }
    }
}
