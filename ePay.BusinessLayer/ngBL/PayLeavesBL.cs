
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 2/23/2017 2:54:14 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataAccess;
using EPay.DataClasses;
using EPay.DataAccess;
using NMART.DataAccess;


namespace EPay.BusinessLayer
{
    public class PayLeavesBL
    {
        public bool IsDirty { get; set; }

        public List<PayLeavesDC> LoadAllEmployee()
        {
            DBConnection objConnection = new DBConnection();

            PayLeavesDA objPayLeavesDA = new PayLeavesDA();
            List<PayLeavesDC> objPayLeavesDC = null;
            try
            {
                objConnection.Open(false);
                objPayLeavesDC = objPayLeavesDA.LoadAllEmployee(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return objPayLeavesDC;
        }
        public List<PayLeavesDC> LoadAll()
        {
            DBConnection objConnection = new DBConnection();

            PayLeavesDA objPayLeavesDA = new PayLeavesDA();
            List<PayLeavesDC> objPayLeavesDC = null;
            try
            {
                objConnection.Open(false);
                objPayLeavesDC = objPayLeavesDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return objPayLeavesDC;
        }


        public PayLeavesDC LoadByPrimaryKey(string Code)
        {
            DBConnection objConnection = new DBConnection();
            PayLeavesDA objPayLeavesDA = new PayLeavesDA();
            PayLeavesDC objPayLeavesDC = null;
            try
            {
                objConnection.Open(false);
                objPayLeavesDC = objPayLeavesDA.LoadByPrimaryKey(objConnection, Code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return objPayLeavesDC;
        }
        public int Update(List<PayLeavesDC> objPayDesignations)
        {
            int updatedCount = 0;
            DBConnection objConnection = new DBConnection();
            PayLeavesDA objPayLeavesDA = new PayLeavesDA();
            try
            {
                objConnection.Open(true);
                updatedCount = objPayLeavesDA.Update(objConnection, objPayDesignations);
                IsDirty = objPayLeavesDA.IsDirty;
                if (IsDirty)
                    objConnection.Rollback();
                else
                    objConnection.Commit();
            }
            catch (Exception ex)
            {
                objConnection.Rollback();
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return updatedCount;
        }
        public int Insert(List<PayLeavesDC> objPayDesignations)
        {
            int insertedCount = 0;
            DBConnection objConnection = new DBConnection();
            PayLeavesDA objPayLeavesDA = new PayLeavesDA();
            try
            {
                objConnection.Open(true);
                insertedCount = objPayLeavesDA.Insert(objConnection, objPayDesignations);
                objConnection.Commit();
            }
            catch (Exception ex)
            {
                objConnection.Rollback();
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return insertedCount;
        }
        public int Delete(List<PayLeavesDC> objPayDesignations)
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            PayLeavesDA objPayLeavesDA = new PayLeavesDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objPayLeavesDA.Delete(objConnection, objPayDesignations);
                objConnection.Commit();
            }
            catch (Exception ex)
            {
                objConnection.Rollback();
                throw ex;
            }
            finally
            {
                objConnection.Close();
            }
            return deletedCount;
        }


    }
}