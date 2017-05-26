using System;

public class Player
{
	public Player()
	{
        string name = "";
        string userName = "";
        int age = 0;
        int money = 0;
	}

    public Player(string namey, string userNamey, int agy, int monies)
    {
        string name = namey;
        string userName = userNamey;
        int age = agy;
        int money = monies;
    }

    void setMoney(int amount)
    {
        money += amount;
    }

    int getMoney()
    {
        return money;
    }


    //Has Cards?
    //Is player at the table?

}
