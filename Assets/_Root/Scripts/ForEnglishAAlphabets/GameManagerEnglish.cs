using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Root.Scripts.ForEnglishAAlphabets
{
    public class GameManagerEnglish : MonoBehaviour
    {
        public static List<char> storeEnglishAlphabetListCopy = new List<char>();
        public EnglishAlphabetsData englishAlphabetsData;
        public GameObject textPrefabEnglish;
        public Transform textContainerEnglish;
   
        void Start()
        {
            englishAlphabetsData.SetUniqueRandomAlphabetEnglish();
            storeEnglishAlphabetListCopy = englishAlphabetsData.storeEnglishAlphabetList;
            spawnEnglishAlphabets();
            storeEnglishAlphabetListCopy.Sort();
        }

        GameObject[] spawnEnglishAlphabets()
        {
            GameObject[] textMeshProEnglish = new GameObject[storeEnglishAlphabetListCopy.Count];
            for (int i = 0; i < storeEnglishAlphabetListCopy.Count; i++)
            {
                textMeshProEnglish[i] = Instantiate(textPrefabEnglish, textContainerEnglish);
                textMeshProEnglish[i].GetComponentInChildren<TextMeshProUGUI>().text = storeEnglishAlphabetListCopy[i].ToString();

            }
            return textMeshProEnglish;
        }

        public static void OnButtonClickEnglishAlphabet(TMP_Text textEnglish, Button button)
        {
            if (textEnglish.text == storeEnglishAlphabetListCopy[0].ToString())
            {
                storeEnglishAlphabetListCopy.RemoveAt(0);
                if (storeEnglishAlphabetListCopy.Count == 0)
                {
                    SceneManager.LoadScene("GamePlayEnglish");
                }
                Destroy(button.gameObject);
            }
            else
            {
                ButtonSpriteChange.buttonSpriteChange.ChangeButtonBackground(button);
            }

          
        }
        
    }
}
