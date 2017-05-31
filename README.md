# DeadReckoned.ULog
A better logging framework for Unity.

ULog is a simple, yet flexible replacement for Unity's limited Debug.Log method family.

## Installation
If you just want to install the ULog assemblies into an existing Unity project, you can download a install the .unitypackage in the /Packages folder of the repository.

## Usage
To begin using a ULog logger over the your existing Debug.Log calls, you'll first need to fetch an ILog and then call one of the logging methods. The simplest way to do this is as follows:

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

Add the MyAwesomeBehaviour component to a GameObject and hit play. The Unity console should output the follow:

> [MyAwesomeBehaviour] I am awake!

There are several logging methods available:

- Assert()
- Debug()
- Info()
- Warn()
- Error()
- Fatal()
- Verbose()