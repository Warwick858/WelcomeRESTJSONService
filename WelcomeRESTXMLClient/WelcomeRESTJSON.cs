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
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace WelcomeRESTJSONClient
{
    public partial class WelcomeRESTJSON : Form
    {
        //Object to invoke the WelcomeRESTXMLSerice
        private HttpClient client = new HttpClient();

        public WelcomeRESTJSON()
        {
            InitializeComponent();
        } // end constructor

        //Get user input, pass it to the web service, and process response
        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            //Send request to WelcomeRESTJSONService - NOTE: POST NUMBER IN URI MAY HAVE CHANGED!!
            string result = await client.GetStringAsync(new Uri("http://localhost:15173/WelcomeRESTJSONService.svc/welcome/"
                + NameTxtBox.Text));

            //Deserialize JSON response
            DataContractJsonSerializer JSONSerializer = new DataContractJsonSerializer(typeof(TextMessage));

            //Parse JSON response into TextMessage object
            TextMessage msg = (TextMessage)JSONSerializer.ReadObject(new MemoryStream(Encoding.Unicode.GetBytes(result)));

            //Display message
            MessageBox.Show(msg.Message, "Welcome");
        } // end method SubmitBtn_Click

        //TextMessage class representing a JSON object
        [Serializable]
        public class TextMessage
        {
            public string Message;
        } // end class TextMessage
    } // end class WelcomeRESTJSON
} // end namespace WelcomeRESTJSONClient
