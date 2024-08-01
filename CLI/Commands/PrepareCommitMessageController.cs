using Microsoft.Extensions.Logging;
using CodeRoom.Zenitsu.CLI.Enums;

namespace CodeRoom.Zenitsu.CLI.Commands;

public class PrepareCommitMessageController
{
    private readonly ILogger<PrepareCommitMessageController> _logger;

    # region ---- Constructor --------------------------------------------------

    public PrepareCommitMessageController(
        ILogger<PrepareCommitMessageController> logger
    )
    {
        _logger = logger;
    }

    # endregion

    [Command(name: "commit-message", Aliases = ["cm"])]
    public async Task<uint> InstallHookAsync(
        [Option(shortName: ShortOptions.Install)]
        bool install,

        [Option(shortName: ShortOptions.Uninstall)]
        bool uninstall
    )
    {
        _logger.LogInformation("i: {i}", install);
        _logger.LogInformation("u: {u}", uninstall);
        _logger.LogInformation("Installing prepare-commit-msg hook...");

        return 0;
    }

    // [Command(name: "commit-message")]
    // public async Task UninstallHookAsync(
    //     [Option(shortName: ShortOptions.Uninstall)]
    //     bool uninstall
    // )
    // {
    //     _logger.LogInformation("Uninstalling prepare-commit-msg hook...");
    //     Console.WriteLine("Uninstalling prepare-commit-msg hook...");
    // }
}
