﻿using System;
using System.IO;

namespace LyonPalmeForms.Tools
{
    /// <summary>
    /// Gère les logs de l'application.
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Ecrit les logs dans un fichier dédié.
        /// (logerror : fichier consignant les erreurs d'exécution, logmessage : fichier consignant les messages de l'application).
        /// </summary>
        /// <param name="logMessage">Le message à logger.</param>
        /// <param name="w">Le fichier dans lequel écrire.</param>
        public static void WriteLog(string logMessage, System.IO.TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        /// <summary>
        /// Parcours le fichier log passé en paramètre et affiche son contenu.
        /// </summary>
        /// <param name="r">Le fichier à lire.</param>
        public static void DumpLog(System.IO.StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

