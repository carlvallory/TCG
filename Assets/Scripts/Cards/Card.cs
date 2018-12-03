using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class Card : ScriptableObject
    {

        public new string name;
        public string description;

        public Sprite artwork;

        public int manaCost;
        public int attack;
        public int health;
        public int ability;

        public string type;

        //group
        public string color;
        public string ethnic;
        public string myths;


    }
}