using System.Collections.Generic;

namespace AutofacExample
{
    interface IBackupFactory
    {
        IEnumerable<string> GetFtpUsers();
    }
}