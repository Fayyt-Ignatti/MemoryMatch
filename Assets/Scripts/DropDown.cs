using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
  [SerializeField]
  public static Dropdown drp1;
  public static Dropdown drp2;
  public static Dropdown drp3;
  public static Dropdown drp4;
  public static Dropdown drp5;
  public static Dropdown drp6;
  public static Dropdown drp7;
  public static Dropdown drp8;
  public static Dropdown drp9;
  public static Dropdown drp10;
  public static Dropdown drp11;
  public static Dropdown drp12;
  public static Dropdown drp13;
  public static Dropdown drp14;
  public static Dropdown drp15;
  public static Dropdown drp16;
  public static Dropdown drp17;
  public static Dropdown drp18;
  public static Dropdown drp19;
  public static Dropdown drp20;

  public static int[] oddValues = new int[10];
  public static int[] evenValues = new int[10];

  public static Dictionary<int, int> lookupDict = new Dictionary<int, int>();

  private void Start()
  {
    DropDown.drp1 = GameObject.Find("DropDown 1").GetComponent<Dropdown>();
    DropDown.drp2 = GameObject.Find("DropDown 2").GetComponent<Dropdown>();
    DropDown.drp3 = GameObject.Find("DropDown 3").GetComponent<Dropdown>();
    DropDown.drp4 = GameObject.Find("DropDown 4").GetComponent<Dropdown>();
    DropDown.drp5 = GameObject.Find("DropDown 5").GetComponent<Dropdown>();
    DropDown.drp6 = GameObject.Find("DropDown 6").GetComponent<Dropdown>();
    DropDown.drp7 = GameObject.Find("DropDown 7").GetComponent<Dropdown>();
    DropDown.drp8 = GameObject.Find("DropDown 8").GetComponent<Dropdown>();
    DropDown.drp9 = GameObject.Find("DropDown 9").GetComponent<Dropdown>();
    DropDown.drp10 = GameObject.Find("DropDown 10").GetComponent<Dropdown>();
    DropDown.drp11 = GameObject.Find("DropDown 11").GetComponent<Dropdown>();
    DropDown.drp12 = GameObject.Find("DropDown 12").GetComponent<Dropdown>();
    DropDown.drp13 = GameObject.Find("DropDown 13").GetComponent<Dropdown>();
    DropDown.drp14 = GameObject.Find("DropDown 14").GetComponent<Dropdown>();
    DropDown.drp15 = GameObject.Find("DropDown 15").GetComponent<Dropdown>();
    DropDown.drp16 = GameObject.Find("DropDown 16").GetComponent<Dropdown>();
    DropDown.drp17 = GameObject.Find("DropDown 17").GetComponent<Dropdown>();
    DropDown.drp18 = GameObject.Find("DropDown 18").GetComponent<Dropdown>();
    DropDown.drp19 = GameObject.Find("DropDown 19").GetComponent<Dropdown>();
    DropDown.drp20 = GameObject.Find("DropDown 20").GetComponent<Dropdown>();

  }
  /// <summary>
  /// Assigns called buttons value, and sets it in one of two lists.
  /// </summary>
  /// <param name="sender"></param>
  public void DropDownClicker(Dropdown sender)
  {
    Dropdown btn = sender;

    switch (btn.name)
    {
      case "DropDown 1":
        DropDown.oddValues.SetValue(btn.value, 0);
        break;
      case "DropDown 2":
        DropDown.evenValues.SetValue(btn.value, 0);
        break;
      case "DropDown 3":
        DropDown.oddValues.SetValue(btn.value, 1);
        break;
      case "DropDown 4":
        DropDown.evenValues.SetValue(btn.value, 1);
        break;
      case "DropDown 5":
        DropDown.oddValues.SetValue(btn.value, 2);
        break;
      case "DropDown 6":
        DropDown.evenValues.SetValue(btn.value, 2);
        break;
      case "DropDown 7":
        DropDown.oddValues.SetValue(btn.value, 3);
        break;
      case "DropDown 8":
        DropDown.evenValues.SetValue(btn.value, 3);
        break;
      case "DropDown 9":
        DropDown.oddValues.SetValue(btn.value, 4);
        break;
      case "DropDown 10":
        DropDown.evenValues.SetValue(btn.value, 4);
        break;
      case "DropDown 11":
        DropDown.oddValues.SetValue(btn.value, 5);
        break;
      case "DropDown 12":
        DropDown.evenValues.SetValue(btn.value, 5);
        break;
      case "DropDown 13":
        DropDown.oddValues.SetValue(btn.value, 6);
        break;
      case "DropDown 14":
        DropDown.evenValues.SetValue(btn.value, 6);
        break;
      case "DropDown 15":
        DropDown.oddValues.SetValue(btn.value, 7);
        break;
      case "DropDown 16":
        DropDown.evenValues.SetValue(btn.value, 7);
        break;
      case "DropDown 17":
        DropDown.oddValues.SetValue(btn.value, 8);
        break;
      case "DropDown 18":
        DropDown.evenValues.SetValue(btn.value, 8);
        break;
      case "DropDown 19":
        DropDown.oddValues.SetValue(btn.value, 9);
        break;
      case "DropDown 20":
        DropDown.evenValues.SetValue(btn.value, 9);
        break;
      default:
        break;
    }
  }
}
