using System.Collections.Generic;

namespace EvoComputerTechService.Models
{
    public class RoleNames
    {
        public static string Admin = "Admin";
        public static string User = "User";
        public static string PassiveUser = "PassiveUser";
        public static string Operator = "Operator";
        public static string Technician = "Technician";

        public static List<string> Roles => new List<string>() { Admin, User, PassiveUser, Operator, Technician };
    }
}
