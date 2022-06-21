using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI.Interfaces
{
    interface IItem
    {
        public string Name { get; set; }

        public void Use();
    }
}
