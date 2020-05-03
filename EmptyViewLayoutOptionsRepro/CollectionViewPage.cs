using Xamarin.Forms;

namespace EmptyViewLayoutOptionsRepro
{
    class CollectionViewPage : ContentPage
    {
        public CollectionViewPage(in View emptyView, in string title)
        {
            Title = title;

            Content = new CollectionView
            {
                EmptyView = emptyView
            };
        }
    }
}
