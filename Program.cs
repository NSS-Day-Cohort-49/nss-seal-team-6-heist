using System;
using System.Collections.Generic;
using System.Linq;

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
                    PercentageCut = 6
                },
                new LockSpecialist(){
                    Name = "Kipp",
                    SkillLevel = 36,
                    PercentageCut = 14
                },
                new Muscle(){
                    Name = "Sylvester",
                    SkillLevel = 85,
                    PercentageCut = 23
                },
                new Hacker(){
                    Name = "Julian",
                    SkillLevel = 90,
                    PercentageCut = 34
                },
                new LockSpecialist(){
                    Name = "Christina",
                    SkillLevel = 99,
                    PercentageCut = 26
                }
            };

            Console.WriteLine($"There are {rolodex.Count} robbers in your rolodex!");

            Console.WriteLine("---------------");
            
            while (true) 
            {
                Console.WriteLine("Please enter a name for a new robber contact!");
                string newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }

                Console.Write(@$"What is {newMemberName}'s specialty?
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
                CashOnHand = new Random().Next(50000, 1000000),
                AlarmScore = new Random().Next(0,101),
                VaultScore = new Random().Next(0,101),
                SecurityGuardScore = new Random().Next(0,101)
            };

            int alarm = piggyBankChase.AlarmScore;
            int vault = piggyBankChase.VaultScore;
            int guard = piggyBankChase.SecurityGuardScore;

            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Console.WriteLine("Security Recon Report:");

            if (alarm > vault && alarm > guard)
            {
                Console.WriteLine($"Most secure: Alarm");
            }
            else if (vault > alarm && vault > guard)
            {
                Console.WriteLine($"Most secure: Vault");
            }
            else
            {
                Console.WriteLine("Most secure: Security guards");
            }

            if (alarm < vault && alarm < guard)
            {
                Console.WriteLine($"Least secure: Alarm");
            }
            else if (vault < alarm && vault < guard)
            {
                Console.WriteLine($"Least secure: Vault");
            }
            else
            {
                Console.WriteLine("Least secure: Security guards");
            }

            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("");

            Console.WriteLine("Your contacts:");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");


            foreach (IRobber robber in rolodex)
            {
                Console.WriteLine(rolodex.IndexOf(robber));
                Console.WriteLine("Name: " + robber.Name);
                Console.WriteLine("Specialty " + robber.GetType().Name);
                Console.WriteLine("Skill Level " + robber.SkillLevel);
                Console.WriteLine("Percentage Cut " + robber.PercentageCut);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            List<IRobber> crew = new List<IRobber>();

            int crewCut = 0;

            while (true)
            {
                Console.WriteLine("Enter the index of the robber you want to include in your crew, or press ENTER to begin your heist.");
                string contactIndex = Console.ReadLine();

                if (contactIndex == "")
                {
                    break;    
                }

                IRobber contact = rolodex[int.Parse(contactIndex)];

                if (crew.Contains(contact))
                {
                    Console.WriteLine("Robber already in crew.");
                    Console.WriteLine("");
                }
                else if (crewCut + contact.PercentageCut > 100) {
                    Console.WriteLine("You can't afford that robber.");
                    Console.WriteLine("");
                }
                else
                {
                    crew.Add(contact);
                    crewCut += contact.PercentageCut;
                    Console.WriteLine($"You added {contact.Name} to your crew for this job.");
                    Console.WriteLine("");
                    Console.WriteLine("Current crew size: " + crew.Count);
                    foreach(IRobber robber in crew)
                    {
                        Console.WriteLine(robber.Name);
                    }
                    Console.WriteLine("");
                }

            }

            foreach (IRobber robber in crew)
            {
                robber.PerformSkill(piggyBankChase);
            }
            
            if(piggyBankChase.IsSecure){
                Console.WriteLine("");
                Console.WriteLine(":( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :(");
                Console.WriteLine(":(  Your crew were no match for the bank's security systems... Hope you make lots of friends in prison!  :(");
                Console.WriteLine(":( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :( :(");
            }
            else
            {
                double score = piggyBankChase.CashOnHand;
                double yourCut = score;
                Console.WriteLine("");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine("$  You took that bank down! Look at all dem Bennies!  $");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine("");
                Console.WriteLine($"Your crew stole ${score}!");
                foreach (IRobber robber in crew)
                {
                    double robberCut = 100.00/robber.PercentageCut;
                    double payout = score/robberCut;
                    Console.WriteLine($"You pay {robber.Name} their {robber.PercentageCut}% cut: ${Convert.ToInt32(payout)}");
                    yourCut -= payout;
                }

                Console.WriteLine($"After paying your crew you have ${Convert.ToInt32(yourCut)}.");
            }
        }
    }
}


// Create a new List<IRobber> and store it in a variable called crew. Prompt the user to enter the index of the operative they'd like to include in the heist. Once the user selects an operative, add them to the crew list.

// Allow the user to select as many crew members as they'd like from the rolodex. Continue to print out the report after each crew member is selected, but the report should not include operatives that have already been added to the crew, or operatives that require a percentage cut that can't be offered.

// Once the user enters a blank value for a crew member, we're ready to begin the heist. Each crew member should perform his/her skill on the bank. Afterwards, evaluate if the bank is secure. If not, the heist was a success! Print out a success message to the user. If the bank does still have positive values for any of its security properties, the heist was a failure. Print out a failure message to the user.

// If the heist was a success, print out a report of each members' take, along with how much money is left for yourself.