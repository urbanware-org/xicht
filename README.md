# *Xicht* <img src="https://github.com/urbanware-org/xicht/blob/master/Stuff/GitHub/Xicht.png" alt="Xicht logo" height="48px" width="48px" align="right"/>

**Table of contents**
* [Definition](#definition)
* [Details](#details)
* [Requirements](#requirements)
* [Graphics](#graphics)
* [Command-line arguments](#command-line-arguments)
* [Useless facts](#useless-facts)

----

## Definition

Visual CPU monitoring tool using a HUD face to display the current load.

[Top](#xicht-)

## Details

In the 1990's, first-person shooters like _Doom_ had the player's face on their HUD (head-up-display) to show his current state of health. Also, the face looked around and reacted to events like getting hurt or acquiring certain items.

The _Xicht_ project takes the _Doom_ HUD face as a model to display the CPU load. The more load the CPU has, the less "health" the displayed face shows.

There is some typical behavior:

* Randomly looks around<img src="https://github.com/urbanware-org/xicht/blob/master/Stuff/GitHub/Xicht_main_window.png" alt="Main window" align="right"/>
* Bleeds depending on the CPU load
* Shows "hurt face" when the load increases
* Shows "shocked face" on high load increase
* Shows "smile face" on high load decrease
* Shows "dead face" on full CPU load.
* Shows "invulnerable face" with glowing eyes if the CPU is idle (not _Doom_ typical, but used for this case)

Furthermore, there is a right-click menu, where you can manually set the maximum health displayed, trigger face events (such as smiling) and a totally useless "freak out" mode.

There is also an animated tray icon available that also shows the CPU load in the system tray.

[Top](#xicht-)

## Requirements

### Binary

Depending on the platform, the following runtime environments are required.

* ***Windows***:
  * _Microsoft .NET Framework 2.0_ (or higher)
* ***Linux***:
  * _Mono_ (tested with version 4.2.4)
* ***MacOS***:
  * Should also run with _Mono_ (not tested, yet)

### Source code

The project was once written in 2015 using *Microsoft Visual Studio 2012 Express* (if I remember it right) and before uploading it here the binary has been compiled with _Visual Studio 2015 Community Edition_.

Feel free to modify!

### Compatibility

#### Tray icon

Notice that the tray icon feature only works properly on _Windows_, yet.

When using it on other platforms, it works so far, but the handles of the icons cannot be deleted. This leads to a slow but steadily increasing memory consumption. Displaying the tray icon for a few minutes should not be a problem, rather than permanently enabling it.

[Top](#xicht-)

## Graphics

### Default images

By default, _Xicht_ comes with some great high resolution face images (as shown on the screenshot above). Special thanks to Reinchard for designing and kindly providing them.

### Original images

Some people asked me why I do not distribute the original _Doom_ HUD face images with my project.

Well, the reason is simple. I don't have the permission. I officially asked _id Software_ in 2015 if I could use them for my project and they liked the idea, but unfortunately refused.

Another problem with the original faces is the resolution of them is pretty low (less than 40x40 pixels), so upscaling results in quite pixelated and blurred graphics.

However, if you want to use the original _Doom_ faces anyway, you may find them somewhere on the internet.

### Replacing with user-defined images

Inside the `Images` sub-directory you can find the different image files of the faces used by _Xicht_ to display the status.

You may backup the directory first before making any changes.

Simply replace the corresponding files. Notice that the images...

* must have the correct file name, otherwise no or the wrong image will be displayed.
* must have the same height and width (square), otherwise they will be scaled and, due to this, warped.
* should have a size of (at least) 256x256 pixels.
* should have a transparent background or the same color as the background of the main window (black `#000000`).

If you don't want the look-around effect, you can take the look center image e. g. `face_look_center_100.png` and create duplicates called `face_look_left_100` and `face_look_right_100`.

Of course, you can also use different graphics that are not related to _Doom_.

[Top](#xicht-)

## Command-line arguments

There are a few command-line arguments for _Xicht_ to set some options on startup.

Notice that the arguments neither start with dashes (`-` or `--`) nor slashes (`/`).

### General

* `disable-topmost`<br>The main window will not stay in the foreground if it has lost the focus. This solves some problems with some tiling window managers on _Unix_-like systems.
* `tray`<br>Show the tray icon by default.

### Size and position

Notice that there is no validation or error handling for these arguments, so giving invalid values may result in an exception.

#### Size

* `height=<value>`<br>The default height of the main window in pixels.
* `width=<value>`<br>The default width of the main window in pixels.

#### Position

* `top=<value>`<br>The distance in pixels between the top edge of the screen and the main window.
* `left=<value>`<br>The distance in pixels between the left edge of the screen and the main window.

[Top](#xicht-)

## Useless facts

* The first version uploaded on this *GitHub* repository was *Xicht* 1.1.2.4 built on January 3<sup>rd</sup>, 2018.
* The project name "Xicht" (actually spelled "Gsicht" in ordinary language) is derived from "Gesicht" which is the German word for "face".

[Top](#xicht-)

