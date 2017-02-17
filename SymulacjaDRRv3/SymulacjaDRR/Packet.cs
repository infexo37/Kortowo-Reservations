using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SymulacjaDRR
{
    class Packet
    {
        public BlockControl Block { get; set; }
        public int Length { get; protected set; }
        public Packet(int length)
        {
            this.Length = length;
        }
    }
}
