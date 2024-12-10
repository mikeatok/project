using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp6.Model
{
    public partial class Vehicle : ObservableObject

    {
        [ObservableProperty]
        public string make;
        [ObservableProperty]
        public string model;
        [ObservableProperty]
        public string imageurl;
        

        public Vehicle( string make, string model,string imageurl)
        {
            
            this.Make = make;
            this.Model = model;
            this.imageurl = imageurl;
        }

    }





}








