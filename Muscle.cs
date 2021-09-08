using System;
using System.Collections.Generic;

namespace SealTeamSix
{
    public class Hacker : Robber, IRobber
    {
        public override void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is giving security a beatdown. Decreased security by {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has demolished the security guards!");
            }
        }
    }
}