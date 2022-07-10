using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube2_hp : MonoBehaviour
{
    public int HP = 100;
    public Slider hpbar;
    public Image hpbar_color;
    HitPoint script;

    public 
    // Start is called before the first frame update
    void Start()
    {
        script = this.gameObject.GetComponent<HitPoint>();

    }

  /*  //攻撃されたか
    bool Attack(){
        if(Input.GetKey(KeyCode.W)){
            return true;
        }
        else{
            return false;
        }
    }
  */
    // Update is called once per frame
    void Update()
    {

        hpbar.value = script.HP;

        //色変え
        if(script.HP < 20){
            hpbar_color.color=new Color32(255,0,0,255);
        }

    }
}
