using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
  public Image image_1;
  public Image image_2;
  public Image image_3;
  public Image image_4;
  public Image image_5;
  public Image image_6;
  public Image image_7;
  public Image image_8;
  public Image image_9;
  public Image image_10;
  public Image image_11;
  public Image image_12;
  public Image image_13;
  public Image image_14;
  public Image image_15;
  public Image image_16;
  public Image image_17;
  public Image image_18;
  public Image image_19;
  public Image image_20;

  public List<Image> images;

  private string url1 = "D:/Documents/LessonPlans/USEducation/Pictures/MemoryMatch/";
  private string url2 = "E:/Randall/MemoryMatch/Pictures/";

  /// <summary>
  /// Loads Sprites on waking.
  /// </summary>
  private void Awake()
  {
    this.images.Add(this.image_1);
    this.images.Add(this.image_2);
    this.images.Add(this.image_3);
    this.images.Add(this.image_4);
    this.images.Add(this.image_5);
    this.images.Add(this.image_6);
    this.images.Add(this.image_7);
    this.images.Add(this.image_8);
    this.images.Add(this.image_9);
    this.images.Add(this.image_10);
    this.images.Add(this.image_11);
    this.images.Add(this.image_12);
    this.images.Add(this.image_13);
    this.images.Add(this.image_14);
    this.images.Add(this.image_15);
    this.images.Add(this.image_16);
    this.images.Add(this.image_17);
    this.images.Add(this.image_18);
    this.images.Add(this.image_19);
    this.images.Add(this.image_20);
  }

  private void Start()
  {
    if (ImageManager.url1Exists)
    {
      this.LoadImages(this.url1);
    }
    else if (ImageManager.url2Exists)
    {
      this.LoadImages(this.url2);
    }
    else
    {
      for (int i = 0; i < this.images.Count; i++)
      {
        string id = SaveSystem.GetInt("Entry " + i).ToString(); ;
        Sprite spr = Resources.Load<Sprite>("Pictures/" + id);
        this.images[i].sprite = spr;
      }
    }
  }

  private void LoadImages(string url)
  {
    for (int i = 0; i < this.images.Count; i++)
    {
      string id = SaveSystem.GetInt("Entry " + i).ToString();
      using (WWW www = new WWW("file:///" + url + id + ".png"))
      {
        this.images[i].sprite = Sprite.Create(www.texture, new Rect(0.0f, 0.0f,
          www.texture.width, www.texture.height), new Vector2(0.5f, 0.5f), 1024.0f);
      }
    }
  }

  public bool FileChk(string url)
  {
    if (System.IO.File.Exists(url + "Test.png"))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}


