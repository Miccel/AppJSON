using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AppJSON.ExtendedMethods
{
    public class JSON : ICRUD
    {
        public string name;
        public int ID;
        public Object obj;
        private string jsonOutput;

        public JSON(string name, Object obj)
        {
            this.name = name;
            this.obj = obj;
            this.jsonOutput = "";
        }

        public void Read()
        {
            if(this.jsonOutput != "")
            {
                Console.WriteLine("Non è possibile creare un nuovo oggetto JSON. Prima liberare quello in memoria.");
            }
            else
            {
                this.jsonOutput = JsonConvert.SerializeObject(this.obj, Formatting.Indented);
            }
        }

        public void Update()
        {
            Console.WriteLine("Sto aggiornando");
        }

        public void Destroy()
        {
            Console.WriteLine("Sto distruggendo");
        }

        public void PrintJSON()
        {
            Console.WriteLine(this.jsonOutput);
        }
    }
}
