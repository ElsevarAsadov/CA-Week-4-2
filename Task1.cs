using System;

namespace HomeWork
{  
    public class Task1
    {
        public string value;

        public Task1(string str) {
            this.value = str;
        }

        //case fot char
        public int LastIndexOf(char s)
        {
            for(int i = this.value.Length - 1; i > -1; i--)
            {
                if (this.value[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }

        //case for string
        public int LastIndexOf(string s)
        {
            //shows how many char remain in other mean if lettersRemain == 0 means we find a occurence of var 's'
            int lettersRemain = s.Length - 1;
            int idx = -1;
            for (int i = this.value.Length - 1; i > -1; i--)
            {
                if (lettersRemain < 0)
                {
                    return idx + 1;
                }
                else if (this.value[i] == s[lettersRemain])
                {
                    idx = i - 1 ;
                    lettersRemain--;
            
                }
                else
                {
                    idx = -1;
                    lettersRemain = s.Length - 1;
                }
            }
            idx = -1;


            return idx;
        }


        //case for char
        public bool Contains(char s) {

            foreach(char i in this.value)
            {
                if (i == s) return true;
            }

            return false;
        }

        //case for string
        public bool Contains(string s) {
            //this value is the index of searched string letter we search
            int validLetterIdx = 0;
            foreach(char i in this.value)
            {
                if(validLetterIdx > s.Length-1)
                {
                    return true;
                }
                else if(i != s[validLetterIdx])
                {   //reset idx
                    validLetterIdx = 0;
                }
                else if(i == s[validLetterIdx])
                {
                    validLetterIdx++;
                }
            }
            return false;
            
        }

     
        public string Replace(char s, char x)
        {
            string res = String.Empty;
            //which idx should be changed
            int[] idxs = new int[0];
            //find indexes
            for(int i = 0; i < this.value.Length; i++)
            {
                if (this.value[i] == s) {
                    Array.Resize(ref idxs, idxs.Length + 1);
                    idxs[^1] = i;
                };
            }

            //replace
            for(int i = 0; i < this.value.Length; i++)
            {
                if (idxs.Contains(i))
                {
                    res += x;
                }
                else
                {
                    res += this.value[i];
                }
            }

            return res;

        }

        
        public string Substring(int startIndex)
        {
            string res = String.Empty;
            
            //original design uses value.Length but it sounds very dummy so if the length greater than length - 1 this implementation throws exception
            if(startIndex > this.value.Length - 1 || startIndex < 0)
            {
                throw new Exception("Wtf?");
            }

            for(int i = startIndex; i < this.value.Length; i++)
            {
                res += this.value[i];
            }

            return res;

        }

        //the basic format
        public string Trim()
        {

            int startIndex = 0;
            int endIndex = this.value.Length - 1;

            while (startIndex < this.value.Length && this.value[startIndex] == ' ')
            {
                startIndex++;
            }

            while (endIndex >= 0 && this.value[endIndex] == ' ')
            {
                endIndex--;
            }

            if (endIndex < startIndex)
            {
                return string.Empty;
            }

            return this.value.Substring(startIndex, endIndex - startIndex + 1);
        }

    }
}
