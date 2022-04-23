using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int SelectedSkin = 0;
    public GameObject playerskin;

    public void NextOption()
    {
        SelectedSkin = SelectedSkin + 1;
        if (SelectedSkin == skins.Count)
        {
            SelectedSkin = 0;
        }
        sr.sprite = skins[SelectedSkin];

    }
    public void BackOption()
    {
        SelectedSkin = SelectedSkin - 1;
        if (SelectedSkin < 0)
        {
            SelectedSkin = skins.Count -1;
        }
        sr.sprite = skins[SelectedSkin];
    }
}
