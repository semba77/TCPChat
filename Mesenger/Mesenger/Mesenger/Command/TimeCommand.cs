using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerC3c.Command
{
    public class TimeCommand : ICommand
    {
        private string result;
        public string Result => result;

        public void Execute(string atrib)
        {
            result = DateTime.Now.ToString();
        }
    }
}
