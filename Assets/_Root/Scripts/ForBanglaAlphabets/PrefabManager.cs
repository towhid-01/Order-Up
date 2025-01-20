using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Root.Scripts.ForBanglaAlphabets
{
    public class PrefabManager : MonoBehaviour
    {
        public Button btn;
        public TMP_Text txt;

        private void OnEnable()
        {
            btn.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            MainSystemForBangla.OnButtonClickBangla(txt,btn);
        }


    }
}
