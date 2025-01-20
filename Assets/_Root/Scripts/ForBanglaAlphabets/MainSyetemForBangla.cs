using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Root.Scripts.ForBanglaAlphabets
{
    public class MainSystemForBangla : MonoBehaviour
    {
        public static List<char> _storeRandomBanglaAlphabetCopy = new List<char>();
        public BanglaLetterData banglaLetterData;
        public GameObject textPrefab;
        public Transform textContainer;
        
        public int count = 5;
        private void Start()
        {
            banglaLetterData.SelectUniqueRandomChar(count);
            _storeRandomBanglaAlphabetCopy = banglaLetterData._storeRandomBanglaAlphabet;
            SpawnAlphabet();
            _storeRandomBanglaAlphabetCopy.Sort();
        }


        
        GameObject[] SpawnAlphabet()
        {
         GameObject[] textMeshPro = new GameObject[count];
            
            for (int i = 0; i <  count; i++)
            {
                textMeshPro[i] = Instantiate(textPrefab, textContainer);
                textMeshPro[i].GetComponentInChildren<TextMeshProUGUI>().text = _storeRandomBanglaAlphabetCopy[i].ToString();
            }
            return textMeshPro;
        }
        
        
        public static void OnButtonClickBangla(TMP_Text tmp, Button btn)
        {
            if (tmp.text == _storeRandomBanglaAlphabetCopy[0].ToString())
            {
                _storeRandomBanglaAlphabetCopy.RemoveAt(0);
                if (_storeRandomBanglaAlphabetCopy.Count == 0)
                {
                    SceneManager.LoadScene("GamePlayBangla");
                }
                Destroy(btn.gameObject);
            }
            
            else
            {
                ButtonSpriteChange.buttonSpriteChange.ChangeButtonBackground(btn);
            }
        }


    }

}
