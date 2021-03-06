#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfExpander
{
    [Preserve(AllMembers = true)]
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields

        int counter = 11;

        #endregion

        #region Properties

        public ObservableCollection<Contact> ContactsInfo { get; set; }

        #endregion

        #region Constructor

        public ViewModel()
        {
            ContactsInfo = new ObservableCollection<Contact>();
            Assembly assembly = typeof(SampleBrowser.SfExpander.ExpandableListView).GetTypeInfo().Assembly;
            int i = 0;
            foreach (var cusName in CustomerNames)
            {
                if (counter == 13)
                    counter = 1;
                var contact = new Contact(cusName);
                contact.CallTime = CallTime[i];
#if COMMONSB
                contact.PhoneImage = ImageSource.FromResource("SampleBrowser.Icons.Accordion.PhoneImage.png", assembly);
                contact.ContactImage = ImageSource.FromResource("SampleBrowser.Icons.Accordion.Image" + counter + ".png", assembly);
                contact.AddContact = ImageSource.FromResource("SampleBrowser.Icons.Accordion.AddContact.png", assembly);
                contact.NewContact = ImageSource.FromResource("SampleBrowser.Icons.Accordion.NewContact.png", assembly);
                contact.SendMessage = ImageSource.FromResource("SampleBrowser.Icons.Accordion.SendMessage.png", assembly);
                contact.BlockSpan = ImageSource.FromResource("SampleBrowser.Icons.Accordion.BlockSpan.png", assembly);
                contact.CallDetails = ImageSource.FromResource("SampleBrowser.Icons.Accordion.CallDetails.png", assembly);
#else
                contact.PhoneImage = ImageSource.FromResource("SampleBrowser.SfExpander.Images.PhoneImage.png", assembly);
                contact.ContactImage = ImageSource.FromResource("SampleBrowser.SfExpander.Images.Image" + counter + ".png", assembly);
                contact.AddContact = ImageSource.FromResource("SampleBrowser.SfExpander.Images.AddContact.png", assembly);
                contact.NewContact = ImageSource.FromResource("SampleBrowser.SfExpander.Images.NewContact.png", assembly);
                contact.SendMessage = ImageSource.FromResource("SampleBrowser.SfExpander.Images.SendMessage.png", assembly);
                contact.BlockSpan = ImageSource.FromResource("SampleBrowser.SfExpander.Images.BlockSpan.png", assembly);
                contact.CallDetails = ImageSource.FromResource("SampleBrowser.SfExpander.Images.CallDetails.png", assembly);
#endif
                i++;
                ContactsInfo.Add(contact);
                counter++;

            }
        }

        #endregion

        #region Fields

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Katherin",
            "Aliza",
            "Masona" ,
            "Lia" ,
            "Jacob  " ,
            "Jayden " ,
            "Ethani  " ,
            "Noah   " ,
            "Lucas  " ,
            "Logan  " ,
            "John  " ,
        };

        string[] CallTime = new string[]
        {
            "Tunisia, 1 days ago",
            "Colombia, 1 days ago",
            "Fiji, 1 days ago",
            "Belgium, 1 days ago",
            "Japan, 1 days ago",
            "Argentina, 2 days ago",
            "Mexico, 2 days ago",
            "Guinea, 2 days ago",
            "Australia, 2 days ago",
            "Uruguay, 2 days ago",
            "Denmark, 3 days ago",
            "Peru, 3 days ago",
            "Greece, 3 days ago",
            "Austria, 3 days ago",
            "Hungary, 3 days ago",
            "Japan, 4 days ago",
            "Malaysia, 4 days ago",
            "Bermuda, 4 days ago",
            "Egypt, 4 days ago",
            "Philippines, 4 days ago",
            "Sweden, 5 days ago",
            "Vietnam, 5 days ago",
            "Yemen, 5 days ago",
            "Nepal, 5 days ago",
            "Kenya, 5 days ago",
            "Iceland, 6 days ago",
            "Canada, 6 days ago",
            "Angola, 6 days ago",
            "Italy, 6 days ago",
            "Monaco, 6 days ago",
            "Sudan, 1 week ago",
            "Togo, 1 week ago",
            "Benin, 1 week ago"
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
