namespace Animaciones
{
    public interface IcrudAnimacion
    {
        string GetPosicionInicial();
        string[] GetAtacar1();
        string[] GetAtacar2();
        string[] GetAtacar3();
        string GetPosicionDefender();
        string GetAccionMejora();
        string GetMorir();
    }
}
