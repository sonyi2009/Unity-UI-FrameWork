using System;
using UnityEngine;


namespace SGF.Utils
{
    public class GameObjectUtils
    {
        public static void SetActiveRecursively(GameObject target, bool bActive)
        {
#if (!UNITY_3_5)
            for (int n = target.transform.childCount - 1; 0 <= n; n--)
                if (n < target.transform.childCount)
                    SetActiveRecursively(target.transform.GetChild(n).gameObject, bActive);
            target.SetActive(bActive);
#else
		target.SetActiveRecursively(bActive);
#endif
        }

    }

}
