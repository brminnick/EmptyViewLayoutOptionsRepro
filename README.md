# EmptyViewLayoutOptionsRepro

A reproduction demonstrating that `Xamarin.Forms.CollectionView.EmptyView` doesn't honor `HorizontalLayoutOptions` or `VerticalLayoutOptions`

## Reproduction Steps

1. Download/clone this repo
2. In Visual Studio, open `EmptyViewLayoutOptionsRepro.sln`
3. In Visual Studio, build/deploy to either an iOS or Android simulator or device
4. In the app, tap `Broken EmptyView`
5. In the app, confirm the `Label` is not centered, despite its `HorizontalOptions` and `VerticalOptions` both set to `LayoutOptions.Center`
6. In the app, tap `Back` to return to the previous page
7. In the app, tap `Workaround`
8. In the app, confirm the `Label` is centered


### Screenshots

| **Without Workaround** | **With Workaround** |
| ---------------------- | ------------------- |
| ![](https://user-images.githubusercontent.com/13558917/80929253-37744e00-8d5f-11ea-95ad-0c546d8eb61a.png) | ![](https://user-images.githubusercontent.com/13558917/80929250-36432100-8d5f-11ea-9c30-a5d7118536bf.png) |
