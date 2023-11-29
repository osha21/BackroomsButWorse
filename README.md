# BackroomsButWorse

## Overview of the Game
The project is based on the online fictional creppypasta, The Backrooms. In the Backrooms there is an enemy patrolling the map, and when the player gets too close to the player, it will start chasing. There is no way to escape the Backrooms and your only option is to run from the enemy.

The main parts of the game are:
-	Player – a capsule, moved with the wasd keys and left shift key to sprint.
-	Camera – used as a first person camera following the player as it moves
-	Enemy – a capsule, patrolling the map using the navmesh pathfinding and chasing the player.
-	Map – is built like a maze and has no exit.
-	Lose condition – the game ends when the enemy is in range of the player


## Project Parts

### Scripts
- PlayerCamera – used for the rotation of the camera.
- Cam – used for transforming the camera to a Gameobject on the player, creating a first person camera.
- Movement – used for the movement of the plauer using rigidbodiy physics and setting the speed for the player if sprinting or not.
- EnemyScript – creating three states: when patrolling, chasing and attacking using navmesh.


## References
- [Easy 3D pathfinding in Unity - NavMesh Basic Tutorial](https://www.youtube.com/watch?v=tFpv4xFZrq8)
- [How to Make a Simple Enemy Patrol AI in Unity in 2 minutes](https://www.youtube.com/watch?v=gcT6NmN3Zyo)
- [FULL 3D ENEMY AI in 6 MINUTES! | Unity Tutorial](https://www.youtube.com/watch?v=UjkSFoLxesw) 
- [SLOPE MOVEMENT, SPRINTING & CROUCHING - Unity Tutorial](https://www.youtube.com/watch?v=xCxSjgYTw9c&t=129s)
- [FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial](https://www.youtube.com/watch?v=f473C43s8nE&t=367s)