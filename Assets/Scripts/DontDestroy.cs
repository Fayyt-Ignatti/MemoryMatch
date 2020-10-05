using UnityEngine;

public class DontDestroy : MonoBehaviour
{
  private void Awake()
  {
    GameObject[] objs = GameObject.FindGameObjectsWithTag("ImageController");

    if (objs.Length > 1)
    {
      Destroy(this.gameObject);
    }

    DontDestroyOnLoad(this.gameObject);
  }

}
