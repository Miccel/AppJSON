namespace AppJSON.ExtendedMethods
{
/// <summary>
/// Intefaccia che contiene metodi CRUD(Create, Read, Update, Destroy).
/// Per semplicità il metodo Create viene sostituito dal costruttore
/// che eredita l'interfaccia
/// </summary>
    public interface ICRUD
    {
         void Read();
         void Update();
         void Destroy();
    }
}
