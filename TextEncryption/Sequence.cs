using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncryption
{
    /// <summary>Class <c>Sequence</c> model of characters sequence. 
    /// Gives able to check has this sequence specific character and replace it.</summary>
    class Sequence
    {
        readonly string value;

        public Sequence(string value)
        {
            this.value = value;
        }

        private int GetCharacterPosition(string character)
        {
            return value.IndexOf(character);
        }

        private int GetReplacedCharacterPosition(int originalCharacterPosition, int shift)
        {
            int replacedCharacterPosition = (originalCharacterPosition + shift) % value.Length;
            if (replacedCharacterPosition < 0) replacedCharacterPosition += value.Length;

            return replacedCharacterPosition;
        }

        private string GetReplacedCharacter(int originalCharacterPosition, int shift)
        {
            int replacedCharacterPosition = GetReplacedCharacterPosition(originalCharacterPosition, shift);

            return value.Substring(replacedCharacterPosition, 1);
        }

        public string GetReplacedCharacterOrEmptyString(string character, int shift)
        {
            int originalCharacterPosition = GetCharacterPosition(character);
            if (originalCharacterPosition == -1) return ""; // No character in sequence

            return GetReplacedCharacter(originalCharacterPosition, shift);
        }
    }
}
