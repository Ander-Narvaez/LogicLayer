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

        DataLayer.Class.ClsInventario vInventario = new DataLayer.Class.ClsInventario();
        [WebMethod]
        public string MaintenanceInventario(string pEMPRESA, String pSUCURSAL, String pPROVEEDOR, int pINVENTARIO, String pARTICULO, int pMAXIMOS, int pMINIMOS, int pEXISTENCIAS, String pACCION)
        {
            this.vInventario.aEMPRESA = pEMPRESA;
            this.vInventario.aSUCURSAL = pSUCURSAL;
            this.vInventario.aPROVEEDOR = pPROVEEDOR;
            this.vInventario.aINVENTARIO = pINVENTARIO;
            this.vInventario.aARTICULO = pARTICULO;
            this.vInventario.aMAXIMOS = pMAXIMOS;
            this.vInventario.aMINIMOS = pMINIMOS;
            this.vInventario.aEXISTENCIAS = pEXISTENCIAS;

            return vInventario.MaintenanceInventario(vInventario, pACCION);
        }
        [WebMethod]
        public DataSet GetListInventario(string pEMPRESA, String pSUCURSAL, String pPROVEEDOR, int pINVENTARIO, String pARTICULO, int pMAXIMOS, int pMINIMOS, int pEXISTENCIAS, String pACCION)
        {
            this.vInventario.aEMPRESA = pEMPRESA;
            this.vInventario.aSUCURSAL = pSUCURSAL;
            this.vInventario.aPROVEEDOR = pPROVEEDOR;
            this.vInventario.aINVENTARIO = pINVENTARIO;
            this.vInventario.aARTICULO = pARTICULO;
            this.vInventario.aMAXIMOS = pMAXIMOS;
            this.vInventario.aMINIMOS = pMINIMOS;
            this.vInventario.aEXISTENCIAS = pEXISTENCIAS;

            return vInventario.GetListInventario(vInventario, pACCION);
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
        public string MaintenanceBodega(string pEMPRESA, String pSUCURSAL, string pBODEGA, int pINVENTARIO, String pNOMBRE, String pUBICACION, String pACCION)
        {
            this.vBodega.aEMPRESA = pEMPRESA;
            this.vBodega.aSUCURSAL = pSUCURSAL;
            this.vBodega.aBODEGA = pBODEGA;
            this.vBodega.aINVENTARIO = pINVENTARIO;
            this.vBodega.aNOMBRE = pNOMBRE;
            this.vBodega.aUBICACION = pUBICACION;

            return vBodega.MaintenanceBodega(vBodega, pACCION);
        }
        [WebMethod]
        public DataSet GetListBodega(string pEMPRESA, String pSUCURSAL, string pBODEGA, int pINVENTARIO, String pNOMBRE, String pUBICACION, String pACCION)
        {
            this.vBodega.aEMPRESA = pEMPRESA;
            this.vBodega.aSUCURSAL = pSUCURSAL;
            this.vBodega.aBODEGA = pBODEGA;
            this.vBodega.aINVENTARIO = pINVENTARIO;
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

        DataLayer.Class.ClsUsuarios vUsuarios = new DataLayer.Class.ClsUsuarios();
        [WebMethod]
        public string MaintenanceUsuarios(string pEMPRESA, String pSUCURSAL, int pID, String pUSUARIO, String pCONTRA, String pTIPO, String pACCION)
        {
            this.vUsuarios.aEMPRESA = pEMPRESA;
            this.vUsuarios.aSUCURSAL = pSUCURSAL;
            this.vUsuarios.aID = pID;
            this.vUsuarios.aUSUARIO = pUSUARIO;
            this.vUsuarios.aCONTRA = pCONTRA;
            this.vUsuarios.aTIPO = pTIPO;

            return vUsuarios.MaintenanceUsuarios(vUsuarios, pACCION);
        }
        [WebMethod]
        public DataSet GetListUsuarios(string pEMPRESA, String pSUCURSAL, int pID, String pUSUARIO, String pCONTRA, String pTIPO, String pACCION)
        {
            this.vUsuarios.aEMPRESA = pEMPRESA;
            this.vUsuarios.aSUCURSAL = pSUCURSAL;
            this.vUsuarios.aID = pID;
            this.vUsuarios.aUSUARIO = pUSUARIO;
            this.vUsuarios.aCONTRA = pCONTRA;
            this.vUsuarios.aTIPO = pTIPO;

            return vUsuarios.GetListUsuarios(vUsuarios, pACCION);
        }

        DataLayer.Class.ClsCarde_Movimiento vCarde_Movimiento = new DataLayer.Class.ClsCarde_Movimiento();
        [WebMethod]
        public string MaintenanceCarde_Movimiento(string pEMPRESA, String pSUCURSAL, String pUSUARIO, Int32 pMOVIMIENTO, Int32 pINVENTARIO, String pTIPO, Int32 pCANTIDAD_EXISTENTE, Int32 pCANTIDAD, DateTime pFECHA_HORA, String pACCION)
        {
            this.vCarde_Movimiento.aEMPRESA = pEMPRESA;
            this.vCarde_Movimiento.aSUCURSAL = pSUCURSAL;
            this.vCarde_Movimiento.aUSUARIO = pUSUARIO;
            this.vCarde_Movimiento.aMOVIMIENTO = pMOVIMIENTO;
            this.vCarde_Movimiento.aINVENTARIO  = pINVENTARIO;
            this.vCarde_Movimiento.aTIPO = pTIPO;
            this.vCarde_Movimiento.aCANTIDAD = pCANTIDAD_EXISTENTE;
            this.vCarde_Movimiento.aCANTIDAD = pCANTIDAD;
            this.vDetalle_Factura.aFECHA_HORA = pFECHA_HORA;
            

            return vCarde_Movimiento.MaintenanceCarde_Movimiento(vCarde_Movimiento, pACCION);
        }
        [WebMethod]
        public DataSet GetListCarde_Movimiento(string pEMPRESA, String pSUCURSAL, String pUSUARIO, Int32 pMOVIMIENTO, Int32 pINVENTARIO, String pTIPO, Int32 pCANTIDAD_EXISTENTE, Int32 pCANTIDAD, DateTime pFECHA_HORA, String pACCION)
        {
            this.vCarde_Movimiento.aEMPRESA = pEMPRESA;
            this.vCarde_Movimiento.aSUCURSAL = pSUCURSAL;
            this.vCarde_Movimiento.aUSUARIO = pUSUARIO;
            this.vCarde_Movimiento.aMOVIMIENTO = pMOVIMIENTO;
            this.vCarde_Movimiento.aINVENTARIO  = pINVENTARIO;
            this.vCarde_Movimiento.aTIPO = pTIPO;
            this.vCarde_Movimiento.aCANTIDAD = pCANTIDAD_EXISTENTE;
            this.vCarde_Movimiento.aCANTIDAD = pCANTIDAD;
            this.vCarde_Movimiento.aFECHA_HORA = pFECHA_HORA;
            

            return vCarde_Movimiento.GetListCarde_Movimiento(vCarde_Movimiento, pACCION);
        }

         DataLayer.Class.ClsEstante vEstante = new DataLayer.Class.ClsEstante();
        [WebMethod]
        public string MaintenanceEstante(string pEMPRESA, String pSUCURSAL, String pBODEGA,  String pSECCION, String pESTANTE, String pDESCRIPCION, String pACCION)
        {
            this.vEstante.aEMPRESA = pEMPRESA;
            this.vEstante.aSUCURSAL = pSUCURSAL;
            this.vEstante.aBODEGA = pBODEGA;
            this.vEstante.aSECCION = pSECCION;
            this.vEstante.aESTANTE  = pESTANTE;
            this.vEstante.aDESCRIPCION = pDESCRIPCION;
            

            return vEstante.MaintenanceEstante(vEstante, pACCION);
        }
        [WebMethod]
        public DataSet GetListEstante(string pEMPRESA, String pSUCURSAL, String pBODEGA,  String pSECCION, String pESTANTE, String pDESCRIPCION, String pACCION)
        {
            this.vEstante.aEMPRESA = pEMPRESA;
            this.vEstante.aSUCURSAL = pSUCURSAL;
            this.vEstante.aBODEGA = pBODEGA;
            this.vEstante.aSECCION = pSECCION;
            this.vEstante.aESTANTE  = pESTANTE;
            this.vEstante.aDESCRIPCION = pDESCRIPCION;
            

            return vEstante.GetListEstante(vEstante, pACCION);
        }

        DataLayer.Class.ClsSeccion vSeccion = new DataLayer.Class.ClsSeccion();
        [WebMethod]
        public string MaintenanceSeccion(string pEMPRESA, String pSUCURSAL, String pBODEGA, String pSECCION, String pDESCRIPCION, String pACCION)
        {
            this.vSeccion.aEMPRESA = pEMPRESA;
            this.vSeccion.aSUCURSAL = pSUCURSAL;
            this.vSeccion.aBODEGA = pBODEGA;
            this.vSeccion.aSECCION = pSECCION;
            this.vSeccion.aDESCRIPCION = pDESCRIPCION;

            return vSeccion.MaintenanceSeccion(vSeccion, pACCION);
        }
        [WebMethod]
        public DataSet GetListSeccion(string pEMPRESA, String pSUCURSAL, String pBODEGA, String pSECCION, String pDESCRIPCION, String pACCION)
        {
            this.vSeccion.aEMPRESA = pEMPRESA;
            this.vSeccion.aSUCURSAL = pSUCURSAL;
            this.vSeccion.aBODEGA = pBODEGA;
            this.vSeccion.aSECCION = pSECCION;
            this.vSeccion.aDESCRIPCION = pDESCRIPCION;

            return vSeccion.GetListSeccion(vSeccion, pACCION);
        }
    }
}
