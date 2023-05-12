using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerC3c.Command
{
    internal class sendClient : ICommand
    {
        private string result;
        public string Result => result;

        public void Execute(string atrib)
        {
            result = DateTime.Now.ToString();
        }
    }
}
