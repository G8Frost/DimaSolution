using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Game
{
    class Location
    {
        public List<Location> Locations;
        public string Name;
        public string Description;
        public People NPC;
        public Monster Monster;
        public Chest Loot;
        public Quest Quest { get; set; }

        public Action<Player> Action { get; set; }

        public Action<Player> SelectLocation { get; set; }
    }

    abstract class People
    {
        public string Name;
        public Quest Quest;

        public abstract void Dialogue( Player peasant );

    }

    class Peasant : People
    {
        public override void Dialogue( Player peasant )
        {
            Console.WriteLine( "  Крестьянин: Ты же слышыл легенду про избранного? Интересно, кто это может быть?" );
            Console.Write(
                "  1)Мне-то какая разница? Главное, что не я. И от этого мне не лучше. Пусть я и не избранный, но эти твари похитили моего сына и убили мою жену. И я буду мстить. 2)Хорошо бы узнать. Я, конечно, надеюсь, что я. Но, это маловероятно. Однако, отомстить придётся в любом случае. (Выберите ответ): " );
            String answer = Console.ReadLine();
            switch ( answer )
            {
                case "1":
                    peasant.Karma--;
                    Console.WriteLine(
                        "  Крестьянин: А ты оказывается эгоист, не ожидал я такого. (Начислена отрицательная карма) " +
                        peasant.Karma );
                    break;
                case "2":
                    peasant.Karma++;
                    Console.WriteLine(
                        "  Крестьянин: Вот я так же думаю. А насчёт вероятности... А, чёрт его знает! (Начислена положительная карма) " +
                        peasant.Karma );
                    break;
            }
            Console.WriteLine(
                "  Крестьянин: А ты в армию идти не планируешь? Ах, забыл, у нас никто не хочет в армию. И ты в том числе. Ну, бывай." );
        }

    }

    class Steward : People
    {
        public override void Dialogue(Player peasant)
        {
            Console.Write(
               "  Вальтер(Сюжетный квест!): Эй! Ты ведь из Дримфолла, верно? Ах, ну да. Я староста этой деревни, Вальтер. Наши разведчики доложили, что к нам идёт кто-то из дримфола. 1)Разведчики? Как тут у вас всё серьёзно. 2)Разведчики?! Какого чёрта?! Вы следили за мной?! (Выберите ответ): " );
            String answer4 = Console.ReadLine();
            switch ( answer4 )
            {
                case "1":
                    peasant.Karma++;
                    Console.WriteLine(
                        "  Вальтер(Сюжетный квест!): Хех, ещё как серьёзно. Шпионы следят в основном за демонами, однако докладывают обо всём, что видят или слышат. (Начислена положительная карма) " +
                        peasant.Karma );
                    break;
                case "2":
                    peasant.Karma--;
                    Console.WriteLine(
                        "  Вальтер(Сюжетный квест!): Шпионы обязаны докладывать мне обо всём, что видят. И я бы не советовал тебе хамить мне и повышать на меня голос. Ты в моей деревне, парниша. (Начислена отрицательная карма) " +
                        peasant.Karma );
                    break;
            }
            Console.WriteLine( "  Вальтер(Сюжетный квест!): Итак, что привело тебя ко мне в деревню?" );
            Console.WriteLine(
                "  Я хочу уничтожить главного демона. Он убил мою жену и зачем-то похитил сына, говоря про какой-то ритуал. Ты не знаешь, где их... логово?" );
            Console.WriteLine(
                "  Вальтер(Сюжетный квест!): Давай договоримся. Скажем, услуга за услугу. Доберись до Пещер Смерти, что в горах Орбах. Там обитает демон. Демон-Принц, если быть точнее. Он и его прихвостни уже давно досаждают нам. Именно из-за них появились шпионы. Убей его для нас, а я дам тебе наводку. Идёт? 1)Только ради семьи. Шантажист хренов. 2)Идёт. (Выберите ответ): " );
            String answer5 = Console.ReadLine();
            switch ( answer5 )
            {
                case "1":
                    peasant.Karma--;
                    Console.WriteLine(
                        "  Вальтер(Сюжетный квест!): Иди уже. И что б не возвращался, пока эта тварь не сдохнет. Или пока не сдохнешь ты. (Начислена отрицательная карма) " +
                        peasant.Karma );
                    break;
                case "2":
                    peasant.Karma++;
                    Console.WriteLine(
                        "  Вальтер(Сюжетный квест!): Ну, в добрый путь. Удачи. Только пока не убьёшь тварь, не возвращайся. (Начислена положительная карма) " +
                        peasant.Karma );
                    break;
            }
        }
    }

    class Human : People
    {
        public override void Dialogue( Player peasant )
        {

        }
    }


    class LocationFactory
    {
        /// <summary>
        /// Дримфолл.
        /// </summary>
        /// <returns></returns>
        public Location CreateDreamfallLocation()
        {
            Location DreamfallLocation = new Location();

            DreamfallLocation.Name = "  Локация: Дримфолл";
            DreamfallLocation.Description = "(Столица одноимённого королевства)";
            var Club = new Weapon();
            Club.Dmg = 5;

            DreamfallLocation.Loot = new Chest() { Weapon = Club };

            DreamfallLocation.NPC = new Peasant();

            DreamfallLocation.Action = player =>
            {
                Console.Write( "  1)Остаться в городе. 2)Выйти из города (Выберите вариант): " );
                String answer2 = Console.ReadLine();
                switch ( answer2 )
                {
                    case "1":
                        Console.WriteLine( "  Немного побродив по городу, вы нашли дубину и отправились в путь." );
                        player.CurrentWeapon = Club;
                        Console.WriteLine( " Текущий урон: " + player.SharedDmg );
                        break;
                    case "2":
                        Console.WriteLine( "  Вы отправились в путь.(Не терпится?)" );
                        Console.WriteLine( " Текущий урон: " + player.SharedDmg );
                        break;
                }
            };

            DreamfallLocation.SelectLocation = player =>
            {
                Console.Write(
                "  Вы слышите стоны и просьбы о помощи. С одной стороны, вам интересно, но с другой, инстинкт самосохранения подсказывает вам, что идти не стоит, так как там может быть засада. Как вы поступите? 1)Пойти. 2)Не идти. (Выберите вариант): " );
                String answer3 = Console.ReadLine();
                switch ( answer3 )
                {
                    case "1":
                        player.Karma = player.Karma + 3;
                        Console.WriteLine(
                            "  Стоны издавал сильно истерзанный, но всё ещё живой человек. Он попросил вас окончить его мучения. Взяв меч, вы окончили его мучения и положили ему в руку меч, следуя традиции. Вы вернулись обратно ко входу в Дримфол (Начислена положительная карма) " +
                            player.Karma );
                        Console.WriteLine(
                            "  Традиция: Если воин погиб с оружием в руках, в следующей жизни его вещи снова будут при нём. Поэтому, ни в коем случае нельзя забирать его меч, так как в следующей жизни вам могут неосознанно отомстить" );
                        break;
                    case "2":
                        player.Karma = player.Karma - 3;
                        Console.WriteLine(
                            "  Вы сделали вид, что не слышали. В этом сыграл роль инстинкт самосохранения. (Начислена отрицательная карма) " +
                            player.Karma );
                        break;
                }
            };

            DreamfallLocation.Quest = new Quest
            {
                Name = "  Новый квест: В путь!",
                Description = "(Ваше путешествие по Дримфолу начинается)",
            };

            DreamfallLocation.Locations = new List<Location> { CreateEnterToDreamfalLocation() };

            return DreamfallLocation;

        }
        /// <summary>
        /// Вход в Дримфолл.
        /// </summary>
        /// <returns></returns>
        public Location CreateEnterToDreamfalLocation()
        {
            Location EnterToDreamfal = new Location();

            EnterToDreamfal.Name = "  Локация: Вход в Дримфолл";
            EnterToDreamfal.Description = "";

            var loc2 = CreateFirstBattleLocation();
            var loc1 = CreatePlaceWithHumanLocation();

            EnterToDreamfal.Locations = new List<Location>() { loc1, loc2 };

            EnterToDreamfal.SelectLocation = player =>
            {
                Console.Write( "  Вы слышите стоны и просьбы о помощи. С одной стороны, вам интересно, но с другой, инстинкт самосохранения подсказывает вам, что идти не стоит, так как там может быть засада. Как вы поступите? 1)Пойти. 2)Не идти. (Выберите вариант): " );
                String answer3 = Console.ReadLine();
                switch ( answer3 )
                {
                    case "1":
                        player.Karma = player.Karma + 3;
                        player.CurrentLocation = loc1;
                        Console.WriteLine( "  Стоны издавал сильно истерзанный, но всё ещё живой человек. Он попросил вас окончить его мучения. Взяв меч, вы окончили его мучения и положили ему в руку меч, следуя традиции. Вы вернулись обратно ко входу в Дримфол (Начислена положительная карма) " + player.Karma );
                        Console.WriteLine( "  Традиция: Если воин погиб с оружием в руках, в следующей жизни его вещи снова будут при нём. Поэтому, ни в коем случае нельзя забирать его меч, так как в следующей жизни вам могут неосознанно отомстить" );
                        break;
                    case "2":
                        player.Karma = player.Karma - 3;
                        player.CurrentLocation = loc2;
                        Console.WriteLine( "  Вы сделали вид, что не слышали. В этом сыграл роль инстинкт самосохранения. (Начислена отрицательная карма) " + player.Karma );
                        break;
                }
            };



            return EnterToDreamfal;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Location CreatePlaceWithHumanLocation()
        {
            Location PlaceWithHuman = new Location();

            PlaceWithHuman.Name = "  Локация: Место с раненым человеком";
            PlaceWithHuman.Description = "";


            return PlaceWithHuman;

        }

        public Location CreateFirstBattleLocation()
        {
            var ChangedHuman = new Monster("", 30);
            ChangedHuman.Dmg = 3;
            ChangedHuman.Prot = 0;

            Location FirstBattle = new Location();

            FirstBattle.Name = "  Локация: Место первой битвы";
            FirstBattle.Description = "";

            FirstBattle.Action = player =>
            {
                Console.WriteLine( "  На пути на вас внезапно напал монстр. Защищайтесь!" );
                Program.PvE( player, ChangedHuman );
                player.EXP = player.EXP + 10;
                Console.WriteLine( "Вы получили 10 ед. опыта. Опыт: " + player.EXP );
            };

            return FirstBattle;

        }

        public Location CreateDivarication1Location()
        {
            Location Divarication1 = new Location();

            Divarication1.Name = "  Локация: Развилка(1)";
            Divarication1.Description = "";

            Divarication1.Action = player =>
            {
                var ChangedHuman = new Monster("", 30);
                ChangedHuman.Dmg = 3;
                ChangedHuman.Prot = 0;
                Console.Write( "  Вы нашли развилку. Выберите, куда пойти: 1)Налево. 2)Направо: " );
                String choice = Console.ReadLine();
                switch ( choice )
                {
                    case "1":
                        Console.WriteLine( "  Монстр! Защищайтесь!" );
                        Program.PvE( player, ChangedHuman );
                        player.EXP = player.EXP + 10;
                        Console.WriteLine( "Вы получили 10 ед. опыта. Опыт: " + player.EXP );
                        player.Karma = player.Karma + 3;
                        Console.WriteLine(
                            "  После победы над монстром из кустов вышла старая женщина, со своими детьми или внуками. Отблагодарив вас, она ушла. (Начислена положительная карма) " +
                            player.Karma );
                        Console.WriteLine( "  Вы вернулись назад." );
                        break;
                    case "2":
                        Console.WriteLine(
                            "  Пройдя пару шагов, вы услышали странные звуки, а затем крики о помощи. Вы молниеносно метнулись на помощь кричавшему. Путь вам преградил монстр." );
                        Program.PvE( player, ChangedHuman );
                        player.EXP = player.EXP + 10;
                        Console.WriteLine( "Вы получили 10 ед. опыта. Опыт: " + player.EXP );
                        player.Karma = player.Karma + 1;
                        Console.WriteLine(
                            "  Крестьянка: Вы спасли нас, спасибо. Чудище успело убить моего внука. Эх, бедный Димитр. Спасибо вам ещё раз. (Начислена положительная карма) " +
                            player.Karma );
                        Console.WriteLine( "  Вы вернулись назад к развилке." );
                        break;
                }
            };

            return Divarication1;

        }

        public Location CreateLakewoodLocation()
        {
            Location Lakewood = new Location();

            Lakewood.Name = "  Локация: Деревня Лэйквуд";
            Lakewood.Description = "(Деревня, которая была построена, чтобы защищать Королевство от монстров. Местный староста может знать что-то о местонахождении главного демона)";

            Lakewood.Quest = new Quest
            {
                Name = "  Новый квест: Услуга за услугу",
                Description = "(Староста попросил вас об услуге, а взамен пообещал помочь)"
            };



            return Lakewood;

        }

    }
}
