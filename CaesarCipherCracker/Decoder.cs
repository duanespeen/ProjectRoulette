using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherCracker
{
    public class Decoder
    {
        private string _input;
        public Decoder(string input)
        {
            _input = input;
        }
        
        public string Caeser(int shift)
        {
            char[] decoded = new char[_input.Length];
            for(int i = 0; i < _input.Length; i++)
            {
                if (!char.IsLetter(_input[i])) decoded[i] = _input[i];
                else
                {
                    char c = char.ToUpper(_input[i]);
                    c = (char)(c - shift);
                    if (c < 'A') c = (char)(c + 26);
                    decoded[i] = char.IsUpper(_input[i]) ? c : char.ToLower(c);
                }
            }
            return new string(decoded);
        }
    }
}
