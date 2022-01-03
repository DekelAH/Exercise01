using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Exercise01/Models/Card Model", fileName = "Card Model")]
public class CardModel : ScriptableObject
{
    #region Editor

    [SerializeField]
    private int _currentLevel;

    [SerializeField]
    private int _levelMax;

    [SerializeField]
    private int _levelMin;

    #endregion

    #region Methods

    private void OnValidate()
    {
        CheckMaxLevel(_currentLevel);
    }

    private void CheckMaxLevel(int currentLevel)
    {
        if (currentLevel >= _levelMax)
        {
            if (_currentLevel > _levelMax)
            {
                throw new Exception("Current level can't be higher than Level Max");
            }

            _currentLevel = _levelMax;
        }
    }

    #endregion

    #region Properties

    public int CurrentLevel => _currentLevel;

    public int LevelMax => _levelMax;

    #endregion
}
