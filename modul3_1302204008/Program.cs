using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah buah= new KodeBuah();
            Console.WriteLine("Table-Driven");
            Console.WriteLine("Nama Buah        |   Kode Buah");
            buah.getKodeBuah();

            Console.WriteLine();
            Console.WriteLine("====== Posisi ======");
            PosisiKarakterGame posisi = new PosisiKarakterGame();
            posisi.kegiatan();
        }

    }
    class KodeBuah
    {

        Dictionary<string, string> DataBuah = new Dictionary<string, string>() {
            {"Apel      ",  "|    A00"},
            {"Aprikot",     "|    B00"},
            {"Alpukat",     "|    C00"},
            {"Pisang    ",  "|    D00"},
            {"Paprika",     "|    E00"},
            {"Blackberry",  "|    F00"},
            {"Ceri      ",  "|    H00"},
            {"Kelapa    ",  "|    I00"},
            {"Jagung    ",  "|    J00"},
            {"Kurma  ",     "|    K00"},
            {"Durian  ",    "|    L00"},
            {"Anggur  ",    "|    M00"},
            {"Melon  ",     "|    N00"},
            {"Semagka  ",   "|    O00"}
        };
        public void getKodeBuah()
        {
            foreach (KeyValuePair<string, string> key in DataBuah)
            {
                Console.WriteLine("{0} \t {1}", key.Key, key.Value);
            }
        }
    }
    class PosisiKarakterGame
    {
        enum State { Terbang, Jongkok, Berhenti };
        public void kegiatan()
        {
            State state = State.Terbang;

            String[] screenName = { "Terbang", "Jongkok" };
            do
            {
                if(state == State.Terbang) {
                    Console.WriteLine("posisi take off");
                }
                if(state == State.Jongkok) {
                    Console.WriteLine("posisi Landing");
                }

                Console.WriteLine("" + screenName[(int)state]);
                Console.WriteLine();
                Console.Write("Tekan tombol : ");
                String kegiatan = Console.ReadLine();
                switch (state)
                {
                    case State.Terbang:
                        if (kegiatan != "w")
                        {
                            state = State.Jongkok;
                        }
                        break;
                    case State.Jongkok:
                        if (kegiatan != "s")
                        {
                            state = State.Terbang;
                        }
                        break;
                    case State.Berhenti:
                        if (kegiatan == "q")
                        {
                            state = State.Berhenti;
                        }
                        break;
                }
            } while (state != State.Berhenti);
        }

    }
}
