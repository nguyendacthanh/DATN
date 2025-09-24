using UnityEngine;

public class CharacterAction : MonoBehaviour
{
    public bool Attack = false;

    public void Update()
    {
        if(Attack == true)
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponent<Character>().Mau -= 10;
            Attack = false;
        }
    }
}
