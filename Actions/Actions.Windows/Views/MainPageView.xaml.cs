﻿using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Actions.Entities;

namespace Actions.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPageView : Page
    {
        public MainPageView()
        {
            this.InitializeComponent();
            Movie movie = new Movie
            {
                Title = "Matrix"
            };

            MainHub.DataContext = movie;
        }
    }
}
