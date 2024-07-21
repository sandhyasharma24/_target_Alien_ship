using UnityEngine;

public class lec34_shipmanager_cipher : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject,2f);
        //gameobject here will take reference of that gameobject on which this script is attached

    }
    private void OnMouseDown()
    {
        Debug.Log("hit");
        lec31_gameplay_cipher.instance.IncrementScore();
        Destroy(gameObject);
    }
}
