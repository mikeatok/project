using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp6.Model;

namespace MauiApp6.Viewmodel
{

    public partial class Communityviewmodel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Vehicle> vehicles;


        public Communityviewmodel()
        {

            this.vehicles = new ObservableCollection<Vehicle>();



            Addsampledata();

        }

        void Addsampledata()
        {
            Vehicles.Add(new Vehicle( "Toyota", "Corrola", "https://media.toyota.co.uk/wp-content/uploads/sites/5/2022/06/2022-%E2%80%93-COROLLA-TOURING-SPORTS-MtE_Dynamic_001-scaled.jpg"));
            Vehicles.Add(new Vehicle( "Ford", "fiesta", "https://hips.hearstapps.com/hmg-prod/images/2017-ford-fiesta-1557785069.jpg"));
            Vehicles.Add(new Vehicle( "Nissan", "GTR", "nissan_gtr.jpg"));
            Vehicles.Add(new Vehicle( "Mercedes", "C-class", "mercedes_class.jpg"));
            Vehicles.Add(new Vehicle("Toyota", "Camry", "toyota_camry.jpg"));
            Vehicles.Add(new Vehicle("Mercedes", "GLK", "mercedes_glkk.jpg"));
            
        }

        
        void Addvehicle(string make, string model, string imageurl)
        {
            Vehicle vehicle = new Vehicle(make, model, imageurl);
            vehicles.Add(vehicle);

        }
        void Deletevehicle(string Make, string Model, string imageurl)
        {
            var vehicletoremove = Vehicles.FirstOrDefault(i => i.Make == Make && i.Model == Model);
            if (vehicletoremove != null)
            {
                Vehicles.Remove(vehicletoremove);
            }
            static void PrintVehiclelist(ObservableCollection<Vehicle> vehicles)

            {

                if (vehicles.Count >= 0) ;
                foreach (Vehicle vehicle in vehicles)

                {
                    Console.WriteLine($"{vehicle.Make} {vehicle.Model}");
                }


            }
        }
    }
}




