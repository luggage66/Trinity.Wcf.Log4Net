using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using log4net;
using System.Reflection;
using System.ServiceModel.Channels;
using log4net.Config;
using System.IO;

namespace Trinity.Wcf.Log4Net
{
    //http://pieterderycke.wordpress.com/2012/09/05/logging-all-unhandled-exception-in-wcf-with-log4net/
    public class Log4NetErrorHandler : IErrorHandler
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool HandleError(Exception error)
        {
            log.Error(error);
            return false; // Exception has to pass the stack further
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
        }
    }
}
