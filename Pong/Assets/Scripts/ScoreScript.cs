using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private TMP_Text _tx;
    [SerializeField] private int _winCond;

    // Start is called before the first frame update
    void Start()
    {
        _tx = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_tx.name == "RightScore") _tx.text = $"{GlobalData.RightScore}";
        else if (_tx.name == "LeftScore") _tx.text = $"{GlobalData.LeftScore}";
    }
}
