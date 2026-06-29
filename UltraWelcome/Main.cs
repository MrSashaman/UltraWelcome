using System;
using LabApi.Loader.Features.Plugins;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.Handlers;
using LabApi.Features.Console;

namespace UltraWelcome
{
    internal class Main : Plugin<Config>
    {
        public override string Name => "UltraWelcome";
        public override string Description => "Welcome Players on your server";
        public override string Author => "mrSashaman";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredApiVersion => new Version(1, 1, 7);
        private WelcomeService _welcomeService;
        private MessageService _messageService;

        public override void Enable()
        {
            Logger.Debug("Welcome to UltraWelcome");
            _messageService = new MessageService();
            _welcomeService = new WelcomeService(_messageService);

            PlayerEvents.Joined += OnPlayerJoined;
        }

        public override void Disable()
        {
            PlayerEvents.Joined -= OnPlayerJoined;
        }

        private void OnPlayerJoined(PlayerJoinedEventArgs ev)
        {
            if (ev?.Player == null) return;

            _welcomeService.HandleJoin(ev.Player, Config);    
        }
    }
}