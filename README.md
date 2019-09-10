# Yukky Log C# SDK

Easy to use SDK to send log to Yukky Log !

For more informations visit https://log.yukkyapp.com/doc

## Installation

Download the file named **Yukky.Log.dll** which is in the folder **bin/Debug/netstandard2.0**.

Then add it to your C# project you might need to install the nugget package **Microsoft.AspNet.WebApi.Client** for this to work.

**That's it !**

## Initialisation

Somewhere in your code you should add this :

```
using Yukky.Log;
...
YukkyLog.Init("<appkey>", "<appsecret>");
```

This will initialize the SDK.

You can add a third parameter to specify if you want the debug mode.

## Send some logs

### The Log class

To send a Log, you need to create it first.

To do that, you must create a Log object like this :

```
new Log("C# Test", new[] { "C#", "Test" }, "", null);
```

The first parameter is the log name, the second is an array of tags, the third is a description and the last one is some infos you want to send, it must be an object.

If you want to create your own log type (not error, warning or info), you can create a FullLog object like this :

```
new Log("C# Test", new[] { "C#", "Test" }, "", null, "page access");
```

The parameters are the same as Log but you must add another one which is the name of your custom type.

### Error

To send an error log simply add this line :

```
YukkyLog.Error(new Log("C# Test", new[] { "C#", "Test" }, "", null))
```

### Warning

To send a warning log simply add this line :

```
YukkyLog.Warning(new Log("C# Test", new[] { "C#", "Test" }, "", null))
```

### Info

To send an info log simply add this line :

```
YukkyLog.Info(new Log("C# Test", new[] { "C#", "Test" }, "", null))
```

### Custom

To send a custom log simply add this line :

```
YukkyLog.Custom(new FullLog("C# Test", new[] { "C#", "Test" }, "", null, "page access"))
```
