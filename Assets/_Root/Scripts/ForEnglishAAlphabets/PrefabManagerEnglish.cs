using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Root.Scripts.ForEnglishAAlphabets
{
    public class PrefabManagerEnglish : MonoBehaviour
    {
         public Button btnEnglish;
         public TMP_Text txtEnglish;

        private void OnEnable()
        {
        
            btnEnglish.onClick.AddListener(OnButtonClickEnglish);
        }
    

        private void OnButtonClickEnglish()
        {
            GameManagerEnglish.OnButtonClickEnglishAlphabet(txtEnglish, btnEnglish);
        }

    }
}