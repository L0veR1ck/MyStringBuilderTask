using System;
using System.Collections.Generic;
using System.Linq;

namespace MyStringBuilderTask
{
    //Необходимо создать свою реализацию StringBuilder. 
    //Нужно уметь добавлять строку/символ, чистить билдер и преваращать в строку
    //В классе MyStringBuilder реализуйте необходимый функционал 
    //В классе MyStringBuilderTests продеманстрируйте использоване вашей реализации ¬


    // "ab" + "bc" "abbc"
    // [a][b][][][][][][] "bc" --> "bc" [a][b][b][c][][][][]

    public class MyStringBuilder
    {
        public List<char> Value = new List<char>();

        public void Append(string s)
        {
            foreach (var cur in s)
            {
                Value.Add(cur);
            }
        }

        public void Clear()
        {
            Value.Clear();
        }

        public string ToString()
        {
            return string.Join(String.Empty, Value);
        }
    }
}