using System;

namespace Buffteks.Model
{
    public class TeamProject
    {
        public int TeamID 
        {  
            get{
                if(this.TeamID == 3)
                {
                    return 9;
                }
                else{
                    return this.TeamID;
                }

            }
        
            set{

            } 
            
        }

        public Team TheTeam {get; set; }

        public int ProjectID {get; set;}
        public Team TheProject {get; set; }

      
    }
}