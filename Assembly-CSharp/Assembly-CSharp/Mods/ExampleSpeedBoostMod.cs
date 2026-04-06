// ExampleSpeedBoostMod.cs

// A simple speed boost mod
// that increases player walk and run speed by 1.5x

using UnityEngine;

public class ExampleSpeedBoostMod : MonoBehaviour
{
    private float speedMultiplier = 1.5f;

    private void Start()
    {
        // Assuming there are methods to get player speed
        // This is where the speed boost logic would be implemented.
        IncreasePlayerSpeed();
    }

    private void IncreasePlayerSpeed()
    {
        // Example logic to increase player speed
        // Player.walkSpeed *= speedMultiplier;
        // Player.runSpeed *= speedMultiplier;
    }
}