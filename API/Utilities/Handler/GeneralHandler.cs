namespace API.Utilities.Handler;

public class GeneralHandler
{
    public static string Nik(string? nik = null)
    {
        // Cek input nik = null 
        if (nik is null)
        {
            return "000001";  //  default NIK "000001" bila input nik adalah null 
        }
        var generateNik = int.Parse(nik) + 1; //  input nik bertambah 1 ke angka tersebut
        return generateNik.ToString();
    }

}
