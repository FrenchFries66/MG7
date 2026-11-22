using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    // All of the Sparrows in the Scene, except Sparrow_Start.
    [SerializeField] private GameObject[] _birds;

    // The player the birds react to.
    [SerializeField] private Transform _player;

    // How close the player has to be for a bird to pop out.
    [SerializeField] private float _interactionDistance = 5.0f;

    private void Update()
    {
        for (int i = 0; i < _birds.Length; i++)
        {
            float distance = Vector3.Distance(
                _birds[i].transform.position, _player.position);

            if (distance <= _interactionDistance)
            {
                _birds[i].SetActive(true);
            }
        }
    }
}
