using Minave.Traveling.App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Minave.Traveling.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BuildMainMenu();

        }

        private void BuildMainMenu()
        {
            var layout = new RelativeLayout();
            var button = new Button
            {
                Text = "StackLayout",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var tagline = new Label() { Text = "PRueba" };

            var scovilleLabel = new Label()
            {
                Text = "SCOVILLE UNITS:",
                FontSize = 15,
                TextColor = Color.FromHex("#B7A19B"),
                FontFamily = Device.OnPlatform("HelveticaNeue-CondensedBlack", "sans-serif-condensed", "")
            };

            var scoville = new Label()
            {
                Text = "Prueba",
                FontSize = 20,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", "")
            };

            var name = new Label()
            {
                Text = "nommbre",
                FontSize = 30,
                TextColor = Color.FromHex("#FF6600"),
                FontFamily = Device.OnPlatform("HelveticaNeue-Medium", "sans-serif", "")
            };

            var details = new StackLayout()
            {
                Spacing = 10,
                Padding = new Thickness(50, 10),
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = {
            name,
            tagline,
            scovilleLabel,
            scoville,
        }
            };





            var addTravelBtn = new Button
            {
                Text = "Añadir Viaje"

            };
            var myImage = new Image()
            {
                Source = ImageSource.FromUri(new Uri("https://media-cdn.tripadvisor.com/media/photo-s/03/9b/2d/f2/new-york-city.jpg"))
            };
            var yellowBox = new BoxView
            {
                Color = Color.Yellow,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var greenBox = new BoxView
            {
                Color = Color.Green,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var blueBox = new BoxView
            {
                Color = Color.Blue,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75

            };

            var travel = new Travels()
            {
                Name = "Orlando"
            };




            var travels = new List<Travels>();
            travels.Add(travel);
            travels.Add(travel);
            travels.Add(travel);
            travels.Add(travel);
            travels.Add(travel);
            travels.Add(travel);
            travels.Add(travel);
            travels.Add(travel);


            layout.Children.Add(addTravelBtn,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * .5;
                }));


            foreach (var viaje in travels)
            {
                layout.Children.Add(myImage, Constraint.Constant(0), Constraint.Constant(0));
                layout.Children.Add(details, Constraint.Constant(0));




            }
            Content = layout;
        }
        private string NewTravelPage()
        {
            return "hola";
        }
    }
}
