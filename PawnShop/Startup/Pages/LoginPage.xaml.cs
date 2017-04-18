﻿using PawnShop.CommunicationService.Core;
using PawnShop.CommunicationService.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Startup.Interfaces;
using Startup.SwitchingService;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page, ISwitchable
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_Btn(object sender, RoutedEventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Password;
            var command = "Login";
            CommandDispatcher dispatcher = new CommandDispatcher();
            dispatcher.DispatchCommand(new string[]
            {
                command,
                username,
                password
            });
            var user = LoginUser.User.Credentials.Email;
            
            Switcher.Switch(new TestPage());
<<<<<<< HEAD
        }
        private void register_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new RegisterPage());
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
=======
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
>>>>>>> df251bf378ce915a10bdb267680b3047ed4ddfee
    }
}
