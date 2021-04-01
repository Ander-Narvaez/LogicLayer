﻿using System;
using System.Data;
using System.Web.Services;

namespace LogicLayer
{
 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
  
    public class WebService : System.Web.Services.WebService
    {

        DataLayer.Class.ClsEmpresa vEmpresa = new DataLayer.Class.ClsEmpresa();
        [WebMethod]
        public string MaintenanceEmpresa(string pID_COMPAÑIA, String pNOMBRE, String pUBICACION, String pEMAIL, String pTELEFONO, String pACCION)
        {
            this.vEmpresa.aID_COMPAÑIA = pID_COMPAÑIA;
            this.vEmpresa.aNOMBRE = pNOMBRE;
            this.vEmpresa.aUBICACION = pUBICACION;
            this.vEmpresa.aEMAIL = pEMAIL;
            this.vEmpresa.aTELEFONO = pTELEFONO;

            return vEmpresa.MaintenanceEmpresa(vEmpresa, pACCION);
        }
        [WebMethod]
        public DataSet GetListEmpresa(string pID_COMPAÑIA, String pNOMBRE, String pUBICACION, String pEMAIL, String pTELEFONO, String pACCION)
        {
            this.vEmpresa.aID_COMPAÑIA = pID_COMPAÑIA;
            this.vEmpresa.aNOMBRE = pNOMBRE;
            this.vEmpresa.aUBICACION = pUBICACION;
            this.vEmpresa.aEMAIL = pEMAIL;
            this.vEmpresa.aTELEFONO = pTELEFONO;

            return vEmpresa.GetListEmpresa(vEmpresa, pACCION);
        }
    }
}
