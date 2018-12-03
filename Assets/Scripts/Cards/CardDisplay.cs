using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SA
{
    public class CardDisplay : MonoBehaviour
    {

        public Card card;

        public Text nameText;
        public Text description;

        public Image artworkImage;

        public Text manaText;
        public Text attackText;
        public Text healthText;
        public Text abilityText;

        public Text typeText;

        // Use this for initialization
        void Start()
        {
            LoadCard(card);
        }

        public void LoadCard(Card card)
        {
            if (card == null)
            {
                return;
            }

            nameText.text = card.name;
            description.text = card.description;

            artworkImage.sprite = card.artwork;

            manaText.text = card.manaCost.ToString();
            attackText.text = card.attack.ToString();
            healthText.text = card.health.ToString();

            if (string.IsNullOrEmpty(card.ability.ToString()))
            {
                abilityText.gameObject.SetActive(false);
            } else {
                abilityText.gameObject.SetActive(true);
                abilityText.text = card.ability.ToString();
            }

            typeText.text = card.type;
        }

    }
}