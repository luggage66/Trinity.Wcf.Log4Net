using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using log4net.Config;

namespace Trinity.Wcf.Log4Net
{
    public class Log4NetServiceBehavior : IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, 
                                         ServiceHostBase serviceHostBase, 
                                         System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, 
                                         BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            XmlConfigurator.Configure();

            var errorHandler = new Log4NetErrorHandler();

            foreach (ChannelDispatcher channelDispatcher in serviceHostBase.ChannelDispatchers)
            {
                channelDispatcher.ErrorHandlers.Add(errorHandler);
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {

        }
    }
}
