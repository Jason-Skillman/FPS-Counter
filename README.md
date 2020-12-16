# FPS-Counter
Shows frames per second during runtime. Can be used to debug performace issues.

## How to install
This package can be installed through the Unity `Package Manager` with Unity version 2019.3 or greater.

Open up the package manager `Window/Package Manager` and click on `Add package from git URL...`.

![unity_package_manager_git_drop_down](Documentation~/images/unity_package_manager_git_drop_down.png))

Paste in this repository's url.

`https://github.com/Jason-Skillman/FPS-Counter.git`

![unity_package_manager_git_with_url](Documentation~/images/unity_package_manager_git_with_url.png))

Click `Add` and the package will be installed in your project.

---
**NOTE:** Unity 2019.2 or lower

Other ways to install the package
1. To install the package in an earler version of Unity you can clone this git into your project's `Packages` folder.
1. Another alternative would be to download the package and in the `Package Manager` click on `Add package from disk...` and select the package's root folder.

---

## How to use
You can add the FPS counter to your scene by going to `Create/FPS/FPS Counter` in the `Hierarchy` window. This will add the FPS Counter prefab and only one should exist in a scene at a time.

## API

## Properties
|Return Type|Name|Description|
|---|---|---|
|`int`|`IsOn`|Turn on/off the FPS counter.|
|`float`|`UpdateInterval`|The update interval time in seconds.|
