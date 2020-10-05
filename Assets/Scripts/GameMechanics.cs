using UnityEngine;

public class GameMechanics : MonoBehaviour
{
  public Canvas exitCanvas;

  private void Start()
  {
    this.exitCanvas.enabled = false;
  }

  /// <summary>
  /// Exits application.
  /// </summary>
  public void Exit()
  {
    Application.Quit();
  }

  /// <summary>
  /// Opens the verification canvas to allow player to exit game.
  /// </summary>
  public void MenuOpen()
  {
    if (this.exitCanvas.enabled)
    {
      this.exitCanvas.enabled = false;
    }
    else
    {
      this.exitCanvas.enabled = true;
    }
  }
}
