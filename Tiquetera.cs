class Tiquetera{
    public int UltimoID{get ; private set;}
    public int DevolverUltimoID(int ultimoid){
      int IDActual = ultimoid + 1;
      return IDActual;
    }
}