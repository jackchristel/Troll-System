using ConVar;
using Network;
using Oxide.Core.Libraries.Covalence;
using Oxide.Game.Rust.Libraries;

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
        private void BanCommand(IPlayer player, string command, string[] args)
        {
            Message = string.Join(" ", args);
        }
        
    }
}
