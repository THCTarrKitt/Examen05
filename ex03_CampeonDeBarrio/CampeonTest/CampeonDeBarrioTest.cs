using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex03_CampeonDeBarrio;
using System;

namespace CampeonTest
{
    [TestClass]
    public class ex03_CampeonDeBarrioTests
    {
        

       

        [TestMethod]

        //public void PruebaCampeonUnico()
        //{
        //    Jugador[] losJugadores = new Jugador[]
        //    {
        //        new Jugador
        //        {
        //            Nombre = "awa",
        //            Puntos = 180,
        //            Campañas = 3

        //        },
        //        new Jugador
        //        {
        //            Nombre = "ewe",
        //            Puntos = 180,
        //            Campañas = 4

        //        },
        //        new Jugador
        //        {
        //            Nombre = "iwi",
        //            Puntos = 180,
        //            Campañas = 5

        //        },
        //        new Jugador
        //        {
        //            Nombre = "owo",
        //            Puntos = 190,
        //            Campañas = 1

        //        },
        //        new Jugador
        //        {
        //            Nombre = "uwu",
        //            Puntos = 190,
        //            Campañas = 1

        //        }
        //    };

        //    string[] ganadorEsperado = { "uwu", "owo" };
        //    string[] ganadorActual = Program.IdentificaCampeon(losJugadores);

        //    Assert.AreEqual(ganadorEsperado, ganadorActual);
        //}

        public void PruebaCampeonesNumero()
        {
            Jugador[] losJugadores = new Jugador[]
            {
                new Jugador
                {
                    Nombre = "awa",
                    Puntos = 180,
                    Campañas = 3

                },
                new Jugador
                {
                    Nombre = "ewe",
                    Puntos = 180,
                    Campañas = 4

                },
                new Jugador
                {
                    Nombre = "iwi",
                    Puntos = 180,
                    Campañas = 5

                },
                new Jugador
                {
                    Nombre = "owo",
                    Puntos = 190,
                    Campañas = 1

                },
                new Jugador
                {
                    Nombre = "uwu",
                    Puntos = 190,
                    Campañas = 1

                }
            };

            int numeroEsperado = 2;
            int numeroActual = Program.IdentificaCampeon(losJugadores);

            Assert.AreEqual(numeroEsperado, numeroActual);

        }
    }
}