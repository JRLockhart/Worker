using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class StingPatrol : Worker
    {

        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public bool SharpenStinger(int Length) { }
        public bool LookForEnemies() { }
        public void Sting(string Enemy) { }
    }
}
