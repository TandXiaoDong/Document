﻿// © 2011 IDesign Inc. 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.ServiceModel;

namespace ServiceModelEx.ServiceBus
{
   [ServiceContract]
   public interface IServiceBusDiscoveryCallback
   {
      [OperationContract(IsOneWay = true)]
      void DiscoveryResponse(Uri address,string contractName,string contractNamespace,Uri[] scopes);
   }
}