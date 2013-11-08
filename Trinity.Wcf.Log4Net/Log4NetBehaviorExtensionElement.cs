using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;

namespace Trinity.Wcf.Log4Net
{
    public class Log4NetBehaviorExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(Log4NetServiceBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new Log4NetServiceBehavior();
        }
    }
}
