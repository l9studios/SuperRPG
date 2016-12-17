﻿using System;
using UnityEngine;

public class InventoryItem : MonoBehaviour, Purchasable
{

	public int stamina;
    public int IdItem;
    public int ID { get; set; }
    public string Title { get; set; }
    public int Value { get; set; }
    public int Power { get; set; }
    public int Defence { get; set; }
    public string Description { get; set; }
    public bool Stackable { get; set; }
    public int Rarity { get; set; }
    public string Slug { get; set; }
    public Sprite Sprite { get; set; }

    public InventoryItem(int id, string title, int value, int power, int defence, string description, bool stackable, int rarity, string slug)
    {
        this.ID = id;
        this.Title = title;
        this.Value = value;
        this.Power = power;
        this.Defence = defence;
        this.Description = description;
        this.Stackable = stackable;
        this.Rarity = rarity;
        this.Slug = slug;
        this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);
    }

    public InventoryItem()
    {
        this.ID = -1;
    }

     public InventoryItem(int id)
    {
        this.ID = id;
    }
    
    public virtual void Purchase()
    {
         FindObjectOfType<Inventory>().AddItem(IdItem);
    }
}