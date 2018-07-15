// ******************************************************************************************************************
//  Simple Web Service Example
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Web_Service
{
    [ServiceContract]
    public interface IWelcomeRESTJSONService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/welcome/{yourName}")] // WebGet Attribute returns data in JSON

        TextMessage Welcome(string yourName);
    } // end interface IWelcomeRESTXMLService

    //Class to encapsulate a string to send in JSON format
    [DataContract]
    public class TextMessage
    {
        //Only [DataMembers] of a [DataContract] are serialized, either in XML of JSON
        [DataMember] // DataMember attribute exposes this property to the client
        public string Message { get; set; }
    } // end class TestMessage
} // end namespace Web_Service
