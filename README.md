This is a Unity boilerplate with usefull script and other templates I often reuse between projects.

- [Features](#features)
- [How to install](#how-to-install)
  - [PackageManager](#packagemanager)
- [Usage](#usage)
  - [Hash caching](#hash-caching)
- [:construction: Roadmap :construction:](#construction-roadmap-construction)
- [Credits \& Read also](#credits--read-also)
- [License](#license)

## Features

- .gitignore and .gitattributes templates
- Hash cashing classes template
- Basic event channels setup
- Custom script templates

## How to install

### PackageManager

Add package from git url : https://github.com/gaetanthiesson/unity-boilerplate/tree/main/Assets/Boilerplate

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

## :construction: Roadmap :construction:

- [X] .gitignore and .gitattributes templates
- [X] ScriptableObjects event channels
- [X] Hash cache file template
- [ ] Script templates
- [ ] Documentation and exemples event channels
- [ ] UI components
- [ ] Utilities extension methods

## Credits & Read also

You can find most of the pattern and templates explained there.

- [ScriptableObjects as event channels](https://unity.com/how-to/scriptableobjects-event-channels-game-code#how-event-channels-help)
- [Shader parameters hash caching](https://forum.unity.com/threads/shader-propertytoid-name-why-is-it-more-efficient-and-best-practise-to-store-multiple-ids.492831/#post-3216842)
  
## License
Distributed under the MIT License. See `LICENSE.txt` for more information.