# *Xicht* <img src="https://raw.githubusercontent.com/urbanware-org/xicht/master/Stuff/GitHub/Xicht.png" alt="Xicht logo" height="48px" width="48px" align="right"/>

**Table of contents**
*   [Definition](#definition)
*   [Details](#details)
*   [Requirements](#requirements)
*   [Graphics](#graphics)
*   [Command-line arguments](#command-line-arguments)
*   [Useless facts](#useless-facts)

----

## Definition

Visual CPU monitoring tool using a HUD face to display the current load.

[Top](#xicht-)

## Details

In the 1990's, first-person shooters like *Doom* had the player's face on their HUD (head-up-display) to show his current state of health. Also, the face looked around and reacted to events like getting hurt or acquiring certain items.

The *Xicht* project takes the *Doom* HUD face as a model to display the CPU load. The more load the CPU has, the less "health" the displayed face shows.

There is some typical behavior:

*   Randomly looks around<img src="https://raw.githubusercontent.com/urbanware-org/xicht/master/Stuff/GitHub/Xicht_main_window.png" alt="Main window" align="right"/>
*   Bleeds depending on the CPU load
*   Shows "hurt face" when the load increases
*   Shows "shocked face" on high load increase
*   Shows "smile face" on high load decrease
*   Shows "dead face" on full CPU load
*   Shows "invulnerable face" with glowing eyes if the CPU is idle (not *Doom* typical, but used for this case)

Furthermore, there is a right-click menu, where you can manually set the maximum health displayed, trigger face events (such as smiling) and a totally useless "freak out" mode.

There is also a small animated tray icon available.<img src="https://raw.githubusercontent.com/urbanware-org/xicht/master/Stuff/GitHub/Xicht_tray_icon.png" alt="Tray icon" align="right"/>

[Top](#xicht-)

## Requirements

### Binary

Depending on the platform, the following runtime environments are required.

*   ***Windows***:
    *   *Microsoft .NET Framework 2.0* (or higher)
*   ***Linux***:
    *   *Mono* (tested with version 4.2.4)
*   ***MacOS***:
    *   Should also run with *Mono* (not tested, yet)

### Source code

The project was once written in 2015 using *Microsoft Visual Studio 2012 Express* (if I remember it right) and before uploading it here the binary has been compiled with *Visual Studio 2015 Community Edition*.

Feel free to modify!

[Top](#xicht-)

## Graphics

### Default images

By default, *Xicht* comes with some great [high resolution face images](https://github.com/urbanware-org/xicht/blob/master/Stuff/GitHub/Preview.md) (as shown on the screenshot above). Special thanks to Reinchard for designing and kindly providing them.

### Original images

Some people asked me why I do not distribute the original *Doom* HUD face images with my project.

Well, the reason is simple. I don't have the permission. I officially asked *id Software* in 2015 if I could use them for my project and they liked the idea, but unfortunately refused.

Another problem with the original faces is the resolution of them is pretty low (less than 40x40 pixels), so upscaling results in quite pixelated and blurred graphics.

However, if you want to use the original *Doom* faces anyway, you may find them somewhere on the internet.

### Replacing with user-defined images

The default face images can be easily replaced with user-defined ones. Of course, you can also use different graphics that are not related to *Doom*.

You may backup the directory first before making any changes.

#### Images

Inside the `Images` sub-directory you can find the different image files of the faces used by *Xicht* to display the status on the main window.

Simply replace the corresponding files. Notice that the images...

*   must have the correct file name, otherwise no or the wrong image will be displayed.
*   must have the same height and width (square), otherwise they will be scaled and, due to this, warped.
*   must be image files in PNG format.
*   should have a size of (at least) 256x256 pixels.
*   should have a transparent background or the same color as the background of the main window (black `#000000`).

If you don't want the look-around effect, you can take the look center image e. g. `face_look_center_100.png` and create duplicates called `face_look_left_100.png` and `face_look_right_100.png`.

#### Tray icon

Inside the `Tray` sub-directory you can find the icons used to display the status in the system tray.

Simply replace the corresponding files. Notice that the icons...

*   must have the correct file name, otherwise no or the wrong icon will be displayed.
*   must be icon files in ICO format.
*   should have a size of 32x32 pixels and also contain 16x16 and 24x24 variants.
*   should have a transparent background.

You can also avoid the look-around effect here as described [above](#images).

With the `convert` command provided by the platform-independent *ImageMagick* software suite you can simply convert the PNG images used on the main window to the ICO files required for the system tray. For example under *Linux*:

```bash
$ cd Images
$ find -type f | grep "\.png$" > /tmp/png2ico.tmp
$ while read line; do
      convert "$line" -define icon:auto-resize=32,24,16 $(sed -e "s/\.png$/\.ico/g" <<< $line)
  done < /tmp/png2ico.tmp
$ rm -f /tmp/png2ico.tmp
$ mv *.ico ../Tray/
```

In case there is a problem displaying the transparency, you can replace it with e. g. the background color of your tray bar just by adding a couple of parameters.

Let's assume your tray bar has the background color `#2f2f2f` (<img src="https://raw.githubusercontent.com/urbanware-org/xicht/master/Stuff/GitHub/2f2f2f.png" alt="#2f2f2f">). In that case the `convert` command looks like this:

```bash
$ cd Images
$ find -type f | grep "\.png$" > /tmp/png2ico.tmp
$ while read line; do
      convert "$line" -background "#2f2f2f" -flatten \
              -define icon:auto-resize=32,24,16 $(sed -e "s/\.png$/\.ico/g" <<< $line)
  done < /tmp/png2ico.tmp
$ rm -f /tmp/png2ico.tmp
$ mv *.ico ../Tray/
```

[Top](#xicht-)

## Command-line arguments

There are a few command-line arguments for *Xicht* to set some options on startup.

Notice that the arguments neither start with dashes (`-` or `--`) nor slashes (`/`).

### General

*   `disable-topmost`<br>The main window will not stay in the foreground if it has lost the focus. This solves some problems with some tiling window managers on *Unix*-like systems.
*   `tray`<br>Show the tray icon by default.

### Size and position

Notice that there is no validation or error handling for these arguments, so giving invalid values may result in an exception.

#### Size

*   `height=<value>`<br>The default height of the main window in pixels.
*   `width=<value>`<br>The default width of the main window in pixels.

#### Position

*   `top=<value>`<br>The distance in pixels between the top edge of the screen and the main window.
*   `left=<value>`<br>The distance in pixels between the left edge of the screen and the main window.

[Top](#xicht-)

## Useless facts

*   The first version uploaded on this *GitHub* repository was *Xicht* 1.1.2.4 built on January 3<sup>rd</sup>, 2018.
*   The project name "Xicht" (actually spelled "Gsicht" in ordinary language) is derived from "Gesicht" which is the German word for "face".

[Top](#xicht-)
