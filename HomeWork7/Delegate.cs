using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public delegate void PortHendler(string message);
    public delegate void CallHendler(string message, string phoneNumberInterlocutor);
    public delegate void Call(string message);
}
