using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Views
{
    public class CardView : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        private Image _cardItemImage;

        [SerializeField]
        private Image _levelIndicator;

        [SerializeField]
        private Text _levelMaxView;

        [SerializeField]
        private Text _currentLevelView;

        [SerializeField]
        private Text _levelToUpgradeView;

        [SerializeField]
        private CardModel _cardModel;

        #endregion

        #region Methods

        private void Start()
        {
            ViewDataSync();
            SetLevelIndicatorColor();
        }

        private void ViewDataSync()
        {
            _levelMaxView.text = _cardModel.LevelMax.ToString();
            _currentLevelView.text = _cardModel.CurrentLevel.ToString();
            _levelToUpgradeView.text = _cardModel.LevelToUpgrade.ToString();
        }

        private void SetLevelIndicatorColor()
        {
            if (_cardModel.LevelUpResult)
            {
                _levelIndicator.color = Color.green;
            }
            else
            {
                _levelIndicator.color = Color.red;
            }
        }

        #endregion
    }
}
