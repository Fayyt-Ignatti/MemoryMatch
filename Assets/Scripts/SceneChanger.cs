using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
  /// <summary>
  /// Changes scene to play screen.
  /// </summary>
  public void SceneChange()
  {
    SceneManager.LoadScene("Play Screen");
  }
}
