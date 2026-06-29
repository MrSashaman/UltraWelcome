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

public class MessageService
{
    public void Send(Player player, string message, Config config)
    {
        switch (config.Mode)
        {
            case WelcomeMessageMode.Hint:
                player.SendHint(message, config.DisplayTime);
                break;

            case WelcomeMessageMode.Broadcast:
                player.SendBroadcast(
                    $"<color={config.BroadcastColor}>{message}</color>",
                    config.BroadcastDur
                );
                break;

            case WelcomeMessageMode.Both:
                player.SendHint(message, config.DisplayTime);
                player.SendBroadcast(
                    $"<color={config.BroadcastColor}>{message}</color>",
                    config.BroadcastDur
                );
                break;
        }
    }
}