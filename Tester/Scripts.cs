using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Tester
{
    class Scripts
    {
        public static Data DataFile = new Data();
        public static Data DataLocationCompiler = new Data();

        public static void Debug(string locationFile)
        {
            #region Debug

            Data.ClearLocation(DataFile);
            Data.ClearLocation(DataLocationCompiler);

            Split(locationFile, DataFile);
            Split(Data.LocationCompiler, DataLocationCompiler);

            
            Process mYproces;
            mYproces = new Process();
            mYproces.StartInfo.FileName = "cmd.exe";
            mYproces.StartInfo.Arguments = $"/C \"cd {DataLocationCompiler.CURRENT_DERECTORY} && {DataLocationCompiler.NAME_PART}{DataLocationCompiler.EXT_PART} {DataFile.CURRENT_DERECTORY} \"{DataFile.NAME_PART}\" {DataFile.EXT_PART}\" ";

            mYproces.Start();
            mYproces.WaitForExit();  // ждем завершения процеса

            Process[] fasms = Process.GetProcessesByName("FASM");

            foreach (Process fasm in fasms)
                fasm.WaitForExit();
            //Thread.Sleep(3000);
            #endregion
        }

        private static void Split(string locationFile, Data data)
        {
            int mode = 0;
            for (int i = locationFile.Length - 1; i >= 0; i--)
            {
                switch (mode)
                {
                    case 0:
                        data.EXT_PART = locationFile[i].ToString() + data.EXT_PART;
                        if (locationFile[i] == '.')
                            mode++;
                        break;
                    case 1:
                        if (locationFile[i] == '\\')
                        {
                            i++;
                            mode++;
                        }
                        else
                        {
                            data.NAME_PART = locationFile[i].ToString() + data.NAME_PART;
                        }
                        break;
                    default:
                        data.CURRENT_DERECTORY = locationFile[i].ToString() + data.CURRENT_DERECTORY;
                        break;
                }
            }

        }
    }
}
