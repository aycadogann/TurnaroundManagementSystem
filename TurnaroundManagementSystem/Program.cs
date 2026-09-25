using TurnaroundManagementSystem;

Aircraft aircraft = new Aircraft();

GroundOperation groundOperation = new GroundOperation();
groundOperation.OperationName = "Cleaning";
groundOperation.EstimatedMinutes = 45;
groundOperation.IsCompleted = false;
groundOperation.ResponsibleEmployee = null;

GroundOperation groundOperation2 = new GroundOperation();
groundOperation2.OperationName = "Fuel";
groundOperation2.EstimatedMinutes = 10;
groundOperation2.IsCompleted = true;
groundOperation2.ResponsibleEmployee = null;

GroundOperation groundOperation3 = new GroundOperation();
groundOperation3.OperationName = "Baggage";
groundOperation3.EstimatedMinutes = 60;
groundOperation3.IsCompleted = false;
groundOperation3.ResponsibleEmployee = null;

GroundOperation groundOperation4 = new GroundOperation();
groundOperation4.OperationName = "Catering";
groundOperation4.EstimatedMinutes = 30;
groundOperation4.IsCompleted = true;
groundOperation4.ResponsibleEmployee = null;

GroundOperation groundOperation5 = new GroundOperation();
groundOperation5.OperationName = "Technical";
groundOperation5.EstimatedMinutes = 90;
groundOperation5.IsCompleted = false;
groundOperation5.ResponsibleEmployee = null;

GroundOperation groundOperation6 = new GroundOperation();
groundOperation6.OperationName = "Cleaning";
groundOperation6.EstimatedMinutes = 15;
groundOperation6.IsCompleted = false;
groundOperation6.ResponsibleEmployee = null;