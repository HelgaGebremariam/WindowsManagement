using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsManagement.Services
{
    [ComVisible(true)]
    [Guid("8E2C74B2-8B52-4C12-8FCF-23F86DE02EE4")]
    [ClassInterface(ClassInterfaceType.None)]
    public class PowerManagementService : IPowerManagementService
    {
        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?GetBatteryState@@YAHXZ")]
        private static extern int GetBatteryStateStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?GetLastSleepTime@@YA_KXZ")]
        private static extern ulong GetLastSleepTimeStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?GetLastWakeTime@@YA_KXZ")]
        private static extern ulong GetLastWakeTimeStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?Sleep@@YAXXZ")]
        private static extern void SleepStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?Hybernate@@YAXXZ")]
        private static extern void HybernateStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?ReserveHibernationFile@@YAXXZ")]
        private static extern void ReserveHibernationFileStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?DeleteHibernationFile@@YAXXZ")]
        private static extern void DeleteHibernationFileStatic();

        [DllImport("WindowsManagement.CppCore.dll", EntryPoint = "?GetSystemIdless@@YAKXZ")]
        private static extern ulong GetSystemIdlessStatic();

        public int GetBattaryState()
        {
            return GetBatteryStateStatic();
        }

        public ulong GetLastSleepTime()
        {
            return GetLastSleepTimeStatic();
        }
        public ulong GetLastWakeTime()
        {
            return GetLastWakeTimeStatic();
        }

        public void Sleep()
        {
            SleepStatic();
        }

        public void Hybernate()
        {
            HybernateStatic();
        }

        public void ReserveHibernationFile()
        {
            ReserveHibernationFileStatic();
        }

        public void DeleteHibernationFile()
        {
            DeleteHibernationFileStatic();
        }

        public ulong GetSystemIdless()
        {
            return GetSystemIdlessStatic();
        }

    }
}
