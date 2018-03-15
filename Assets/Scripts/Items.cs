using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

    public void Shield()
    {

    }

    public void ExtraArmor()
    {

    }

    public void SpeedBooster()
    {
        //Speed boost - Special fuel that can temporarily increase speed
    }

    public void Rockets()
    {
        //unguided rockets that deals a great deal of damage (Area of effect)

    }

    public void OilSlick()
    {
        //makes the ground slippery, which makes the car harder to control


    }
    public void EMPBlast()
    {
        //cause the car to slightly malfunction (randomize controls, car slows down, items can be used [e.g. rocket can’t be fired, boost can’t be used, etc.])

    }


    //Item Interaction:
    //Shield + Rocket: Shield protects well against rockets, rockets don’t pass through shields
    //Shield + Oil: Shield does not help with oil slick, oil slick can go through shield
    //Shield + EMP: Shield has slight protection against EMP, EMP will only slightly slow down the car with shield
    //Armor + Rockets: Armor minimize some of the damage of the rocket, rockets do some damage
    //Armor + Oil: Armor helps stabilize against oil, oil can cause mild slipperiness.
    //Armor + EMP: Armor does not protect well against EMP, EMP can easily disrupt
    //Boost + Rockets: Boost very vulnerable against rockets, rockets can easily cause car to catch fire
    //Boost + Oil: Boost slightly stabilizes car, but controls become slightly limited
    //Boost + EMP: Boost protects well against EMP, EMP does not do anything to the car
    //Worst Against > Defense Item = OK against > Best against
    //Oil > Shield = EMP > Rocket
    //EMP > Armor = Rocket > Oil
    //Rocket > Boost = Oil > EMP

}
