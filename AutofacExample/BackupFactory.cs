using System.Collections.Generic;
using System.Linq;

namespace AutofacExample
{
    class BackupFactory : IBackupFactory
    {
        public IEnumerable<string> GetFtpUsers()
        {
            return Enumerable.Empty<string>();
        }
    }
}