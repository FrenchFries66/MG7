# MG7
## Devlog

Xiangyi Li, she/her

`_birds` is a `GameObject[]` that holds the 4 sparrows in the scene. Every frame, `i` goes from 0 to `_birds.Length - 1`, and the script checks the distance between each bird and the player. If the bird is close enough, it uses `SetActive(true)` to activate the bird, and the bird pops up.

The two things passed into `Vector3.Distance` are the bird's position and the player's position, and both of them are 3D coordinates. The distance between the player and the bird is compared with my `_interactionDistance`, and if it is less than or equal to it, the bird is activated.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
