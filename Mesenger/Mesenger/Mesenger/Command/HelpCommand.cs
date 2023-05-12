using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerC3c.Command
{
    public class HelpCommand : ICommand
    {
        private string result;
        public string Result => result;

        public void Execute(string atrib)
        {
            result = "time, help, ipconfig, who";
        }
    }
}
