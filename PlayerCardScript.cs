using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace TraderScrolling
{
    public class PlayerCardScript : MonoBehaviour
    {
        private void Awake()
        {
            //Adjusts Money position
            var rightPerson = GameObject.Find("Right Person");
            if (rightPerson == null) return;
            
            var list = rightPerson.GetComponentsInChildren<RectTransform>(true).ToList();
            var money = list.FirstOrDefault(x => x.name == "Money");
            if (money != null)
            {
                var moneyRect = money.GetComponent<RectTransform>();
                moneyRect.anchoredPosition = new Vector2(moneyRect.anchoredPosition.x + 60f, moneyRect.anchoredPosition.y);

                // Change spacing
                var money2 = rightPerson.GetComponentInChildren<HorizontalLayoutGroup>(true);
                if (money2 != null)
                {
                    money2.spacing = 10;
                }
            }

            // Make tile simple
            var tile = rightPerson.GetComponentsInChildren<Image>(true).ToList();
            var tileImage = tile.FirstOrDefault(x => x.name == "Background Tile");
            if (tileImage != null)
            {
                tileImage.type = Image.Type.Simple;
            }

            var foundObject = rightPerson.transform.Find("Background Tile");
            if (foundObject != null)
            {
                foundObject.gameObject.SetActive(true);

                var tileRect = foundObject.GetComponent<RectTransform>();
                if (tileRect != null)
                {
                    tileRect.sizeDelta = new Vector2(500f, 0);
                }
            }

            // Change Colour alpha to max for background
            var background = tile.FirstOrDefault(x => x.name == "Background");
            if (background != null)
            {
                background.color = new Color(0, 0, 0, 1);
            }
        }
    }
}
