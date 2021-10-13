using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace among_us
{
    internal class imposter
    {
        public static bool issus = false;
        public imposter(string charactername)
        {
            // make sure is not sus
            checksus(charactername);
            // anti-sus
            if (issus == true)
            {
                //sus alert
                throw new SusException("ALERT: HIGH SUS LEVELS DETECTED");
            }
            
        }
        public void checksus(string name)
        {
            switch (name)
            {
                // add among us
                case "red among us":
                    Console.WriteLine("obviously sus");
                    
                    issus = true;
                    break;
                case "green among us":
                    Console.WriteLine("not too much sus");
                    issus=false;
                    break;
                case "yellow among us":
                    Console.WriteLine("always sus");
                    issus=true;
                    break;
                case "AObject=NullError.Exception":
                    Console.WriteLine("hacks man");
                    issus=!issus;
                    break;
            }
        }

    }
}
