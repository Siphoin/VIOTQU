using System;
using System.Diagnostics;
using System.Management;

namespace VIOTQU
{
    /// <summary>
    /// class for get data on the pc
    /// </summary>
    public  class PCConfig : IDisposable
    {
        /// <summary>
        /// name processor
        /// </summary>
        private string NameProcessor;
        /// <summary>
        /// size ram
        /// </summary>
        
        private string MemoeyTotal;
        /// <summary>
        /// version Windows
        /// </summary>
        private string windowsName;
        /// <summary>
        /// name video driver. if not exits return value None
        /// </summary>
        private string nameVideoAdapter = "None";
        public PCConfig()
        {
            // get name processor
            ManagementObjectSearcher mos =
  new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                NameProcessor = mo["Name"].ToString();
            }
            // get ram data
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            double res;
            MemoryShow memoryShow = new MemoryShow();
            foreach (ManagementObject result in results)
            {
                res = Convert.ToDouble(result["TotalVisibleMemorySize"]);

                MemoeyTotal = memoryShow.GetStringRAM(res);
            }

            memoryShow.Dispose();

            // get windows data

            string subKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion";
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey skey = key.OpenSubKey(subKey);

            windowsName = skey.GetValue("ProductName").ToString();

            // get video card data

            ManagementObjectSearcher searcherCard
     = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            foreach (ManagementObject mo in searcherCard.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                       nameVideoAdapter = property.Value.ToString();
                    }
                }
            }
        }

        public string processorName { get => NameProcessor; }
        public string memoryTotalString { get => MemoeyTotal; }
        public string windows { get => windowsName; }
        public string videoAdapter { get => nameVideoAdapter; }

        public void Dispose()
        {
            NameProcessor = null;
            MemoeyTotal = null;
            windowsName = null;
            nameVideoAdapter = null;
        }
    }
}
