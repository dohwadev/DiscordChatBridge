using System;
using Dalamud.Logging;
using Dalamud.Plugin;
using Dalamud.Plugin.Ipc;

namespace Dalamud.DiscordBridge.API
{
    public class DiscordBridgeProvider
    {
        private const string LabelProviderApiVersion = "DiscordBridge.APIVersion";
        private const string LabelProviderSendMessage = "DiscordBridge.SendMessage";

        private readonly ICallGateProvider<int> providerAPIVersion;
        private readonly ICallGateProvider<string, string, string, object> providerSendMessage;

        public DiscordBridgeProvider(DalamudPluginInterface pluginInterface, IDiscordBridgeAPI api)
        {
            try
            {
                this.providerAPIVersion = pluginInterface.GetIpcProvider<int>(LabelProviderApiVersion);
                this.providerAPIVersion.RegisterFunc(() => api.APIVersion);
                
                this.providerSendMessage =
                    pluginInterface.GetIpcProvider<string, string, string, object>(LabelProviderSendMessage);
                this.providerSendMessage.RegisterAction(api.SendMessage);
            }
            catch (Exception ex)
            {
                PluginLog.LogError($"Error registering IPC provider:\n{ex}");
            }
        }
        
        public void Dispose()
        {
            this.providerAPIVersion?.UnregisterFunc();
            this.providerSendMessage?.UnregisterAction();
        }
    }
}
