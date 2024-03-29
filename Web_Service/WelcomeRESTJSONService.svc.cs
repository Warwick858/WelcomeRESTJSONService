﻿// ******************************************************************************************************************
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

namespace Web_Service
{
    public class WelcomeRESTJSONService : IWelcomeRESTJSONService
    {
        /// <summary>
        /// To return a welcome message to the client
        /// </summary>
        /// <param name="yourName">name as a string</param>
        /// <returns>the welcome message as a string</returns>
        public TextMessage Welcome(string yourName)
        {
            TextMessage msg = new TextMessage
            {
                Message = string.Format("Welcome to WCF Web Services with REST and JSON, {0}!", yourName)
            };

            return msg;
        } // end method Welcome
    } // end class WelcomeRESTXMLService
} // end namespace Web_Service
