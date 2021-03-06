/* Name: Clint MacDonald
 * Date: June 13, 2022
 * Title: Droid Class
 * Purpose: NETD2202 - Week 7 Demo 1
 */

#region Using Statements 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion

namespace _01Week7Demo1_DroidClass
{
    /// <summary>
    /// A class object representing Driods from the Star Wars universe.
    /// </summary>
    class Droid
    {
        #region GlobalVars
        public const int MinDesignationLength = 3;
        public const int MaxDesignationLength = 8;
        public const int MinOwnerLength = 5;
        #endregion

        #region Properties
        // commenting out as this is the LONG WAY
        //private string designation;
        //public string Designation
        //{
        //    get 
        //    {
        //        return designation;
        //    }
        //    set 
        //    {
        //        designation = value;
        //    }
        //}

        public string Designation { get; set; }
        public bool IsInService { get; set; }
        public string Owner { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        #endregion

        #region  Constructors
        public Droid()
        {
            Designation = string.Empty;
            Owner = string.Empty;
            PrimaryColor = Color.Gray;
            SecondaryColor = Color.Gray;
            IsInService = false;
        }
        public Droid(string designation, string owner, bool isInService, Color primaryColor, Color secondaryColor)
        {
            Designation = designation;
            Owner = owner;
            IsInService = isInService;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion

        #region Custom Methods
        public void SellDroid(string owner, bool isInService)
        {
            Owner = owner;
            IsInService = isInService;
        }
        #endregion

        #region Static Methods
        public static Droid FindDroid(string designation)
        {
            Droid returnDroid;


            return returnDroid;
        }
        #endregion

    }
}
