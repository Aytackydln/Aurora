﻿using System.Collections.Generic;
using System.Linq;

namespace Aurora.Profiles.Dota_2.GSI.Nodes
{
    /// <summary>
    /// Class representing item information
    /// </summary>
    public class Items_Dota2 : Node
    {
        private List<Item> inventory = new List<Item>();
        private List<Item> stash = new List<Item>();

        /// <summary>
        /// Number of items in the inventory
        /// </summary>
        public int InventoryCount { get { return inventory.Count; } }

        /// <summary>
        /// Gets the array of the inventory items
        /// </summary>
        [Range(0, 8)]
        public Item[] InventoryItems
        {
            get { return inventory.ToArray(); }
        }

        /// <summary>
        /// Number of items in the stash
        /// </summary>
        public int StashCount { get { return stash.Count; } }

        /// <summary>
        /// Gets the array of the stash items
        /// </summary>
        [Range(0, 5)]
        public Item[] StashItems
        {
            get { return stash.ToArray(); }
        }

        internal Items_Dota2(string json_data) : base(json_data)
        {
            List<string> slots = _ParsedData.Properties().Select(p => p.Name).ToList();
            
            foreach (string ItemSlot in slots)
            {
                if (ItemSlot.StartsWith("slot"))
                    this.inventory.Add(new Item(_ParsedData[ItemSlot].ToString()));
                else if(ItemSlot.StartsWith("stash"))
                    this.stash.Add(new Item(_ParsedData[ItemSlot].ToString()));
            }
        }

        /// <summary>
        /// Gets the inventory item at the specified index
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns></returns>
        public Item GetInventoryAt(int index)
        {
            if (index > inventory.Count - 1)
                return new Item("");

            return inventory[index];
        }

        /// <summary>
        /// Gets the stash item at the specified index
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns></returns>
        public Item GetStashAt(int index)
        {
            if (index > stash.Count - 1)
                return new Item("");

            return stash[index];
        }

        /// <summary>
        /// Checks if item exists in the inventory
        /// </summary>
        /// <param name="itemName">The item name</param>
        /// <returns>A boolean if item is in the inventory</returns>
        public bool InventoryContains(string ItemName)
        {
            foreach(Item InventoryItem in this.inventory)
            {
                if (InventoryItem.Name.Equals(ItemName))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if item exists in the stash
        /// </summary>
        /// <param name="itemname">The item name</param>
        /// <returns>A boolean if item is in the stash</returns>
        public bool StashContains(string ItemName)
        {
            foreach (Item StashItem in this.stash)
            {
                if (StashItem.Name.Equals(ItemName))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Gets index of the first occurence of the item in the inventory
        /// </summary>
        /// <param name="itemName">The item name</param>
        /// <returns>The first index at which item is found, -1 if not found.</returns>
        public int InventoryIndexOf(string ItemName)
        {
            for (int x = 0; x < this.inventory.Count; x++)
            {
                if (this.inventory[x].Name.Equals(ItemName))
                    return x;
            }

            return -1;
        }

        /// <summary>
        /// Gets index of the first occurence of the item in the stash
        /// </summary>
        /// <param name="itemname">The item name</param>
        /// <returns>The first index at which item is found, -1 if not found.</returns>
        public int StashIndexOf(string ItemName)
        {
            for (int x = 0; x < this.stash.Count; x++)
            {
                if (this.stash[x].Name == ItemName)
                    return x;
            }

            return -1;
        }
    }
}
