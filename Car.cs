using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part1
{
    class Car
    {
      public    string manufacture;
      public    int year { get; set; }



      public    int PlateNumber;
      public    string color;
      public    string owner;


        float speed;

        public void changeSpeed(int s)
        { 
           if(s > 0) 
            
            {
            
              speed = s;    
            
            }
        }



    }
}
