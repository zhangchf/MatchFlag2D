using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text targetText;
    public Text resultText;
    public string targetName;

    // Start is called before the first frame update
    void Start()
    {
        targetText.text = targetName;
        
    }

    public bool MatchName(string name)
    {
        resultText.text = (name == targetName) ? "Correct" : "Wrong";
        Animator animator = resultText.GetComponent<Animator>();
        if (animator != null)
        {
            animator.Play("ScaleOutAnimation", 0, 0);
        }
        return name == targetName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
