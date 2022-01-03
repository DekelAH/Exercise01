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
        private Text _levelMaxView;

        [SerializeField]
        private Text _currentLevelView;

        [SerializeField]
        private CardModel _cardModel;

        #endregion

        #region Fields

        #endregion

        #region Methods

        //private void Start()
        //{
        //    ViewDataSync();
        //}

        private void FixedUpdate()
        {
            ViewDataSync();
        }

        private void ViewDataSync()
        {
            _levelMaxView.text = _cardModel.LevelMax.ToString();
            _currentLevelView.text = _cardModel.CurrentLevel.ToString();
        }

        #endregion
    }
}
