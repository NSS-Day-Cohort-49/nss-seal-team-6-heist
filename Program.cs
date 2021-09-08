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
                Muscle luke = new Muscle(){
                    Name = "Luke",
                    SkillLevel = 69,
                    PercentageCut = 70
                },
                Hacker kal = new Hacker(){
                    Name = "Kal",
                    SkillLevel = 27,
                    PercentageCut = 5
                },
                LockSpecialist kipp = new LockSpecialist(){
                    Name = "Kipp",
                    SkillLevel = 36,
                    PercentageCut = 5
                },
                Muscle sly = new Muscle(){
                    Name = "Sylvester",
                    SkillLevel = 85,
                    PercentageCut = 5
                },
                Hacker julian = new Hacker(){
                    Name = "Julian",
                    SkillLevel = 90,
                    PercentageCut = 5
                },
                LockSpecialist christina = new Christina(){
                    Name = "Christina",
                    SkillLevel = 99,
                    PercentageCut = 5
                }
            }
        }
    }
}


// In the Main method, create a List<IRobber> and store it in a variable named rolodex. This list will contain all possible operatives that we could employ for future heists. We want to give the user the opportunity to add new operatives to this list, but for now let's pre-populate the list with 5 or 6 robbers (give it a mix of Hackers, Lock Specialists, and Muscle).

// When the program starts, print out the number of current operatives in the rolodex. Then prompt the user to enter the name of a new possible crew member. Once the user has entered a name, print out a list of possible specialties and have the user select which specialty this operative has. The list should contain the following options

// Hacker (Disables alarms)
// Muscle (Disarms guards)
// Lock Specialist (cracks vault)
// Once the user has selected a specialty, prompt them to enter the crew member's skill level as an integer between 1 and 100. Then prompt the user to enter the percentage cut the crew member demands for each mission. Once the user has entered the crew member's name, specialty, skill level, and cut, you should instantiate the appropriate class for that crew member (based on their specialty) and they should be added to the rolodex.

// Continue the above action and allow the user to enter as many crew members as they like to the rolodex until they enter a blank name before continuing.

// Once the user is finished with their rolodex, it's time to begin a new heist