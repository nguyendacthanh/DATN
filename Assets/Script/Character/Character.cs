using UnityEngine;

public class Character
{

    public UnitData CharactersData;
    public int Ten;
    public int Class;

    public int TanCong;
    public int Mau;
    public int Speed;

    public int Giap;
    public int TinhThan;

    private void Start()
    {

        if (CharactersData != null)
        {
            Ten = CharactersData.Ten;
            Class = CharactersData.Class;
            TanCong = CharactersData.TanCong;
            Mau = CharactersData.Mau;
            Speed = CharactersData.Speed;
            Giap = CharactersData.Giap;
            TinhThan = CharactersData.TinhThan;
        }

    }
}
