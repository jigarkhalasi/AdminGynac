using Sculptor.Gynac.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Sculptor.Gynac.Repository.UserTalks
{
    public class UserTalksRepository : BaseRepository, IUserTalksRepository
    {
        public async Task<IQueryable<UserTalk>> SetUserTalks(Int32 userId, List<int> talksId, string endDate)
        {
            return await Task.Run(() =>
            {

                var userTalksdata = _contex.UserTalks.Where(t => t.UserId == userId);
                _contex.UserTalks.RemoveRange(userTalksdata);
                _contex.SaveChanges();

                if (talksId != null)
                {

                    foreach (var item in talksId)
                    {
                        var dataModel = new UserTalk();
                        dataModel.Enddate = DateTime.ParseExact(endDate, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        dataModel.TalkId = item;
                        dataModel.UserId = userId;
                        dataModel.IsActive = 0;
                        dataModel.IsVideoStatus = 0;
                        dataModel.IsExamlear = 0;
                        dataModel.IsModuleClear = 0;
                        dataModel.CreateDate = DateTime.UtcNow;
                        dataModel.UpdateDate = DateTime.UtcNow;
                        dataModel.ModuleId = _contex.TalkMasters.Where(t => t.Id == item).FirstOrDefault().ModulId;
                        _contex.UserTalks.Add(dataModel);
                    }
                    _contex.SaveChanges();
                }

                return _contex.UserTalks.Where(t => t.UserId == userId);
            });

        }


        public async Task<bool> IsUserTalksExits(int userId)
        {
            return await Task.Run(() =>
            {
                var data = _contex.UserTalks.Where(t => t.UserId == userId);
                return (data.ToList().Count > 0 ? true : false);
            });
        }


        public async Task<IQueryable<UserTalk>> GetUserTalks(int userId)
        {
            return await Task.Run(() =>
            {
                var data = _contex.UserTalks.Where(t => t.UserId == userId);
                return data;
            });
        }


        public async Task<bool> DeleteUserTalksExits(int userId)
        {
            return await Task.Run(() =>
            {
                var data = _contex.UserTalks.Where(t => t.UserId == userId);
                _contex.UserTalks.RemoveRange(data);

                return (_contex.SaveChanges() > 0 ? true : false);
            });
        }


        public IEnumerable<TutorialSummaryModel> TutorialSummary(int userId)
        {   
            var model = new List<TutorialSummaryModel>();

            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            DataSet dsResult = new DataSet();

            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                con.Open();
                SqlCommand command = new SqlCommand("Get_Tutorial_Summary", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@User_Id", userId);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                da.Fill(dsResult);

                try
                {
                    DataSet ds = dsResult;

                    if (ds != null && ds.Tables[0].Rows[0][0].ToString() == "Session 1")
                    {
                        int i = 0;
                        int moduleCountCompleted = 0;
                        int moduleCountPending = 0;
                        int finalmoduleCountCompleted = 0;
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            var data = new TutorialSummaryModel();
                            if (row["SessionName"].ToString() == ds.Tables[1].Rows[i]["SessionName"].ToString())
                            {
                                data.SessionName = row["SessionName"].ToString();
                                data.TotalTalks = Convert.ToInt32(row["TotalTalks"].ToString());
                                if (row["TotalCompletedTalks"].ToString() != "")
                                {

                                    data.TotalCompletedTalks = (row["TotalCompletedTalks"].ToString() != "") ? Convert.ToInt32(row["TotalCompletedTalks"].ToString()) : 0;
                                    data.TotalPendingTalks = (row["TotalCompletedTalks"].ToString() != "") ? data.TotalTalks - data.TotalCompletedTalks : data.TotalTalks;
                                    data.TotalModules = Convert.ToInt32(ds.Tables[1].Rows[i]["TotalModules"].ToString());

                                }
                                else
                                {
                                    data.TotalCompletedTalks = 0;
                                    data.TotalPendingTalks = 0;
                                    data.TotalTalks = 0;
                                    data.TotalModules = 0;
                                } 
                                
                                moduleCountCompleted = 0;
                                moduleCountPending = 0;
                                finalmoduleCountCompleted = 0;
                                data.TotalCompletedModules = 0;
                                                               
                                if (ds.Tables[2] != null && ds.Tables[2].Rows.Count > i)
                                {
                                   
                                    if (Convert.ToInt32(ds.Tables[1].Rows[i]["SessionId"].ToString()) == Convert.ToInt32(ds.Tables[2].Rows[i]["SessionId"].ToString()))
                                    {
                                        if (ds.Tables[3] != null && ds.Tables[3].Rows.Count > 0)
                                        {

                                            foreach (DataRow row1 in ds.Tables[3].Rows)
                                            {
                                                if (Convert.ToInt32(ds.Tables[2].Rows[i]["ModuleId"].ToString()) == Convert.ToInt32(row1["ModulId"].ToString()))
                                                {
                                                    if (row1["isStatus"].ToString() == "1")
                                                    {
                                                        moduleCountCompleted++;
                                                    }
                                                    else
                                                    {
                                                        moduleCountPending++;
                                                    }

                                                    if (Convert.ToInt32(ds.Tables[2].Rows[i]["TotalModuleImage"].ToString()) == moduleCountCompleted)
                                                    {
                                                        finalmoduleCountCompleted++;
                                                        data.TotalCompletedModules = finalmoduleCountCompleted;
                                                    }

                                                    data.TotalPendingModules = (data.TotalCompletedModules != 0 && data.TotalCompletedModules != null) ? data.TotalModules - data.TotalCompletedModules : data.TotalModules;
                                                }

                                            }
                                        }
                                        else {
                                            data.TotalCompletedModules = 0;
                                            data.TotalPendingModules = data.TotalModules;
                                        }
                                    }
                                    else
                                    {
                                        data.TotalPendingModules = 0;
                                        data.TotalCompletedModules = 0;
                                    }
                                }
                                else
                                {
                                    data.TotalPendingModules = data.TotalModules;
                                    data.TotalCompletedModules = 0;
                                  //  data.TotalModules = 0;                                    
                                }                                
                                model.Add(data);
                            }
                            i++;
                        }
                    }
                }
                catch
                {
                    throw;
                }                
            }            
            
            return model.ToList();                        
            
        }
    }
}