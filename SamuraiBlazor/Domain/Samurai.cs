using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamuraiBlazor.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Quote> Quotes { get; set; }
        public Horse Horse { get; set; }
    }
}
