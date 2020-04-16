using System;
using System.Linq;

namespace MortalityWHO {
    class Program {
        static void Main() {
            var mortalityDb = new MortalityDb();
            foreach (var reason in mortalityDb.records.OrderBy(r=>r.deaths1))
                Console.WriteLine(reason.cause + " - " + reason.deaths1);
        }
    }
}
