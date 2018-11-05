using UnityEngine;

namespace Assets.Scripts.UIManager.Example
{
    public class Example
    {
        public void Init()
        {
            Debuger.EnableLog = true;
            UIManager.Instance.Init("ui/Example/");
            UIManager.MainPage = "UIPage1";
            UIManager.Instance.EnterMainPage();
        }
    }
}