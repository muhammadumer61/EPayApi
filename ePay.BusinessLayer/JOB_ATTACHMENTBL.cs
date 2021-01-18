
// Auto Generated by Tool Version # (1.3.0.3)
// Macrosoft Inc on: 2/23/2017 2:54:15 PM
// Last Updated on: 

using System;
using System.Collections.Generic;
using EPay.DataAccess;
using NMART.DataClasses;
using NMART.DataAccess;

namespace NMART.BusinessLayer
{		
	public class JOB_ATTACHMENTBL
	{
		public bool IsDirty { get; set; }
		
		public List<JOB_ATTACHMENTDC>  LoadAll()
		{
			DBConnection objConnection = new DBConnection();
			JOB_ATTACHMENTDA objJOB_ATTACHMENTDA = new JOB_ATTACHMENTDA();
			List<JOB_ATTACHMENTDC>  objJOB_ATTACHMENTDC = null;
            try
            {
				objConnection.Open(false);
				objJOB_ATTACHMENTDC = objJOB_ATTACHMENTDA.LoadAll(objConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objJOB_ATTACHMENTDC;
		}
		
		
		public JOB_ATTACHMENTDC LoadByPrimaryKey(int JOB_ID, int ATTACHMENT_ID)
		{
			DBConnection objConnection = new DBConnection();
			JOB_ATTACHMENTDA objJOB_ATTACHMENTDA = new JOB_ATTACHMENTDA();
			JOB_ATTACHMENTDC objJOB_ATTACHMENTDC = null;
            try
            {
				objConnection.Open(false);
				objJOB_ATTACHMENTDC = objJOB_ATTACHMENTDA.LoadByPrimaryKey(objConnection, JOB_ID, ATTACHMENT_ID);                
            }
            catch (Exception ex)
            {
                throw ex;
            }   
			finally 
            {
                objConnection.Close();
            }
            return objJOB_ATTACHMENTDC;
		}
		public int Update(List<JOB_ATTACHMENTDC> objJOB_ATTACHMENTs)        
        {
            int updatedCount = 0;
            DBConnection objConnection = new DBConnection();
            JOB_ATTACHMENTDA objJOB_ATTACHMENTDA = new JOB_ATTACHMENTDA();
            try
            {
                objConnection.Open(true);
                updatedCount = objJOB_ATTACHMENTDA.Update(objConnection, objJOB_ATTACHMENTs);
                IsDirty = objJOB_ATTACHMENTDA.IsDirty;
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

        public int Insert(List<JOB_ATTACHMENTDC> objJOB_ATTACHMENTs)        
        {
            int insertedCount = 0;
            DBConnection objConnection = new DBConnection();
            JOB_ATTACHMENTDA objJOB_ATTACHMENTDA = new JOB_ATTACHMENTDA();
            try
            {
                objConnection.Open(true);
                insertedCount = objJOB_ATTACHMENTDA.Insert(objConnection, objJOB_ATTACHMENTs);
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
		public int Delete(List<JOB_ATTACHMENTDC> objJOB_ATTACHMENTs)        
        {
            int deletedCount = 0;
            DBConnection objConnection = new DBConnection();
            JOB_ATTACHMENTDA objJOB_ATTACHMENTDA = new JOB_ATTACHMENTDA();
            try
            {
                objConnection.Open(true);
                deletedCount = objJOB_ATTACHMENTDA.Delete(objConnection, objJOB_ATTACHMENTs);
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