using System;
using System.Collections.Generic;

namespace SealTeamSix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Muscle(){
                    Name = "Luke",
                    SkillLevel = 69,
                    PercentageCut = 70
                },
                new Hacker(){
                    Name = "Kal",
                    SkillLevel = 27,
                    PercentageCut = 5
                },
                new LockSpecialist(){
                    Name = "Kipp",
                    SkillLevel = 36,
                    PercentageCut = 5
                },
                new Muscle(){
                    Name = "Sylvester",
                    SkillLevel = 85,
                    PercentageCut = 5
                },
                new Hacker(){
                    Name = "Julian",
                    SkillLevel = 90,
                    PercentageCut = 5
                },
                new LockSpecialist(){
                    Name = "Christina",
                    SkillLevel = 99,
                    PercentageCut = 5
                }
            };




            Console.WriteLine("Your contacts:");

            foreach (IRobber robber in rolodex)
            {
            Console.WriteLine(robber.Name);
            }

            Console.WriteLine($"There are {rolodex.Count} robbers in your rolodex!");



            Console.WriteLine("---------------");
            while (true) 
            {
                Console.WriteLine("Please enter a name for a new member!");
                string newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }

                Console.Write(@"Please select a specialty!
                1. Hacker (Disables Alarms)
                2. Muscle (Disables Security Guards)
                3. Lock Specialist (Cracks Vaults)
                ");



                int newMemberSpecialty = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a skill level between 1-100");
                int newMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a percentage cut between 1-100");
                int newMemberPercentageCut = int.Parse(Console.ReadLine());           
                

                IRobber newMember;
                if (newMemberSpecialty ==  1) 
                {
                    newMember = new Hacker(){
                        Name = newMemberName,
                        SkillLevel = newMemberSkillLevel,
                        PercentageCut = newMemberPercentageCut
                    };
                    rolodex.Add(newMember);
                } else if (newMemberSpecialty == 2) 
                {
                    newMember = new Muscle(){
                        Name = newMemberName,
                        SkillLevel = newMemberSkillLevel,
                        PercentageCut = newMemberPercentageCut
                    };
                    rolodex.Add(newMember);
                } else if (newMemberSpecialty == 3) {
                    newMember = new LockSpecialist(){
                        Name = newMemberName,
                        SkillLevel = newMemberSkillLevel,
                        PercentageCut = newMemberPercentageCut
                    };
                    rolodex.Add(newMember);
                }

                Console.WriteLine(rolodex.Count);
            
            } 


                  Bank piggyBankChase = new Bank()
            {
                AlarmScore = new Random().Next(0,101),
            };


        }
    }
}

// Continue the above action and allow the user to enter as many crew members as they like to the rolodex until they enter a blank name before continuing.

// Once the user is finished with their rolodex, it's time to begin a new heist

// The program should create a new bank object and randomly assign values for these properties:

// AlarmScore (between 0 and 100)
// VaultScore (between 0 and 100)
// SecurityGuardScore (between 0 and 100)
// CashOnHand (between 50,000 and 1 million)
// Let's do a little recon next. Print out a Recon Report to the user. This should tell the user what the bank's most secure system is, and what its least secure system is (don't print the actual integer scores--just the name, i.e. Most Secure: Alarm Least Secure: Vault

// Now that we have a clue what kind of security we're working with, we can try to built out the perfect crew.