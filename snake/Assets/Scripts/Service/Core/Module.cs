using SGF;

namespace Assets.Scripts.Service.Core
{
    public abstract class Module
    {
        public virtual void Release()
        {
            this.Log("Release");
        }
    }
}