using Cocona.Builder;
using CodeRoom.Zenitsu.CLI.Commands;

namespace CodeRoom.Zenitsu.CLI.Extensions;

public static class CoconaAppExtension
{
    public static void AddZenitsuCommands(this ICoconaAppBuilder app)
    {
        app.AddCommands<PrepareCommitMessageController>();
    }
}
