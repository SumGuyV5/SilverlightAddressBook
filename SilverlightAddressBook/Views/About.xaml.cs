/*****************************************************************
**  Program Name:   SAB (Silverlight Address Book) 				**
**  Version Number: V1.0                                        **
**  Copyright (C):  June 1, 2010 Richard W. Allen               **
**  Date Started:   June 1, 2010                                **
**  Date Ended:     June 1, 2010                                **
**  Author:         Richardn W. Allen                           **
**  Webpage:        http://richard-allen.homelinux.com/         **
**  IDE:            Visual Studio 2010                          **
**  Compiler:       C# 2010                                     **
**  Langage:        Silverlight 4 C# 2010     				    **
**  License:        GNU GENERAL PUBLIC LICENSE Version 2    	**
**		            see license.txt for for details	            **
******************************************************************/
namespace SilverlightAddressBook
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Navigation;
    
    /// <summary>
    /// <see cref="Page"/> class to present information about the current application.
    /// </summary>
    public partial class About : Page
    {
        /// <summary>
        /// Creates a new instance of the <see cref="About"/> class.
        /// </summary>
        public About()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.AboutPageTitle + " " + ApplicationStrings.ApplicationName;

            this.HeaderText.Text += " " + ApplicationStrings.ApplicationName;

            this.ContentText.Text = ApplicationStrings.ApplicationName + "\n";
            this.ContentText.Text += String.Format("Version {0}", ApplicationStrings.VersionNum) + "\n";
            this.ContentText.Text += ApplicationStrings.Copyright + "\n";
            this.ContentText.Text += "An address book coded in C#, Silverlight 4, RIA services and SQL Server 2008 Express and is licensed under the GPL 2. see license.txt in the source download for details\n\n";
            this.ContentText.Text += "Note: All data Submited will be viewable by the public and is saved on my SQL Server 2008. If you wish to Submit an address you will need to register or login as user \"Test\" password \"test2@\".\n";
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}