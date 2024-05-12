This is a [Unity](https://unity.com/) boilerplate with reusable script and other templates I often reuse between projects.

## Features
- .gitignore and .gitattributes templates
- Hash cashing classes template
- Basic event channels setup
- Custom script templates

## Usage

### Hash caching
#### For shaders properties
```
public class ShaderParam
{
    public static readonly int _AlphaID = Shader.PropertyToID("_Alpha");
}

....

mat.SetFloat(ShaderParam._AlphaID, 1.0f);
```
#### Animator parameters
```
public class AnimatorParam
{
    public static readonly int SpeedHash = Animator.StringToHash("Speed");
}

....

animator.SetFloat(AnimatorParam.SpeedHash, 1.0f);
```

## Roadmap
- [X] .gitignore and .gitattributes templates
- [X] ScriptableObjects event channels
- [X] Hash cache file template
- [ ] Script templates
- [ ] Documentation and exemples
- [ ] UI components
- [ ] Utilities extension methods

## License
Distributed under the MIT License. See `LICENSE.txt` for more information.

## Read also
You can find most of the pattern and templates explained there.

- [ScriptableObjects as event channels](https://unity.com/how-to/scriptableobjects-event-channels-game-code#how-event-channels-help)
- [Shader parameters hash caching](https://forum.unity.com/threads/shader-propertytoid-name-why-is-it-more-efficient-and-best-practise-to-store-multiple-ids.492831/#post-3216842)