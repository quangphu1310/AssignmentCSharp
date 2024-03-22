using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public class Position
    {
        public int Id { get; set; }
        public string NamePos { get; set; }
        public static List<Position> GetPositions()
        {
            return new List<Position>()
            {
                new Position{Id = 1, NamePos= "Position 1"},
                new Position{Id = 2, NamePos= "Position 2"},
                new Position{Id = 3, NamePos= "Position 3"}
            };
        }
    }

}
