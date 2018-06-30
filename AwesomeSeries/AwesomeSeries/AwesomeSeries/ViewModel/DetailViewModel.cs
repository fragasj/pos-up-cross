﻿using AwesomeSeries.Models;
using AwesomeSeries.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeSeries.ViewModel
{
    public class DetailViewModel : ViewModelBase
    {

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        string _overview;
        public string Overview
        {
            get { return _overview; }
            set { _overview = value; OnPropertyChanged(); }
        }

        string _poster;
        public string Poster
        {
            get { return _poster; }
            set { _poster = value; OnPropertyChanged(); }
        }

        string _backdrop;
        public string Backdrop
        {
            get { return _backdrop; }
            set { _backdrop = value; OnPropertyChanged(); }
        }

        double _votes;
        public double Votes
        {
            get { return _votes; }
            set { _votes = value; OnPropertyChanged(); }
        }

        string _releaseDate;
        public string RealeseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; OnPropertyChanged(); }
        }

        public DetailViewModel() : base("")
        {
        }

        public override async Task InitializeAsync(object parameter)
        {
            var serie = (parameter as Serie);
            Title = serie.Name;
            Name = serie.OriginalName;
            Overview = serie.Overview;

            Poster = serie.Poster;
            Backdrop = serie.Backdrop;
            RealeseDate = serie.ReleaseDate;

            await base.InitializeAsync(parameter);

        }

    }
}
