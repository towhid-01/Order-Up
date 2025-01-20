using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;
namespace _Root.Scripts.ForBanglaAlphabets
{
    [Serializable]
    public class  BanglaLetterData  
    {
        public List<char> banglaAlphabetList = new List<char>()
        {
            'অ', 'আ', 'ই', 'ঈ', 'উ', 'ঊ', 'ঋ', 'এ', 'ঐ', 'ও', 'ঔ',
            'ক', 'খ', 'গ', 'ঘ', 'ঙ',
            'চ', 'ছ', 'জ', 'ঝ', 'ঞ',
            'ট', 'ঠ', 'ড', 'ঢ', 'ণ',
            'ত', 'থ', 'দ', 'ধ', 'ন',
            'প', 'ফ', 'ব', 'ভ', 'ম',
            'য', 'র', 'ল', 'শ', 'ষ',
            'স', 'হ', 'ড', 'ঢ', 'য়'
        };
    
        public List<char> _storeRandomBanglaAlphabet = new List<char>();
        
        public int count = 5;

        public void SelectUniqueRandomChar(int counter)
        {
            
            for (int i = 0; i < counter; i++)
            {
                var random = Random.Range(0, banglaAlphabetList.Count);
                _storeRandomBanglaAlphabet.Add(banglaAlphabetList[random]); 
                banglaAlphabetList.RemoveAt(random);
                
            }
            
    

        }
    }
}