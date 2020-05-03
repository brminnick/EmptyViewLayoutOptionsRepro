using System;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace EmptyViewLayoutOptionsRepro
{
    public class SelectionPage : ContentPage
    {
        readonly Label _emptyViewLabel = new Label
        {
            Text = "Should Be Centered",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
        };

        public SelectionPage()
        {
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Button { Text = "Workaround" }.Assign(out Button workaroundButton),
                    new Button { Text = "Broken EmptyView" }.Assign(out Button brokenEmptyViewButton)
                }
            };

            workaroundButton.Clicked += HandleWorkaroundButtonClicked;
            brokenEmptyViewButton.Clicked += HandleBrokenEmptyViewButtonClicked;
        }

        async void HandleBrokenEmptyViewButtonClicked(object sender, EventArgs e) =>
           await Navigation.PushAsync(new CollectionViewPage(_emptyViewLabel, "Empty View Doesn't Honor LayoutOptions"));

        async void HandleWorkaroundButtonClicked(object sender, EventArgs e)
        {
            var absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(_emptyViewLabel, new Rectangle(.5, .5, -1, -1), AbsoluteLayoutFlags.PositionProportional);

            await Navigation.PushAsync(new CollectionViewPage(absoluteLayout, "Use an Absoulute Layout as a Workaround"));
        }
    }
}
