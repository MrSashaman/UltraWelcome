using System;
using LabApi.Features.Wrappers;
using LabApi.Loader.Features.Plugins;
using LabApi.Features;
using LabApi;
using LabApi.Features.Console;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.Handlers;
using System.Drawing;


namespace UltraWelcome;

public class WelcomeService
{
    private readonly MessageService _messageService;

    public WelcomeService(MessageService messageService)
    {
        _messageService = messageService;
    }

    public void HandleJoin(Player player, Config config)
    {
        string message = config.WelcomeText.Replace("{PlayerName}", player.Nickname);

        _messageService.Send(player, message, config);
    }
}