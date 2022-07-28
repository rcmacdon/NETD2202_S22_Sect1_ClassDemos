 /* Trooper Class File Definition
 * Author: Clint MacDonald
 * Date: June 27, 2022
 */

#region USING statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
#endregion

namespace _01Week11_FileIO
{
    class Trooper
    {

        #region Global Variables
        public static List<Trooper> troopers = new List<Trooper>();
        private static int nextID = 1;
        #endregion

        #region Properties
        public int Designation { get; set; }
        public String NickName { get; set; }
        public String HomeWorld { get; set; }
        public DateTime Born { get; set; }
        public String Unit { get; set; }
        public Boolean IsDefective { get; set; }
        public Color HairColor { get; set; }
        public Color EyeColor { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor - using autoincrement designation
        /// </summary>
        public Trooper() 
        {
            Designation = nextID++;

            SetDefaults();
        }

        /// <summary>
        /// Parameterize Constructor - using autoincrement Designation
        /// </summary>
        /// <param name="nickName">The name that the trooper responds to when communicating</param>
        /// <param name="homeWorld">The world the Trooper was BORN on.</param>
        /// <param name="born">Date of Birth</param>
        /// <param name="unit"></param>
        /// <param name="isDefective"></param>
        /// <param name="hairColor"></param>
        /// <param name="eyeColor"></param>
        public Trooper(String nickName, String homeWorld, DateTime born, String unit,
                        Boolean isDefective, Color hairColor, Color eyeColor)
        {
            Designation = nextID++;

            NickName = nickName;
            HomeWorld = homeWorld;
            Born = born;
            Unit = unit;
            IsDefective = isDefective;
            HairColor = hairColor;
            EyeColor = eyeColor;
        }
        #endregion

        #region Custom Methods

        #region Instance Methods
        /// <summary>
        /// Sets the default values for all properties except the designation
        /// </summary>
        private void SetDefaults()
        {
            NickName = string.Empty;
            HomeWorld = string.Empty;
            Born = DateTime.Today;
            Unit = string.Empty;
            IsDefective = false;
            HairColor = Color.Gray;
            EyeColor = Color.Gray;
        }

        public void ChangeUnit(string newUnit)
        {
            Unit = newUnit;
        }

        #endregion

        #region Static Methods

        public static List<Trooper> GetSampleTroopers()
        {
            List<Trooper> returnList = new List<Trooper>();

            returnList.Add(new Trooper("Clint", "Tatooine", new DateTime(1972, 05, 16), "Blue", false,
                        Color.Brown, Color.Brown));
            returnList.Add(new Trooper("Rex", "Endor", new DateTime(2062, 08, 11), "Red", false,
                        Color.Black, Color.Blue));
            returnList.Add(new Trooper("Ugly", "Hoth", new DateTime(2053, 11, 22), "Blue", true,
                                    Color.Yellow, Color.Red)); ;

            return returnList;
        }

        public static void ChangeUnit(int designation, string newUnit)
        {
            Trooper troop = FindTrooper(designation);
            troop.Unit = newUnit;
        }

        public static Trooper FindTrooper(int designation)
        {
            return troopers.Find(t => t.Designation == designation);

            //Trooper foundTrooper = null;

            //foreach (Trooper t in troopers)
            //{
            //    if (t.Designation == designation)
            //    {
            //        return t;
            //    }
            //}

            //return foundTrooper;
        }

        public static List<String> GetUniqueUnits()
        {
            List<String> returnList = new List<String>();

            foreach (Trooper t in troopers)
            { 
                if (!returnList.Contains(t.Unit)) returnList.Add(t.Unit); 
            }

            return returnList;
        }

        public static Boolean TrooperExists(int designation)
        {
            return troopers.FindAll(t => t.Designation == designation).Count > 0;
        }

        public static void SaveTroopers(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(ConvertTroopersToCSV());
            sw.Close();
            fs.Close();
        }

        public static void LoadFromCSV(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            String linecontent = string.Empty;
            String[] items = new string[8];
            String[] dateItems = new string[2];
            Trooper t;

            while (!sr.EndOfStream)
            {
                try
                {
                    linecontent = sr.ReadLine();
                    items = linecontent.Split(",");
                    t = new Trooper();
                    t.Designation = Convert.ToInt32(items[0]);
                    t.NickName = items[1];
                    t.Unit = items[2];
                    //date
                    dateItems = items[3].Split("-");
                    t.Born = new DateTime(Convert.ToInt32(dateItems[0]),
                                          Convert.ToInt32(dateItems[1]),
                                          Convert.ToInt32(dateItems[2]));
                    t.HomeWorld = items[4];
                    t.IsDefective = Convert.ToBoolean(items[5]);
                    t.HairColor = ConvertStringToColour(items[6]);
                    t.EyeColor = ConvertStringToColour(items[7]);
                    // add to list of troopers
                    troopers.Add(t);
                }
                catch { }
            }




        }

        public static string ConvertTroopersToCSV()
        {
            string retVal = string.Empty;

            foreach (Trooper t in troopers)
            {
                retVal += t.Designation.ToString() + ","
                    + t.NickName + ","
                    + t.Unit + ","
                    + t.Born.ToString().Substring(0, 10) + ","
                    + t.HomeWorld + ","
                    + t.IsDefective + ","
                    + ConvertColourToString(t.HairColor) + ","
                    + ConvertColourToString(t.EyeColor) + "\n";
            }

            return retVal;
        }

        private static String ConvertColourToString(Color clr)
        {
            return clr.ToString()
                .Replace("Color [", "")
                .Replace("]", "")
                .Replace(" ", "")
                .Replace("A=", "")
                .Replace("R=", "")
                .Replace("G=", "")
                .Replace("B=", "")
                .Replace(",", ";");
        }

        private static Color ConvertStringToColour(String str)
        {
            Color rc;

            if (str.Contains(";"))  // RGB color
            {
                string[] items = new string[3];
                items = str.Split(";");
                rc = Color.FromArgb(Convert.ToInt32(items[0]),
                                     Convert.ToInt32(items[1]),
                                     Convert.ToInt32(items[2]),
                                     Convert.ToInt32(items[3]));
            } else  // named color
            {
                rc = Color.FromName(str);
            }

            return rc;
        }
        #endregion

        #endregion
    }
}
