# DiagnosticSource6Preview_Activity

Starting preview version 6.0.0-preview.3.21201.4 of System.Diagnostic.DiagnosticSource, there is a behavior change when trying to create activity by passing invalid W3C Id for parent.

**Previous Behavior**: 

Activity is not created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent"). This behavior is same whether Activity.ForceDefaultIdFormat is set to True or False.


**New Behavior**: 

Activity is created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent") and setting Activity.ForceDefaultIdFormat to True.

Activity is not created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent") and setting Activity.ForceDefaultIdFormat to False.


The `main` branch of this repo shows example code using .NET5.0 console app for the behavior noted above with version 6.0.0-preview.3.21201.4. `DiagnosticSource5_Activity` branch uses 6.0.0-preview.2.21154.6 which confirms the previous behavior (also matches with behavior from version 5.0.1).
