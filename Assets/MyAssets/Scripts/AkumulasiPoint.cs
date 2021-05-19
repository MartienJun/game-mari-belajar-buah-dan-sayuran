using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AkumulasiPoint : MonoBehaviour
{
    private float score;
    public GameObject titlePanel;
    public GameObject questionPanel;
    public GameObject[] listSoal;
    public GameObject endPanel;
    public Text labelScore;
    GameObject currentQuestion;
    
    Stack<GameObject> stackSoal = new Stack<GameObject>();


    public void StartGame()
    {
        score = 0;
        titlePanel.SetActive(false);
        questionPanel.SetActive(true);
        List<GameObject> list = new List<GameObject>(listSoal);
        
        while(list.Count > 0)
        {
            int index = Mathf.FloorToInt(Random.Range(0,list.Count));
            stackSoal.Push(list[index]);
            list.RemoveAt(index);
        }
        NextQuestion();
    }

    public void NextQuestion()
    {
        if(currentQuestion != null)
        {
            currentQuestion.SetActive(false);
        }
        
        if(stackSoal.Count == 0)
        {
            endPanel.SetActive(true);
            labelScore.text = "Score: " + score.ToString();
        }
        else
        {
            currentQuestion = stackSoal.Pop();
            currentQuestion.SetActive(true);
        }
    }

    public void AnswerCorrect()
    {
        NextQuestion();
        score += 1;
    }

    public void AnswerWrong()
    {
        NextQuestion();
    }
}