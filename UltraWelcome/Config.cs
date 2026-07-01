using System.ComponentModel;

namespace UltraWelcome
{
    public class Config
    {
        
        public bool IsEnabled { get; set; } = true;
        public WelcomeMessageMode Mode { get; set; } = WelcomeMessageMode.Hint;    
        public string WelcomeText { get; set; } = "Добро пожаловать на наш сервер {PlayerName}!"; // Welcome message.

        public float DisplayTime { get; set; } = 5f;
        public ushort BroadcastDur {get; set;} = 10;


        // Use Unity Rich Text color.
        // Examples: red, green, #FF0000
        public string BroadcastColor { get; set; } = "#ff1e00";
        public bool LogToConsole { get; set; } = true;

    }
}
