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

    using System.ServiceModel.DomainServices.Client.ApplicationServices;

    /// <summary>
    /// Home page for the application.
    /// </summary>
    public partial class Home : Page
    {
        /// <summary>
        /// Creates a new <see cref="Home"/> instance.
        /// </summary>
        public Home()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.HomePageTitle + " " + ApplicationStrings.ApplicationName;
        }

        private void Authentication_Login(object sender, AuthenticationEventArgs e)
        {
            contactDomainDataSource.SubmitChanges();

            WebContext.Current.Authentication.LoggedIn -= Authentication_Login;
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void contactDomainDataSource_LoadedData(object sender, System.Windows.Controls.LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void SaveChangesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (WebContext.Current.User.IsAuthenticated)
            {
                contactDomainDataSource.SubmitChanges();
            }
            else
            {
                WebContext.Current.Authentication.LoggedIn += new EventHandler<AuthenticationEventArgs>(Authentication_Login);
                new LoginUI.LoginRegistrationWindow().Show();
            }
            
        }

        private void ReloadDataButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            contactDomainDataSource.Load();
        }
    }
}