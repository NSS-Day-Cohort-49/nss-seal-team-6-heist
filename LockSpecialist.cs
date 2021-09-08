using System;
using System.Collections.Generic;

namespace SealTeamSix
{
    public class LockSpecialist : Robber, IRobber
    {
        public override void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is breaking into the vault. Decreased vault score by {SkillLevel} points.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has busted the locks!");
            }
        }
    }
}