using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavesManager : MonoBehaviour
{
  public Button imageLoader;

  public void Save2()
  {
    this.AddToDictionary();
    this.SaveMatches();
    SaveSystem.SaveToDisk();
  }

  public void Load2()
  {

    this.LoadRandomImages();
    this.LoadMatches();
  }

  /// <summary>
  /// Checks the int in each position of list Odd Values.
  /// If it is not 0, and is not already in dictionary LookUp Dict,
  /// adds the key from position in Odd Values list to the complimentary
  /// value from Even Values list.
  /// </summary>
  public void AddToDictionary()
  {
    DropDown.lookupDict.Clear();

    for (int i = 0; i < 10; i++)
    {
      int check = Convert.ToInt32(DropDown.oddValues.GetValue(i));
      if (!(check == 0) && !(DropDown.lookupDict.ContainsKey(check)))
      {
        DropDown.lookupDict.Add(Convert.ToInt32(DropDown.oddValues.GetValue(i)), Convert.ToInt32(DropDown.evenValues.GetValue(i)));
      }
    }
  }

  public void SaveMatches()
  {
    SaveSystem.SetInt("DropDown 1", DropDown.oddValues[0]);
    SaveSystem.SetInt("DropDown 2", DropDown.evenValues[0]);
    SaveSystem.SetInt("DropDown 3", DropDown.oddValues[1]);
    SaveSystem.SetInt("DropDown 4", DropDown.evenValues[1]);
    SaveSystem.SetInt("DropDown 5", DropDown.oddValues[2]);
    SaveSystem.SetInt("DropDown 6", DropDown.evenValues[2]);
    SaveSystem.SetInt("DropDown 7", DropDown.oddValues[3]);
    SaveSystem.SetInt("DropDown 8", DropDown.evenValues[3]);
    SaveSystem.SetInt("DropDown 9", DropDown.oddValues[4]);
    SaveSystem.SetInt("DropDown 10", DropDown.evenValues[4]);
    SaveSystem.SetInt("DropDown 11", DropDown.oddValues[5]);
    SaveSystem.SetInt("DropDown 12", DropDown.evenValues[5]);
    SaveSystem.SetInt("DropDown 13", DropDown.oddValues[6]);
    SaveSystem.SetInt("DropDown 14", DropDown.evenValues[6]);
    SaveSystem.SetInt("DropDown 15", DropDown.oddValues[7]);
    SaveSystem.SetInt("DropDown 16", DropDown.evenValues[7]);
    SaveSystem.SetInt("DropDown 17", DropDown.oddValues[8]);
    SaveSystem.SetInt("DropDown 18", DropDown.evenValues[8]);
    SaveSystem.SetInt("DropDown 19", DropDown.oddValues[9]);
    SaveSystem.SetInt("DropDown 20", DropDown.evenValues[9]);
  }

  public void LoadRandomImages()
  {
    ImageManager.randomizedImages.Clear();
    for (int i = 0; i < 20; i++)
    {
      ImageManager.randomizedImages.Add(SaveSystem.GetInt("Entry " + i.ToString()));
    }

    this.Loading();
  }

  public void Loading()
  {
    ImageManager.url1Exists = ImageManager.FileChk(ImageManager.url1);
    ImageManager.url2Exists = ImageManager.FileChk(ImageManager.url2);

    if (ImageManager.url1Exists)
    {
      this.LoadImages(ImageManager.url1);
    }
    else if (ImageManager.url2Exists)
    {
      this.LoadImages(ImageManager.url2);
    }
    else
    {
      for (int i = 0; i < ImageManager.images.Count; i++)
      {
        string id = ImageManager.randomizedImages[i].ToString();
        Sprite spr = Resources.Load<Sprite>("Pictures/" + id);
        ImageManager.images[i].sprite = spr;
      }
    }
  }

  private void LoadImages(string url)
  {
    for (int i = 0; i < ImageManager.images.Count; i++)
    {
      string id = ImageManager.randomizedImages[i].ToString();
      using (WWW www = new WWW("file:///" + url + id + ".png"))
      {
        ImageManager.images[i].sprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f,
          www.texture.width, www.texture.height), new Vector2(0.5f, 0.5f), 1024.0f);
      }
    }
  }

  public void LoadMatches()
  {
    DropDown.drp1.value = SaveSystem.GetInt("DropDown 1");
    DropDown.oddValues.SetValue(DropDown.drp1.value, 0);
    DropDown.drp2.value = SaveSystem.GetInt("DropDown 2");
    DropDown.evenValues.SetValue(DropDown.drp2.value, 0);
    DropDown.drp3.value = SaveSystem.GetInt("DropDown 3");
    DropDown.oddValues.SetValue(DropDown.drp3.value, 1);
    DropDown.drp4.value = SaveSystem.GetInt("DropDown 4");
    DropDown.evenValues.SetValue(DropDown.drp4.value, 1);
    DropDown.drp5.value = SaveSystem.GetInt("DropDown 5");
    DropDown.oddValues.SetValue(DropDown.drp5.value, 2);
    DropDown.drp6.value = SaveSystem.GetInt("DropDown 6");
    DropDown.evenValues.SetValue(DropDown.drp6.value, 2);
    DropDown.drp7.value = SaveSystem.GetInt("DropDown 7");
    DropDown.oddValues.SetValue(DropDown.drp7.value, 3);
    DropDown.drp8.value = SaveSystem.GetInt("DropDown 8");
    DropDown.evenValues.SetValue(DropDown.drp8.value, 3);
    DropDown.drp9.value = SaveSystem.GetInt("DropDown 9");
    DropDown.oddValues.SetValue(DropDown.drp9.value, 4);
    DropDown.drp10.value = SaveSystem.GetInt("DropDown 10");
    DropDown.evenValues.SetValue(DropDown.drp10.value, 4);
    DropDown.drp11.value = SaveSystem.GetInt("DropDown 11");
    DropDown.oddValues.SetValue(DropDown.drp11.value, 5);
    DropDown.drp12.value = SaveSystem.GetInt("DropDown 12");
    DropDown.evenValues.SetValue(DropDown.drp12.value, 5);
    DropDown.drp13.value = SaveSystem.GetInt("DropDown 13");
    DropDown.oddValues.SetValue(DropDown.drp13.value, 6);
    DropDown.drp14.value = SaveSystem.GetInt("DropDown 14");
    DropDown.evenValues.SetValue(DropDown.drp14.value, 6);
    DropDown.drp15.value = SaveSystem.GetInt("DropDown 15");
    DropDown.oddValues.SetValue(DropDown.drp15.value, 7);
    DropDown.drp16.value = SaveSystem.GetInt("DropDown 16");
    DropDown.evenValues.SetValue(DropDown.drp16.value, 7);
    DropDown.drp17.value = SaveSystem.GetInt("DropDown 17");
    DropDown.oddValues.SetValue(DropDown.drp17.value, 8);
    DropDown.drp18.value = SaveSystem.GetInt("DropDown 18");
    DropDown.evenValues.SetValue(DropDown.drp18.value, 8);
    DropDown.drp19.value = SaveSystem.GetInt("DropDown 19");
    DropDown.oddValues.SetValue(DropDown.drp19.value, 9);
    DropDown.drp20.value = SaveSystem.GetInt("DropDown 20");
    DropDown.evenValues.SetValue(DropDown.drp20.value, 9);

    this.AddToDictionary();
  }
}
