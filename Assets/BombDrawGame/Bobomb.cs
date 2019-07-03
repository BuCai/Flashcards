using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bobomb : MonoBehaviour
{
    public Sprite[] sprites;
    public string _imagePath = "KBA/u1";
    public Image[] bombImages;


    private void Start()
    {
        //_imagePath = LevelNumber.bookName + LevelNumber.numberOfLevel;

        Debug.Log(_imagePath);

        Object[] loadedSprites = Resources.LoadAll(_imagePath, typeof(Sprite));
        loadedSprites = new Sprite[loadedSprites.Length];
        for (int i = 0; i < loadedSprites.Length; i++)
        {
            bombImages[i].sprite = (Sprite)loadedSprites[i];
        }
    }
}
