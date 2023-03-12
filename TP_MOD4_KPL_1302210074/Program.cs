// See https://aka.ms/new-console-template for more information
namespace TP_MOD4_KPL
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            KodePos table_kode_pos = new KodePos();
            Console.WriteLine("Kode pos Batununggal");
            table_kode_pos.getkodepos("Batunuggal");
            Console.WriteLine("Kode pos semua Daerah");
            table_kode_pos.getallkodepos();
        }
    }
    class KodePos
    {
        Dictionary<string, string> dic = new Dictionary<string, string>(){
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"},
        };

        public void getkodepos(string kode)
        {
            if(dic.ContainsKey(kode))
            {
                Console.WriteLine(kode + " : " + dic[kode]);
            }
            else
            {
                Console.WriteLine(kode + "Kode tidak terdaftar");
            }
        }

        public void getallkodepos()
        {
            foreach(KeyValuePair<string, string> i in dic)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }


}