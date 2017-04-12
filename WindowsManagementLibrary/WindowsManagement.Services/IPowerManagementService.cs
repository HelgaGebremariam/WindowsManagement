using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsManagement.Services
{
    [ComVisible(true)]
    [Guid("69E39A4B-7106-41A6-B5CF-3A6FA0B4E6D5")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IPowerManagementService
    {
        int GetBattaryState();
        ulong GetLastSleepTime();
        ulong GetLastWakeTime();
        void Sleep();
        void Hybernate();
        void ReserveHibernationFile();
        void DeleteHibernationFile();
        ulong GetSystemIdless();
    }
}
