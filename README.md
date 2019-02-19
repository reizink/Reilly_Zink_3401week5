# Reilly_Zink_3401week5

**GameScene: Use left/right mouse click to move Player to the side. Raycast will detect and log object in the way.

- Terrains are unique object types that can be molded, sculpted, and textured inside Unity to create
detailed landscapes
- As of 2018.3, multiple terrains can be linked together seamlessly
- Terrain heightmaps dictate the elevation shapes of the terrain
- Terrains are slightly limited because of their reliance on heightmaps; for instance, holes or “caves”
are not possible with built-in terrains
- You can create your own brush shapes to paint terrain heightmaps or textures
- Prefabs allow you to create and save a gameObject complete with its components, properties, and
any children it may have
- Prefabs are considered assets and are stored in the Project window when created
- Used for saving complex configurations; useful for spawning systems at runtime
- Changes made to a prefab asset will ripple through to all copies of that prefab
- Spawning an object or prefab while the game is running is called Instantiation
- You can instantiate an object from a script with the Instantiate () function
- A public GameObject variable in a script can hold a reference to a prefab asset
- Each “copy” of a prefab in a scene is known as a instance of that prefab
- A ray is a line that starts at a point and goes in a single direction
- A raycast tests intersections with a ray (AKA determines what colliders the ray crosses through)
- Often used for line of sight tests, hitscan weapon aiming, light reflections, and many other things
- Can answer questions like “what’s in front of this object?”, or “what is the angle of the surface
under my player?”
- A lerp is a linear interpolation between two numbers
- This means finding a value that is some percentage between two given values
- For example, lerping between 3 and 5 by 50% would return the number 4 (because 4 is 50% of the
way between 3 and 5)
- Unity has built-in functions for numerical lerping (Mathf.Lerp) as well as lerping between Vectors
(Vector3.Lerp)
- Can be used over multiple frames to gradually and smoothly change a value
