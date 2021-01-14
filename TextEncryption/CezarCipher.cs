using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncryption
{
    class CezarCipher : System.Collections.Generic.List<Sequence>
    {
        static public readonly int DEFAULT_KEY = 13;
        private int key = DEFAULT_KEY;
        private readonly string UKRAINIAN_ALPHBET = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩ",
                                ENGLISH_ALPHBET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                                SYMMOLS = "!\"#$%^&*()+=-_'?.,|/`~№:;@[]{}",
                                NUMBERS = "0123456789";

        public CezarCipher()
        {
            this.LoadAvailableSequences();
        }

        private void LoadSequence(string sequence)
        {
            this.Add(new Sequence(sequence));
        } 

        private void LoadAlphbetSequence(string sequence)
        {
            LoadSequence(sequence.ToUpper());
            LoadSequence(sequence.ToLower());
        }

        private void LoadAvailableSequences()
        {
            LoadAlphbetSequence(ENGLISH_ALPHBET);
            LoadAlphbetSequence(UKRAINIAN_ALPHBET);
            LoadSequence(NUMBERS);
            LoadSequence(SYMMOLS);
        }

        public void SetKey(int key)
        {
            this.key = key;
        }

        private string GetCharacterByIndex(string text, int index)
        {
            return text.Substring(index, 1);
        }

        private string GetReplacedCharacterFromSequences(string character, int key)
        {
            foreach (Sequence sequence in this)
            {
                string replacedCharacter = sequence.GetReplacedCharacterOrEmptyString(character, key);
                if (replacedCharacter != "") return replacedCharacter;
            }

            return "";
        }

        private string GetReplacedOrOriginalCharacter(string character, int key)
        {
            string replacedCharater = GetReplacedCharacterFromSequences(character, key);
            if (replacedCharater == "") return character;

            return replacedCharater;
        }

        public string Codeс(string text, int key)
        {
            string result = "";

            for (int characterIndex = 0; characterIndex < text.Length; characterIndex++)
            {
                string character = GetCharacterByIndex(text, characterIndex);
                result += GetReplacedOrOriginalCharacter(character, key);
            }

            return result;
        }

        public string Encode(string text)
        {
            return this.Codeс(text, this.key);
        }

        public string Decode(string text)
        {
            return this.Codeс(text, -this.key);
        }
    }
}
