This is a Unity boilerplate with usefull script and other templates I often reuse between projects.

- [Features](#features)
- [How to install](#how-to-install)
  - [PackageManager](#packagemanager)
- [Usage](#usage)
  - [Hash caching](#hash-caching)
  - [Script templates](#script-templates)
  - [Event channel ScriptableObjects](#event-channel-scriptableobjects)
- [:construction: Roadmap :construction:](#construction-roadmap-construction)
- [Credits \& Read also](#credits--read-also)
- [License](#license)

## Features

- .gitignore and .gitattributes templates
- Utilities scripts
- Basic event channels setup
- Custom script templates

## How to install

### PackageManager

Add package from git url : https://github.com/gaetanthiesson/unity-boilerplate/tree/main/Assets/Boilerplate
![image](https://github.com/gaetanthiesson/unity-boilerplate/assets/16124367/dfc71ee8-84f2-48ec-a82d-53f880455960)

### Download the last release [here](https://github.com/gaetanthiesson/unity-boilerplate/releases)

:warning: **FOR SCRIPT TEMPLATES TO BE LOADED** :warning:

1. 2 options
    * ScriptTemplates folder must be moved directly under Assets folder
    * Put .txt files into %UNITY_EDITOR_PATH&\Data\Resources\ScriptTemplates (this will apply them to any project using this version of Unity)
3. Restart your Unity Editor

## Usage

### Hash caching

**For shaders properties**

```
public class ShaderParam
{
    public static readonly int _AlphaID = Shader.PropertyToID("_Alpha");
}

....

mat.SetFloat(ShaderParam._AlphaID, 1.0f);
```

**Animator parameters**

```
public class AnimatorParam
{
    public static readonly int SpeedHash = Animator.StringToHash("Speed");
}

....

animator.SetFloat(AnimatorParam.SpeedHash, 1.0f);
```

### Script templates

Extend Unity default script templates

![image](https://github.com/gaetanthiesson/unity-boilerplate/assets/16124367/fc38c5eb-9090-4c03-8612-35ab91d28b9a)

### Event channel ScriptableObjects
Implemented as is [ScriptableObjects as event channels](https://unity.com/how-to/scriptableobjects-event-channels-game-code#how-event-channels-help)

## :construction: Roadmap :construction:

- [X] .gitignore and .gitattributes templates
- [X] ScriptableObjects event channels
- [X] Hash cache file template
- [X] Script templates
- [X] Editor tooling event channels
- [ ] Exemples
- [X] Runtime sets with SO (Observer pattern)
- [ ] Logger
- [ ] UI components
- [ ] Utilities extension methods

## Credits & Read also

You can find most of the pattern and templates explained there.

- [ScriptableObjects as event channels](https://unity.com/how-to/scriptableobjects-event-channels-game-code#how-event-channels-help)
- [PaddleGameSO](https://github.com/UnityTechnologies/PaddleGameSO)
- [Shader parameters hash caching](https://forum.unity.com/threads/shader-propertytoid-name-why-is-it-more-efficient-and-best-practise-to-store-multiple-ids.492831/#post-3216842)
  
## License
Distributed under the MIT License. See `LICENSE.txt` for more information.
