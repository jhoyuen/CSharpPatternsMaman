using Timer;

var timer = new Timer.Timer();
var alarm = new Alarm();

alarm.Subscribe(timer);
timer.Start(10000);

Console.Read();
