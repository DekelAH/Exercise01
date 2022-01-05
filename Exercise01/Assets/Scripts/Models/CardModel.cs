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

    [SerializeField]
    private int _levelToUpgrade;

    #endregion

    #region Fields

    private bool _isLevelUp = true;

    #endregion

    #region Methods

    private void OnValidate()
    {
        CheckMaxLevel(_currentLevel, _levelMax);
        CheckLevelToUpgrade(_levelToUpgrade);
        CheckLevelUp(_levelToUpgrade, _currentLevel, _levelMax);
    }

    private void CheckMaxLevel(int currentLevel, int levelMax)
    {

       _currentLevel = Mathf.Clamp(currentLevel, 1, levelMax);
    }

    private void CheckLevelToUpgrade(int levelToUpgrade)
    {
        _levelToUpgrade = Mathf.Clamp(levelToUpgrade, 1, 10);
    }

    private bool CheckLevelUp(int levelToUpgrade, int currentLevel, int levelMax)
    {
        if (levelToUpgrade + currentLevel > levelMax)
        {
            return _isLevelUp = false;
        }
        else if(levelToUpgrade + currentLevel == levelMax)
        {
            return _isLevelUp;
        }
        else
        {
            return _isLevelUp = false;
        }
    }

    #endregion

    #region Properties

    public int CurrentLevel => _currentLevel;

    public int LevelMax => _levelMax;

    public int LevelToUpgrade => _levelToUpgrade;

    public bool LevelUpResult => _isLevelUp;

    #endregion
}
