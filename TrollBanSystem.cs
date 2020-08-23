using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("Troll Ban System", "Grave", "0.1.0")]
    [Description("A easier way to troll ban someone in rust! doing /tban announces a server message where it says that a player was banned, and /tunban announces that a player was unbanned all without actually banning or unbanning anyone!")]
    class TrollBanSystem : CovalencePlugin
    {
        private void Init()
        {
            Puts("A baby plugin is born!");
        }

        [Command("tban")]
        private void Cmdtban(IPlayer player, string command, string[] args)
        {
            server.Broadcast($"{player.Name} banned {string.Join(" ", args)}");
        }

        [Command("tunban")]
        private void Cmdtunban(IPlayer player, string command, string[] args)
        {
            server.Broadcast($"{player.Name} unbanned {string.Join(" ", args)}");
        }

    }
}
