//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValuPat
{
    using System;
    using System.Collections.Generic;

    public partial class C00_P04_Responsabile
    {
        public int ID_Responsabile { get; set; }

        public Nullable<int> IDDPO { get; set; }
        public virtual List<C00_P01_DPO> DPO {get; set;}

        public Nullable<int> IDTitolare { get; set; }
        public virtual List<C00_P02_Titolare> Titolare { get; set; }

        public string User1 { get; set; }
        public string Password1 { get; set; }
        public string TipoAzienda { get; set; }
        public string RagioneSociale { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string RSL_Comune { get; set; }
        public string RSL_Provincia { get; set; }
        public string RSL_Indirizzo { get; set; }
        public string RSL_CAP { get; set; }
        public string DF_Comune { get; set; }
        public string DF_Provincia { get; set; }
        public string DF_Indirizzo { get; set; }
        public string DF_CAP { get; set; }
        public string CodiceFiscale { get; set; }
        public string PIVA { get; set; }
        public string TelFisso { get; set; }
        public string Cellulare { get; set; }
        public string Email { get; set; }
        public string PEC { get; set; }
        public string RL_Cognome { get; set; }
        public string RL_Nome { get; set; }
        public string RL_CodiceFiscale { get; set; }
        public string RL_Comune { get; set; }
        public string RL_Provincia { get; set; }
        public string RL_Indirizzo { get; set; }
        public string RL_CAP { get; set; }
        public string RL_TelFisso { get; set; }
        public string RL_Cellulare { get; set; }
        public string RL_Email { get; set; }
        public string RL_PEC { get; set; }
        public Nullable<System.DateTime> DataInizio { get; set; }
        public Nullable<System.DateTime> DataFine { get; set; }
        public Nullable<bool> Archivio { get; set; }
    }
}
