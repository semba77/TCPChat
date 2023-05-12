using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerC3c.Command
{
    public interface ICommand
    {
        //public List<string> Arguments { get; set; }
        public string Result { get; }
        public void Execute( string atrib);
    }
}
