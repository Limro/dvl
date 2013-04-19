﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UI.ManagerWindows
{
    /// <summary>
    /// Interaction logic for MasterPasswordPage.xaml
    /// </summary>
    public partial class MasterPasswordPage
    {
        private readonly Frame _parent;
        private readonly UiHandler _ui;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent">the frame this page is shown in</param>
        /// <param name="ui">the UIHandler for this UI</param>
        public MasterPasswordPage(Frame parent, UiHandler ui)
        {
            InitializeComponent();
            _parent = parent;
            _ui = ui;
            MasterPassWordLabel.Content = _ui.GeneratePassword(); 
        }

        /// <summary>
        /// Called when the back button is clicked
        /// </summary>
        /// <param name="sender">autogenerated</param>
        /// <param name="e">autogenerated</param>
        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            _parent.Navigate(new TypeChoicePage(_parent, _ui));
        }

        /// <summary>
        /// Called whene the next button is clicked
        /// </summary>
        /// <param name="sender">autogenerated</param>
        /// <param name="e">autogenerated</param>
        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            _parent.Navigate(new DataLoadPage(_parent, _ui));
        }

        
    }
}
