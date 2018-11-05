using Assets.Scripts.Service.Core;

namespace assets.scripts.service.core
{
    public static class GlobalEvent
    {
        public static ModuleEvent<bool> onLogin = new ModuleEvent<bool>();
        public static ModuleEvent<bool> onPay = new ModuleEvent<bool>();
    }
}