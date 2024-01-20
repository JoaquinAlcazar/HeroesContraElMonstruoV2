using hVSmLib;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System.Dynamic;

namespace heroesContraMonstruoV2
{
    public class heroesVsMonstruo
    {
        public static void Main(String[] args)
        {
            const string welcomeMSG = "             BIENVENIDO A \n" +
                                      "         HEROES CONTRA EL MONSTRUO\n" +
                                      "                ...¡¡¡¡2!!!!!\n\n\n";
            const string pressToCont = "Pulsa un botón para continuar";
            const string mainMenu = "Bienvenido a Heroes contra el monstruo 2, el mismo juego de batalla contra el monstruo, ahora con diseño modular.\n" +
                "¿Quieres probarte en batalla?\n1.Iniciar una nueva batalla\n2.Salir";
            const string thxForPlay = "¡¡¡Gracias por jugar!!!";
            const string diffSelectMSG = "Selecciona una dificultad\n1.Fácil\n2.Difícil\n3.Personalizada\n4.Aleatoria";
            const string mainMenuFail = "Valor invalido, introduce un valor valido.";
            const string letsGoCreate = "Vamos a personalizar a los personajes";
            const string introduceHP = "Introduce su vida [{0}-{1}]";
            const string introduceDMG = "Introduce su daño [{0}-{1}]";
            const string introduceDMGRed = "Introduce su reducción de daño[{0}-{1}]";
            const string minValAssign = "3 fallos, valor mínimo asignado\n";
            const string daleSabor = "Estos heroes se ven fuertes, pero les falta un poco de personalidad\nDales unos nombres.\n\n" +
                "(El formato para los nombres es el siguiente: 'nombre, nombre, nombre, nombre' sin comillas, separados por comas,\n y en orden Arquera, Barbaro, Mago, Druida, para que el juego los detecte bien)";

            const string preBattleStatsDisplay = "{0}\nVida: {1}\nDaño: {2}\nReducción de daño: {3}%";
            const string turnOf = "Turno de {0}: \n";
            const string actionsMenu = "\n\n¿Que hará?\n1.Atacar al enemigo\n2.Defenderse\n3.Habilidad especial\n4.Pasar turno.";
            const string actionTriesFail = "Has fallado 3 veces en introducir una acción valida, pasas el turno automáticamente";

            const string action1MSG = "Haces {0} puntos de daño a {1}\nVida restante de {1}: {2}";
            const string action2MSG = "Te defiendes y aumentas tu reducción de daño el siguiente turno!";
            const string archerSpecial = "¡Flecha mágica!\nHas aturdido al monstruo y no podrá atacar los siguiente 2 turnos";
            const string barbarianSpecial = "¡¡¡RRRAAAAAHHHH!!!\n¡Te has enfadado un montón y te has vuelto invulnerable al daño por 2 turnos!";
            const string mageSpecial = "¡Bola de fuego!\nTu super hechizo ha dañado a {0} y pierde {1} puntos de vida";
            const string druidSpecial = "¡El abrazo de la naturaleza!\n¡Has curado a tus compañeros!";
            const string healMSG = "Vida actual de {0}: {1}HP/{2}HP";
            const string action4MSG = "Pasas el turno.";

            const string enemyAtk = "{0} ataca a tu equipo.\n";
            const string partyStatus = "{0} recibe {1} puntos de daño. Vida: {2}/{3}HP";
            const string barbarianRage = "{0} está enfurecido y no recibe daño";
            const string monsterStaggerMSG = "{0} está aturdido y no puede atacar";

            const string specialCD = "Tu habilidad especial se está recargando. {0} turnos restantes";
            const string isDead = "A {0} no le quedan puntos de vida. No puede atacar";

            const string winMSG = "Has derrotado a {0}, esta noche la taverna estará alegre por ello.\n¿Quieres jugar de nuevo?\n1.Iniciar nueva batalla\n2.Salir";
            const string loseMSG = "Todos los heroes han muerto, la taverna está de luto.\n¿Quieres jugar de nuevo?\n1.Iniciar nueva batalla\n2.Salir";



            int mainMenuSelect = 0;
            int dificultySelect = 0;
            int actionSelection = 0;

            int actionTries = 0;
            int attTries = 0;
            int statInput = 0;
            bool statCheck = false;

            string heroesNames;
            string[] namesArray = new string[4];

            string[] monsterNames = {"Nagito, el titiritero", "Gorlock, el destructor", "El devoramundos", "Titán Speakerman"};
            string monsterName = monsterNames[heroesContraMonstruoClass.randomNumberGenerator(0, 2)];

            int damageDealt = 0;

            //stats arquera
            int archerHP = 0;
            int actualArcherHP = 0;
            int archerDamage = 0;
            int archerDamageReduction = 0;
            int archerSkillCD = 0;
            bool archerDefending = false;

            int maxArchHP = 2000;
            int minArchHP = 1500;

            int maxArchDamage = 300;
            int minArchDamage = 200;

            int maxArchDamageReduction = 35;
            int minArchDamageReduction = 25;

            //stats barbaro
            int barbarianHP = 0;
            int actualBarbarianHP = 0;
            int barbarianDamage = 0;
            int barbarianDamageReduction = 0;
            int barbarianSkillCD = 0;
            int barbarianSkillTurns = 0;
            bool barbarianDefending = false;

            int maxBarbHP = 3750;
            int minBarbHP = 3000;

            int maxBarbDamage = 250;
            int minBarbDamage = 150;

            int maxBarbDamageReduction = 45;
            int minBarbDamageReduction = 35;

            //stats maga
            int mageHP = 0;
            int actualMageHP = 0;
            int mageDamage = 0;
            int mageDamageReduction = 0;
            int mageSkillCD = 0;
            bool mageDefending = false;

            int maxMageHP = 1500;
            int minMageHP = 1100;

            int maxMageDamage = 400;
            int minMageDamage = 300;

            int maxMageDamageReduction = 35;
            int minMageDamageReduction = 20;

            //stats druida
            int druidHP = 0;
            int actualDruidHP = 0;
            int druidDamage = 0;
            int druidDamageReduction = 0;
            int druidSkillCD = 0;
            bool druidDefending = false;

            int maxDruiHP = 2500;
            int minDruiHP = 2000;

            int maxDruiDamage = 120;
            int minDruiDamage = 70;

            int maxDruiDamageReduction = 40;
            int minDruiDamageReduction = 25;

            //stats monstruo
            int monsterHP = 0;
            int monsterDamage = 0;
            int monsterDamageReduction = 0;
            int monsterCheck = 0;
            int monsterStagger = 0;

            int maxMonsHP = 10000;
            int minMonsHP = 7000;

            int maxMonsDamage = 400;
            int minMonsDamage = 300;

            int maxMonsDamageReduction = 30;
            int minMonsDamageReduction = 20;

            Console.WriteLine(welcomeMSG);
            Console.WriteLine(pressToCont);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(mainMenu);
            while (mainMenuSelect != 2) {
                while (mainMenuSelect<1 || mainMenuSelect > 2)
                {
                    mainMenuSelect = Convert.ToInt32(Console.ReadLine());
                    if (mainMenuSelect == 2) { 
                        Console.WriteLine(thxForPlay);
                    } else
                    {
                        Console.WriteLine(mainMenuFail);
                    }
                }

                Console.Clear();

                if (mainMenuSelect == 1)
                {
                    //seleccion de dificultad y creacion de personajes
                    Console.WriteLine(diffSelectMSG);
                    while (dificultySelect < 1 || dificultySelect > 4)
                    {
                        dificultySelect = Convert.ToInt32(Console.ReadLine());
                        if (dificultySelect == 1)
                        {
                            archerHP = 2000;
                            actualArcherHP = archerHP;
                            archerDamage = 300;
                            archerDamageReduction = 35;

                            barbarianHP = 3750;
                            actualBarbarianHP = barbarianHP;
                            barbarianDamage = 250;
                            barbarianDamageReduction = 45;

                            mageHP = 1500;
                            actualMageHP = mageHP;
                            mageDamage = 400;
                            mageDamageReduction = 35;


                            druidHP = 2500;
                            actualDruidHP = druidHP;
                            druidDamage = 120;
                            druidDamageReduction = 40;

                            monsterHP = 7000;
                            monsterDamage = 300;
                            monsterDamageReduction = 20;
                        }
                        else if (dificultySelect == 2)
                        {
                            archerHP = 1500;
                            actualArcherHP = archerHP;
                            archerDamage = 200;
                            archerDamageReduction = 25;

                            barbarianHP = 3000;
                            actualBarbarianHP = barbarianHP;
                            barbarianDamage = 150;
                            barbarianDamageReduction = 35;

                            mageHP = 1100;
                            actualMageHP = mageHP;
                            mageDamage = 300;
                            mageDamageReduction = 20;


                            druidHP = 2000;
                            actualDruidHP = druidHP;
                            druidDamage = 70;
                            druidDamageReduction = 25;

                            monsterHP = 10000;
                            monsterDamage = 400;
                            monsterDamageReduction = 30;
                        }
                        else if (dificultySelect == 3)
                        {
                            //creación de la arquera
                            Console.Clear();
                            Console.WriteLine("Vamos a crear a la arquera");

                            Console.WriteLine(introduceHP, minArchHP, maxArchHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minArchHP, maxArchHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    archerHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                archerHP = minArchHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minArchDamage, maxArchDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minArchDamage, maxArchDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    archerDamage = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                archerDamage = minArchDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minArchDamageReduction, maxArchDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minArchDamageReduction, maxArchDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    archerDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                archerDamage = minArchDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();


                            //Creación del barbaro
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos al barbaro");

                            Console.WriteLine(introduceHP, minBarbHP, maxBarbHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minBarbHP, maxBarbHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    barbarianHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                barbarianHP = minBarbHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minBarbDamage, maxBarbDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minBarbDamage, maxBarbDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    barbarianHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                barbarianDamage = minBarbDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minBarbDamageReduction, maxBarbDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minBarbDamageReduction, maxBarbDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    barbarianDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                barbarianDamageReduction = minBarbDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();

                            //Creación de la maga
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos a la maga");

                            Console.WriteLine(introduceHP, minMageHP, maxMageHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMageHP, maxMageHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    mageHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                mageHP = minMageHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minMageDamage, maxMageDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMageDamage, maxMageDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    mageHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                mageDamage = minMageDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minMageDamageReduction, maxMageDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMageDamageReduction, maxMageDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    mageDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                mageDamageReduction = minMageDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();

                            //Creación del druida
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos al druida");

                            Console.WriteLine(introduceHP, minDruiHP, maxDruiHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minDruiHP, maxDruiHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    druidHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                druidHP = minDruiHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minDruiDamage, maxDruiDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minDruiDamage, maxDruiDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    druidHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                druidDamage = minDruiDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minDruiDamageReduction, maxDruiDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minDruiDamageReduction, maxDruiDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    druidDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                druidDamageReduction = minDruiDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();

                            //Creación del monstruo
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos al monstruo");

                            Console.WriteLine(introduceHP, minMonsHP, maxMonsHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMonsHP, maxMonsHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    monsterHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                monsterHP = minMonsHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minMonsDamage, maxMonsDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMonsDamage, maxMonsDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    monsterDamage = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                monsterDamage = minMonsDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minMonsDamageReduction, maxMonsDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMonsDamageReduction, maxMonsDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    monsterDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                monsterDamageReduction = minMonsDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();
                        }
                        else if (dificultySelect == 4)
                        {
                            archerHP = heroesContraMonstruoClass.randomNumberGenerator(minArchHP, maxArchHP);
                            actualArcherHP = archerHP;
                            archerDamage = heroesContraMonstruoClass.randomNumberGenerator(minArchDamage, maxArchDamage);
                            archerDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minArchDamageReduction, maxArchDamageReduction);

                            barbarianHP = heroesContraMonstruoClass.randomNumberGenerator(minBarbHP, maxBarbHP);
                            actualBarbarianHP = barbarianHP;
                            barbarianDamage = heroesContraMonstruoClass.randomNumberGenerator(minBarbDamage, maxBarbDamage);
                            barbarianDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minBarbDamageReduction, maxBarbDamageReduction);

                            mageHP = heroesContraMonstruoClass.randomNumberGenerator(minMageHP, maxMageHP);
                            actualMageHP = mageHP;
                            mageDamage = heroesContraMonstruoClass.randomNumberGenerator(minMageDamage, maxMageDamage);
                            mageDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minMageDamageReduction, maxMageDamageReduction);


                            druidHP = heroesContraMonstruoClass.randomNumberGenerator(minDruiHP, maxDruiHP);
                            actualDruidHP = druidHP;
                            druidDamage = heroesContraMonstruoClass.randomNumberGenerator(minDruiDamage, maxDruiDamage);
                            druidDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minDruiDamageReduction, maxDruiDamageReduction);

                            monsterHP = heroesContraMonstruoClass.randomNumberGenerator(minMonsHP, maxMonsHP);
                            monsterDamage = heroesContraMonstruoClass.randomNumberGenerator(minMonsDamage, maxMonsDamage);
                            monsterDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minMonsDamageReduction, maxMonsDamageReduction);
                        }
                        else
                        {
                            Console.WriteLine(mainMenuFail);
                        }
                    }
                    dificultySelect = 0;

                    //Revisión de stats y selección de nombres
                    Console.Clear();
                    Console.WriteLine(daleSabor);
                    heroesNames = Console.ReadLine();
                    namesArray = heroesContraMonstruoClass.nameArrayGenerator(heroesNames);

                    Console.Clear();
                    Console.WriteLine("Arquera " + preBattleStatsDisplay, namesArray[0], archerHP, archerDamage, archerDamageReduction);
                    Console.WriteLine("\nBárbaro " + preBattleStatsDisplay, namesArray[1], barbarianHP, barbarianDamage, barbarianDamageReduction);
                    Console.WriteLine("\nMaga " + preBattleStatsDisplay, namesArray[2], mageHP, mageDamage, mageDamageReduction);
                    Console.WriteLine("\nDruida " + preBattleStatsDisplay, namesArray[3], druidHP, druidDamage, druidDamageReduction);

                    Console.WriteLine("\n\nTu enemigo: " + preBattleStatsDisplay, monsterName, monsterHP, monsterDamage, monsterDamageReduction);

                    Console.WriteLine("Pulsa cualquier tecla para iniciar la batalla");
                    Console.ReadKey();
                    Console.Clear();



                    //Turnos
                    do
                    {
                        //Turno Arquera
                        actionTries = 0;
                        actionSelection = 0;
                        if (monsterHP > 0)
                        {
                            if (actualArcherHP > 0)
                            {
                                while (actionSelection < 1 || actionSelection > 4)
                                {
                                    if (actionTries < 3)
                                    {
                                        Console.WriteLine(turnOf, namesArray[0] + actionsMenu);
                                        actionSelection = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine(actionTriesFail);
                                        actionSelection = 2;
                                    }
                                    switch (actionSelection)
                                    {
                                        case 1:
                                            damageDealt = heroesContraMonstruoClass.damageCalculator(archerDamage, monsterDamageReduction);
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(action1MSG, damageDealt, monsterName, monsterHP);
                                            break;
                                        case 2:
                                            Console.WriteLine(action2MSG);
                                            archerDefending = true;
                                            break;
                                        case 3:
                                            if (archerSkillCD > 5)
                                            {
                                                Console.WriteLine(specialCD, archerSkillCD);
                                                actionSelection = 0;
                                            }
                                            else
                                            {
                                                Console.WriteLine(archerSpecial);
                                                monsterStagger = 2;
                                                archerSkillCD = 5;
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine(action4MSG);
                                            break;
                                        default:
                                            Console.WriteLine(mainMenuFail);
                                            actionTries++;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(isDead, namesArray[0]);
                            }
                            Console.WriteLine(pressToCont);
                            Console.ReadKey();
                        }
                        Console.Clear();

                        //Turno barbaro
                        actionTries = 0;
                        actionSelection = 0;
                        if (monsterHP > 0)
                        {
                            if (actualBarbarianHP > 0)
                            {
                                while (actionSelection < 1 || actionSelection > 4)
                                {
                                    if (actionTries < 3)
                                    {
                                        Console.WriteLine(turnOf, namesArray[1] + actionsMenu);
                                        actionSelection = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine(actionTriesFail);
                                        actionSelection = 4;
                                    }
                                    switch (actionSelection)
                                    {
                                        case 1:
                                            damageDealt = heroesContraMonstruoClass.damageCalculator(barbarianDamage, monsterDamageReduction);
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(action1MSG, damageDealt, monsterName, monsterHP);
                                            break;
                                        case 2:
                                            Console.WriteLine(action2MSG);
                                            barbarianDefending = true;
                                            break;
                                        case 3:
                                            if (archerSkillCD > 5)
                                            {
                                                Console.WriteLine(specialCD, barbarianSkillCD);
                                                actionSelection = 0;
                                            }
                                            else
                                            {
                                                Console.WriteLine(barbarianSpecial);
                                                barbarianSkillTurns = 2;
                                                barbarianSkillCD = 5;
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine(action4MSG);
                                            break;
                                        default:
                                            Console.WriteLine(mainMenuFail);
                                            actionTries++;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(isDead, namesArray[1]);
                            }
                            Console.WriteLine(pressToCont);
                            Console.ReadKey();
                        }
                        Console.Clear();

                        //Turno maga
                        actionTries = 0;
                        actionSelection = 0;
                        if (monsterHP > 0)
                        {
                            if (actualMageHP > 0)
                            {
                                while (actionSelection < 1 || actionSelection > 4)
                                {
                                    if (actionTries < 3)
                                    {
                                        Console.WriteLine(turnOf, namesArray[2] + actionsMenu);
                                        actionSelection = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine(actionTriesFail);
                                        actionSelection = 4;
                                    }
                                    switch (actionSelection)
                                    {
                                        case 1:
                                            damageDealt = heroesContraMonstruoClass.damageCalculator(mageDamage, monsterDamageReduction);
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(action1MSG, damageDealt, monsterName, monsterHP);
                                            break;
                                        case 2:
                                            Console.WriteLine(action2MSG);
                                            mageDefending = true;
                                            break;
                                        case 3:
                                            if (mageSkillCD > 5)
                                            {
                                                Console.WriteLine(specialCD, archerSkillCD);
                                                actionSelection = 0;
                                            }
                                            else
                                            {
                                                damageDealt = heroesContraMonstruoClass.damageCalculator((mageDamage * 3), monsterDamageReduction);
                                                Console.WriteLine(mageSpecial, monsterName, damageDealt);
                                                monsterHP -= damageDealt;
                                                mageSkillCD = 5;
                                                
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine(action4MSG);
                                            break;
                                        default:
                                            Console.WriteLine(mainMenuFail);
                                            actionTries++;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(isDead, namesArray[2]);
                            }
                            Console.WriteLine(pressToCont);
                            Console.ReadKey();
                        }
                        Console.Clear();

                        //Turno Druida
                        actionTries = 0;
                        actionSelection = 0;
                        if (monsterHP > 0)
                        {
                            if (actualDruidHP > 0)
                            {
                                while (actionSelection < 1 || actionSelection > 4)
                                {
                                    if (actionTries < 3)
                                    {
                                        Console.WriteLine(turnOf, namesArray[3] + actionsMenu);
                                        actionSelection = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else
                                    {
                                        Console.WriteLine(actionTriesFail);
                                        actionSelection = 4;
                                    }
                                    switch (actionSelection)
                                    {
                                        case 1:
                                            damageDealt = heroesContraMonstruoClass.damageCalculator(druidDamage, monsterDamageReduction);
                                            monsterHP -= damageDealt;
                                            Console.WriteLine(action1MSG, damageDealt, monsterName, monsterHP);
                                            break;
                                        case 2:
                                            Console.WriteLine(action2MSG);
                                            mageDefending = true;
                                            break;
                                        case 3:
                                            if (archerSkillCD > 5)
                                            {
                                                Console.WriteLine(specialCD, druidSkillCD);
                                                actionSelection = 0;
                                            }
                                            else
                                            {
                                                Console.WriteLine(druidSpecial);
                                                if (actualArcherHP > 0)
                                                {
                                                    actualArcherHP = heroesContraMonstruoClass.druidHealing(actualArcherHP, archerHP);
                                                    Console.WriteLine(healMSG, namesArray[0], actualArcherHP, archerHP);
                                                }
                                                if (actualBarbarianHP > 0)
                                                {
                                                    actualBarbarianHP = heroesContraMonstruoClass.druidHealing(actualBarbarianHP, barbarianHP);
                                                    Console.WriteLine(healMSG, namesArray[1], actualBarbarianHP, barbarianHP);
                                                }
                                                if (actualMageHP > 0)
                                                {
                                                    actualMageHP = heroesContraMonstruoClass.druidHealing(actualMageHP, mageHP);
                                                    Console.WriteLine(healMSG, namesArray[2], actualMageHP, mageHP);
                                                }
                                                if (actualDruidHP > 0)
                                                {
                                                    actualDruidHP = heroesContraMonstruoClass.druidHealing(actualDruidHP, druidHP);
                                                    Console.WriteLine(healMSG, namesArray[3], actualDruidHP, druidHP);
                                                }
                                                druidSkillCD = 5;
                                            }
                                            break;
                                        case 4:
                                            Console.WriteLine(action4MSG);
                                            break;
                                        default:
                                            Console.WriteLine(mainMenuFail);
                                            actionTries++;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine(isDead, namesArray[3]);
                            }
                            Console.WriteLine(pressToCont);
                            Console.ReadKey();
                        }
                        Console.Clear();
                        
                        //Turno Monstruo
                        if (monsterHP > 0)
                        {
                            
                            if (monsterStagger == 0)
                            {
                                
                                //Ataque a la arquera
                                Console.WriteLine(enemyAtk, monsterName);
                                damageDealt = heroesContraMonstruoClass.damageCalculator(monsterDamage, archerDamageReduction, archerDefending);
                                actualArcherHP -= damageDealt;
                                Console.WriteLine(partyStatus, namesArray[0], damageDealt, actualArcherHP, archerHP);

                                //Ataque al barbaro
                                if (barbarianSkillTurns > 0)
                                {
                                    Console.WriteLine(barbarianRage, namesArray[1]);
                                    barbarianSkillTurns--;
                                }
                                else
                                {
                                    damageDealt = heroesContraMonstruoClass.damageCalculator(monsterDamage, barbarianDamageReduction, barbarianDefending);
                                    actualBarbarianHP -= damageDealt;
                                    Console.WriteLine(partyStatus, namesArray[1], damageDealt, actualBarbarianHP, barbarianHP);
                                }

                                //Ataque a la maga
                                damageDealt = heroesContraMonstruoClass.damageCalculator(monsterDamage, mageDamageReduction, mageDefending);
                                actualMageHP -= damageDealt;
                                Console.WriteLine(partyStatus, namesArray[2], damageDealt, actualMageHP, mageHP);

                                //Ataque al druida
                                damageDealt = heroesContraMonstruoClass.damageCalculator(monsterDamage, druidDamageReduction, druidDefending);
                                actualDruidHP -= damageDealt;
                                Console.WriteLine(partyStatus, namesArray[3], damageDealt, actualDruidHP, druidHP);
                            }
                            else
                            {
                                Console.WriteLine(monsterStaggerMSG, monsterName);
                                monsterStagger--;
                            }

                            
                            archerSkillCD--;
                            barbarianSkillCD--;
                            mageSkillCD--;
                            druidSkillCD--;

                            Console.WriteLine(pressToCont);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        
                    } while (monsterHP>0 && (actualArcherHP > 1 || actualBarbarianHP > 1 || actualMageHP > 1 || actualDruidHP > 1));
                    
                    if (monsterHP < 1)
                    {
                        Console.WriteLine(winMSG, monsterName);
                        mainMenuSelect = Convert.ToInt32(Console.ReadLine());
                    } else
                    {
                        Console.WriteLine(loseMSG);
                        mainMenuSelect = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}
