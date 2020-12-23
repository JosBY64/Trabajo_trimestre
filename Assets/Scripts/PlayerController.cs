using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int life = 100;
    public int money = 400;
    public int cartera = 0;

    public Text textHP;
    public Text textMoney;
    public Slider sliderHP;
    //public Button butonTurret;

    public GameObject turretPrefab;
    public GameObject turretBankPrefab;
    public GameObject moneyGot;

    public Transform moneyGotPosition;

    
    void Start()
    {
        cartera = money;
        sliderHP.maxValue = life;
    }

    void Update()
    {
        lifeUpdate();
        moneyUpdate();
    }

    private void lifeUpdate()
    {
        textHP.text = "Vida: " + life;
        sliderHP.value = life; 
    }

    private void moneyUpdate()
    {
       
        textMoney.text = "Dinero$ " + money;
        if (cartera < money)
        {
            //Debug.Log("DINERO + 50");
            Instantiate(moneyGot, moneyGotPosition.position, Quaternion.identity, moneyGotPosition);
            cartera = money;
        }

    }

    public void LifeSteal(int damage)
    {
        life -= damage;
    }

    public void buyTurret()
    {
        if (money >= 300)
        {
            money -= 300;
            Instantiate(turretPrefab, transform.position, Quaternion.identity);
        }
   
    }
    public void buyBankTurret()
    {
        if (money >= 120)
        {
            money -= 120;
            Instantiate(turretBankPrefab, transform.position, Quaternion.identity);
        }

    }
    public void bank(int ganancia)
    {
       money += ganancia;
        //Debug.Log("la ganancia es de : " + ganancia);
    }
}
