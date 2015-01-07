using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPSInventoryForPC
{
    public enum ChemState
    {
        SOLID,
        LIQUID,
        GAS,
    }
    public class Chemical
    {
        private readonly string _chemID {get;}
        private readonly string _chemName { get; }
        private readonly string _chemFormula { get; }
        private readonly ChemState _state { get; }

        private double currAmt { get; set; }
        private double alertAmt { get; set; }
        private double idealAmt { get; set; }
        private string whrToPurchase { get; set; }
        private string note { get; set; }
        

        /// <summary>
        /// the default constructor to create a new instance of chemical
        /// take all needed infomation to create a chemical, id, name, fomula, state, curramt, alertamt, idealamt, and note is optional
        /// </summary>
        /// <param name="chemid"></param>
        /// <param name="chemname"></param>
        /// <param name="chemformula"></param>
        /// <param name="steate"></param>
        /// <param name="curramt"></param>
        /// <param name="alertamt"></param>
        /// <param name="idealamt"></param>
        /// <param name="note"></param>
        //public Chemical (string chemid, string chemname, string chemformula, ChemState steate, double curramt, double alertamt, double idealamt, string note = "")
        //{
        //    this._chemID = chemid;
        //    this._chemName = chemname;
        //    this._chemFormula = chemformula;

        //}

        //private void initReadOnlyAttributes(string chemid, string chemname, string chemformula, ChemState steate, double curramt, double alertamt, out double idealamt, out string note = "")
        //{

        //}
    }
}
