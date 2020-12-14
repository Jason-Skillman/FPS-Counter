# FPS-Counter
Shows frames per second during runtime. Can be used to debug performace issues.

## How to install
This package can be installed through the Unity `Package Manager`

Open up the package manager `Window/Package Manager` and click on `Add package from git URL...`.

![unity_package_manager_git_drop_down](Documentation~/images/unity_package_manager_git_drop_down.png))

Paste in this repository's url.

`https://github.com/Jason-Skillman/FPS-Counter.git`

![unity_package_manager_git_with_url](Documentation~/images/unity_package_manager_git_with_url.png))

Click `Add` and the package will be installed in your project.

## How to use
You can add the FPS counter to your scene by going to `Create/FPS/FPS Counter` in the `Hierarchy` window. This will add the FPS Counter prefab and only one should exist in a scene at a time.

## API

## Properties
|Return Type|Name|Description|
|---|---|---|
|`int`|`IsOn`|Turn on/off the FPS counter.|
|`float`|`UpdateInterval`|The update interval time in seconds.|
