using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public GameObject enemigoSprite;
    private bool turn = true;
    public combateManager combateManager;
    void Update()
    {
        if (!GameManager.Instance.inCombat)
        {
            float moveHorizontal = Input.GetAxis("Horizontal"); //Manera reducida que hace que el personaje se mueva reduciendo el codigo
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
            transform.position += movement * speed * Time.deltaTime;
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && turn == true) //Las acciones que hacen al presionar los botones del raton
            {
                if (combateManager.newAccion(0))
                {
                    GameManager.Instance.restart();
                    enemigoSprite.SetActive(false);
                }  
                turn = false;
                StartCoroutine(delayTurn());
            }
            if (Input.GetMouseButtonDown(1) && turn == true)
            {
                if (combateManager.newAccion(1))
                {
                    GameManager.Instance.restart();
                    enemigoSprite.SetActive(false);
                }
                turn = false;
                StartCoroutine(delayTurn());
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) // aparecen los sprites y se congela la escena para que no se mueva nada en ella mas que el combate
    {
        if(collision.tag == "Enemigo")
        {
            GameManager.Instance.uiManager.combateUI.SetActive(true);
            GameManager.Instance.inCombat = true;
            enemigoSprite.SetActive(true);
            int randomValue = Random.Range(0, 2);
            switch (randomValue)
            {
                case 0:
                    if (enemigoSprite.gameObject != null)
                    {
                        enemigoSprite.gameObject.AddComponent<sukamond>();
                        enemigoSprite.gameObject.GetComponent<sukamond>().constructor("sukamond", 10, GameManager.Instance.levelManager.sprites[2]);
                        enemigoSprite.gameObject.GetComponent<SpriteRenderer>().sprite = enemigoSprite.gameObject.GetComponent<sukamond>().GetSprite();
                    }
                    break;
                case 1:
                    if (enemigoSprite.gameObject != null)
                    {
                        enemigoSprite.gameObject.AddComponent<sukamond>();
                        enemigoSprite.gameObject.GetComponent<sukamond>().constructor("goblin", 10, GameManager.Instance.levelManager.sprites[3]);
                        enemigoSprite.gameObject.GetComponent<SpriteRenderer>().sprite = enemigoSprite.gameObject.GetComponent<sukamond>().GetSprite();
                    }
                    break;
            }
            combateManager.setNewCombat(this.GetComponent<Character>(), enemigoSprite.GetComponent<Character>());
        }
    }
    public void setSprite(Sprite _sprite)
    {
        GetComponent<SpriteRenderer>().sprite = _sprite;
    }
    public IEnumerator delayTurn()
    {
        yield return new WaitForSeconds(1);
        turn = true;
    }
}
