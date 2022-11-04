using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] AudioClip coinCollectClip;
    public PlayerManager player;
    public float velocidade;

    [Range(0f, 1f)]
    public float chanceDano;
    float pity = 1f;

    void Update()
    {
        transform.Rotate(Vector3.forward, velocidade * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerManager player = other.GetComponent<PlayerManager>();
            AudioManager.Instance.PlaySound(coinCollectClip, true);
            float rng = Random.Range(0f, 1f) * pity;
            if (rng > chanceDano)
            {
                player.PegouMoeda();
                pity = 1f;
            }
            else
            {
                player.SofreuDano();
                pity += 0.1f;
            }
            Destroy(gameObject);
        }
    }



}
