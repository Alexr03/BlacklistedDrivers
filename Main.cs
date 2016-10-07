using Rocket.Core.Plugins;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Rocket.Core.Logging;

namespace BlackListedDrivers
{
    public class Main : RocketPlugin<BlackListedDriversConfiguration>
    {
        public static Main Instance;
        public static List<CSteamID> Blacklisted = new List<CSteamID>();

        protected override void Load()
        {
            Instance = this;
            Rocket.Core.Logging.Logger.Log("Blacklisted Drivers loaded! ~~ Alexr03!");

            Rocket.Unturned.Events.UnturnedPlayerEvents.OnPlayerUpdateStance += UpdatedStance;

            if (!Configuration.Instance.Save_Local)
            {
                Logger.Log("Due to Save_Local is the only option in this version it must be set to on for the plugin to function ~~ Unloading...");
                Unload();
            }
        }

        private void UpdatedStance(UnturnedPlayer player, byte stance)
        {
            if(stance == 6)
            {
                if (Blacklisted.Contains(player.CSteamID))
                {
                    player.CurrentVehicle.kickPlayer(0);
                }
            }
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Blacklisted Drivers unloaded! ~~ Alexr03!");
        }

        private void FixedUpdate()
        {
        }
    }
}
