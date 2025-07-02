using RemoteControlLight.Commands;
using RemoteControlLight;

// Create the receiver
Light livingRoomLight = new Light();

// Create commands and bind them to the receiver
ICommand turnOn = new TurnOnCommand(livingRoomLight);
ICommand turnOff = new TurnOffCommand(livingRoomLight);

// Create the invoker
RemoteControl remote = new RemoteControl();

var arg = "turn lights on or off...";
while(!string.IsNullOrEmpty(arg))
{
    Console.WriteLine("Press the lights switch to turn ON or OFF:");
    arg = Console.ReadLine();

    if(arg == "ON")
    {
        remote.SetCommand(turnOn);
        remote.PressButton();
    }

    if (arg == "OFF")
    {
        remote.SetCommand(turnOff);
        remote.PressButton();
    }
}