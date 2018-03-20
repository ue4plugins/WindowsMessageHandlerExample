# WindowsMessageHandlerExample

Example plug-in for the IWindowsMessageHandler API.


## About

This Unreal Engine 4 plug-in shows how to use *IWindowsMessageHandler* in order
to intercept and process events from the Windows message queue without having to
modify Engine code. This is useful for integrating hardware and software SDKs
that use Windows messages to provide some or all of their functionality.

Make sure to pull the Tag that matches your Unreal Engine version. If you sync
to Master the code may not compile, because it may depend on Engine changes that
are not yet available in the UE4 Master branch.


## Supported Platforms

This plug-in was last built against **Unreal Engine 4.19**.
It is intended to be used on Windows only.


## Dependencies

This plug-in requires Visual Studio and either a C++ code project or a the full
Unreal Engine 4 source code from GitHub. If you are new to programming in UE4,
please see the official [Programming Guide](https://docs.unrealengine.com/latest/INT/Programming/index.html)! 


## Usage

You can use this plug-in as a project plug-in, or an Engine plug-in.

If you use it as a project plug-in, clone this repository into your project's
*/Plugins* directory and compile your game in Visual Studio. A C++ code project
is required for this to work.

If you use it as an Engine plug-in, clone this repository into the
*/Engine/Plugins/Media* directory and compile your game. Full Unreal Engine 4
source code from GitHub (4.9 or higher) is required for this.

After compiling the plug-in, you have to **enable it** in Unreal Editor's
plug-in browser.

Once activated, the plug-in simply writes intercepted Windows messages to the
output log.


## Support

Please [file an issue](https://github.com/ue4plugins/WindowsMessageHandlerExample/issues),
submit a [pull request](https://github.com/ue4plugins/WindowsMessageHandlerExample/pulls?q=is%3Aopen+is%3Apr)
or email us at info@headcrash.industries


## References

* [Introduction to UE4 Plugins](https://wiki.unrealengine.com/An_Introduction_to_UE4_Plugins) (Unreal Engine Wiki)
* [How can i add window message?](https://answers.unrealengine.com/questions/162868/how-can-i-add-window-message.html) (AnswerHub)
