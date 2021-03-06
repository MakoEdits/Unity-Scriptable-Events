# Unity-Scriptable-Events

Based on Ryan Hipple's Unite 2017 talk and demos

Full credit to him and his team for the concept, initial implementations and philosophy

[Original Demonstration Repo](https://github.com/roboryantron/Unite2017)

[Unite Austin 2017 - Game Architecture with Scriptable Objects](https://youtu.be/raQ3iHhE_Kk)

# Description

Scriptable Events decouple events from code to be easily reused anywhere in your project free from context

GameEvents can also be extended to send information within the events raise method

# Installation

**To install this package:**

* Open the Unity Package Manager under Window > Package Manager
* Click the add + button in the status bar
* Select **Add package from git URL**
* Enter [https://github.com/MakoEdits/Unity-Scriptable-Events.git](https://github.com/MakoEdits/Unity-Scriptable-Events.git)
* Click **Add**

# Usage

**ScriptableEvent Asset**

* Create new ScriptableEvent under Create > GameEvents

**GameObject Event Listener**

* Add related EventListener to GameObject in scene (eg. Creating a Float GameEvent and adding FloatEventListener)
* Assign ScriptableEvent asset to EventListener's Event
* Point EventListener Response to any GameObject scripts public methods

**ScriptableEvent Raising**

* Add related GameEvent reference to any script:

```cs
using Mako.ScriptableEvents;

public class MyClass : MonoBehaviour
{
	public FloatGameEvent myFloatEvent;

	public void RaiseFloatEvent()
	{
	    myFloatEvent.Raise(1.5f);
	}
}
```

* Attach script to GameObject in Scene

* Drag and drop ScriptableEvent Asset onto GameEvent reference

# Extending Functionality

**Making new ScriptableEvent types**

* Create a new script along the lines of the following:

*Ensure that the name of the script is the same as the class that creates the VariableGameEvent*

*because it will create a ScriptableObject*

```cs
using System;
using UnityEngine;
using UnityEngine.Events;

using Mako.ScriptableEvents;

[CreateAssetMenu(menuName = "GameEvents/{type}")] [Serializable]
public class {type}GameEvent : VariableGameEvent<{type}, {type}GameEvent, {type}UnityEvent>{}

[Serializable]
public class {type}UnityEvent : UnityEvent<{type}> { }
```

*eg.*

```cs
using System;
using UnityEngine;
using UnityEngine.Events;

using Mako.ScriptableEvents;

[CreateAssetMenu(menuName = "GameEvents/Transform")] [Serializable]
public class TransformGameEvent : VariableGameEvent<Transform, TransformGameEvent, TransformUnityEvent>{}

[Serializable]
public class TransformUnityEvent : UnityEvent<Transform> { }
```

*The UnityEvent declaration can happen anwhere in code, but needs to be a subclass so that the Unity Inspector will Serialize it*


**Making new EventListeners**

* Make sure the related GameEvent already exists
* Create a new script along the lines of the following:

*Ensure that the name of the script is the same as the class that creates the VariableEventListener*

*because it is a MonoBehaviour*

```cs
using Mako.ScriptableEvents;

[System.Serializable]
public class {type}EventListener : VariableEventListener<{type}, {type}GameEvent, {type}UnityEvent> { }

```

*eg.*

```cs
using UnityEngine;
using Mako.ScriptableEvents;

[System.Serializable]
public class TransformEventListener : VariableEventListener<Transform, TransformGameEvent, TransformUnityEvent> { }
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.


## License
[MIT](https://choosealicense.com/licenses/mit/)