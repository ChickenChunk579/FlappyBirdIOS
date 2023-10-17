using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSetter : MonoBehaviour
{
    public static ScoreSetter instance;

    [SerializeField]
    int score = 0;

    public Sprite one, two, three, four, five, six, seven, eight, nine, zero;

    public Image digit1;
    public Image digit2;
    public Image digit3;

    public void Awake()
    {
        instance = this;
        SetScore(score);
    }

    void SetScore(int score)
    {
        string scoreString = score.ToString("D3");

        List<char> scoreChars = scoreString.ToCharArray().ToList();
        switch (scoreChars[0])
        {
            case '1':
                digit1.sprite = one;
                break;
            case '2':
                digit1.sprite = two;
                break;
            case '3':
                digit1.sprite = three;
                break;
            case '4':
                digit1.sprite = four;
                break;
            case '5':
                digit1.sprite = five;
                break;
            case '6':
                digit1.sprite = six;
                break;
            case '7':
                digit1.sprite = seven;
                break;
            case '8':
                digit1.sprite = eight;
                break;
            case '9':
                digit1.sprite = nine;
                break;
            case '0':
                digit1.sprite = zero;
                break;
        }

        switch (scoreChars[1])
        {
            case '1':
                digit2.sprite = one;
                break;
            case '2':
                digit2.sprite = two;
                break;
            case '3':
                digit2.sprite = three;
                break;
            case '4':
                digit2.sprite = four;
                break;
            case '5':
                digit2.sprite = five;
                break;
            case '6':
                digit2.sprite = six;
                break;
            case '7':
                digit2.sprite = seven;
                break;
            case '8':
                digit2.sprite = eight;
                break;
            case '9':
                digit2.sprite = nine;
                break;
            case '0':
                digit2.sprite = zero;
                break;
        }

        switch (scoreChars[2])
        {
            case '1':
                digit3.sprite = one;
                break;
            case '2':
                digit3.sprite = two;
                break;
            case '3':
                digit3.sprite = three;
                break;
            case '4':
                digit3.sprite = four;
                break;
            case '5':
                digit3.sprite = five;
                break;
            case '6':
                digit3.sprite = six;
                break;
            case '7':
                digit3.sprite = seven;
                break;
            case '8':
                digit3.sprite = eight;
                break;
            case '9':
                digit3.sprite = nine;
                break;
            case '0':
                digit3.sprite = zero;
                break;
        }
    }

    public void AddPoint()
    {
        score++;
        SetScore(score);
    }
}
