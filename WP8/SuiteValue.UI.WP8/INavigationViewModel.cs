﻿using System;
using System.Collections.Generic;
using System.Windows.Navigation;

namespace SuiteValue.UI.WP8
{
    public interface INavigationViewModel
    {
        event EventHandler<NavigationEventArgs> RequestNavigateTo;
        event EventHandler<EventArgs> RequestNavigateBack;
        bool RegisteredForNavigation { get; set; }

        void OnNavigatedTo(NavigationMode mode, IDictionary<string,string> parameter);
        bool OnNavigatingFrom(NavigationMode mode);
        void OnNavigatedFrom(NavigationMode mode);
        bool OnBackKeyPress();
    }
}