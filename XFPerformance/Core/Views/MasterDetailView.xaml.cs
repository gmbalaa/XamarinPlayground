﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Core.Views
{
    public partial class MasterDetailView : MasterDetailPage
    {
        public MasterDetailView()
        {
            InitializeComponent();
        }

        void OnClickToListView(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("## CLICADO ##");
			IsPresented = false;
            Detail = new NavigationPage(new DetailView());
        }

        async void OnClickToListViewLazy(object sender, EventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("## CLICADO ##");
			IsPresented = false;
			await Task.Delay(225);
            Detail = new NavigationPage(new DetailView());
        }

		void OnClickToDetail(object sender, EventArgs e)
		{
            System.Diagnostics.Debug.WriteLine("## CLICADO ##");
			IsPresented = false;
            Detail = new NavigationPage(new SampleView());
		}

		async void OnClickToDetailLazy(object sender, EventArgs args)
		{
            System.Diagnostics.Debug.WriteLine("## CLICADO ##");
			IsPresented = false;
			await Task.Delay(225);
			Detail = new NavigationPage(new Sample2View());
		}
    }
}
