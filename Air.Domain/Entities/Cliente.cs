using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
