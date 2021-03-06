﻿![MEGAFUSELOGO](megafuse_logo.png "MegaFUSE logo")

An open source implementation of the Mega Cloud service as a FUSE filesystem for Windows.

⚠ WARNING: MegaFUSE is still in alpha! Use at your own risk until a beta version has been released!

⚠ [MegaFuse](https://github.com/matteoserva/MegaFuse) and MegaFUSE are similar in concept but are NOT related!

`"Mega" is a registered trademark of Mega Limited.`

## The Stack

* [Dokany](https://github.com/dokan-dev/dokany)
* [Dokan.Net](https://github.com/dokan-dev/dokan-dotnet)
* [MegaApiClient](https://github.com/gpailler/MegaApiClient)

## License

MegaFUSE is licensed under the GNU GPLv3 License. A copy can be found at FSF.org

## Installing MegaFUSE

In order to install MegaFUSE, you must first install the Dokan FUSE driver which is available [here](https://github.com/dokan-dev/dokany/releases).

Once the driver installation has completed, clone this repository and build it using Visual Studio 2017. If the build fails, make sure you have installed all required NuGet packages using the Package Manager Console in VS 2017.

Alternatively, if you do not want to build MegaFUSE from source, download a release once one becomes available.