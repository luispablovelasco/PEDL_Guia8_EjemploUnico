using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PEDL_Guia8_EjemploUnico
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creamos una tabla hash utilizando la clase Hastable disponible en Collection
            Hashtable thash1 = new Hashtable();

            //Agregando elementos a la tabla hash
            //Los valores pueden duplicarse pero no las claves

            thash1.Add("txt", "Programa notepad.exe");
            thash1.Add("bmp", "Programa paint.exe");
            thash1.Add("dib", "Programa paint.exe");
            thash1.Add("rtf", "Programa wordpad.exe");

            //Comprobación de validacion de que no se admiten llaves duplicadas

            try
            {
                thash1.Add("txt" , "Programa windword.exe");
            }
            catch 
            {
                Console.WriteLine("Un elemento con la clave = \"txt\" Ya existe \n");
                
            }

            //Podemos obtener el valor utilizando la clave
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Imprimimos un valor de la tabla usando la clave");
            Console.WriteLine("Para la clave = \"rtf\", valor = {0}", thash1["rtf"] + "\n");

            //Tambien podemos cambiar el valor utilizando la clave
            thash1["rtf"] = "recortes.exe";
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Cambiando el valor asociado a la claver rtf");
            Console.WriteLine("Para la clave = \"rtf\", valor = {0}.", thash1["rtf"]);
            Console.WriteLine("n--------------------------------------------------");

            //Si la clave no existe, al utilizar esta sintaxis tambien se puede agregar igual que add
            thash1["doc"] = "winword.exe";

            //ContainsKey puede ser usada para probar si la clave ya existe

            if (!thash1.Contains("ht"))
            {
                thash1.Add("ht", "hypertrm.exe");
                Console.WriteLine("Valor agregado para = \"ht\": {0}", thash1["ht"]);
                Console.WriteLine("-----------------------------------------------------");
            }

            /*
                Para obtener solo los valores, utilice la propiedad values, utilizamos ICollection para formar una
                nueva coleccion a partir de los valores de la tabla hash
            */

            ICollection valueColl = thash1.Values;

            //Imprimimos solo valores

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("IMPRIMIENDO SOLO VALORES DE LA TABLA");

            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            /*
                Para obtener solo las claves utilice la propiedad Keys, utilizamos ICollection para formar una nueva 
                coleccion para formar una nueva coleccion a partir de las claves de la tabla hash
            */

            ICollection KeyColl = thash1.Keys;
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("IMPRIMIENDO NSOLO LAS LLAVES DE LA TABLA");
            foreach (string s in KeyColl)
            {
                Console.WriteLine("Clave = {0}",s);
            }

            //Removiendo elementos
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("--------------------- REMOVER CLAVES ------------------------");
            Console.WriteLine("Primero se remueve la clave .doc");
            Console.WriteLine("\nRemover (\"doc\")"); thash1.Remove("doc");
            Console.WriteLine("-------");
            Console.WriteLine("\n Despues verificamos si la clave aun existe en la tabla");
            if (!thash1.ContainsKey("doc"))
            {
                Console.WriteLine("Clave \"doc\" no encontrada.");
            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.ReadLine();

        }
    }
}
