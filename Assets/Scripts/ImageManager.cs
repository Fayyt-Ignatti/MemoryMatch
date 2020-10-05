using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
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

  public static List<Image> images = new List<Image>();
  public static List<int> randomizedImages = new List<int>();

  public static string url1 = "D:/Documents/LessonPlans/USEducation/Pictures/MemoryMatch/";
  public static string url2 = "E:/Randall/MemoryMatch/Pictures/";

  private int listEntry;

  public static bool url1Exists;
  public static bool url2Exists;

  private void Start()
  {
    ImageManager.images.Add(this.image_1);
    ImageManager.images.Add(this.image_2);
    ImageManager.images.Add(this.image_3);
    ImageManager.images.Add(this.image_4);
    ImageManager.images.Add(this.image_5);
    ImageManager.images.Add(this.image_6);
    ImageManager.images.Add(this.image_7);
    ImageManager.images.Add(this.image_8);
    ImageManager.images.Add(this.image_9);
    ImageManager.images.Add(this.image_10);
    ImageManager.images.Add(this.image_11);
    ImageManager.images.Add(this.image_12);
    ImageManager.images.Add(this.image_13);
    ImageManager.images.Add(this.image_14);
    ImageManager.images.Add(this.image_15);
    ImageManager.images.Add(this.image_16);
    ImageManager.images.Add(this.image_17);
    ImageManager.images.Add(this.image_18);
    ImageManager.images.Add(this.image_19);
    ImageManager.images.Add(this.image_20);
  }

  public void PopulateList()
  {
    ImageManager.randomizedImages.Clear();

    for (int i = 0; i < 20; i++)
    {
      ImageManager.randomizedImages.Add(0);
    }

    this.checkList();
  }

  public void checkList()
  {
    if (ImageManager.randomizedImages.Contains(0))
    {
      this.listEntry = this.findOpenSpot();
      this.ObtainRandomizedPic(this.listEntry);
    }
    else
    {
      ImageManager.CompileImages();
    }
  }

  public int findOpenSpot()
  {
    int j = 0;
    for (int i = 0; i < ImageManager.randomizedImages.Count; i++)
    {
      if (ImageManager.randomizedImages[i] == 0)
      {
        j = i;
        break;
      }
    }
    return j;
  }

  public void ObtainRandomizedPic(int pic)
  {
    int possibleValue;

    for (int i = 0; i < 100; i++)
    {
      possibleValue = Random.Range(1, 21);

      if (!(ImageManager.randomizedImages.Contains(possibleValue)))
      {
        ImageManager.randomizedImages[pic] = possibleValue;
        break;
      }
    }
    this.checkList();
  }

  public static void CompileImages()
  {
    ImageManager.url1Exists = ImageManager.FileChk(ImageManager.url1);
    ImageManager.url2Exists = ImageManager.FileChk(ImageManager.url2);

    if (ImageManager.url1Exists)
    {
      ImageManager.LoadImages(ImageManager.url1);
    }
    else if (ImageManager.url2Exists)
    {
      ImageManager.LoadImages(ImageManager.url2);
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
    ImageManager.SaveRandomList();
  }

  public static bool FileChk(string url)
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

  public static void LoadImages(string url)
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

  public static void SaveRandomList()
  {
    for (int i = 0; i < ImageManager.randomizedImages.Count; i++)
    {
      SaveSystem.SetInt("Entry " + i.ToString(), ImageManager.randomizedImages[i]);
    }
  }
}
