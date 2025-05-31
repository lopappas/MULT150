using UnityEngine;
public class GoalScript : MonoBehaviour
{
    public AudioSource winAudioSource;
    public AudioClip winClip;

    public bool isSolved = false;
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            winAudioSource.PlayOneShot(winClip);
            Destroy(collidedWith);
        }
    }
}
