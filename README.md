# DeadReckoned.ULog
A better logging framework for Unity.

ULog is a simple, yet flexible replacement for Unity's limited Debug.Log method family.

## Installation
If you just want to install the ULog assemblies into an existing Unity project, you can download a install the .unitypackage from the /UnityPackages folder of the repository.
[Download the .unitypackage] (UnityPackages/DeadReckoned.ULog.unitypackage)

## Usage
To begin using a ULog logger over the your existing Debug.Log calls, you'll first need to fetch an `ILog` instance and call one of the logging methods. The simplest way to do this is as follows:

```csharp
using DeadReckoned.ULog;	
using UnityEngine;

public class MyAwesomeBehaviour : MonoBehaviour
{
    private static ILog _log = LogManager.GetLogger<MyAwesomeBehaviour>();

    private void Awake()
    {
        _log.Info("I am awake!");
    }
}
```

Add the MyAwesomeBehaviour component to a GameObject and hit play. The Unity console will output the following:

> `[MyAwesomeBehaviour] I am awake!`

There are several logging methods available:

- `Assert`
- `Debug`
- `Info`
- `Warn`
- `Error`
- `Fatal`
- `Verbose`

Each method represents a different level of logging, and can be filtered out via the `LogManager.Config` configuration object.

### Conditional Logging
String manipulation can be a huge bottleneck, so ensuring that we don't ever do more work than we need to is important for keeping your framerates up. To improve performance, you can selectively enable or disable logging levels. For example, you will likely want to disable `Assert`, `Debug` and `Verbose` in a release build, but keep them around for development builds. You could do this in the following way:

```csharp
#if UNITY_EDITOR || DEBUG
    LogManager.Config.SetAllLevels(true);
#else
    LogManager.Config
        .SetLevel(LogLevel.Assert, false)
        .SetLevel(LogLevel.Debug, false)
        .SetLevel(LogLevel.Verbose, false);
#endif
```

> **NOTE**: By default, all logging levels are enabled unless explicitly disabled as in the example above.

Although disabling logging levels will prevent those log events from reaching the Unity console as expected, we still have the problem of string operations in the logging calls that are scattered throughout the application. One more performance improvement we can make is to ensure that these string operations are only executed if the desired logging level is enabled, like so:

```csharp
if (_log.IsDebugEnabled())
{
    _log.Debug("Debug logging is enabled.");
}
```

This ensures that any operations that would be required to print the log event will only run if the `Debug` log event is enabled.