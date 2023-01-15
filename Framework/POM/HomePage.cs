using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class HomePage
    {
        

        public static void Startup()
        {
            Driver.StartDriver();
            Driver.OpenPage("https://www.skytech.lt");
            
        }
      
        
    }
}
