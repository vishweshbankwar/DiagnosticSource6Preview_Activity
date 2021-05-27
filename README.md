# DiagnosticSource6Preview_Activity

Latest preview version 6 of System.Diagnostic.DiagnosticSource has a functionality change when trying to create activity by passing invalid W3C Id for parent.

**Expected Behavior**: 

Activity is not created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent"). This behavior is expected to be same whether Activity.ForceDefaultIdFormat is set to True or False.


**Actual Behavior**: 

Activity is created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent") and setting Activity.ForceDefaultIdFormat to True.

Activity is not created when starting activity by calling activitySource.StartActivity("TestActivity", ActivityKind.Client, "InvalidW3CIdParent") and setting Activity.ForceDefaultIdFormat to False.


The `main` branch of this repo shows example code for the behavior noted above with version 6.0.0-preview.4.21253.7. `DiagnosticSource5_Activity` confirms the expected behavior with latest stable release version 5.0.1.
