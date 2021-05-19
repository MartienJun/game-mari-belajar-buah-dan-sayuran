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
    public GameObject[] listFruits;
    public GameObject endPanel;
    public Text labelScore;
    GameObject currentQuestion;
    GameObject currentFruit;
    
    Stack<GameObject> stackSoal = new Stack<GameObject>();
    Stack<GameObject> stackFruit = new Stack<GameObject>();


    public void StartGame()
    {
        score = 0;
        stackSoal.Clear();
        stackFruit.Clear();
        titlePanel.SetActive(false);
        endPanel.SetActive(false);
        questionPanel.SetActive(true);
        List<GameObject> list = new List<GameObject>(listSoal);
        List<GameObject> list2 = new List<GameObject>(listFruits);
        
        while(list.Count > 0)
        {
            int index = Mathf.FloorToInt(Random.Range(0,list.Count));
            stackSoal.Push(list[index]);
            stackFruit.Push(list2[index]);
            list.RemoveAt(index);
            list2.RemoveAt(index);
        }
        NextQuestion();
    }

    public void EndGame()
    {
        endPanel.SetActive(true);
        questionPanel.SetActive(false);
        stackSoal.Clear();
        stackFruit.Clear();
        labelScore.text = score.ToString();
    }

    public void NextQuestion()
    {
        if(currentQuestion != null)
        {
            currentQuestion.SetActive(false);
            currentFruit.SetActive(false);
        }
        
        if(stackSoal.Count == 0)
        {
            EndGame();
        }
        else
        {
            currentQuestion = stackSoal.Pop();
            currentFruit = stackFruit.Pop();
            currentQuestion.SetActive(true);
            currentFruit.SetActive(true);
        }
    }

    public void AnswerCorrect()
    {
        score += 20;
        NextQuestion();
    }

    public void AnswerWrong()
    {
        NextQuestion();
    }
}