using System;
using System.Collections.Generic;
using System.Globalization;

namespace PersonsInfo
{
    public class StartUp
    {
        
        static void Main(string[] args)
        {
          
          var n = int.Parse(Console.ReadLine());
          Team team = new Team("SoftUni");
          for (int i = 0; i < n; i++)
          {
              var cmdArgs = Console.ReadLine().Split();
              var person = new Person(cmdArgs[0],
              cmdArgs[1],
              int.Parse(cmdArgs[2]),
              decimal.Parse(cmdArgs[3], CultureInfo.InvariantCulture));
              team.AddPlayer(person);
          }
          
          
          Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
          Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            
            
        }
    }
}