﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;

    public Color highlightColor = Color.cyan;

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null)
        {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.85f, 0.85f, 1.0f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.75f, 0.75f, 1.0f);
        if(targetObject != null )
        {
            targetObject.SendMessage(targetMessage);
        }
    }
}
