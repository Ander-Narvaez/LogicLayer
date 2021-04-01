using System;
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
        public string MaintenanceEmpresa(string pEMPRESA, String pNOMBRE, String pUBICACION, String pEMAIL, String pTELEFONO, String pACCION)
        {
            this.vEmpresa.aEMPRESA = pEMPRESA;
            this.vEmpresa.aNOMBRE = pNOMBRE;
            this.vEmpresa.aUBICACION = pUBICACION;
            this.vEmpresa.aEMAIL = pEMAIL;
            this.vEmpresa.aTELEFONO = pTELEFONO;

            return vEmpresa.MaintenanceEmpresa(vEmpresa, pACCION);
        }
        [WebMethod]
        public DataSet GetListEmpresa(string pEMPRESA, String pNOMBRE, String pUBICACION, String pEMAIL, String pTELEFONO, String pACCION)
        {
            this.vEmpresa.aEMPRESA = pEMPRESA;
            this.vEmpresa.aNOMBRE = pNOMBRE;
            this.vEmpresa.aUBICACION = pUBICACION;
            this.vEmpresa.aEMAIL = pEMAIL;
            this.vEmpresa.aTELEFONO = pTELEFONO;

            return vEmpresa.GetListEmpresa(vEmpresa, pACCION);
        }

        DataLayer.Class.ClsArticulo vArticulo = new DataLayer.Class.ClsArticulo();
        [WebMethod]
        public string MaintenanceArticulo(string pARTICULO, String pCATEGORIA, Decimal pPRECIO, String pACCION)
        {
            this.vArticulo.aARTICULO = pARTICULO;
            this.vArticulo.aCATEGORIA = pCATEGORIA;
            this.vArticulo.aPRECIO = pPRECIO;

            return vArticulo.MaintenanceArticulo(vArticulo, pACCION);
        }
        [WebMethod]
        public DataSet GetListArticulo(string pARTICULO, String pCATEGORIA, Decimal pPRECIO, String pACCION)
        {
            this.vArticulo.aARTICULO = pARTICULO;
            this.vArticulo.aCATEGORIA = pCATEGORIA;
            this.vArticulo.aPRECIO = pPRECIO;

            return vArticulo.GetListArticulo(vArticulo, pACCION);
        }

        DataLayer.Class.ClsCategoria_articulo vCategoria_Articulo = new DataLayer.Class.ClsCategoria_articulo();
        [WebMethod]
        public string MaintenanceCategoria_Articulo(string pCODIGO, String pDESCRIPCION, Int32 pIMPUESTO, String pACCION)
        {
            this.vCategoria_Articulo.aCODIGO = pCODIGO;
            this.vCategoria_Articulo.aDESCRIPCION = pDESCRIPCION;
            this.vCategoria_Articulo.aIMPUESTO = pIMPUESTO;

            return vCategoria_Articulo.MaintenanceCategoria_articulo(vCategoria_Articulo, pACCION);
        }
        [WebMethod]
        public DataSet GetListCategoria_articulo(string pCODIGO, String pDESCRIPCION, Int32 pIMPUESTO, String pACCION)
        {
            this.vCategoria_Articulo.aCODIGO = pCODIGO;
            this.vCategoria_Articulo.aDESCRIPCION = pDESCRIPCION;
            this.vCategoria_Articulo.aIMPUESTO = pIMPUESTO;

            return vCategoria_Articulo.GetListCategoria_articulo(vCategoria_Articulo, pACCION);
        }

        DataLayer.Class.ClsArticulo_Inventario vArticulo_Inventario = new DataLayer.Class.ClsArticulo_Inventario();
        [WebMethod]
        public string MaintenanceArticulo_Inventario(string pEMPRESA, String pSUCURSAL, String pPROVEEDOR, int pINVENTARIO, String pARTICULO, int pMAXIMOS, int pMINIMOS, int pEXISTENCIAS, String pACCION)
        {
            this.vArticulo_Inventario.aEMPRESA = pEMPRESA;
            this.vArticulo_Inventario.aSUCURSAL = pSUCURSAL;
            this.vArticulo_Inventario.aPROVEEDOR = pPROVEEDOR;
            this.vArticulo_Inventario.aINVENTARIO = pINVENTARIO;
            this.vArticulo_Inventario.aARTICULO = pARTICULO;
            this.vArticulo_Inventario.aMAXIMOS = pMAXIMOS;
            this.vArticulo_Inventario.aMINIMOS = pMINIMOS;
            this.vArticulo_Inventario.aEXISTENCIAS = pEXISTENCIAS;

            return vArticulo_Inventario.MaintenanceArticulo_Inventario(vArticulo_Inventario, pACCION);
        }
        [WebMethod]
        public DataSet GetListArticulo_Inventario(string pEMPRESA, String pSUCURSAL, String pPROVEEDOR, int pINVENTARIO, String pARTICULO, int pMAXIMOS, int pMINIMOS, int pEXISTENCIAS, String pACCION)
        {
            this.vArticulo_Inventario.aEMPRESA = pEMPRESA;
            this.vArticulo_Inventario.aSUCURSAL = pSUCURSAL;
            this.vArticulo_Inventario.aPROVEEDOR = pPROVEEDOR;
            this.vArticulo_Inventario.aINVENTARIO = pINVENTARIO;
            this.vArticulo_Inventario.aARTICULO = pARTICULO;
            this.vArticulo_Inventario.aMAXIMOS = pMAXIMOS;
            this.vArticulo_Inventario.aMINIMOS = pMINIMOS;
            this.vArticulo_Inventario.aEXISTENCIAS = pEXISTENCIAS;

            return vArticulo_Inventario.GetListArticulo_Inventario(vArticulo_Inventario, pACCION);
        }

        DataLayer.Class.ClsClientes vClientes = new DataLayer.Class.ClsClientes();
        [WebMethod]
        public string MaintenanceClientes(string pCEDULA, String pNOMBRE, String pAPELLIDO_1, String pAPELLIDO_2, String pACCION)
        {
            this.vClientes.aCEDULA = pCEDULA;
            this.vClientes.aNOMBRE = pNOMBRE;
            this.vClientes.aAPELLIDO_1 = pAPELLIDO_1;
            this.vClientes.aAPELLIDO_1 = pAPELLIDO_2;

            return vClientes.MaintenanceClientes(vClientes, pACCION);
        }
        [WebMethod]
        public DataSet GetListClientes(string pCEDULA, String pNOMBRE, String pAPELLIDO_1, String pAPELLIDO_2, String pACCION)
        {
            this.vClientes.aCEDULA = pCEDULA;
            this.vClientes.aNOMBRE = pNOMBRE;
            this.vClientes.aAPELLIDO_1 = pAPELLIDO_1;
            this.vClientes.aAPELLIDO_1 = pAPELLIDO_2;

            return vClientes.GetListClientes(vClientes, pACCION);
        }

        DataLayer.Class.ClsBodega vBodega = new DataLayer.Class.ClsBodega();
        [WebMethod]
        public string MaintenanceBodega(string pBODEGA, String pNOMBRE, String pUBICACION, String pACCION)
        {
            this.vBodega.aBODEGA = pBODEGA;
            this.vBodega.aNOMBRE = pNOMBRE;
            this.vBodega.aUBICACION = pUBICACION;

            return vBodega.MaintenanceBodega(vBodega, pACCION);
        }
        [WebMethod]
        public DataSet GetListBodega(string pBODEGA, String pNOMBRE, String pUBICACION, String pACCION)
        {
            this.vBodega.aBODEGA = pBODEGA;
            this.vBodega.aNOMBRE = pNOMBRE;
            this.vBodega.aUBICACION = pUBICACION;

            return vBodega.GetListBodega(vBodega, pACCION);
        }

        DataLayer.Class.ClsFactura vFactura = new DataLayer.Class.ClsFactura();
        [WebMethod]
        public string MaintenanceFactura(string pEMPRESA, String pSUCURSAL, int pFACTURA, String pCLIENTE, String pEMPLEADO, DateTime pFECHA, String pESTADO, String pACCION)
        {
            this.vFactura.aEMPRESA = pEMPRESA;
            this.vFactura.aSUCURSAL = pSUCURSAL;
            this.vFactura.aFACTURA = pFACTURA;
            this.vFactura.aCLIENTE = pCLIENTE;
            this.vFactura.aEMPLEADO = pEMPLEADO;
            this.vFactura.aFECHA = pFECHA;
            this.vFactura.aESTADO = pESTADO;

            return vFactura.MaintenanceFactura(vFactura, pACCION);
        }
        [WebMethod]
        public DataSet GetListFactura(string pEMPRESA, String pSUCURSAL, int pFACTURA, String pCLIENTE, String pEMPLEADO, DateTime pFECHA, String pESTADO, String pACCION)
        {
            this.vFactura.aEMPRESA = pEMPRESA;
            this.vFactura.aSUCURSAL = pSUCURSAL;
            this.vFactura.aFACTURA = pFACTURA;
            this.vFactura.aCLIENTE = pCLIENTE;
            this.vFactura.aEMPLEADO = pEMPLEADO;
            this.vFactura.aFECHA = pFECHA;
            this.vFactura.aESTADO = pESTADO;

            return vFactura.GetListFactura(vFactura, pACCION);
        }

        DataLayer.Class.ClsProveedores vProveedores = new DataLayer.Class.ClsProveedores();
        [WebMethod]
        public string MaintenanceProveedores(string pID_EMPRESA, String pID_SUCURSAL, String pCEDULA_JURIDICA, String pRAZON_SOCIAL, String pUBICACION, String pEMAIL, String pTELEFONO, String pACCION)
        {
            this.vProveedores.aID_EMPRESA = pID_EMPRESA;
            this.vProveedores.aID_SUCURSAL = pID_SUCURSAL;
            this.vProveedores.aCEDULA_JURIDICA = pCEDULA_JURIDICA;
            this.vProveedores.aRAZON_SOCIAL = pRAZON_SOCIAL;
            this.vProveedores.aUBICACION = pUBICACION;
            this.vProveedores.aEMAIL = pEMAIL;
            this.vProveedores.aTELEFONO = pTELEFONO;

            return vProveedores.MaintenanceProveedores(vProveedores, pACCION);
        }
        [WebMethod]
        public DataSet GetListProveedores(string pID_EMPRESA, String pID_SUCURSAL, String pCEDULA_JURIDICA, String pRAZON_SOCIAL, String pUBICACION, String pEMAIL, String pTELEFONO, String pACCION)
        {
            this.vProveedores.aID_EMPRESA = pID_EMPRESA;
            this.vProveedores.aID_SUCURSAL = pID_SUCURSAL;
            this.vProveedores.aCEDULA_JURIDICA = pCEDULA_JURIDICA;
            this.vProveedores.aRAZON_SOCIAL = pRAZON_SOCIAL;
            this.vProveedores.aUBICACION = pUBICACION;
            this.vProveedores.aEMAIL = pEMAIL;
            this.vProveedores.aTELEFONO = pTELEFONO;

            return vProveedores.GetListProveedores(vProveedores, pACCION);
        }

          DataLayer.Class.ClsDetalle_Factura vDetalle_Factura = new DataLayer.Class.ClsDetalle_Factura();
        [WebMethod]
        public string MaintenanceDetalle_Factura(string pID_EMPRESA, String pID_SUCURSAL, Int32 pNUM_LINEA, Int32 pFACTURA, String pARTICULO, Int32 pCANTIDAD, Int32 pIMPUESTO, Int32 pDESCUENTO, Int32 pTOTAL, String pACCION)
        {
            this.vDetalle_Factura.aID_EMPRESA = pID_EMPRESA;
            this.vDetalle_Factura.aID_SUCURSAL = pID_SUCURSAL;
            this.vDetalle_Factura.aNUM_LINEA = pNUM_LINEA;
            this.vDetalle_Factura.aFACTURA  = pFACTURA;
            this.vDetalle_Factura.aARTICULO = pARTICULO;
            this.vDetalle_Factura.aCANTIDAD = pCANTIDAD;
            this.vDetalle_Factura.aIMPUESTO = pIMPUESTO;
            this.vDetalle_Factura.aDESCUENTO = pDESCUENTO;
            this.vDetalle_Factura.aTOTAL = pTOTAL;

            return vDetalle_Factura.MaintenanceDetalle_Factura(vDetalle_Factura, pACCION);
        }
        [WebMethod]
        public DataSet GetListDetalle_Factura(string pID_EMPRESA, String pID_SUCURSAL, Int32 pNUM_LINEA, Int32 pFACTURA, String pARTICULO, Int32 pCANTIDAD, Int32 pIMPUESTO, Int32 pDESCUENTO, Int32 pTOTAL, String pACCION)
        {
            this.vDetalle_Factura.aID_EMPRESA = pID_EMPRESA;
            this.vDetalle_Factura.aID_SUCURSAL = pID_SUCURSAL;
            this.vDetalle_Factura.aNUM_LINEA = pNUM_LINEA;
            this.vDetalle_Factura.aFACTURA = pFACTURA;
            this.vDetalle_Factura.aARTICULO = pARTICULO;
            this.vDetalle_Factura.aCANTIDAD = pCANTIDAD;
            this.vDetalle_Factura.aIMPUESTO = pIMPUESTO;
            this.vDetalle_Factura.aDESCUENTO = pDESCUENTO;
            this.vDetalle_Factura.aTOTAL = pTOTAL;

            return vDetalle_Factura.GetListDetalle_Factura(vDetalle_Factura, pACCION);
        }

        DataLayer.Class.ClsEmpleados vEmpleados = new DataLayer.Class.ClsEmpleados();
        [WebMethod]
        public string MaintenanceEmpleados(string pEMPRESA, String pSUCURSAL, String pCEDULA, String pNOMBRE, String pAPELLIDOS, String pEMAIL, int pTELEFONO, String pACCION)
        {
            this.vEmpleados.aEMPRESA = pEMPRESA;
            this.vEmpleados.aSUCURSAL = pSUCURSAL;
            this.vEmpleados.aCEDULA = pCEDULA;
            this.vEmpleados.aNOMBRE = pNOMBRE;
            this.vEmpleados.aAPELLIDOS = pAPELLIDOS;
            this.vEmpleados.aEMAIL = pEMAIL;
            this.vEmpleados.aTELEFONO = pTELEFONO;

            return vEmpleados.MaintenanceEmpleados(vEmpleados, pACCION);
        }
        [WebMethod]
        public DataSet GetListEmpleados(string pEMPRESA, String pSUCURSAL, String pCEDULA, String pNOMBRE, String pAPELLIDOS, String pEMAIL, int pTELEFONO, String pACCION)
        {
            this.vEmpleados.aEMPRESA = pEMPRESA;
            this.vEmpleados.aSUCURSAL = pSUCURSAL;
            this.vEmpleados.aCEDULA = pCEDULA;
            this.vEmpleados.aNOMBRE = pNOMBRE;
            this.vEmpleados.aAPELLIDOS = pAPELLIDOS;
            this.vEmpleados.aEMAIL = pEMAIL;
            this.vEmpleados.aTELEFONO = pTELEFONO;

            return vEmpleados.GetListEmpleados(vEmpleados, pACCION);
        }
    }
}
