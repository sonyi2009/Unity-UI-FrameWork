
using SGF.Utils;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UIManager
{

    public static class UIUtils
    {
        public static void SetActive(UIBehaviour ui, bool value)
        {
            if (ui != null && ui.gameObject != null)
            {
                GameObjectUtils.SetActiveRecursively(ui.gameObject, value);
            }
        }
    }
}
