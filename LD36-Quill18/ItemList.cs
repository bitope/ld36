﻿using System;
using System.Collections.Generic;

namespace LD36Quill18
{
    static public class ItemList
    {
        static ItemList()
        {
            Items = new Dictionary<char, Item>();

            char c;

            c = 'B';
            Items[c] = new Item();
            Items[c].Name = "Battery (9v)";
            Items[c].Chixel = new Chixel(c, ConsoleColor.Green);
            Items[c].OnUse += (item) => { OnUse_ChangeEnergy(item, 25); };
            Items[c].UsesLeft = 1;

            c = '$';
            Items[c] = new Item();
            Items[c].Name = "Metal Scraps";
            Items[c].IsMoney = true;
            Items[c].Chixel = new Chixel(c, ConsoleColor.Red);



        }

        static public Dictionary<char, Item> Items;

        public static void OnUse_ChangeEnergy(Item item, int amt)
        {
            PlayerCharacter.Instance.Energy += amt;
            Game.Instance.Message(string.Format("You gained {0} energy.", amt));
        }

    }

}

