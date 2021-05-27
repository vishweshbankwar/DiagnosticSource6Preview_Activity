# DiagnosticSource6Preview_Activity

Starting preview version 6.0.0-preview.3.21201.4 of System.Diagnostic.DiagnosticSource, there is a behavior change when trying to create activity by passing invalid W3C Id for parent.

**Previous Behavior**: 

Activity is not created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent"). This behavior is same whether Activity.ForceDefaultIdFormat is set to True or False.


**New Behavior**: 

Activity is created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent") and setting Activity.ForceDefaultIdFormat to True.

Activity is not created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent") and setting Activity.ForceDefaultIdFormat to False.


The `main` branch of this repo shows example code for the behavior noted above with version 6.0.0-preview.4.21253.7. `DiagnosticSource5_Activity` branch confirms the previous behavior with latest stable release version 5.0.1.
