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

## Environment

=== Visual Studio Enterprise 2019 for Mac (Preview) ===

Version 8.6 Preview (8.6 build 4387)
Installation UUID: 50daf9f8-80c9-478b-98f2-9b06f657ec02
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 6.18.0.23 (d16-6 / 088c73638)

	Package version: 610000103

=== Mono Framework MDK ===

Runtime:
	Mono 6.10.0.103 (2019-12/4a2a26ce694) (64-bit)
	Package version: 610000103

=== Roslyn (Language Service) ===

3.6.0-3.20210.9+4eafdcb1bcbd8d3573f2ba6065e56d9b9ce4f8a3

=== NuGet ===

Version: 5.6.0.6558

=== .NET Core SDK ===

SDK: /usr/local/share/dotnet/sdk/3.1.200/Sdks
SDK Versions:
	3.1.200
	3.1.102
	3.0.101
	2.1.803
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.10.0/lib/mono/msbuild/Current/bin/Sdks

=== .NET Core Runtime ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	5.0.0-preview.1.20120.5
	3.1.2
	3.1.1
	3.1.0
	3.0.3
	3.0.1
	2.1.17
	2.1.16
	2.1.15
	2.1.14

=== Xamarin.Profiler ===

Version: 1.6.13.11
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 11.4.1 (16137)
Build 11E503a

=== Xamarin.Mac ===

Version: 6.18.1.31 (Visual Studio Enterprise)
Hash: b3eedfed9
Branch: d16-6
Build date: 2020-04-09 10:22:36-0400

=== Xamarin.iOS ===

Version: 13.18.1.31 (Visual Studio Enterprise)
Hash: b3eedfed9
Branch: d16-6
Build date: 2020-04-09 10:22:36-0400

=== Xamarin Designer ===

Version: 16.6.0.329
Hash: d4f8bcd13
Branch: remotes/origin/d16-6
Build date: 2020-04-24 02:16:02 UTC

=== Xamarin.Android ===

Version: 10.3.0.74 (Visual Studio Enterprise)
Commit: xamarin-android/d16-6/964ac42
Android SDK: /Users/bramin/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		7.0 (API level 24)
		8.0 (API level 26)
		8.1 (API level 27)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 29.0.5
SDK Build Tools Version: 29.0.2

Build Information: 
Mono: 165f4b0
Java.Interop: xamarin/java.interop/d16-6@2cab35c
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.31.1@49232bc
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-6@bfb66f3

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 16.6.0.50
Hash: 5901879
Branch: remotes/origin/d16-6
Build date: 2020-04-22 18:34:28 UTC

=== Android Device Manager ===

Version: 16.6.0.90
Hash: a1af2f6
Branch: remotes/origin/d16-6
Build date: 2020-04-22 18:34:48 UTC

=== Build Information ===

Release ID: 806004387
Git revision: e9c7399e5072db3ea9868e0143f949d3a543c594
Build date: 2020-04-28 15:43:52-04
Build branch: release-8.6
Xamarin extensions: e9c7399e5072db3ea9868e0143f949d3a543c594

=== Operating System ===

Mac OS X 10.15.4
Darwin 19.4.0 Darwin Kernel Version 19.4.0
    Wed Mar  4 22:28:40 PST 2020
    root:xnu-6153.101.6~15/RELEASE_X86_64 x86_64


