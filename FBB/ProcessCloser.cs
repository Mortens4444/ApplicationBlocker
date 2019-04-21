using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FBB
{
    public class ProcessCloser
    {
        readonly IEnumerable<string> pageTitleParts;

        public ProcessCloser(IEnumerable<string> pageTitleParts)
        {
            this.pageTitleParts = pageTitleParts;
        }

        public void CloseUnwantedWebPages()
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                foreach (var pageTitlePart in pageTitleParts)
                {
                    var lowerCaseTitle = process.MainWindowTitle.ToLower();
                    if (lowerCaseTitle.Contains(pageTitlePart))
                    {
                        var keySender = new KeySender(process.MainWindowHandle);
                        keySender.SendCtrlF4To();
                    }
                }
            }
        }
    }
}
