using System;
using System.Collections.Generic;

namespace _Root.Scripts.ForEnglishAAlphabets
{
    [Serializable]
    public class EnglishAlphabetsData
    {
        public int countEnglish = 5; 
        public List<char> englishAlphabetList = new List<char>()
        {
            'A','B','C','D','E',
            'F','G','H','I','J',
            'K','L','M','N','O',
            'P','Q','R','S','T',
            'U','V','W','X','Y','Z'
        };

        public List<char> storeEnglishAlphabetList = new List<char>();

        public void SetUniqueRandomAlphabetEnglish()
        {
            for (int i = 0; i < countEnglish; i++)
            {
                var randomenglishAlphabet = UnityEngine.Random.Range(0, englishAlphabetList.Count);
                storeEnglishAlphabetList.Add(englishAlphabetList[randomenglishAlphabet]);
                englishAlphabetList.RemoveAt(randomenglishAlphabet);
            }
        }
    
    }
}
