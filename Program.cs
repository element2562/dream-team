using System;
using System.Collections.Generic;
namespace dream_team
{
    class Program
    {
        static void Main(string[] args)
        {
            Jacob jacob = new Jacob("Jacob", "Henderson", "C#");
            Austin austin = new Austin("Austin", "Gorman", "CSS");
            Brett Brett = new Brett("Brett", "Shearin", "JQuery");
            Jordan Jordan = new Jordan("Jordan", "Williams", "SQL");
            Jenn Jenn = new Jenn("Jenn", "Lawson", "JavaScript");
            Evan Evan = new Evan("Evan", "Lusky", ".NET");
            List<iPerson> clientSide = new List<iPerson>();
            List<iPerson> serverSide = new List<iPerson>();
            serverSide.Add(jacob);
            serverSide.Add(Jordan);
            serverSide.Add(Evan);
            clientSide.Add(austin);
            clientSide.Add(Brett);
            clientSide.Add(Jenn);
            foreach ( iPerson item in serverSide )
            {
                item.Work();
            }
            foreach ( iPerson item in clientSide )
            {
                item.Work();
            }

        }
    }
}
