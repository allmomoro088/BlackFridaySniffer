using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Data
{
    public interface IQuery<T>
    {
        IEnumerable<T> ReadAll();
        T Read(string id);
    }
}
