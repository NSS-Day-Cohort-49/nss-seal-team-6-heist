using System;
using System.Collections.Generic;


namespace SealTeamSix 
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public bool isSecure { get; set; } =
        {
            if (CashOnHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0 )
            {
                 isSecure = false;
            }
            else 
            {
                isSecure = true;
            }
        }
    }
}