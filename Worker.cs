using System;


namespace HomeWork
{
    public class Worker
    {
        private byte _exp;
        private string _wc;

        public string Name;
        public string Surname;
        public string WorkerCode { get=>this._wc; set=>this.WorkerCodeValidation(value); }

        public byte Experience
        {
            get => this._exp;
            set
            {
                //this is pointless because user cannot set < 0 and > 256
                if(value > 0) this._exp = value;   
                
            }
        }

        private void WorkerCodeValidation(string value)
        {
            string[] words = value.Split(' ');
            string code = "";


            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    code += word[0];
                }
            }

            this._wc = code;
        }
    }
}
