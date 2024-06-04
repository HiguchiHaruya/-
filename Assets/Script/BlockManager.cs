using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class BlockManager : MonoBehaviour
{
    //シングルトン使って値の受け渡しやってます
    public static BlockManager instance { get; private set; }
    public GameObject _gameobj;
    [SerializeField] Text _scoretext;
    int score = 0;
    private void Awake()
    {
        if (instance == null) { instance = this; }
        else if (instance != null) { Destroy(gameObject); }
    }
    void Start()
    {
        Genelate((float)Random.Range(-6.6f, 10));
    }

    void Update()
    {
        _scoretext.text = score.ToString();
    }
    void Genelate(float r)
    {
        for (int i = 5; i < 105; i += 5)
        {
            Instantiate(_gameobj, new Vector3(r, 3.31f, i), Quaternion.identity);
        }
    }
    public void AddScore(int s)
    {
        score += s;
        Debug.Log(score);
    }
}
