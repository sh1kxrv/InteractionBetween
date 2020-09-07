using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween
{
    public interface ILogger
    {
        void Error(string msg);
        void Error(Exception ex);
        void Warning(string msg);
        void Success(string msg);
        void Info(string msg);
        void Debug(string msg);
    }
}
