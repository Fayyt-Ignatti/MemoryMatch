using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
  public bool twoValues;

  public Button button1;
  public Button button2;
  public Button button3;
  public Button button4;
  public Button button5;
  public Button button6;
  public Button button7;
  public Button button8;
  public Button button9;
  public Button button10;
  public Button button11;
  public Button button12;
  public Button button13;
  public Button button14;
  public Button button15;
  public Button button16;
  public Button button17;
  public Button button18;
  public Button button19;
  public Button button20;

  private int temp1;
  private int temp2;

  private Button tempButton1;
  private Button tempButton2;

  private Button[] panels = new Button[20];

  private void Start()
  {
    this.twoValues = true;

    this.panels[0] = this.button1;
    this.panels[1] = this.button2;
    this.panels[2] = this.button3;
    this.panels[3] = this.button4;
    this.panels[4] = this.button5;
    this.panels[5] = this.button6;
    this.panels[6] = this.button7;
    this.panels[7] = this.button8;
    this.panels[8] = this.button9;
    this.panels[9] = this.button10;
    this.panels[10] = this.button11;
    this.panels[11] = this.button12;
    this.panels[12] = this.button13;
    this.panels[13] = this.button14;
    this.panels[14] = this.button15;
    this.panels[15] = this.button16;
    this.panels[16] = this.button17;
    this.panels[17] = this.button18;
    this.panels[18] = this.button19;
    this.panels[19] = this.button20;
  }

  /// <summary>
  /// Hides the panel of the button that was called.
  /// Assigns the panel to a temp field for later reference.
  /// Sends value to the "Set Values" method.
  /// </summary>
  /// <param name="btn"></param>
  public void ButtonClicker(Button btn)
  {
    btn.gameObject.SetActive(false);

    if (this.twoValues)
    {
      this.tempButton1 = btn;
    }
    else
    {
      this.tempButton2 = btn;
    }

    switch (btn.name)
    {
      case "Button 1":
        this.SetValues(1);
        break;

      case "Button 2":
        this.SetValues(2);
        break;

      case "Button 3":
        this.SetValues(3);
        break;

      case "Button 4":
        this.SetValues(4);
        break;

      case "Button 5":
        this.SetValues(5);
        break;

      case "Button 6":
        this.SetValues(6);
        break;

      case "Button 7":
        this.SetValues(7);
        break;

      case "Button 8":
        this.SetValues(8);
        break;

      case "Button 9":
        this.SetValues(9);
        break;

      case "Button 10":
        this.SetValues(10);
        break;

      case "Button 11":
        this.SetValues(11);
        break;

      case "Button 12":
        this.SetValues(12);
        break;

      case "Button 13":
        this.SetValues(13);
        break;

      case "Button 14":
        this.SetValues(14);
        break;

      case "Button 15":
        this.SetValues(15);
        break;

      case "Button 16":
        this.SetValues(16);
        break;

      case "Button 17":
        this.SetValues(17);
        break;

      case "Button 18":
        this.SetValues(18);
        break;

      case "Button 19":
        this.SetValues(19);
        break;

      case "Button 20":
        this.SetValues(20);
        break;

      default:
        break;
    }
  }

  /// <summary>
  /// Takes the value from the button press and assigns it to a temp field.
  /// If this is the first of a pair of panels, just assign to field.
  /// If this is the second of a pair, call "Is It A Match".
  /// </summary>
  /// <param name="val"></param>
  public void SetValues(int val)
  {
    if (this.twoValues)
    {
      this.temp1 = val;
      this.twoValues = false;
    }
    else
    {
      this.temp2 = val;
      foreach (Button button in this.panels)
      {
        button.interactable = false;
      }
      this.IsItAMatch(this.temp1, this.temp2);
      this.twoValues = true;
    }
  }

  /// <summary>
  /// check if int a and b are keys or values in the dictionary.
  /// If one is a key, and the other is value, then check if they are a pair.
  /// If they are a pair, nothing else is required.
  /// If not, start coroutine to close panels.
  /// </summary>
  /// <param name="a"></param>
  /// <param name="b"></param>
  public void IsItAMatch(int a, int b)
  {
    bool keyA = DropDown.lookupDict.ContainsKey(a);
    bool keyB = DropDown.lookupDict.ContainsKey(b);
    bool valueA = DropDown.lookupDict.ContainsValue(a);
    bool valueB = DropDown.lookupDict.ContainsValue(b);

    if (keyA && valueB)
    {
      DropDown.lookupDict.TryGetValue(a, out int check);
      if (check != b)
      {
        this.StartCoroutine(this.ClosePanels());
      }
      else
      {
        this.PanelsInteractable();
      }
    }
    else if (keyB && valueA)
    {
      DropDown.lookupDict.TryGetValue(b, out int check);
      if (check != a)
      {
        this.StartCoroutine(this.ClosePanels());
      }
      else
      {
        this.PanelsInteractable();
      }
    }
    else
    {
      this.StartCoroutine(this.ClosePanels());
    }
  }

  /// <summary>
  /// closes the panels if they were not a match.
  /// </summary>
  /// <returns></returns>
  IEnumerator ClosePanels()
  {
    yield return new WaitForSeconds(2);
    this.tempButton1.gameObject.SetActive(true);
    this.tempButton2.gameObject.SetActive(true);
    this.PanelsInteractable();
  }

  public void PanelsInteractable()
  {
    foreach (Button button in this.panels)
    {
      button.interactable = true;
    }
  }

  /// <summary>
  /// Activates all panels in play screen.
  /// Resets TwoValues bool to true;
  /// </summary>
  public void ResetPanels()
  {
    foreach (Button panel in this.panels)
    {
      panel.gameObject.SetActive(true);
    }
    this.twoValues = true;
  }
}
