using System;
using System.Collections.Generic;

namespace SealTeamSix
{
    public class Robber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public virtual void PerformSkill(Bank bank)
        {
            
        }
    }
}